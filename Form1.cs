using static System.Windows.Forms.DataFormats;

namespace PROCAP_CLIENT
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        private void buttonmodify_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            switch (comboBoxdp.SelectedIndex)
            {
                case 0: { Formchat formchat = new Formchat(); formchat.Show(); formchat.textBox1.Focus(); } break;
                case 1: { Formstitch formstitch = new Formstitch(); formstitch.Show(); formstitch.textBox1.Focus(); } break;
                case 2: { Formsole formsole = new Formsole(); formsole.Show(); formsole.textBox1.Focus(); } break;
                case 3: { Formassemble formassemble = new Formassemble();formassemble.Show();formassemble.textBox1.Focus(); } break;
                case 4: break;


            }
        }

        private void Formmain_Load(object sender, EventArgs e)
        {
            comboBoxdp.SelectedIndex = 0;
        }
    }
}