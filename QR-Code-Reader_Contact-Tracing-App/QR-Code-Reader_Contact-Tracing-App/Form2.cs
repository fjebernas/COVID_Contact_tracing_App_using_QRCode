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
using ZXing;

namespace QR_Code_Reader_Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        string[] infos = new string[7];
        string[] nameParts = new string[2];
        string name, FN, SN;

        public Form2(Result result)
        {
            InitializeComponent();

            infos = (result.ToString()).Split('-');

            txtBxName.Text = " " + infos[0];
            txtBxAge.Text = " " + infos[1];
            txtBxAddress.Text = " " + infos[2];
            txtBxGender.Text = infos[3];
            txtBxContactNo.Text = " " + infos[4];
            txtBxQuesOne.Text = " " + infos[5];
            txtBxQuesTwo.Text = " " + infos[6];
            txtBxQuesThree.Text = " " + infos[7];

            nameParts = SplitFullNameIntoNameAndSurname(txtBxName.Text);
            FN = nameParts[0];
            SN = nameParts[1];
            nameParts[0] = nameParts[0].Replace(" ", "-");
            nameParts[1] = nameParts[1].ToUpper();
            name = nameParts[1] + "_" + nameParts[0];

            labelName.Text = FN + "'s";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelHeader;

            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            labelDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            timer.Stop();

            StreamWriter dataTxt;

            //dataTxt = File.CreateText(@"C:\Users\franc\Desktop\" + name + ".txt");
            dataTxt = File.CreateText(@"C:\Users\franc\source\repos\Assign#10QRCodeContactTracingApp\QR-Code-Reader_Contact-Tracing-App\QR-Code-Reader_Contact-Tracing-App\user-records\" + name + ".txt");

            dataTxt.WriteLine("---------------Contact Tracing using QR Code---------------" + "\n\n\n" +
                              "Time submitted: " + DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm:ss tt") + "\n\n" +
                              "USER'S DETAILS:" + "\n\n" +
                              "First name: " + FN + "\n" +
                              "Last name: " + SN + "\n" +
                              "Age: " + txtBxAge.Text + "\n" +
                              "Address: " + txtBxAddress.Text + "\n" +
                              "Gender: " + txtBxGender.Text + "\n" +
                              "Contact no.: " + txtBxContactNo.Text + "\n\n" +
                              "USER'S ANSWERS:" + "\n\n" +
                              "1. Have you traveled outside the country anytime from last month until now?\n" +
                              "Answer:" + txtBxQuesOne.Text + "\n" +
                              "2. Have you come into contact with anyone who has traveled outside your country between the period of last month until now?\n" +
                              "Answer:" + txtBxQuesTwo.Text + "\n" +
                              "3. Health conditions or flu-like symptoms: (e.g. fever, cough, breathing difficulty, etc.)\n" +
                              "Answer:" + txtBxQuesThree.Text + "\n"
                              ) ;
            dataTxt.Close();

            MessageBox.Show("Submitted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StartOver();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            timer.Stop();
            
            MessageBox.Show("Not Submitted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Text = "";
            }

            StartOver();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            labelDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }

        void StartOver()
        {
            Array.Clear(infos, 0, infos.Length);

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = "";
            }

            this.Close();
        }

        public static string[] SplitFullNameIntoNameAndSurname(string pFullName)
        {
            string[] NameSurname = new string[2];
            string[] NameSurnameTemp = pFullName.Split(' ');
            for (int i = 0; i < NameSurnameTemp.Length; i++)
            {
                if (i < NameSurnameTemp.Length - 1)
                {
                    if (!string.IsNullOrEmpty(NameSurname[0]))
                        NameSurname[0] += " " + NameSurnameTemp[i];
                    else
                        NameSurname[0] += NameSurnameTemp[i];
                }
                else
                    NameSurname[1] = NameSurnameTemp[i];
            }
            return NameSurname;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Font = new Font("Century Gothic", 13);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Font = new Font("Century Gothic", 12);
        }
    }
}
