
namespace CreateScaffolding
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCSVinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScaffoldingCode = new System.Windows.Forms.TextBox();
            this.btnCreateFinalCode = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCSVinput
            // 
            this.txtCSVinput.Location = new System.Drawing.Point(12, 39);
            this.txtCSVinput.Multiline = true;
            this.txtCSVinput.Name = "txtCSVinput";
            this.txtCSVinput.Size = new System.Drawing.Size(776, 66);
            this.txtCSVinput.TabIndex = 0;
            this.txtCSVinput.Text = "1,2,3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV of column names to interate into the final code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scaffolding code with {0} as place holder for each column name:";
            // 
            // txtScaffoldingCode
            // 
            this.txtScaffoldingCode.Location = new System.Drawing.Point(15, 140);
            this.txtScaffoldingCode.Multiline = true;
            this.txtScaffoldingCode.Name = "txtScaffoldingCode";
            this.txtScaffoldingCode.Size = new System.Drawing.Size(773, 100);
            this.txtScaffoldingCode.TabIndex = 3;
            this.txtScaffoldingCode.Text = "line {0}\r\nnext line\r\n\r\n";
            // 
            // btnCreateFinalCode
            // 
            this.btnCreateFinalCode.Location = new System.Drawing.Point(315, 263);
            this.btnCreateFinalCode.Name = "btnCreateFinalCode";
            this.btnCreateFinalCode.Size = new System.Drawing.Size(187, 23);
            this.btnCreateFinalCode.TabIndex = 4;
            this.btnCreateFinalCode.Text = "Create Final Code";
            this.btnCreateFinalCode.UseVisualStyleBackColor = true;
            this.btnCreateFinalCode.Click += new System.EventHandler(this.btnCreateFinalCode_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 329);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(773, 204);
            this.txtResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final Useable Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCreateFinalCode);
            this.Controls.Add(this.txtScaffoldingCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCSVinput);
            this.Name = "Form1";
            this.Text = "Code Scaffolding Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCSVinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScaffoldingCode;
        private System.Windows.Forms.Button btnCreateFinalCode;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}

