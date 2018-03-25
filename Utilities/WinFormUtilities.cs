using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public static class WinFormUtilities
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
            {
                source.Text = value;
            }

            else
            {
                source.AppendText("\r\n" + value);
            }

            source.Update();
        }
        public static void ReplaceText(this Control source, string value)
        {
            source.Text = value;
            source.Update();
        }
        public static void UpdatePictureBox(this PictureBox source, Bitmap img)
        {
            source.Image = img;
            source.Update();
        }
        public static void UpdateValue(this ProgressBar source, int value)
        {
            if (value < 0)
            {
                value = 0;
            }
            source.Value = value;
            source.Update();
        }

        public static void Initiate(this ProgressBar source, int max)
        {
            source.Maximum = max;
            source.Value = source.Maximum;
            source.Update();
        }
    }
}
