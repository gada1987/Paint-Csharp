
namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.Panel();
            this.pnl_toolBar = new System.Windows.Forms.Panel();
            this.rbtn_eraserTool = new System.Windows.Forms.RadioButton();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_colorDialog = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cbx_size = new System.Windows.Forms.ComboBox();
            this.rbtn_rectangleTool = new System.Windows.Forms.RadioButton();
            this.rbtn_lineTool = new System.Windows.Forms.RadioButton();
            this.rbtn_circleTool = new System.Windows.Forms.RadioButton();
            this.rbtn_penTool = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnl_toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.AllowDrop = true;
            this.pic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic.Location = new System.Drawing.Point(0, 67);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(784, 444);
            this.pic.TabIndex = 0;
            this.pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_DragDrop);
            this.pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_DragEnter);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // pnl_toolBar
            // 
            this.pnl_toolBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_toolBar.Controls.Add(this.rbtn_eraserTool);
            this.pnl_toolBar.Controls.Add(this.btn_load);
            this.pnl_toolBar.Controls.Add(this.btn_save);
            this.pnl_toolBar.Controls.Add(this.tbx_colorDialog);
            this.pnl_toolBar.Controls.Add(this.btn_clear);
            this.pnl_toolBar.Controls.Add(this.cbx_size);
            this.pnl_toolBar.Controls.Add(this.rbtn_rectangleTool);
            this.pnl_toolBar.Controls.Add(this.rbtn_lineTool);
            this.pnl_toolBar.Controls.Add(this.rbtn_circleTool);
            this.pnl_toolBar.Controls.Add(this.rbtn_penTool);
            this.pnl_toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toolBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_toolBar.Name = "pnl_toolBar";
            this.pnl_toolBar.Size = new System.Drawing.Size(784, 70);
            this.pnl_toolBar.TabIndex = 6;
            // 
            // rbtn_eraserTool
            // 
            this.rbtn_eraserTool.AutoSize = true;
            this.rbtn_eraserTool.Location = new System.Drawing.Point(403, 25);
            this.rbtn_eraserTool.Name = "rbtn_eraserTool";
            this.rbtn_eraserTool.Size = new System.Drawing.Size(55, 17);
            this.rbtn_eraserTool.TabIndex = 9;
            this.rbtn_eraserTool.TabStop = true;
            this.rbtn_eraserTool.Text = "Eraser";
            this.rbtn_eraserTool.UseVisualStyleBackColor = true;
            this.rbtn_eraserTool.CheckedChanged += new System.EventHandler(this.rbtn_eraserTool_CheckedChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(538, 19);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(619, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save to";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_colorDialog
            // 
            this.tbx_colorDialog.Location = new System.Drawing.Point(58, 22);
            this.tbx_colorDialog.Name = "tbx_colorDialog";
            this.tbx_colorDialog.ReadOnly = true;
            this.tbx_colorDialog.Size = new System.Drawing.Size(74, 20);
            this.tbx_colorDialog.TabIndex = 6;
            this.tbx_colorDialog.Click += new System.EventHandler(this.tbx_colorDialog_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(700, 19);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cbx_size
            // 
            this.cbx_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_size.FormattingEnabled = true;
            this.cbx_size.Location = new System.Drawing.Point(12, 21);
            this.cbx_size.Name = "cbx_size";
            this.cbx_size.Size = new System.Drawing.Size(40, 21);
            this.cbx_size.TabIndex = 1;
            this.cbx_size.SelectedIndexChanged += new System.EventHandler(this.cbx_size_SelectedIndexChanged);
            // 
            // rbtn_rectangleTool
            // 
            this.rbtn_rectangleTool.AutoSize = true;
            this.rbtn_rectangleTool.Location = new System.Drawing.Point(323, 25);
            this.rbtn_rectangleTool.Name = "rbtn_rectangleTool";
            this.rbtn_rectangleTool.Size = new System.Drawing.Size(74, 17);
            this.rbtn_rectangleTool.TabIndex = 4;
            this.rbtn_rectangleTool.TabStop = true;
            this.rbtn_rectangleTool.Text = "Rectangle";
            this.rbtn_rectangleTool.UseVisualStyleBackColor = true;
            this.rbtn_rectangleTool.CheckedChanged += new System.EventHandler(this.rbtn_rectangleTool_CheckedChanged);
            // 
            // rbtn_lineTool
            // 
            this.rbtn_lineTool.AutoSize = true;
            this.rbtn_lineTool.Location = new System.Drawing.Point(165, 25);
            this.rbtn_lineTool.Name = "rbtn_lineTool";
            this.rbtn_lineTool.Size = new System.Drawing.Size(45, 17);
            this.rbtn_lineTool.TabIndex = 1;
            this.rbtn_lineTool.TabStop = true;
            this.rbtn_lineTool.Text = "Line";
            this.rbtn_lineTool.UseVisualStyleBackColor = true;
            this.rbtn_lineTool.CheckedChanged += new System.EventHandler(this.rbtn_lineTool_CheckedChanged);
            // 
            // rbtn_circleTool
            // 
            this.rbtn_circleTool.AutoSize = true;
            this.rbtn_circleTool.Location = new System.Drawing.Point(266, 25);
            this.rbtn_circleTool.Name = "rbtn_circleTool";
            this.rbtn_circleTool.Size = new System.Drawing.Size(51, 17);
            this.rbtn_circleTool.TabIndex = 3;
            this.rbtn_circleTool.TabStop = true;
            this.rbtn_circleTool.Text = "Circle";
            this.rbtn_circleTool.UseVisualStyleBackColor = true;
            this.rbtn_circleTool.CheckedChanged += new System.EventHandler(this.rbtn_circleTool_CheckedChanged);
            // 
            // rbtn_penTool
            // 
            this.rbtn_penTool.AutoSize = true;
            this.rbtn_penTool.Location = new System.Drawing.Point(216, 25);
            this.rbtn_penTool.Name = "rbtn_penTool";
            this.rbtn_penTool.Size = new System.Drawing.Size(44, 17);
            this.rbtn_penTool.TabIndex = 2;
            this.rbtn_penTool.TabStop = true;
            this.rbtn_penTool.Text = "Pen";
            this.rbtn_penTool.UseVisualStyleBackColor = true;
            this.rbtn_penTool.CheckedChanged += new System.EventHandler(this.rbtn_penTool_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.pnl_toolBar);
            this.Controls.Add(this.pic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_toolBar.ResumeLayout(false);
            this.pnl_toolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pic;
        private System.Windows.Forms.ComboBox cbx_size;
        private System.Windows.Forms.RadioButton rbtn_lineTool;
        private System.Windows.Forms.RadioButton rbtn_penTool;
        private System.Windows.Forms.RadioButton rbtn_rectangleTool;
        private System.Windows.Forms.RadioButton rbtn_circleTool;
        private System.Windows.Forms.TextBox tbx_colorDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel pnl_toolBar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.RadioButton rbtn_eraserTool;
    }
}

