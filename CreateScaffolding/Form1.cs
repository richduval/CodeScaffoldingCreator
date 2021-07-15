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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFinalCode_Click(object sender, EventArgs e)
        {
            try
            {
                var csvinput = txtCSVinput.Text.Split(',');
                var scaffoldingtemplate = txtScaffoldingCode.Text;
                string results = "";

                foreach(var item in csvinput)
                {
                    results += scaffoldingtemplate.Replace("{0}", item.Trim());
                }
                txtResult.Text = results;

                Debug.WriteLine("debug");
            }

            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
