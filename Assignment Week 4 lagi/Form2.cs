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
    public partial class SecondWindowForm : Form
    {
        public MainWindowForm form1;

        public string Labelwthv
        {
            get
            {
                return this.LB_Answer.Text;
            }
            set
            {
                this.LB_Answer.Text = value;
            }
        }
        public SecondWindowForm()
        {
            InitializeComponent();
        }

        private void SecondWindowForm_Load(object sender, EventArgs e)
        {

        }

        private void CB_Terms_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Terms.Checked == true)
            {
                BTN_Magic.Enabled = true;
            }
            else
            {
                BTN_Magic.Enabled = false;
            }
        }

        private void BTN_Magic_Click(object sender, EventArgs e)
        {
            if (RB_Blue.Checked || RB_Red.Checked || RB_Yellow.Checked || RB_Green.Checked || RB_Purple.Checked) 
            { 
                if(RB_Orange.Checked || RB_Pink.Checked || RB_Beige.Checked)
                {
                    if (RB_Blue.Checked)
                    {
                        MainWindowForm.formInstance.BackColor = Color.Blue;
                    }                
                    else if(RB_Red.Checked)
                    {
                        MainWindowForm.formInstance.BackColor = Color.Red;
                    }
                    else if (RB_Yellow.Checked)
                    {
                        MainWindowForm.formInstance.BackColor = Color.Yellow;
                    }
                    else if (RB_Green.Checked)
                    {
                        MainWindowForm.formInstance.BackColor = Color.Green;
                    }
                    else if (RB_Purple.Checked)
                    {
                        MainWindowForm.formInstance.BackColor = Color.Purple;
                    }
                    if (RB_Orange.Checked)
                    {
                        MainWindowForm.formInstance.ForeColor = Color.Orange;
                    }
                    else if (RB_Pink.Checked)
                    {
                        MainWindowForm.formInstance.ForeColor = Color.Pink;
                    }
                    else if (RB_Beige.Checked)
                    {
                        MainWindowForm.formInstance.ForeColor = Color.Beige;
                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
                }
            }
            else
            {
                MessageBox.Show("Please Select A Color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void CB_Choices_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_Terms.Checked && CB_Choices.Checked) 
            {
                BTN_Magic.Enabled = true;
            }
            else
            {
                BTN_Magic.Enabled = false;
            }
        }
    }
}
