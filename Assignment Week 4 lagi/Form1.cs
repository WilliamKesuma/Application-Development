using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Week_4_lagi
{
    public partial class MainWindowForm : Form
    {

        public static MainWindowForm formInstance;
        public TextBox tbx;
        SecondWindowForm form2 = new SecondWindowForm();
        int random = 0;

        public MainWindowForm()
        {
            InitializeComponent();
            formInstance = this;
            tbx = TB_Name;
        }

        private void BTN_OpenNextForm_Click(object sender, EventArgs e)
        {
            form2.Show();
            random = 1;
            if (CB_AllContentTrue.Checked && random > 0)
            {
                BTN_Submit.Enabled = true;
            }
            else
            {
                BTN_Submit.Enabled = false;
            }
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TB_Name.Text) || string.IsNullOrEmpty(TB_Artist.Text))
            {
                MessageBox.Show("Text Box Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form2.Labelwthv = "Hi my name is " + TB_Name.Text + ", and my favorite artist is " + TB_Artist.Text + ".";
            }
        }

        private void CB_AllContentTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_AllContentTrue.Checked && random > 0)
            {
                BTN_Submit.Enabled = true;            
            }
            else
            { 
                BTN_Submit.Enabled = false; 
            }

        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
