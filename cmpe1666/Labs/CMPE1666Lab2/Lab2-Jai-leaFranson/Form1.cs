using System;
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
            else
            {
                trackValue.Text = modificationSlider.Value.ToString();
                smallSlideLabel.Text = "Less";
                bigSlideLabel.Text = "More";
            }
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
                    {
                        pictureToModify.SetPixel(x, y, NoiseAdjuster(pictureToModify.GetPixel(x, y), random));
                    }

                    loopCounter++;
                    progressBar.Value = (int)(loopCounter / maxSize * 100);
                }

            }
            pictureBox.Image = pictureToModify;
                
        }

      

        private Color ContrastAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value / 5;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            for (int value = 0; value < rgbValue.Length; value++)
            {
                if (rgbValue[value] > 128)
                {
                    rgbValue[value] += percentageChange;
                    if(rgbValue[value] > 255)
                        rgbValue[value] = 255;
                }
                else if (value < 128)
                {
                    rgbValue[value] -= percentageChange;
                    if (rgbValue[value] < 0)
                        rgbValue[value] = 0;
                }
                
            }
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }


        private Color BlackAndWhiteAdjuster(Color currentPixel)
        {
            double percentageChange = modificationSlider.Value/100.00;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
            double totalValue = (rgbValue[0] + rgbValue[1] + rgbValue[2]) / 3;

            for (int value = 0; value < 3; value++)
            {
                rgbValue[value] += (int)Math.Round((totalValue - rgbValue[value]) * percentageChange);
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        private Color TintAdjuster(Color currentPixel)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };

            if(percentageChange < 50)
            {
                percentageChange = 50 - percentageChange;
                rgbValue[0] += percentageChange;
                if (rgbValue[0] > 255)
                    rgbValue[0] = 255;

            }
            else if(percentageChange > 50)
            {
                percentageChange = percentageChange - 50;
                rgbValue[1] += percentageChange;
                if (rgbValue[1] > 255)
                    rgbValue[1] = 255;
            }

            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        private Color NoiseAdjuster(Color currentPixel, Random colourModifier)
        {
            int percentageChange = modificationSlider.Value;
            int[] rgbValue = { currentPixel.R, currentPixel.G, currentPixel.B };
           

            for (int value = 0; value < 3; value++)
            {
                rgbValue[value] += colourModifier.Next(-percentageChange, percentageChange+1);

                if (rgbValue[value] > 255)
                    rgbValue[value] = 255;
                else if (rgbValue[value] < 0)
                    rgbValue[value] = 0;
            }
            currentPixel = Color.FromArgb(rgbValue[0], rgbValue[1], rgbValue[2]);
            return currentPixel;
        }

        private void transformBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ModifyPicture();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }


}
