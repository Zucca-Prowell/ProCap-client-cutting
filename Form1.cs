

using Npgsql;
using Npgsql.Internal;
using System.Data;
using System.Data.SqlTypes;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;

namespace Client
{

    public partial class Form1 : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataAdapter adp;
        DataSet dat;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;//�q�{���Combox�����Ĥ@�ӿﶵ

        }
        private void Form1_load(object sender, EventArgs e)
        {
            DataGridViewDataLoad();
        }
        private void DataGridViewDataLoad()
        {
            string sql1 = "select * from Prowell";
            adp = new NpgsqlDataAdapter(sql1, conn);
            dat = new DataSet();
            adp.Fill(dat);
            dataGridView1.DataSource = dat.Tables[0];

        }
        public void adddata()
        {
            InitializeComponent();
        }
        public void adddata_load(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
        
            form2.Show();
            form2.textBox1.Focus();
            //�q�{�k�q
           
            
        }
    
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            /*
             * ��combox�̭����W�r�P�ƾڮw�̭����W�r�۹����ADatagrid��ܥX���@�檺�H��
             * */
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("�O�_�R����H���H", "�R��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                /*
                 * �R��DB�����ƾڡA�襤�@�ӧR�����
                 * */
            }
        }
    }

}