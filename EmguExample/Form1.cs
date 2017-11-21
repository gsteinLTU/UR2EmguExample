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
using Emgu.CV.Util;

namespace EmguExample
{
    public partial class Form1 : Form
    {
        private VideoCapture capture = new VideoCapture(0);
        
        public Form1()
        {
            InitializeComponent();
        }

        private Thread t;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start worker thread
            t = new Thread(ProcessImage);
            t.Start();
        }

        private Image<Bgr, byte> img = null;

        private void ProcessImage()
        {
            while (true)
            {
                // Read from webcam
                Mat m = new Mat();                
                capture.Read(m);
                img = m.Clone().ToImage<Bgr, byte>();
                Image<Bgr, byte> tempImage = img.Clone();

                // Blur image to remove noise
                tempImage = tempImage.SmoothGaussian(5);

                // Threshold image to find regions
                var greyImage = tempImage.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();

                // Get points along edges
                CvInvoke.FindContours(greyImage, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                // For debugging output
                CvInvoke.DrawContours(tempImage, contours, -1, new MCvScalar(1,1,0), -1);


                foreach (var contour in contours.ToArrayOfArray())
                {
                    VectorOfPoint poly = new VectorOfPoint();

                    // Finds polygon of contour
                    CvInvoke.ApproxPolyDP(new VectorOfPoint(contour), poly, CvInvoke.ArcLength(new VectorOfPoint(contour), true) * 0.05, true);
                    
                    // Draw corners
                    foreach (var point in poly.ToArray())
                    {
                        tempImage.Draw(new CircleF(point, 2), new Bgr(255,255,0), -1 );
                    }

                    // Triangle
                    if (poly.Size == 3)
                    {
                        // Paint it blue
                        tempImage.FillConvexPoly(poly.ToArray(), new Bgr(255,0,0));
                    }

                }

                // Update display
                pictureBoxFilter.Image = tempImage.ToBitmap();
                pictureBoxOriginal.Image = img.ToBitmap();
                frameAvailable = false;
                Thread.Sleep(1);
            }

        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
