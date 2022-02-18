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
            if (!isCameraRunning)
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cboBxDevices.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();

                isCameraRunning = true;

                timer.Start();

                btnStart.BackColor = Color.FromArgb(18, 46, 118);
                btnStart.ForeColor = Color.FromArgb(199, 216, 231);
                btnStart.Text = "Stop";
            } 
            else if (isCameraRunning)
            {
                DevicesReset();

                btnStart.BackColor = Color.FromArgb(199, 216, 231);
                btnStart.ForeColor = Color.FromArgb(18, 46, 118);
                btnStart.Text = "Start";
            }
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
                    DevicesReset();

                    var form2 = new Form2(result);
                    form2.Show();

                    btnStart.BackColor = Color.FromArgb(199, 216, 231);
                    btnStart.ForeColor = Color.FromArgb(18, 46, 118);
                    btnStart.Text = "Start";
                }
            }
        }

        void DevicesReset()
        {
            if (isCameraRunning)
                captureDevice.Stop();

            if (pictureBox.Image != null)
            {
                pictureBox.Image = null;
            }

            isCameraRunning = false;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!isCameraRunning)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(18, 46, 118);
                btn.Font = new Font("Century Gothic", 16);
            } else
            {
                btn.Font = new Font("Century Gothic", 16);
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!isCameraRunning)
            {
                btn.BackColor = Color.FromArgb(199, 216, 231);
                btn.ForeColor = Color.FromArgb(18, 46, 118);
                btn.Font = new Font("Century Gothic", 14);
            } else
            {
                btn.Font = new Font("Century Gothic", 14);
            }
        }
    }
}
