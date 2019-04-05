namespace DespatchBay_DE
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripAccountIDLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripBalanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAvailableBalanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despatchBayCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importOrdersCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_for_SenderAddress = new System.Windows.Forms.Label();
            this.SenderAddress = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_SenderEmail = new System.Windows.Forms.TextBox();
            this.txt_SenderTelephone = new System.Windows.Forms.TextBox();
            this.txt_SenderName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_forSenderEmail = new System.Windows.Forms.Label();
            this.lbl_forSenderTel = new System.Windows.Forms.Label();
            this.lbl_forSenderName = new System.Windows.Forms.Label();
            this.senderAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAccountIDLabel,
            this.toolStripBalanceLabel,
            this.toolStripAvailableBalanceLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripAccountIDLabel
            // 
            this.toolStripAccountIDLabel.Name = "toolStripAccountIDLabel";
            this.toolStripAccountIDLabel.Size = new System.Drawing.Size(69, 17);
            this.toolStripAccountIDLabel.Text = "Account ID:";
            // 
            // toolStripBalanceLabel
            // 
            this.toolStripBalanceLabel.Name = "toolStripBalanceLabel";
            this.toolStripBalanceLabel.Size = new System.Drawing.Size(51, 17);
            this.toolStripBalanceLabel.Text = "Balance:";
            // 
            // toolStripAvailableBalanceLabel
            // 
            this.toolStripAvailableBalanceLabel.Name = "toolStripAvailableBalanceLabel";
            this.toolStripAvailableBalanceLabel.Size = new System.Drawing.Size(102, 17);
            this.toolStripAvailableBalanceLabel.Text = "Available Balance:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.addOnsToolStripMenuItem,
            this.elpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despatchBayCredentialsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // despatchBayCredentialsToolStripMenuItem
            // 
            this.despatchBayCredentialsToolStripMenuItem.Name = "despatchBayCredentialsToolStripMenuItem";
            this.despatchBayCredentialsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.despatchBayCredentialsToolStripMenuItem.Text = "Despatch Bay Credentials";
            this.despatchBayCredentialsToolStripMenuItem.Click += new System.EventHandler(this.despatchBayCredentialsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importOrdersCSVToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // importOrdersCSVToolStripMenuItem
            // 
            this.importOrdersCSVToolStripMenuItem.Name = "importOrdersCSVToolStripMenuItem";
            this.importOrdersCSVToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.importOrdersCSVToolStripMenuItem.Text = "Import Orders CSV";
            // 
            // addOnsToolStripMenuItem
            // 
            this.addOnsToolStripMenuItem.Name = "addOnsToolStripMenuItem";
            this.addOnsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.addOnsToolStripMenuItem.Text = "Add Ons";
            // 
            // elpToolStripMenuItem
            // 
            this.elpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.elpToolStripMenuItem.Name = "elpToolStripMenuItem";
            this.elpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.elpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lbl_for_SenderAddress
            // 
            this.lbl_for_SenderAddress.AutoSize = true;
            this.lbl_for_SenderAddress.Location = new System.Drawing.Point(6, 22);
            this.lbl_for_SenderAddress.Name = "lbl_for_SenderAddress";
            this.lbl_for_SenderAddress.Size = new System.Drawing.Size(94, 13);
            this.lbl_for_SenderAddress.TabIndex = 3;
            this.lbl_for_SenderAddress.Text = "Collection Address";
            // 
            // SenderAddress
            // 
            this.SenderAddress.FormattingEnabled = true;
            this.SenderAddress.Location = new System.Drawing.Point(106, 19);
            this.SenderAddress.Name = "SenderAddress";
            this.SenderAddress.Size = new System.Drawing.Size(121, 21);
            this.SenderAddress.TabIndex = 4;
            this.SenderAddress.SelectedIndexChanged += new System.EventHandler(this.SenderAddress_SelectedIndexChanged);
            this.SenderAddress.Click += new System.EventHandler(this.SenderAddress_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txt_SenderEmail);
            this.groupBox1.Controls.Add(this.txt_SenderTelephone);
            this.groupBox1.Controls.Add(this.txt_SenderName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_forSenderEmail);
            this.groupBox1.Controls.Add(this.lbl_forSenderTel);
            this.groupBox1.Controls.Add(this.lbl_forSenderName);
            this.groupBox1.Controls.Add(this.SenderAddress);
            this.groupBox1.Controls.Add(this.lbl_for_SenderAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 13;
            // 
            // txt_SenderEmail
            // 
            this.txt_SenderEmail.Location = new System.Drawing.Point(106, 99);
            this.txt_SenderEmail.Name = "txt_SenderEmail";
            this.txt_SenderEmail.Size = new System.Drawing.Size(167, 20);
            this.txt_SenderEmail.TabIndex = 12;
            // 
            // txt_SenderTelephone
            // 
            this.txt_SenderTelephone.Location = new System.Drawing.Point(106, 73);
            this.txt_SenderTelephone.Name = "txt_SenderTelephone";
            this.txt_SenderTelephone.Size = new System.Drawing.Size(167, 20);
            this.txt_SenderTelephone.TabIndex = 11;
            // 
            // txt_SenderName
            // 
            this.txt_SenderName.Location = new System.Drawing.Point(106, 46);
            this.txt_SenderName.Name = "txt_SenderName";
            this.txt_SenderName.Size = new System.Drawing.Size(167, 20);
            this.txt_SenderName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // lbl_forSenderEmail
            // 
            this.lbl_forSenderEmail.AutoSize = true;
            this.lbl_forSenderEmail.Location = new System.Drawing.Point(31, 102);
            this.lbl_forSenderEmail.Name = "lbl_forSenderEmail";
            this.lbl_forSenderEmail.Size = new System.Drawing.Size(69, 13);
            this.lbl_forSenderEmail.TabIndex = 7;
            this.lbl_forSenderEmail.Text = "Sender Email";
            // 
            // lbl_forSenderTel
            // 
            this.lbl_forSenderTel.AutoSize = true;
            this.lbl_forSenderTel.Location = new System.Drawing.Point(5, 76);
            this.lbl_forSenderTel.Name = "lbl_forSenderTel";
            this.lbl_forSenderTel.Size = new System.Drawing.Size(95, 13);
            this.lbl_forSenderTel.TabIndex = 6;
            this.lbl_forSenderTel.Text = "Sender Telephone";
            // 
            // lbl_forSenderName
            // 
            this.lbl_forSenderName.AutoSize = true;
            this.lbl_forSenderName.Location = new System.Drawing.Point(28, 49);
            this.lbl_forSenderName.Name = "lbl_forSenderName";
            this.lbl_forSenderName.Size = new System.Drawing.Size(72, 13);
            this.lbl_forSenderName.TabIndex = 5;
            this.lbl_forSenderName.Text = "Sender Name";
            // 
            // senderAddressBindingSource
            // 
            this.senderAddressBindingSource.DataSource = typeof(DespatchBay_DE.SenderAddress);
            // 
            // addressServiceBindingSource
            // 
            this.addressServiceBindingSource.DataSource = typeof(DespatchBay_DE.AddressService);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressServiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAccountIDLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripBalanceLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAvailableBalanceLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despatchBayCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importOrdersCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_for_SenderAddress;
        private System.Windows.Forms.ComboBox SenderAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource senderAddressBindingSource;
        private System.Windows.Forms.BindingSource addressServiceBindingSource;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_SenderEmail;
        private System.Windows.Forms.TextBox txt_SenderTelephone;
        private System.Windows.Forms.TextBox txt_SenderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_forSenderEmail;
        private System.Windows.Forms.Label lbl_forSenderTel;
        private System.Windows.Forms.Label lbl_forSenderName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

