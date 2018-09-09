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
        static void appendLine(this TextBox source, string value)
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
        public static void AppendLine(this TextBox source, string value,bool safe)
        {
            if(safe)
            {
                source.Invoke(new MethodInvoker(delegate
                {
                    source.appendLine(value);
                }));
            }
            else
            {
                source.appendLine(value);
            }
            
        }
        static void replaceText(this Control source, string value)
        {
            source.Text = value;
            source.Update();
        }
        public static void ReplaceText(this Control source, string value, bool safe)
        {
            if (safe)
            {
                source.Invoke(new MethodInvoker(delegate
                {
                    source.replaceText(value);
                }));
            }
            else
            {
                source.replaceText(value);
            }
        }
        public static void Show(this Form form, bool safe)
        {
            if (safe)
            {
                form.Invoke(new MethodInvoker(delegate
                {
                    form.Show();
                }));
            }
            else
            {
                form.Show();
            }
        }
        public static void Update(this Control ctrl, bool safe)
        {
            if (safe)
            {
                ctrl.Invoke(new MethodInvoker(delegate
                {
                    ctrl.Update();
                }));
            }
            else
            {
                ctrl.Update();
            }
        }
        public static void UpdatePictureBox(this PictureBox source, Bitmap img, bool safe)
        {
            if (safe)
            {
                source.Invoke(new MethodInvoker(delegate
                {
                    source.UpdatePictureBox(img);
                }));
            }
            else
            {
                source.UpdatePictureBox(img);
            }
        }
        public static void UpdatePictureBox(this PictureBox source, Bitmap img)
        {
            source.Image = img;
            source.Update();
        }
        public static void UpdateValue(this ProgressBar source, int value, bool safe)
        {
            if (safe)
            {
                source.Invoke(new MethodInvoker(delegate
                {
                    source.UpdateValue(value);
                }));
            }
            else
            {
                source.UpdateValue(value);
            }
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
        public static void Initiate(this ProgressBar source, int max, bool safe)
        {
            if (safe)
            {
                source.Invoke(new MethodInvoker(delegate
                {
                    source.Initiate(max);
                }));
            }
            else
            {
                source.Initiate(max);
            }
        }
        public static void Initiate(this ProgressBar source, int max)
        {
            source.Maximum = max;
            source.Value = source.Maximum;
            source.Update();
        }
    }
}
