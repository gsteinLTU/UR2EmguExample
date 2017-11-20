using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace EmguExample
{
    public partial class Form1 : Form
    {
        private VideoCapture capture = new VideoCapture(0);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture.ImageGrabbed += OnCaptureOnImageGrabbed;

            // Start worker thread
            Thread t = new Thread(ProcessImage);
            t.Start();

            // Start webcam
            capture.Start();
        }

        private Image<Bgr, byte> img = null;
        private bool frameAvailable = false;
        private void ProcessImage()
        {
            while (true)
            {
                // If no frame available, wait
                if (!frameAvailable)
                {
                    Thread.Sleep(1);
                    continue;
                }

                // Read from webcams
                Mat m = new Mat();                
                capture.Read(m);
                img = m.ToImage<Bgr, byte>();
                
                
                Image<Bgr, byte> tempImage = img.Clone();

                Image<Hsv, byte> tempImageHsv = img.Convert<Hsv, byte>();

                // Create mask based on sliders
                Image<Bgr, byte> mask = tempImageHsv[0].InRange(new Gray(hueMin), new Gray(hueMax)).Convert<Bgr, byte>();
                mask &= tempImageHsv[1].InRange(new Gray(satMin), new Gray(satMax)).Convert<Bgr, byte>();
                mask &= tempImageHsv[2].InRange(new Gray(valMin), new Gray(valMax)).Convert<Bgr, byte>();

                // Remove noise from mask
                mask = mask.Erode(3);
                mask = mask.Dilate(3);

                // Apply mask
                tempImage &= mask;
                
                // Display output
                pictureBoxFilter.Image = tempImage.ToBitmap();
                pictureBoxOriginal.Image = img.ToBitmap();
                frameAvailable = false;
            }
        }

        private void OnCaptureOnImageGrabbed(object o, EventArgs args)
        {
            // Tell worker thread that we have something to process
            frameAvailable = true;
        }

        private byte hueMin = 0;
        private byte hueMax = 180;
        private byte satMin = 0;
        private byte satMax = 100;
        private byte valMin = 0;
        private byte valMax = 100;
        private void hueBarMin_Scroll(object sender, EventArgs e)
        {
            hueMin = (byte)hueBarMin.Value;
        }

        private void hueBarMax_Scroll(object sender, EventArgs e)
        {
            hueMax = (byte)hueBarMax.Value;
        }

        private void satBarMin_Scroll(object sender, EventArgs e)
        {
            satMin= (byte)satBarMin.Value;
        }

        private void satBarMax_Scroll(object sender, EventArgs e)
        {
            satMax = (byte)satBarMax.Value;
        }

        private void valBarMin_Scroll(object sender, EventArgs e)
        {
            valMin = (byte)valBarMin.Value;
        }

        private void valBarMax_Scroll(object sender, EventArgs e)
        {
            valMax = (byte)valBarMax.Value;
        }
    }
}
