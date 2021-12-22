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

        private void btnCreateSpecial_Click(object sender, EventArgs e)
        {
            var txtcsvinput = txtCSVinput.Text;
            var csvinput = txtcsvinput.Split(',');

            var scaffoldingtemplate2 = txtScaffoldingCode2.Text;
            string results2 = "";

            foreach (var litem in csvinput)
            {
                string item = litem.Trim();

                // revisionID AS VV_revisionID
                if (item.ToLower().Contains(" as "))
                {
                    
                    var startofAS = item.ToLower().IndexOf(" as ");
                    int itemlength = startofAS;
                    if(itemlength < 0) { itemlength = 0; }

                    var oldtablecolumnname = item.Substring(0, itemlength);
                    var newtablecolumnname = String.Concat("[", oldtablecolumnname.Replace("_", " "), "]");
                    var results = String.Concat(newtablecolumnname, item.Substring(startofAS, item.Length - itemlength));
                    //var results = item.Replace(oldtablecolumnname, newtablecolumnname);

                    results2 += scaffoldingtemplate2.Replace("{0}", results);
                }
                else
                {
                    results2 += scaffoldingtemplate2.Replace("{0}", item);
                }

                
            }
            
            
            txtResult2.Text = results2;
        }
    }
}
