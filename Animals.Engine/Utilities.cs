using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Animals.Engine.Animals;
using Animals.Engine.Animals.Implementations;

namespace Animals.Engine
{
    public static class Utilities
    {
        public static Random seedRandom;
        public static int RandomNumberBetween(int low, int max)
        {
            // Thread.Sleep(1);
            if (seedRandom == null)
            {
                seedRandom = new Random(DateTime.Now.Millisecond);
            }
            Random rng = new Random(seedRandom.Next(0, 100000));
            return rng.Next(low, max);
        }

       
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
            if(value<0)
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
        public static P SafeCast<T,P>(this T inp)
            where T:class,P
            where P:class
        {
            if(inp==null)
            {
                throw new NullReferenceException("Cannot cast nuul object");
            }
            P output = inp as T;
            return output;
        }
        

    }
}
