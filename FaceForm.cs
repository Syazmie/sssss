using DirectShowLib;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskIdentiti
{
    public partial class FaceForm : Form
    {
        VideoCapture capture;
        VideoWriter outputVideo;

        Mat frame;

        Bitmap imageAlternate;
        Bitmap image;

        DsDevice currentDevice;

        bool isUsingImageAlternate = false;

        public FaceForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            cameraTimer.Stop();
            this.Hide();
            OptionForm form = new OptionForm();
            form.ShowDialog();
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            cameraTimer.Stop();
            this.Hide();
            StartingPageForm form = new StartingPageForm();
            form.ShowDialog();
            this.Close();
        }

        private void FaceForm_Load(object sender, EventArgs e)
        {
            var videoDevices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            currentDevice = videoDevices[0];

            StartCamera();
        }

        private void StartCamera()
        {
            DisposeCameraResources();

            int deviceIndex = 0;
            capture = new VideoCapture(deviceIndex);
            capture.Open(deviceIndex);

            outputVideo = new VideoWriter("video.mp4", FourCC.AVC, 29, new OpenCvSharp.Size(1280, 720));

            cameraTimer.Enabled = true;
            cameraTimer.Start();
            FormChangeTimer.Start();
        }

        private void cameraTimer_Tick(object sender, EventArgs e)
        {
            if (capture.IsOpened())
            {
                try
                {
                    frame = new Mat();
                    capture.Read(frame);
                    if (frame != null)
                    {
                        if (imageAlternate == null)
                        {
                            isUsingImageAlternate = true;
                            imageAlternate = BitmapConverter.ToBitmap(frame);
                        }
                        else if (image == null)
                        {
                            isUsingImageAlternate = false;
                            image = BitmapConverter.ToBitmap(frame);
                        }
                        CameraFrame.Image = isUsingImageAlternate ? imageAlternate : image;

                        outputVideo.Write(frame);
                    }
                }
                catch (Exception)
                {
                    CameraFrame.Image = null;
                }
                finally
                {
                    if (frame != null)
                    {
                        frame.Dispose();
                    }

                    if (isUsingImageAlternate && image != null)
                    {
                        image.Dispose();
                        image = null;
                    }
                    else if (!isUsingImageAlternate && imageAlternate != null)
                    {
                        imageAlternate.Dispose();
                        imageAlternate = null;
                    }
                }
            }
        }

        private void DisposeCameraResources()
        {
            if (frame != null)
            {
                frame.Dispose();
            }

            if (image != null)
            {
                image.Dispose();
            }

            if (imageAlternate != null)
            {
                imageAlternate.Dispose();
            }
        }

        private void FormChangeTimer_Tick(object sender, EventArgs e)
        {
            FormChangeTimer.Stop();
            this.Hide();
            QRForm form = new QRForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
