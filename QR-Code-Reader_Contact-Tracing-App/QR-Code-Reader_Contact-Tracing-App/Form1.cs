using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QR_Code_Reader_Contact_Tracing_App
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        bool isCameraRunning = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo x in filterInfoCollection)
            {
                cboBxDevices.Items.Add(x.Name);
                cboBxDevices.SelectedIndex = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboBxDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();

            isCameraRunning = true;

            timer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isCameraRunning)
            {
                captureDevice.Stop();
            } 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    displayTxtBx.Text = result.ToString();
                    timer.Stop();
                    if (isCameraRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

            if (pictureBox.Image != null)
            {
                pictureBox.Image = null;
            }

            isCameraRunning = false;
        }
    }
}
