using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Paint
{
    static class SaveAndLoadHandler
    {
        static public void SaveTo(Bitmap bitMap)
        {
            // Save image as png file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Files (*png) | *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bitMap.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        static public void Load(Graphics g, Panel pic)
        {
            // Load png image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Png Files (*png) | *.png";
            ofd.DefaultExt = "png";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(Image.FromFile(ofd.FileName), 0, 0, pic.Width, pic.Height); // Draw image from file
                pic.Invalidate(); // Update panel
            }
        }

        static public void LoadOnDrag(Panel pic, DragEventArgs e, Graphics g)
        {
            // Load png image by draging
            var data = e.Data.GetData(DataFormats.FileDrop);
           
            string filename;
            bool validData = GetFilename(out filename, e);

            if (validData)
            {
                g.DrawImage(Image.FromFile(filename), 0, 0, pic.Width, pic.Height); // Draw image from file
                pic.Invalidate(); // Update panel
            }
        }

        static public bool GetFilename(out string filename, DragEventArgs e)
        {
            filename = String.Empty;

            if((e.AllowedEffect & DragDropEffects.Copy) != DragDropEffects.Copy) return false;

            // Control number of images selected
            var data = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (data.Length != 1) return false;

            // Control file extension
            filename = data[0];
            string extension = Path.GetExtension(filename).ToLower();
            if (extension != ".png") return false; 

            return true;
        }
    }
}
