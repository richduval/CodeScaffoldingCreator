
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
            this.cbReplaceBrackets = new System.Windows.Forms.CheckBox();
            this.txtScaffoldingCode2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.btnCreateSpecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCSVinput
            // 
            this.txtCSVinput.Location = new System.Drawing.Point(16, 48);
            this.txtCSVinput.Margin = new System.Windows.Forms.Padding(4);
            this.txtCSVinput.Multiline = true;
            this.txtCSVinput.Name = "txtCSVinput";
            this.txtCSVinput.Size = new System.Drawing.Size(1033, 80);
            this.txtCSVinput.TabIndex = 0;
            this.txtCSVinput.Text = "1,2,3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CSV of column names to interate into the final code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scaffolding code with {0} as place holder for each column name:";
            // 
            // txtScaffoldingCode
            // 
            this.txtScaffoldingCode.Location = new System.Drawing.Point(20, 172);
            this.txtScaffoldingCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtScaffoldingCode.Multiline = true;
            this.txtScaffoldingCode.Name = "txtScaffoldingCode";
            this.txtScaffoldingCode.Size = new System.Drawing.Size(1029, 84);
            this.txtScaffoldingCode.TabIndex = 3;
            this.txtScaffoldingCode.Text = "line {0}\r\nnext line\r\n\r\n";
            // 
            // btnCreateFinalCode
            // 
            this.btnCreateFinalCode.Location = new System.Drawing.Point(426, 403);
            this.btnCreateFinalCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFinalCode.Name = "btnCreateFinalCode";
            this.btnCreateFinalCode.Size = new System.Drawing.Size(249, 28);
            this.btnCreateFinalCode.TabIndex = 4;
            this.btnCreateFinalCode.Text = "Create Final Code";
            this.btnCreateFinalCode.UseVisualStyleBackColor = true;
            this.btnCreateFinalCode.Click += new System.EventHandler(this.btnCreateFinalCode_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(20, 460);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1029, 185);
            this.txtResult.TabIndex = 5;
            this.txtResult.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final Useable Code from Scaffolding code 1:";
            // 
            // cbReplaceBrackets
            // 
            this.cbReplaceBrackets.AutoSize = true;
            this.cbReplaceBrackets.Location = new System.Drawing.Point(32, 403);
            this.cbReplaceBrackets.Name = "cbReplaceBrackets";
            this.cbReplaceBrackets.Size = new System.Drawing.Size(141, 21);
            this.cbReplaceBrackets.TabIndex = 7;
            this.cbReplaceBrackets.Text = "Replace Brackets";
            this.cbReplaceBrackets.UseVisualStyleBackColor = true;
            // 
            // txtScaffoldingCode2
            // 
            this.txtScaffoldingCode2.Location = new System.Drawing.Point(20, 301);
            this.txtScaffoldingCode2.Margin = new System.Windows.Forms.Padding(4);
            this.txtScaffoldingCode2.Multiline = true;
            this.txtScaffoldingCode2.Name = "txtScaffoldingCode2";
            this.txtScaffoldingCode2.Size = new System.Drawing.Size(1029, 84);
            this.txtScaffoldingCode2.TabIndex = 8;
            this.txtScaffoldingCode2.Text = "                + \"    ,[{0}]\\n\"\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Scaffolding code 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 661);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Final Useable Code from Scaffolding Code 2:";
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(19, 681);
            this.txtResult2.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult2.Multiline = true;
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(1029, 185);
            this.txtResult2.TabIndex = 10;
            this.txtResult2.WordWrap = false;
            // 
            // btnCreateSpecial
            // 
            this.btnCreateSpecial.Location = new System.Drawing.Point(868, 402);
            this.btnCreateSpecial.Name = "btnCreateSpecial";
            this.btnCreateSpecial.Size = new System.Drawing.Size(147, 31);
            this.btnCreateSpecial.TabIndex = 12;
            this.btnCreateSpecial.Text = "Create Special";
            this.btnCreateSpecial.UseVisualStyleBackColor = true;
            this.btnCreateSpecial.Click += new System.EventHandler(this.btnCreateSpecial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 884);
            this.Controls.Add(this.btnCreateSpecial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScaffoldingCode2);
            this.Controls.Add(this.cbReplaceBrackets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCreateFinalCode);
            this.Controls.Add(this.txtScaffoldingCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCSVinput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Code Scaffolding Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
        private System.Windows.Forms.CheckBox cbReplaceBrackets;
        private System.Windows.Forms.TextBox txtScaffoldingCode2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.Button btnCreateSpecial;
    }
}

