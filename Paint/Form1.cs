using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace Paint
{
    public partial class Form1 : Form
    {
        #region Variables

        // Variables
        Bitmap bitMap;

        List<Image> images = new List<Image>();

        Graphics g;
        Tool currentTool;
        SelectedTool selectedTool;
        Color currentColor => colorDialog1.Color;

        int currentSize => cbx_size.SelectedIndex;
        int currentX, currentY, originalX, originalY, distX, distY;
        bool mouseClicked = false;
        readonly int[] sizes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        #endregion

        public Form1()
        {
            InitializeComponent();

            // Double Buffering
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, pic, new object[] { true });


            // Initialize bitmap
            bitMap = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bitMap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pic.BackgroundImage = bitMap;
            pic.BackgroundImageLayout = ImageLayout.None;
            

            // Defalut tool
            rbtn_penTool.Checked = true;

            // Load sizes
            foreach (var item in sizes) cbx_size.Items.Add(item.ToString());
            cbx_size.SelectedIndex = 0;
            
            // Set color
            colorDialog1.Color = Color.Black;
            tbx_colorDialog.BackColor = Color.Black;
            currentTool.Color = currentColor;

            UpdateSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateSettings()
        {
            switch (selectedTool)
            {
                case SelectedTool.pen:
                    currentTool = new PenTool(currentSize, currentColor);
                    break;
                case SelectedTool.line:
                    currentTool = new LineTool(currentSize, currentColor);
                    break;
                case SelectedTool.rectangle:
                    currentTool = new RectangleTool(currentSize, currentColor);
                    break;
                case SelectedTool.circle:
                    currentTool = new CircleTool(currentSize, currentColor);
                    break;
                case SelectedTool.eraser:
                    currentTool = new EraserTool(currentSize);
                    break;
            }
        }

        enum SelectedTool
        {
            pen,
            line,
            rectangle,
            circle,
            eraser
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            pic.Cursor = Cursors.Cross;
            mouseClicked = true;

            // Mouse down pos
            originalX = e.X;
            originalY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                if (selectedTool == SelectedTool.pen || selectedTool == SelectedTool.eraser)
                {
                    currentTool.Draw(originalX, originalY, currentX, currentY, g);
                    originalX = currentX;
                    originalY = currentY;
                }
            }

            // Current mouse pos
            currentX = e.X;
            currentY = e.Y;

            // Distance from mouse down pos to current mouse pos
            distX = currentX - originalX;
            distY = currentY - originalY;

            pic.Invalidate();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            // Draw in mouse up
            pic.Cursor = Cursors.Default;
            mouseClicked = false;

            // Distance from mouse down pos to current mouse pos
            distX = currentX - originalX;
            distY = currentY - originalY;

            // Specific tool selected
            if (selectedTool == SelectedTool.rectangle) currentTool.Draw(originalX, originalY, distX, distY, g);
            if (selectedTool == SelectedTool.circle) currentTool.Draw(originalX, originalY, distX, distY, g);
            if (selectedTool == SelectedTool.line) currentTool.Draw(originalX, originalY, currentX, currentY, g);
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            // Draw preview

            Graphics g = e.Graphics;

            if (mouseClicked)
            {
                // Specific tool selected
                if (selectedTool == SelectedTool.rectangle) currentTool.Draw(originalX, originalY, distX, distY, g);
                if (selectedTool == SelectedTool.circle) currentTool.Draw(originalX, originalY, distX, distY, g);
                if (selectedTool == SelectedTool.line) currentTool.Draw(originalX, originalY, currentX, currentY, g);
            }
        }

        #region Callback Methods

        #region Save and Load methods

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveAndLoadHandler.SaveTo(bitMap);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            SaveAndLoadHandler.Load(g, pic);
        }

        private void pic_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            if (SaveAndLoadHandler.GetFilename(out filename, e)) e.Effect = DragDropEffects.Copy;
        }

        private void pic_DragDrop(object sender, DragEventArgs e)
        {
            SaveAndLoadHandler.LoadOnDrag(pic, e, g);
        }

        #endregion

        #region ToolChange

        private void rbtn_penTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_penTool.Checked)
            {
                selectedTool = SelectedTool.pen;
                UpdateSettings();
            }
        }
        private void rbtn_lineTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_lineTool.Checked)
            {
                selectedTool = SelectedTool.line;
                UpdateSettings();
            }
        }

        private void rbtn_eraserTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_eraserTool.Checked)
            {
                selectedTool = SelectedTool.eraser;
                UpdateSettings();
            }
        }

        private void rbtn_circleTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_circleTool.Checked)
            {
                selectedTool = SelectedTool.circle;
                UpdateSettings();
            }
        }
        private void rbtn_rectangleTool_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_rectangleTool.Checked)
            {
                selectedTool = SelectedTool.rectangle;
                UpdateSettings();
            }
        }

        #endregion

        private void cbx_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTool.Size = cbx_size.SelectedIndex;
        }

        private void tbx_colorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                UpdateSettings();
                tbx_colorDialog.BackColor = colorDialog1.Color;
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Refresh();
        }

        #endregion
    }
}
