using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCAP_CLIENT
{
    public partial class Formlean : Form
    {
        public Formlean()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy-MM-dd" + "產量");

        }

        private void Formlean_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radioButtonlean1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            bool[] boolarray = new bool[6];
            boolarray[0] = !radioButtonlean1.Checked;
            boolarray[1] = !radioButtonlean2.Checked;
            boolarray[2] = !radioButtonlean3.Checked;
            boolarray[3] = string.IsNullOrEmpty(textBoxchat.Text);
            boolarray[4] = string.IsNullOrEmpty(textBoxstitch.Text);
            boolarray[5] = string.IsNullOrEmpty(textBoxassemble.Text);
            bool result=true;
            for (int i = 0; i < boolarray.Length; i++)
            {
                result = (result || boolarray[i]);
            }
            if (result) 
            {
            
            
            }
        }
    }
}
