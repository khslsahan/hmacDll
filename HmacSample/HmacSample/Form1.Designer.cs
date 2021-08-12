
namespace HmacSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateHMac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHexKey = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.lbTxtFile = new System.Windows.Forms.Label();
            this.txtGeneratedHmac = new System.Windows.Forms.TextBox();
            this.lbGenHMac = new System.Windows.Forms.Label();
            this.btnValidateHmac = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richtxtFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGenerateHMac
            // 
            this.btnGenerateHMac.Location = new System.Drawing.Point(210, 232);
            this.btnGenerateHMac.Name = "btnGenerateHMac";
            this.btnGenerateHMac.Size = new System.Drawing.Size(134, 23);
            this.btnGenerateHMac.TabIndex = 0;
            this.btnGenerateHMac.Text = "Generate HMAC";
            this.btnGenerateHMac.UseVisualStyleBackColor = true;
            this.btnGenerateHMac.Click += new System.EventHandler(this.bunGenerateHmacClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 23);
            this.textBox1.TabIndex = 1;
            // 
            // txtHexKey
            // 
            this.txtHexKey.Location = new System.Drawing.Point(131, 40);
            this.txtHexKey.Multiline = true;
            this.txtHexKey.Name = "txtHexKey";
            this.txtHexKey.Size = new System.Drawing.Size(295, 58);
            this.txtHexKey.TabIndex = 1;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(31, 59);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(49, 15);
            this.lbKey.TabIndex = 2;
            this.lbKey.Text = "Hex Key";
            // 
            // lbTxtFile
            // 
            this.lbTxtFile.AutoSize = true;
            this.lbTxtFile.Location = new System.Drawing.Point(31, 129);
            this.lbTxtFile.Name = "lbTxtFile";
            this.lbTxtFile.Size = new System.Drawing.Size(64, 15);
            this.lbTxtFile.TabIndex = 2;
            this.lbTxtFile.Text = "Config File";
            // 
            // txtGeneratedHmac
            // 
            this.txtGeneratedHmac.Location = new System.Drawing.Point(131, 277);
            this.txtGeneratedHmac.Multiline = true;
            this.txtGeneratedHmac.Name = "txtGeneratedHmac";
            this.txtGeneratedHmac.Size = new System.Drawing.Size(295, 58);
            this.txtGeneratedHmac.TabIndex = 1;
            // 
            // lbGenHMac
            // 
            this.lbGenHMac.AutoSize = true;
            this.lbGenHMac.Location = new System.Drawing.Point(31, 298);
            this.lbGenHMac.Name = "lbGenHMac";
            this.lbGenHMac.Size = new System.Drawing.Size(90, 15);
            this.lbGenHMac.TabIndex = 2;
            this.lbGenHMac.Text = "Generted HMac";
            // 
            // btnValidateHmac
            // 
            this.btnValidateHmac.Location = new System.Drawing.Point(210, 358);
            this.btnValidateHmac.Name = "btnValidateHmac";
            this.btnValidateHmac.Size = new System.Drawing.Size(134, 23);
            this.btnValidateHmac.TabIndex = 0;
            this.btnValidateHmac.Text = "Validate Hmac";
            this.btnValidateHmac.UseVisualStyleBackColor = true;
            this.btnValidateHmac.Click += new System.EventHandler(this.buttonValidateHmacClick);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(432, 178);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(72, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.buttonloadClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // richtxtFile
            // 
            this.richtxtFile.Location = new System.Drawing.Point(131, 105);
            this.richtxtFile.Name = "richtxtFile";
            this.richtxtFile.Size = new System.Drawing.Size(295, 96);
            this.richtxtFile.TabIndex = 3;
            this.richtxtFile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 476);
            this.Controls.Add(this.richtxtFile);
            this.Controls.Add(this.lbGenHMac);
            this.Controls.Add(this.lbTxtFile);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGeneratedHmac);
            this.Controls.Add(this.txtHexKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnValidateHmac);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnGenerateHMac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateHMac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtHexKey;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.Label lbTxtFile;
        private System.Windows.Forms.TextBox txtGeneratedHmac;
        private System.Windows.Forms.Label lbGenHMac;
        private System.Windows.Forms.Button btnValidateHmac;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox richtxtFile;
    }
}

