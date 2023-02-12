using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            else if(RCtintRadio.Checked)
            {
                smallSlideLabel.Text = "Red";
                bigSlideLabel.Text = "Cyan";

                if (modificationSlider.Value > 50)
                    trackValue.Text = $"To cyan: {modificationSlider.Value - 50}";
                else if (modificationSlider.Value < 50)
                    trackValue.Text = $"To red: {50 - modificationSlider.Value}";
                else
                    trackValue.Text = "0";
            }
            else if (GMtintRadio.Checked)
            {
                smallSlideLabel.Text = "Green";
                bigSlideLabel.Text = "Magenta";

                if (modificationSlider.Value > 50)
                    trackValue.Text = $"To Magenta: {modificationSlider.Value - 50}";
                else if (modificationSlider.Value < 50)
                    trackValue.Text = $"To Green: {50 - modificationSlider.Value}";
                else
                    trackValue.Text = "0";
            }
            else if (BYtintRadio.Checked)
            {
                smallSlideLabel.Text = "Blue";
                bigSlideLabel.Text = "Yellow";

                if (modificationSlider.Value > 50)
                    trackValue.Text = $"To yellow: {modificationSlider.Value - 50}";
                else if (modificationSlider.Value < 50)
                    trackValue.Text = $"To blue: {50 - modificationSlider.Value}";
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
            else if(colorFinderRadio.Checked)
            {
                if (modificationSlider.Value == 0)
                    modificationSlider.Value = 1;

                smallSlideLabel.Text = "Red";
                bigSlideLabel.Text = "Purple";

                int colorToFind = (int)Math.Ceiling(modificationSlider.Value * 6 / 100.0);
                switch (colorToFind)
                {
                    case 1:
                        trackValue.Text = "Red";
                        break;
                    case 2:
                        trackValue.Text = "Yellow";
                        break;
                    case 3:
                        trackValue.Text = "Green";
                        break;
                    case 4:
                        trackValue.Text = "Cyan";
                        break;
                    case 5:
                        trackValue.Text = "Blue";
                        break;
                    case 6:
                        trackValue.Text = "Magenta";
                        break;

                    default:
                        trackValue.Text = "Err";
                        break;
                }
            }
            else if(pixelRadio.Checked)
            {
                smallSlideLabel.Text = "Small";
                bigSlideLabel.Text = "Big";
                trackValue.Text = modificationSlider.Value.ToString();
                if (modificationSlider.Value == 0)
                    modificationSlider.Value = 1;

            }
            else if(brightnessRadio.Checked)
            {
                smallSlideLabel.Text = "Darker";
                bigSlideLabel.Text = "Lighter";

                if (modificationSlider.Value > 50)
                    trackValue.Text = $"{(modificationSlider.Value - 50) * 2}% Lighter";
                else if (modificationSlider.Value <= 50)
                    trackValue.Text = $"Shifting {(50 - modificationSlider.Value) * 2}% Darker";

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
                for (int y = 0; y < pictureToModify.Height; y++)
                {

                    if (bwRadio.Checked)
                        pictureToModify.SetPixel(x, y, BlackAndWhiteAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (addColorRadio.Checked)
                        pictureToModify.SetPixel(x, y, ColourAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (negativeRadio.Checked)
                        pictureToModify.SetPixel(x, y, NegativeAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (noiseRadio.Checked)
                        pictureToModify.SetPixel(x, y, NoiseAdjuster(pictureToModify.GetPixel(x, y), random));

                    else if(colorEvenerRadio.Checked)
                        pictureToModify.SetPixel(x, y, ColourEvener(x, y, pictureToModify));

                    else if (pixelRadio.Checked)
                    {
                        Pixelizer(x, y, ref pictureToModify);
                        y += modificationSlider.Value - 1;
                    }
                    else if (scrambleRadio.Checked)
                        pictureToModify.SetPixel(x, y, ScrambleAdjuster(pictureToModify.GetPixel(x, y), random));

                    else if (brightnessRadio.Checked)
                        pictureToModify.SetPixel(x, y, BrightnessAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (colorFinderRadio.Checked)
                        pictureToModify.SetPixel(x, y, ColourFinder(pictureToModify.GetPixel(x, y)));

                    else if (tintRadio.Checked)
                        pictureToModify.SetPixel(x, y, TintAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (RCtintRadio.Checked)
                        pictureToModify.SetPixel(x, y, RedCyanTintAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (GMtintRadio.Checked)
                        pictureToModify.SetPixel(x, y, GreenMagentaTintAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (BYtintRadio.Checked)
                        pictureToModify.SetPixel(x, y, BlueYellowTintAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (contrastRadio.Checked)
                        pictureToModify.SetPixel(x, y, ContrastAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (contrastRevRadio.Checked)
                        pictureToModify.SetPixel(x, y, ContrastReverser(pictureToModify.GetPixel(x, y)));

                    else if (RCcontrastRadio.Checked)
                        pictureToModify.SetPixel(x, y, RedCyanContrastAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (GMcontrastRadio.Checked)
                        pictureToModify.SetPixel(x, y, GreenMagentaContrastAdjuster(pictureToModify.GetPixel(x, y)));

                    else if (BYcontrastRadio.Checked)
                        pictureToModify.SetPixel(x, y, BlueYellowContrastAdjuster(pictureToModify.GetPixel(x, y)));


                    loopCounter++;

                    if (pixelRadio.Checked)
                    {
                        if (loopCounter > (maxSize / modificationSlider.Value / modificationSlider.Value))
                            loopCounter = (maxSize / modificationSlider.Value / modificationSlider.Value);
                        progressBar.Value = (int)(loopCounter / (maxSize / modificationSlider.Value / modificationSlider.Value) * 100);
                    }
                    else
                        progressBar.Value = (int)(loopCounter / maxSize * 100);
                }
                if (pixelRadio.Checked)
                {
                    x += modificationSlider.Value - 1;

                    // loopCounter *= modificationSlider.Value;
                }
            }

            pictureBox.Image = pictureToModify;
            progressBar.Value = 0;
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

        private int[] SolveRGBColor(double brightness, double[] colourRatios)
        {
            //Colour Ratios = Yave, Cave, Mave
            int[] solvedRGBvalues = {255 ,255 ,255};


            if((brightness / Math.Sqrt(0.229 + 1 / Math.Pow(colourRatios[0], 2) + 0.114 * Math.Pow(colourRatios[2], 2))) < 255)
            solvedRGBvalues[0] = (int)(brightness / Math.Sqrt(0.229 + 1 / Math.Pow(colourRatios[0], 2) + 0.114 * Math.Pow(colourRatios[2], 2)));

            if(brightness / Math.Sqrt(0.229 * Math.Pow(colourRatios[0], 2) + 1 + 0.114 / Math.Pow(colourRatios[1], 2)) < 255)
            solvedRGBvalues[1] = (int)(brightness / Math.Sqrt(0.229 * Math.Pow(colourRatios[0], 2) + 1 + 0.114 / Math.Pow(colourRatios[1], 2)));

            if(brightness / Math.Sqrt(0.299 / Math.Pow(colourRatios[2], 2) + Math.Pow(colourRatios[1], 2) + 0.114) < 255)
            solvedRGBvalues[2] = (int)(brightness/ Math.Sqrt(0.299 / Math.Pow(colourRatios[2], 2) + Math.Pow(colourRatios[1], 2) + 0.114));

            return solvedRGBvalues;
        }

        private int[] SolveRGBColor(double hue, int averageColor, int degreesOfSeperation)
        {
            averageColor *= 3;
            //averageColor = R + B + G
            

            int[] solvedRGBvalues = {0,0,0};

            hue /= 60;
            if(hue >= 5)
            {
                hue -= 6;
                //Magenta
                //R B G

                // hue = (G-B) / (R - G)
                //degreesOfSeperation = (R-G)

                hue *= degreesOfSeperation;
                //hue = G-B
                //dos = (R-G)
                // B = G - hue
                // R = dos + G
                //ave = dos + G + G + G - hue
                solvedRGBvalues[1] = (int)(averageColor - degreesOfSeperation + hue)/3;
                //G = (ave - dos + hue) /3
                solvedRGBvalues[2] = (int)(solvedRGBvalues[0] - hue);
                //B = G - hue
                solvedRGBvalues[0] = (int)(degreesOfSeperation + solvedRGBvalues[1]);
                //R = dos + G

            }
            else if(hue >= 4)
            {
                //Blue Range
                //B R G

                hue -= 4;
                //hue = (R-G) / (B-G)
                //degreesOfSeperation = (R-G)

                hue *= degreesOfSeperation;
                //hue = R - G
                //dos = B - G
                // R = hue + G
                // B = dos + G

                //ave = G + hue + G + dos + G
                solvedRGBvalues[1] = (int)(averageColor - degreesOfSeperation - hue) / 3;
                //G = (ave - hue - dos) / 3
                solvedRGBvalues[0] = (int)hue + solvedRGBvalues[1];
                //R = hue + G
                solvedRGBvalues[2] = (int)degreesOfSeperation + solvedRGBvalues[1];


            }
            else if(hue >= 3)
            {
                //Cyan
                //B G R

                hue -= 4;
                //hue = (R-G) / (B-R)
                //degreesOfSeperation = (B-R)

                hue *= degreesOfSeperation;
                //hue = R - G
                //dos = B - R
                //G = R - hue
                //B = dos + R

                //ave = R + R - hue + dos + R
                //R = (ave + hue - dos) / 3
                solvedRGBvalues[0] = (int)(averageColor - hue + degreesOfSeperation) / 3;
                //G = R - hue
                solvedRGBvalues[1] = solvedRGBvalues[0] - (int)hue;
                //B = dos + R
                solvedRGBvalues[2] = degreesOfSeperation + solvedRGBvalues[0];

            }
            else if(hue >= 2)
            {
                //Green
                //G B R

                hue -= 2;
                //hue - 2 = (B-R) / (G-R)
                //average = G-R

                hue *= degreesOfSeperation;
                //hue = B - R
                //dos = G - R
                //B = hue + R
                //G = dos + R

                //ave = R + hue + R + dos + R
                //R = (ave - hue - dos) / 3
                solvedRGBvalues[0] = (int)(averageColor - hue - degreesOfSeperation) / 3;
                solvedRGBvalues[1] = degreesOfSeperation + solvedRGBvalues[0];
                solvedRGBvalues[2] = (int)hue + solvedRGBvalues[0];
            }
            else if(hue >= 1)
            {
                //Yellow
                //G R B

                hue -= 2;
                //hue -2 = (B-R) / (G-B)
                //average = G-B
                hue *= degreesOfSeperation;

                //Hue = B-R
                //dos = G - B
                //R = B - hue
                //G = dos + B

                //ave = B - hue + dos + B + B
                // B = ave + hue - dos
                solvedRGBvalues[2] = (int)(averageColor - hue + degreesOfSeperation) / 3;
                //R = B - hue
                solvedRGBvalues[0] = solvedRGBvalues[2] - (int)hue;
                //G = dos + B
                solvedRGBvalues[1] = solvedRGBvalues[2] + degreesOfSeperation;

            }
            else //Hue >= 0
            {
                //Red
                // R G B

                // Hue = (G-B) / (R-B)
                //average = R-B
                hue *= degreesOfSeperation;
                //Hue = G - B
                //Dos = R - B

                //G = hue + b
                //R = B + dos
                //ave = B + dos + B + hue + B
                //B = ave - dos - hue / 3
                solvedRGBvalues[2] = (int)(averageColor - degreesOfSeperation - hue) / 3;
                //R = b + dos
                solvedRGBvalues[0] = solvedRGBvalues[2] + degreesOfSeperation;
                //G = hue + B
                solvedRGBvalues[1] = (int)hue + solvedRGBvalues[2];
            }

            if (solvedRGBvalues[0] > 255)
                solvedRGBvalues[0] = 255;
            if (solvedRGBvalues[1] > 255)
                solvedRGBvalues[1] = 255;
            if (solvedRGBvalues[2] > 255)
                solvedRGBvalues[2] = 255;
            if (solvedRGBvalues[0] < 0)
                solvedRGBvalues[0] = 0;
            if (solvedRGBvalues[1] < 0)
                solvedRGBvalues[1] = 0;
            if (solvedRGBvalues[2] < 0)
                solvedRGBvalues[2] = 0;

            return solvedRGBvalues;

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
            double percentageChange = modificationSlider.Value / 100.00;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            double totalValue = (rgbValue[0] + rgbValue[1] + rgbValue[2]) / 3;

            for (int value = 0; value < 3; value++)
            {
                if(rgbValue[value] == totalValue)
                {
                    
                    if (totalValue < 86)
                    {
                        //Blue
                        if(value == 2)
                        rgbValue[value] += (int)(rgbValue[value] * percentageChange);

                        //magenta
                        if(totalValue > 43 && value == 0)
                            rgbValue[value] += (int)((86 - totalValue) * percentageChange);

                    }
                    else if (totalValue < 169)
                    { 
                        //red
                        if(value == 0)
                        rgbValue[value] += (int)(rgbValue[value] * percentageChange);

                        //yellow
                        if (totalValue > 128 && value == 1)
                            rgbValue[value] += (int)((169 - totalValue) * percentageChange);

                    }
                    else if(value == 1)
                    {
                        //green
                        rgbValue[value] += (int)(rgbValue[value] * percentageChange);

                        //cyan
                        if (totalValue > 212 && value == 2)
                            rgbValue[value] += (int)((255 - totalValue) * percentageChange);
                    }
                   

                }
                else  
                    rgbValue[value] -= (int)Math.Round((totalValue - rgbValue[value]) * percentageChange);

                if (rgbValue[value] > 255)
                    rgbValue[value] = 255;

                if (rgbValue[value] < 0)
                    rgbValue[value] = 0;

            }

       //     int maxIndex = Array.IndexOf(rgbValue, rgbValue.Max());
       //     int difference = rgbValue.Max() - rgbValue.Min();
       //     difference = (int)(difference * percentageChange);

         /*   for (int value = 0; value < 3; value++)
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
            }*/
            

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);

            return currentPixel;
        }

        /*************************************************************
           3.  Negative
         ************************************************************/
        /* private Color NegativeAdjuster(Color currentPixel)
         {
             double percentageChange = modificationSlider.Value / 100.0;
             int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
             double maxBrightness = Math.Sqrt(0.299 * Math.Pow(256, 2) + Math.Pow(256, 2) + 0.114 * Math.Pow(256, 2));
             double brightness = Math.Sqrt(0.299*Math.Pow(currentPixel.R, 2) + Math.Pow(currentPixel.G, 2) + 0.144 * Math.Pow(currentPixel.B, 2));
             double[] cymValues = { currentPixel.G / (double)currentPixel.R *percentageChange, currentPixel.B / (double)currentPixel.G * percentageChange, currentPixel.R* percentageChange / (double)currentPixel.B };

             brightness = (Math.Round(maxBrightness)+ 1 - Math.Round(brightness));
             //double hue = GetHue(rgbValue);
             // double invertedHue = hue - 180;

             //  double luminosity = 0.5 * (rgbValue.Max() - rgbValue.Min());
             //  double invertedLuminosity = 1 - luminosity;

             // if (invertedHue < 0)
             //   invertedHue += 360;

             //rgbValue = SolveHue(invertedHue, invertedLuminosity);
             rgbValue = SolveRGBColor(brightness, cymValues);

             currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
             return currentPixel;
         }
        */

        /*
        private Color NegativeAdjuster(Color currentPixel)
        {
            double percentageChange = modificationSlider.Value / 100.0;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            int[] pureInvertRGB = {255 - currentPixel.R, 255 - currentPixel.G, 255 - currentPixel.B};
            int[] brightnessInvertRGB;

            double hue = GetHue(rgbValue);
            int averageValue = (rgbValue[0] + rgbValue[1] + rgbValue[2]) / 3;
            int colorSeperation = rgbValue.Max() - rgbValue.Min();

           

            averageValue = 255 - averageValue;
            brightnessInvertRGB = SolveRGBColor(hue, averageValue, colorSeperation);

            rgbValue[0] = brightnessInvertRGB[0] + (int)((pureInvertRGB[0] - brightnessInvertRGB[0]) * percentageChange);
            rgbValue[1] = brightnessInvertRGB[1] + (int)((pureInvertRGB[1] - brightnessInvertRGB[1]) * percentageChange);
            rgbValue[2] = brightnessInvertRGB[2] + (int)((pureInvertRGB[2] - brightnessInvertRGB[2]) * percentageChange);


            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);

            return currentPixel;
        }
        */

        private Color NegativeAdjuster(Color currentPixel)
        {
            double percentageChange = modificationSlider.Value / 100.0;
            int[] rgbValue = { 255 - currentPixel.R, 255 - currentPixel.G, 255 - currentPixel.B };

            rgbValue[0] = currentPixel.R + (int)((rgbValue[0] - currentPixel.R) * percentageChange);
            rgbValue[1] = currentPixel.G + (int)((rgbValue[1] - currentPixel.G) * percentageChange);
            rgbValue[2] = currentPixel.B + (int)((rgbValue[2] - currentPixel.B) * percentageChange);


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
        private Bitmap ColourEvener(Bitmap originalImage)
        {
            Bitmap newImage = new Bitmap(originalImage.Width, originalImage.Height);
            int squareSize = modificationSlider.Value;
            int[] rgbValue = { 0, 0, 0 };
            int addedNumbers = 0;
            double loopCounter = 0;
            double maxSize = originalImage.Width * originalImage.Height;

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    rgbValue[0] = 0;
                    rgbValue[1] = 0;
                    rgbValue[2] = 0;
                    addedNumbers = 0;

                    for (int locationX = -squareSize + x; locationX <= squareSize + x; locationX++)
                    {
                        for (int locationY = -squareSize + y; locationY < squareSize + y; locationY++)
                        {
                            if (locationX > 0 && locationY > 0 && locationX < originalImage.Width && locationY < originalImage.Height)
                            {
                                if (locationX != x || locationY != y)
                                {
                                    rgbValue[0] += originalImage.GetPixel(locationX, locationY).R;
                                    rgbValue[1] += originalImage.GetPixel(locationX, locationY).G;
                                    rgbValue[2] += originalImage.GetPixel(locationX, locationY).B;

                                    addedNumbers++;

                                }
                            }
                        }
                    }
                    loopCounter++;
                    rgbValue[0] /= addedNumbers;
                    rgbValue[1] /= addedNumbers;
                    rgbValue[2] /= addedNumbers;

                    newImage.SetPixel(x, y, Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]));
                    progressBar.Value = (int)(loopCounter / maxSize * 100);
                }
            }

            return newImage;
        }

        private Color ColourEvener(int x, int y, Bitmap bitmap)
        {
            Color currentPixel = bitmap.GetPixel(x, y);
            int percentageChange = 100 - modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            int[] averageRGBvalue = { 0, 0, 0 };

            if(x > 0)
            {
                averageRGBvalue[0] += bitmap.GetPixel(x - 1, y).R;
                averageRGBvalue[1] += bitmap.GetPixel(x - 1, y).G;
                averageRGBvalue[2] += bitmap.GetPixel(x - 1, y).B;

            }
            if (x < bitmap.Width - 1)
            {
                averageRGBvalue[0] += bitmap.GetPixel(x + 1, y).R;
                averageRGBvalue[1] += bitmap.GetPixel(x + 1, y).G;
                averageRGBvalue[2] += bitmap.GetPixel(x + 1, y).B;

            }
            if (y > 0)
            {
                averageRGBvalue[0] += bitmap.GetPixel(x, y - 1).R;
                averageRGBvalue[1] += bitmap.GetPixel(x, y - 1).G;
                averageRGBvalue[2] += bitmap.GetPixel(x, y - 1).B;

            }
            if (y < bitmap.Height - 1)
            {
                averageRGBvalue[0] += bitmap.GetPixel(x, y + 1).R;
                averageRGBvalue[1] += bitmap.GetPixel(x, y + 1).G;
                averageRGBvalue[2] += bitmap.GetPixel(x, y + 1).B;

            }

            averageRGBvalue[0] /= 4;
            averageRGBvalue[1] /= 4;
            averageRGBvalue[2] /= 4;

            if (rgbValue[0] < averageRGBvalue[0] - percentageChange 
               || rgbValue[0] > averageRGBvalue[0] + percentageChange)
                rgbValue[0] = averageRGBvalue[0];
           
            if (rgbValue[1] < averageRGBvalue[1] - percentageChange
               || rgbValue[1] > averageRGBvalue[1] + percentageChange)
                rgbValue[1] = averageRGBvalue[1];
          
            if (rgbValue[2] < averageRGBvalue[2] - percentageChange
               || rgbValue[2] > averageRGBvalue[2] + percentageChange)
                rgbValue[2] = averageRGBvalue[2];

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            6. Pixelizer
         ************************************************************/
        private void Pixelizer(int xPosition, int yPosition, ref Bitmap bitmap)
        {
            Color averageColor;
            int pixelSizeX = modificationSlider.Value;
            int pixelSizeY = modificationSlider.Value; 
            double[] rgbValue = { 0, 0, 0};

            if(xPosition + pixelSizeX > bitmap.Width)
            {
                pixelSizeX = bitmap.Width - xPosition;
            }
            if(yPosition + pixelSizeY > bitmap.Height)
            {
                pixelSizeY = bitmap.Height - yPosition;
            }

            for(int xLength = 0; xLength < pixelSizeX; xLength++)
            {
               for(int yLength = 0; yLength < pixelSizeY; yLength++)
                {
                    rgbValue[0] += bitmap.GetPixel(xPosition + xLength, yPosition + yLength).R;
                    rgbValue[1] += bitmap.GetPixel(xPosition + xLength, yPosition + yLength).G;
                    rgbValue[2] += bitmap.GetPixel(xPosition + xLength, yPosition + yLength).B;
                }
            }

           
            rgbValue[0] = rgbValue[0] / (pixelSizeX * pixelSizeY);
            rgbValue[1] = rgbValue[1] / (pixelSizeX * pixelSizeY);
            rgbValue[2] = rgbValue[2] / (pixelSizeX * pixelSizeY);
           


            averageColor = Color.FromArgb((int)rgbValue[0], (int)rgbValue[1], (int)rgbValue[2]);

            for (int xLength = 0; xLength < pixelSizeX; xLength++)
            {
                for (int yLength = 0; yLength < pixelSizeY; yLength++)
                {
                    bitmap.SetPixel(xPosition + xLength, yPosition + yLength, averageColor);
                }
            }

        }
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
        private Color BrightnessAdjuster(Color currentPixel)
        {
            double imageBrightness = (modificationSlider.Value / 100.0);
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            double[] cymValues = { currentPixel.R / (double)currentPixel.G, currentPixel.G / (double)currentPixel.B, currentPixel.B / (double)currentPixel.R };
            //int average = rgbValue.Max() - rgbValue.Min() / 2;
            //double hue = GetHue(rgbValue);
            double oldBrightnessValue = Math.Sqrt(0.299*Math.Pow(currentPixel.R, 2) + Math.Pow(currentPixel.G, 2) + 0.144 * Math.Pow(currentPixel.B, 2));
            double newImageBrightness;
            

            if(imageBrightness > 0.5)
            {
                newImageBrightness = oldBrightnessValue + oldBrightnessValue * (imageBrightness * 2); 
                rgbValue = SolveRGBColor(newImageBrightness, cymValues);
            }
            else if(imageBrightness < 0.5)
            {
                newImageBrightness = oldBrightnessValue - oldBrightnessValue * (1 - imageBrightness * 2);
                rgbValue = SolveRGBColor(newImageBrightness, cymValues);

            }


            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        /*************************************************************
            9. Colour Finder
         ************************************************************/
        private Color ColourFinder(Color currentPixel)
        {
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            int colorToFind = (int)Math.Ceiling(modificationSlider.Value * 6 / 100.0);

            switch(colorToFind)
            {
                case 1:
                    rgbValue[1] -= 10;
                    rgbValue[2] -= 10;
                    //red
                    break;
                case 2:
                    rgbValue[2] -= 10;
                    //Yellow
                    break;
                case 3:
                    rgbValue[0] -= 10;
                    rgbValue[2] -= 10;
                    //Green
                    break;
                case 4:
                    rgbValue[0] -= 10;
                    //cyan
                    break;
                case 5:
                    rgbValue[0] -= 10;
                    rgbValue[1] -= 10;
                    //Blue
                    break;
                case 6:
                    //Magenta
                    rgbValue[1] -= 10;
                    break;
            }

            if (rgbValue[0] < 0)
                rgbValue[0] = 0;
          
            if (rgbValue[1] < 0)
                rgbValue[1] = 0;
          
            if (rgbValue[2] < 0)
                rgbValue[2] = 0;

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

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
        private Color ContrastReverser(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value / 5;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            for (int value = 0; value < rgbValue.Length; value++)
            {
                if (rgbValue[value] < 128)
                {
                    rgbValue[value] += percentageChange;
                    if (rgbValue[value] > 255)
                        rgbValue[value] = 255;
                }
                else if (rgbValue[value] > 128)
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
