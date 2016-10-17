namespace Demo_Add
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRslt = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(78, 189);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(116, 29);
            this.Addbtn.TabIndex = 13;
            this.Addbtn.Text = "Result";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // txtRslt
            // 
            this.txtRslt.Location = new System.Drawing.Point(130, 142);
            this.txtRslt.Name = "txtRslt";
            this.txtRslt.Size = new System.Drawing.Size(112, 22);
            this.txtRslt.TabIndex = 9;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(130, 96);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(112, 22);
            this.txtNum2.TabIndex = 8;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(130, 37);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(112, 22);
            this.txtNum1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRslt);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRslt;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}

