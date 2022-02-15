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
    public partial class Form2 : Form
    {
        public Form2(Result result)
        {
            InitializeComponent();

            string[] infos = (result.ToString()).Split('-');

            //labelHeader.Text = "";

            txtBxName.Text = infos[0];
            txtBxAge.Text = infos[1];
            txtBxAddress.Text = infos[2];
            txtBxGender.Text = infos[3];
            txtBxQuesOne.Text = infos[4];
            txtBxQuesTwo.Text = infos[5];
            txtBxQuesThree.Text = infos[6];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
