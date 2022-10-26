using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace LAB03_PICBENDER_WonhyukCho
{

    public partial class Form1 : Form
    {
        //private Thread threadTime = null;
        private delegate void delImage(Bitmap bm, int i);

        public Form1()
        {
            InitializeComponent();
        }
        public int TrackbarChange
        {
            set
            {
                trackBar1.Value = value;

            }
            get
            {
                return trackBar1.Value;
            }



        }



        private void UI_Btn_Load_Click(object sender, EventArgs e)
        {

            if (UI_OFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bm = new Bitmap(UI_OFD.FileName);
                    UI_pBox.Image = bm;
                    this.Text = UI_OFD.SafeFileName;
                    UI_Btn_Transform.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UI_lbl_Result.Text = TrackbarChange.ToString();

        }

        private void UI_rBtn_Contrast_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_rBtn_Contrast.Checked)
            {
                UI_lbl_Red.Text = "Less".ToString();
                UI_lbl_Green.Text = "More".ToString();
                TrackbarChange = 20;
                UI_lbl_Result.Text = TrackbarChange.ToString();

            }
            else if (UI_rBtn_Tint.Checked)
            {
                UI_lbl_Red.Text = "Red".ToString();
                UI_lbl_Green.Text = "Green".ToString();
                TrackbarChange = 50;
                UI_lbl_Result.Text = TrackbarChange.ToString();

            }
            else if (UI_rBtn_Noise.Checked)
            {
                UI_lbl_Red.Text = "Less".ToString();
                UI_lbl_Green.Text = "More".ToString();
                TrackbarChange = 20;
                UI_lbl_Result.Text = TrackbarChange.ToString();

            }
            else if (UI_rBtn_BW.Checked)
            {
                UI_lbl_Red.Text = "Less".ToString();
                UI_lbl_Green.Text = "More".ToString();
                TrackbarChange = 20;
                UI_lbl_Result.Text = TrackbarChange.ToString();

            }
        }
        private void TransformNoise(Bitmap bm, int i)
        {
            // values for red, green, and blue
            int r = 0, g = 0, b = 0;

            // used to get pixel's color
            Color c = Color.White;

            // random object
            Random rnd = new Random();

            for (int y = 0; y < bm.Height; ++y)
            {
                for (int x = 0; x < bm.Width; ++x)
                {
                    // get the color of current pixel
                    c = bm.GetPixel(x, y);

                    // adds random values to each red, green, and blue values
                    r = c.R + rnd.Next((-1 * i), i);
                    g = c.G + rnd.Next((-1 * i), i);
                    b = c.B + rnd.Next((-1 * i), i);

                    // if each red, green, or blue value is greater than 255, the value is set to 255
                    // if each red, green, or blue value is less than 0, the value is set to 0
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;

                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;

                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;

                    // change the temporary image rather than the actual image
                    bm.SetPixel(x, y, Color.FromArgb(c.A, r, g, b));
                }
                TProg((double)y / bm.Height);

            }
         progressBar2.Value = 0;
        }

        private void TransformBlackNWhite(Bitmap bm, int i)
        {
            float effectLevel = (float)(i / 100.0f);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    Color c = bm.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    r = (int)(r + ((avg - r) * effectLevel));
                    g = (int)(g + ((avg - g) * effectLevel));
                    b = (int)(b + ((avg - b) * effectLevel));

                    bm.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
                TProg((double)y / bm.Height);

            }
          progressBar2.Value = 0;
        }
        private void TransformTint(Bitmap bm, int i)
        {
            // values for red, green, and blue
            int r = 0, g = 0, b = 0;

            // used to get pixel's color
            Color c = Color.White;

            for (int y = 0; y < bm.Height; ++y)
            {
                for (int x = 0; x < bm.Width; ++x)
                {
                    // get the color of current pixel
                    c = bm.GetPixel(x, y);

                    // track bar is set to increase red value
                    if (i < 50)
                    {
                        r = c.R + (50 - i);
                        g = c.G;
                    }

                    // track bar is set to increase green value
                    else
                    {
                        g = c.G + (i - 50);
                        r = c.R;
                    }


                    // if red or green value is greater than 255, set the value to 255
                    // if red or green value is less than 0, set the value to 0
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;

                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;

                    // does not change blue value at all
                    b = c.B;

                    // change the temporary image rather than the actual image
                    bm.SetPixel(x, y, Color.FromArgb(c.A, r, g, b));
                }
                TProg((double)y/bm.Height);

            }
 

        }
        private void TProg(double y)
        {
            progressBar2.Value = (int)Math.Ceiling(y * 100);
        }

        private void TransformContrast(Bitmap bm, int i)
        {
            int effectLevel = (i / 5);
            // values for red, green, and blue
            int r = 0, g = 0, b = 0;

            // used to get pixel's color
            Color c = Color.White;

            for (int y = 0; y < bm.Height; ++y)
            {
                for (int x = 0; x < bm.Width; ++x)
                {
                    // get the color of current pixel
                    c = bm.GetPixel(x, y);

                    // if each red, green, or blue value of the pixel is greater than 128,
                    //  it will increase the value by 1/5th of the track bar value
                    //  else it will decrease the value by 1/5th of the track bar value
                    r = (c.R > 128) ? c.R + effectLevel : c.R - effectLevel;
                    g = (c.G > 128) ? c.G + effectLevel : c.G - effectLevel;
                    b = (c.B > 128) ? c.B + effectLevel : c.B - effectLevel;

                    // if each red, green, or blue value is greater than 255, the value is set to 255
                    // if each red, green, or blue value is less than 0, the value is set to 0
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;

                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;

                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;

                    // change the temporary image rather than the actual image
                    bm.SetPixel(x, y, Color.FromArgb(c.A, r, g, b));

                }
                TProg((double)y/bm.Height);


            }
           progressBar2.Value = 0;
        }

        private void UI_Btn_Transform_Click(object sender, EventArgs e)
        {
            /*   Bitmap temp = new Bitmap(UI_OFD.FileName);
               int i = TrackbarChange;
               if (threadTime == null)
               {

                   threadTime = new Thread( new ParameterizedThreadStart(ThreadCheck(temp, i) ));
                       threadTime.IsBackground = true;


               threadTime.Start();
               }*/




            Bitmap temp = new Bitmap(UI_OFD.FileName);
            int p = TrackbarChange;

            if (UI_rBtn_Contrast.Checked)
            {
                Invoke(new delImage(TransformContrast), temp, p);
            }
            else if (UI_rBtn_BW.Checked)
            {
                Invoke(new delImage(TransformBlackNWhite), temp, p);
            }
            else if (UI_rBtn_Tint.Checked)
            {
                Invoke(new delImage(TransformTint), temp, p);
            }
            else if (UI_rBtn_Noise.Checked)
            {
                Invoke(new delImage(TransformNoise), temp, p);
            }


            UI_pBox.Image = temp;
        }

       /* private void ThreadCheck(Bitmap bm, int i)
        {
         *//*   Bitmap temp = new Bitmap(UI_OFD.FileName);
            int p = TrackbarChange;*//*

            try
            {

                if (UI_rBtn_Contrast.Checked)
                {
                    Invoke(new delContrast(TransformContrast),bm, i);
                }
               // UI_pBox.Image = temp;
            }
            catch (Exception ex) { }
        }*/
    }
}
       



        

      /*  private void ThreadCheck()
        {
            Bitmap temp = new Bitmap(UI_OFD.FileName);
           int p = TrackbarChange;
                
            for(int x= 0; x<temp.Width; x++)
            {
                for(int y= 0; y<temp.Height; y++)
                {
                  
                    try
                    {

                    Invoke(new delContrast(TransformContrast), temp ,p);
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }*/

       /*   \
               
        }
       /* private void CheckTime()
        {
           
        }*/
       // private void TProg(double value)
      /*  {
           progressBar2.Value = (int)value;
        }

    
    }
}
*/