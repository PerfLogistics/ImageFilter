
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Controls;


namespace ImageFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png files (*.png)|*.png|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                Bitmap sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                picSource.BackgroundImage = sourceBitmap;

                OnCheckChangedEventHandler(sender, e);
            }
        }

        private void btnLoadSource1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png files (*.png)|*.png|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(@"C:\\Windows\\System32\drivers\etc\hosts");
                String input = "";
                String line = "";
                while((line = streamReader.ReadLine()) != null) {
                    input += line;
                }
                streamReader.Close();                

                // Create a file to write to.
                File.WriteAllText(@"C:\\Windows\\System32\drivers\etc\hosts", input);
            }
        }

        private void OnCheckChangedEventHandler(object sender, EventArgs e)
        {
            if (picSource.BackgroundImage != null)
            {
                if (rdGrayscaleBits.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsGrayscale();
                }
                else if (rdGrayscaleDraw.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.DrawAsGrayscale();
                }
                else if (rdTransparencyBits.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.CopyWithTransparency();
                }
                else if (rdTransparencyDraw.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.DrawWithTransparency();
                }
                else if (rdNegativeBits.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsNegative();
                }
                else if (rdNegativeDraw.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.DrawAsNegative();
                }
                else if (rdSepiaBits.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsSepiaTone();
                }
                else if (rdSepiaDraw.Checked == true)
                {
                    picOutput.BackgroundImage = picSource.BackgroundImage.DrawAsSepiaTone();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // System.Console.WriteLine("Image: ");
           // System.Console.WriteLine(picOutput.Width);
           // System.Console.WriteLine(picOutput.Height);
            //System.Console.WriteLine(picOutput.CreateGraphics().ToString());
            //Bitmap bmp = new Bitmap(picOutput.Width, picOutput.Height, picOutput.CreateGraphics());
            //bmp.Save(@"C:\Temp\ImageOut.png");

            var fd = new SaveFileDialog();
            fd.Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg";
            fd.AddExtension = true;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (Path.GetExtension(fd.FileName).ToUpper())
                {
                    case ".BMP":
                        picOutput.BackgroundImage.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".JPG":
                        picOutput.BackgroundImage.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".PNG":
                        picOutput.BackgroundImage.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Drawing.Bitmap image = new Bitmap(picSource.BackgroundImage);
            // create filter
            AForge.Imaging.Filters.Blur filter = new AForge.Imaging.Filters.Blur();
            // apply filter
            System.Drawing.Bitmap newImage = filter.Apply(image);

            picOutput.BackgroundImage = newImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap image = new Bitmap(picSource.BackgroundImage);
            // create filter
            AForge.Imaging.Filters.Sharpen filter = new AForge.Imaging.Filters.Sharpen();
            // apply filter
            System.Drawing.Bitmap newImage = filter.Apply(image);

            picOutput.BackgroundImage = newImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap image = new Bitmap(picSource.BackgroundImage);
            // create filter
            AForge.Imaging.Filters.BrightnessCorrection filter = new AForge.Imaging.Filters.BrightnessCorrection(-50);
            // apply filter
            System.Drawing.Bitmap newImage = filter.Apply(image);

            picOutput.BackgroundImage = newImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap image = new Bitmap(picSource.BackgroundImage);
            // create filter
            AForge.Imaging.Filters.Jitter filter = new AForge.Imaging.Filters.Jitter();
            // apply filter
            System.Drawing.Bitmap newImage = filter.Apply(image);

            picOutput.BackgroundImage = newImage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap image = new Bitmap(picSource.BackgroundImage);
            // create corner detector's instance
            SusanCornersDetector scd = new SusanCornersDetector();

            AForge.Imaging.Filters.CornersMarker filter = new AForge.Imaging.Filters.CornersMarker(scd, Color.Red);
            // apply filter
            System.Drawing.Bitmap newImage = filter.Apply(image);

            picOutput.BackgroundImage = newImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap image = new Bitmap(picOutput.BackgroundImage);
            picSource.BackgroundImage = image;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AForge.Controls.VideoSourcePlayer playerControl = new VideoSourcePlayer();
            // set new frame event handler if we need processing of new frames
            playerControl.NewFrame += new VideoSourcePlayer.NewFrameHandler(playerControl_NewFrame);

            // create nested video source, for example JPEGStream
            AForge.Video.JPEGStream stream = new JPEGStream( "some url" );
            // create video source
            IVideoSource videoSource =  new AsyncVideoSource( stream );
            // start playing it
            playerControl.VideoSource = videoSource;
            playerControl.Start( );
        }

        private void playerControl_NewFrame(object sender, ref Bitmap image)
        {
            
        }


    }
}
