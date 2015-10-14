namespace OutPanApiGet
{
    partial class FrmMain
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
            this.btnGet = new System.Windows.Forms.Button();
            this.btnSetCredentials = new System.Windows.Forms.Button();
            this.txtApiValue = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblEAN = new System.Windows.Forms.Label();
            this.txtEANNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRequestType = new System.Windows.Forms.ComboBox();
            this.rTxtOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(513, 77);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(110, 30);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Retreive Data";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnSetCredentials
            // 
            this.btnSetCredentials.Location = new System.Drawing.Point(513, 14);
            this.btnSetCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetCredentials.Name = "btnSetCredentials";
            this.btnSetCredentials.Size = new System.Drawing.Size(110, 30);
            this.btnSetCredentials.TabIndex = 1;
            this.btnSetCredentials.Text = "Set Credentials";
            this.btnSetCredentials.UseVisualStyleBackColor = true;
            this.btnSetCredentials.Click += new System.EventHandler(this.btnSetCredentials_Click);
            // 
            // txtApiValue
            // 
            this.txtApiValue.Location = new System.Drawing.Point(107, 18);
            this.txtApiValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApiValue.Name = "txtApiValue";
            this.txtApiValue.Size = new System.Drawing.Size(321, 25);
            this.txtApiValue.TabIndex = 2;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(14, 21);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(51, 17);
            this.lblApiKey.TabIndex = 3;
            this.lblApiKey.Text = "API Key";
            // 
            // lblEAN
            // 
            this.lblEAN.AutoSize = true;
            this.lblEAN.Location = new System.Drawing.Point(14, 53);
            this.lblEAN.Name = "lblEAN";
            this.lblEAN.Size = new System.Drawing.Size(67, 17);
            this.lblEAN.TabIndex = 4;
            this.lblEAN.Text = "GTIN/EAN";
            // 
            // txtEANNumber
            // 
            this.txtEANNumber.Location = new System.Drawing.Point(107, 50);
            this.txtEANNumber.Name = "txtEANNumber";
            this.txtEANNumber.Size = new System.Drawing.Size(321, 25);
            this.txtEANNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Request Type";
            // 
            // cboRequestType
            // 
            this.cboRequestType.FormattingEnabled = true;
            this.cboRequestType.Items.AddRange(new object[] {
            "All",
            "Attributes",
            "Images",
            "Name",
            "Videos"});
            this.cboRequestType.Location = new System.Drawing.Point(107, 81);
            this.cboRequestType.Name = "cboRequestType";
            this.cboRequestType.Size = new System.Drawing.Size(153, 25);
            this.cboRequestType.TabIndex = 7;
            // 
            // rTxtOutput
            // 
            this.rTxtOutput.Location = new System.Drawing.Point(107, 112);
            this.rTxtOutput.Name = "rTxtOutput";
            this.rTxtOutput.Size = new System.Drawing.Size(516, 198);
            this.rTxtOutput.TabIndex = 8;
            this.rTxtOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(14, 202);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 17);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 323);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rTxtOutput);
            this.Controls.Add(this.cboRequestType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEANNumber);
            this.Controls.Add(this.lblEAN);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.txtApiValue);
            this.Controls.Add(this.btnSetCredentials);
            this.Controls.Add(this.btnGet);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outpan Get";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnSetCredentials;
        private System.Windows.Forms.TextBox txtApiValue;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Label lblEAN;
        private System.Windows.Forms.TextBox txtEANNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRequestType;
        private System.Windows.Forms.RichTextBox rTxtOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

