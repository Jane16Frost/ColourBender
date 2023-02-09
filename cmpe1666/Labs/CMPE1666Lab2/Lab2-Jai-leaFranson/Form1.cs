﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Jai_leaFranson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadPicture(object sender, EventArgs e)
        {
            pictureDialog = new OpenFileDialog();
            pictureDialog.Filter = ".bmp|*.bmp;|.jpg|*.jpg;*.jpeg;|.png|*.png;|All Files|*.*";

            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Load(pictureDialog.FileName);
                    transformBtn.Enabled = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    
                }
            }
            
        }
        private void savePictureBtn_Click(object sender, EventArgs e)
        {
            Bitmap pictureToSave;
            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = ".bmp|*.bmp;|.jpg|*.jpg;*.jpeg;|.png|*.png;";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureToSave = new Bitmap(pictureBox.Image);
                    pictureToSave.Save(saveFileDialog.FileName);

                }
                catch(Exception ex)
                {

                }

            }

        }

        private void UpdateTrackBar(object sender, EventArgs e)
        {
            if (tintRadio.Checked)
            {
                smallSlideLabel.Text = "Red";
                bigSlideLabel.Text = "Green";

                if (modificationSlider.Value > 50)
                    trackValue.Text = $"To green: {modificationSlider.Value - 50}";
                else if (modificationSlider.Value < 50)
                    trackValue.Text = $"To red: {50 - modificationSlider.Value}";
                else
                    trackValue.Text = "0";
            }
            else if(scrambleRadio.Checked)
            {
                smallSlideLabel.Text = "Left Shift";
                bigSlideLabel.Text = "Right Shift";

                if (modificationSlider.Value > 50)
                    trackValue.Text = $"Shifting {(modificationSlider.Value-50) * 2}% Right";
                else if (modificationSlider.Value <= 50)
                    trackValue.Text = $"Shifting {(50 - modificationSlider.Value) * 2}% Left";
            }
            else
            {
                trackValue.Text = modificationSlider.Value.ToString();
                smallSlideLabel.Text = "Less";
                bigSlideLabel.Text = "More";
            }
        }
        private void transformBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ModifyPicture();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        private void ModifyPicture()
        {

            Bitmap pictureToModify = new Bitmap(pictureBox.Image);
            double loopCounter = 0;
            double maxSize = pictureToModify.Width * pictureToModify.Height;
            int percentageChange = modificationSlider.Value / 5;
            Random random = new Random();

            for (int x = 0; x < pictureToModify.Width; x++)
            {
                for(int y =0; y < pictureToModify.Height; y++)
                {
                   
                    if (contrastRadio.Checked)
                    pictureToModify.SetPixel(x, y, ContrastAdjuster(pictureToModify.GetPixel(x,y)));
                  
                    else if(bwRadio.Checked)
                    pictureToModify.SetPixel(x, y, BlackAndWhiteAdjuster(pictureToModify.GetPixel(x, y)));
                  
                    else if(tintRadio.Checked)
                        pictureToModify.SetPixel(x, y, TintAdjuster(pictureToModify.GetPixel(x, y)));
                 
                    else if (noiseRadio.Checked)
                        pictureToModify.SetPixel(x, y, NoiseAdjuster(pictureToModify.GetPixel(x, y), random));
                    
                    else if(scrambleRadio.Checked)
                        pictureToModify.SetPixel(x, y, ScrambleAdjuster(pictureToModify.GetPixel(x, y), random));

                    else if(negativeRadio.Checked)
                        pictureToModify.SetPixel(x, y, NegativeAdjuster(pictureToModify.GetPixel(x, y)));
                    else if(colorRadio.Checked)
                        pictureToModify.SetPixel(x, y, ColourAdjuster(pictureToModify.GetPixel(x, y)));


                    loopCounter++;
                    progressBar.Value = (int)(loopCounter / maxSize * 100);
                }

            }
            pictureBox.Image = pictureToModify;
                
        }

        private double GetHue(int[] rgb)
        {
            double hue = 0;
            switch(Array.IndexOf(rgb, rgb.Max()))
            {
                case 0:
                    hue = (rgb[1] - rgb[2]) / (double)(rgb.Max() - rgb.Min());
                    break;
                case 1:
                    hue = 2.0 + (rgb[2] - rgb[0]) / (double)(rgb.Max() - rgb.Min());
                    break;
                case 2:
                    hue = 4.0 + (rgb[0] - rgb[1]) / (double)(rgb.Max() - rgb.Min());
                    break;
            }

            hue *= 60;
            if (hue < 0)
                hue += 360;
            else if (hue > 360)
                hue -= 360;

            return hue;
        }

        private int[] SolveHue(double hue, double luminosity)
        {
            hue /= 60;
            luminosity /= 0.5;

            if(hue >= 5)
            {
               //Magenta
               //R B G

                // hue - 6 = (G-B) / (R - G)
                //luminosity = (R-G)
            }
            else if(hue >= 4)
            {
                //Blue Range
                //B R G
               
                //hue - 4 = (R-G) / (B-G)
            }
            else if(hue >= 3)
            {
                //Cyan
                //B G R

                //hue - 4 = (R-G) / (B-R)
            }
            else if(hue >= 2)
            {
                //Green
                //G B R

                //hue - 2 = (B-R) / (G-R)
            }
            else if(hue >= 1)
            {
                //Yellow
                //G R B

                //hue -2 = (B-R) / (G-B)
            }
            else //Hue >= 0
            {
                //Red
                // R G B

                // Hue = (G-B) / (R-B)
            }

            return new int[] { 1, 2, 3};

        }

        /*************************************************************
           1. Black and White Adjuster
         ************************************************************/
        private Color BlackAndWhiteAdjuster(Color currentPixel)
        {
            double percentageChange = modificationSlider.Value / 100.00;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            double totalValue = (rgbValue[0] + rgbValue[1] + rgbValue[2]) / 3;

            for (int value = 0; value < 3; value++)
            {
                rgbValue[value] += (int)Math.Round((totalValue - rgbValue[value]) * percentageChange);
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
           2.  Add Colour 
         ************************************************************/
        private Color ColourAdjuster(Color currentPixel)
        {
            double percentageChange = modificationSlider.Value / 100.0;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            int maxIndex = Array.IndexOf(rgbValue, rgbValue.Max());
            int difference = rgbValue.Max() - rgbValue.Min();
            difference = (int)(difference * percentageChange);

            for (int value = 0; value < 3; value++)
            {
                if (value == maxIndex)
                {
                    rgbValue[value] += difference;
                    if (rgbValue[value] > 255)
                        rgbValue[value] = 255;
                }
                else
                {
                    rgbValue[value] -= difference;
                    if (rgbValue[value] < 0)
                        rgbValue[value] = 0;
                }
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);

            return currentPixel;
        }

        /*************************************************************
           3.  Negative
         ************************************************************/
        private Color NegativeAdjuster(Color currentPixel)
        {
            double percentageChange = modificationSlider.Value / 100.0;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            double hue = GetHue(rgbValue);
            double invertedHue = hue - 180;
            
            double luminosity = 0.5 * (rgbValue.Max() - rgbValue.Min());
            double invertedLuminosity = 1 - luminosity;

            if (invertedHue < 0)
                invertedHue += 360;

            rgbValue = SolveHue(invertedHue, invertedLuminosity);

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            4. Noise
         ************************************************************/
        private Color NoiseAdjuster(Color currentPixel, Random colourModifier)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };


            for (int value = 0; value < 3; value++)
            {
                rgbValue[value] += colourModifier.Next(-percentageChange, percentageChange + 1);

                if (rgbValue[value] > 255)
                    rgbValue[value] = 255;
                else if (rgbValue[value] < 0)
                    rgbValue[value] = 0;
            }
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            5. Colour Evener
         ************************************************************/

        /*************************************************************
            6. Pixelizer
         ************************************************************/

        /*************************************************************
            7. Scrambler Adjuster
         ************************************************************/
        private Color ScrambleAdjuster(Color currentPixel, Random random)
        {
            int typeChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            if (typeChange <= 50)
            {//Shift Colours Left
                if (random.Next(50) >= typeChange)
                    currentPixel = Color.FromArgb(rgbValue[1], rgbValue[2], rgbValue[0]);

            }
            else
            {//Shift Colours Right
                if (random.Next(50) <= typeChange - 50)
                    currentPixel = Color.FromArgb(rgbValue[2], rgbValue[0], rgbValue[1]);
            }


            return currentPixel;
        }

        /*************************************************************
            8. Brightness Adjuster
         ************************************************************/

        /*************************************************************
            9. Colour Finder
         ************************************************************/

        /*************************************************************
            10. Trad Tint
         ************************************************************/
        private Color TintAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            if (percentageChange < 50)
            {
                percentageChange = 50 - percentageChange;
                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

            }
            else if (percentageChange > 50)
            {
                percentageChange = percentageChange - 50;
                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            11. Red or Cyan Tint
         ************************************************************/
        private Color RedCyanTintAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            if (percentageChange < 50)
            {
                percentageChange = 50 - percentageChange;
              
                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

                rgbValue[1] -= percentageChange;
                if (rgbValue[1] < 0)
                    rgbValue[1] = 0;

                rgbValue[2] -= percentageChange;
                if (rgbValue[2] < 0)
                    rgbValue[2] = 0;

            }
            else if (percentageChange > 50)
            {
                percentageChange = percentageChange - 50;

                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;

                rgbValue[2] += percentageChange;
                if (rgbValue[2] > 255)
                    rgbValue[2] = 255;

                rgbValue[0] -= percentageChange;
                if (rgbValue[0] < 0)
                    rgbValue[0] = 0;
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }
        /*************************************************************
            12. Green or Magneta Tint
         ************************************************************/
        private Color GreenMagentaTintAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            if (percentageChange < 50)
            {
                percentageChange = 50 - percentageChange;

                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;

                rgbValue[0] -= percentageChange;
                if (rgbValue[0] < 0)
                    rgbValue[0] = 0;

                rgbValue[2] -= percentageChange;
                if (rgbValue[2] < 0)
                    rgbValue[2] = 0;

            }
            else if (percentageChange > 50)
            {
                percentageChange = percentageChange - 50;

                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

                rgbValue[2] += percentageChange;
                if (rgbValue[2] > 255)
                    rgbValue[2] = 255;

                rgbValue[1] -= percentageChange;
                if (rgbValue[1] < 0)
                    rgbValue[1] = 0;
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            13. Blue Or Yellow Tint
         ************************************************************/
        private Color BlueYellowTintAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            if (percentageChange < 50)
            {
                percentageChange = 50 - percentageChange;

                rgbValue[2] += percentageChange;
                if (rgbValue[2] > 255)
                    rgbValue[2] = 255;

                rgbValue[1] -= percentageChange;
                if (rgbValue[1] < 0)
                    rgbValue[1] = 0;

                rgbValue[0] -= percentageChange;
                if (rgbValue[0] < 0)
                    rgbValue[0] = 0;

            }
            else if (percentageChange > 50)
            {
                percentageChange = percentageChange - 50;

                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;

                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

                rgbValue[2] -= percentageChange;
                if (rgbValue[2] < 0)
                    rgbValue[2] = 0;
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            14. Trad Contrast Adjuster
         ************************************************************/
        private Color ContrastAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value / 5;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            for (int value = 0; value < rgbValue.Length; value++)
            {
                if (rgbValue[value] > 128)
                {
                    rgbValue[value] += percentageChange;
                    if (rgbValue[value] > 255)
                        rgbValue[value] = 255;
                }
                else if (rgbValue[value] < 128)
                {
                    rgbValue[value] -= percentageChange;
                    if (rgbValue[value] < 0)
                        rgbValue[value] = 0;
                }

            }
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            15. Contrast Reverser
         ************************************************************/


        /*************************************************************
            16. Red - Cyan Contrast Adjuster
         ************************************************************/
        private Color RedCyanContrastAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value / 5;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };


            if (rgbValue[0] > 128)
            {
                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

                rgbValue[1] -= percentageChange;
                if (rgbValue[1] < 0)
                    rgbValue[1] = 0;
               
                rgbValue[2] -= percentageChange;
                if (rgbValue[2] < 0)
                    rgbValue[2] = 0;
            }
            else if (rgbValue[0] < 128)
            {
                rgbValue[0] -= percentageChange;
                if (rgbValue[0] < 0)
                    rgbValue[0] = 0;

                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;

                rgbValue[2] += percentageChange;
                if (rgbValue[2] > 255)
                    rgbValue[2] = 255;

            }

            
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            17. Green - Magenta Contrast Adjuster
         ************************************************************/
        private Color GreenMagentaContrastAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value / 5;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            
            if (rgbValue[1] > 128)
            {
                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;

                rgbValue[0] -= percentageChange;
                if (rgbValue[0] < 0)
                    rgbValue[0] = 0;

                rgbValue[2] -= percentageChange;
                if (rgbValue[2] < 0)
                    rgbValue[2] = 0;
            }
            else if (rgbValue[1] < 128)
            {
                rgbValue[1] -= percentageChange;
                if (rgbValue[1] < 0)
                    rgbValue[1] = 0;

                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

                rgbValue[2] += percentageChange;
                if (rgbValue[2] > 255)
                    rgbValue[2] = 255;

            }
           
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            18. Blue Yellow Contrast Adjuster
         ************************************************************/
        private Color BlueYellowContrastAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value / 5;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
           
            if (rgbValue[2] > 128)
            {
                rgbValue[2] += percentageChange;
                if (rgbValue[2] > 255)
                    rgbValue[2] = 255;

                rgbValue[1] -= percentageChange;
                if (rgbValue[1] < 0)
                    rgbValue[1] = 0;

                rgbValue[0] -= percentageChange;
                if (rgbValue[0] < 0)
                    rgbValue[0] = 0;
            }
            else if (rgbValue[2] < 128)
            {
                rgbValue[2] -= percentageChange;
                if (rgbValue[2] < 0)
                    rgbValue[2] = 0;

                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;

                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

            }
            
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }
    }


}
