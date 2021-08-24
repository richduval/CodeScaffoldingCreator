using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateScaffolding
{
    public partial class Form1 : Form
    {
        private int frmmargin = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFinalCode_Click(object sender, EventArgs e)
        {
            try
            {
                var txtcsvinput = txtCSVinput.Text;
                if (cbReplaceBrackets.Checked)
                {
                    txtcsvinput = txtcsvinput.Replace("[", "").Replace("]", "");
                }

                var csvinput = txtcsvinput.Split(',');
                var scaffoldingtemplate = txtScaffoldingCode.Text;
                var scaffoldingtemplate2 = txtScaffoldingCode2.Text;
                string results = "";
                string results2 = "";

                foreach (var item in csvinput)
                {
                    results += scaffoldingtemplate.Replace("{0}", item.Trim());
                    results2 += scaffoldingtemplate2.Replace("{0}", item.Trim());
                }
                txtResult.Text = results;
                txtResult2.Text = results2;

                //Debug.WriteLine("debug");
            }

            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeTextBoxes(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resizeTextBoxes(sender);
        }

        private void resizeTextBoxes(object sender)
        {
            Control frmcontrol = (Control)sender;
            var newwidth = frmcontrol.Width - frmmargin;
            txtCSVinput.Width = newwidth;
            txtScaffoldingCode.Width = newwidth;
            txtScaffoldingCode2.Width = newwidth;
            txtResult.Width = newwidth;
            txtResult2.Width = newwidth;
        }
    }
}
