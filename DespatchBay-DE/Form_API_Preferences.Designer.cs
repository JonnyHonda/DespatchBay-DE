namespace DespatchBay_DE
{
    partial class Form_API_Preferences
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
            this.lbl_forApiUser = new System.Windows.Forms.Label();
            this.lbl_forApiKey = new System.Windows.Forms.Label();
            this.txt_ApiUser = new System.Windows.Forms.TextBox();
            this.txt_ApiKey = new System.Windows.Forms.TextBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_forApiUser
            // 
            this.lbl_forApiUser.AutoSize = true;
            this.lbl_forApiUser.Location = new System.Drawing.Point(9, 22);
            this.lbl_forApiUser.Name = "lbl_forApiUser";
            this.lbl_forApiUser.Size = new System.Drawing.Size(49, 13);
            this.lbl_forApiUser.TabIndex = 0;
            this.lbl_forApiUser.Text = "API User";
            // 
            // lbl_forApiKey
            // 
            this.lbl_forApiKey.AutoSize = true;
            this.lbl_forApiKey.Location = new System.Drawing.Point(9, 50);
            this.lbl_forApiKey.Name = "lbl_forApiKey";
            this.lbl_forApiKey.Size = new System.Drawing.Size(45, 13);
            this.lbl_forApiKey.TabIndex = 1;
            this.lbl_forApiKey.Text = "API Key";
            // 
            // txt_ApiUser
            // 
            this.txt_ApiUser.Location = new System.Drawing.Point(64, 19);
            this.txt_ApiUser.Name = "txt_ApiUser";
            this.txt_ApiUser.Size = new System.Drawing.Size(163, 20);
            this.txt_ApiUser.TabIndex = 2;
            // 
            // txt_ApiKey
            // 
            this.txt_ApiKey.Location = new System.Drawing.Point(64, 47);
            this.txt_ApiKey.Name = "txt_ApiKey";
            this.txt_ApiKey.Size = new System.Drawing.Size(163, 20);
            this.txt_ApiKey.TabIndex = 3;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(64, 73);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 4;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(152, 73);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ApiUser);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_forApiUser);
            this.groupBox1.Controls.Add(this.btn_Test);
            this.groupBox1.Controls.Add(this.lbl_forApiKey);
            this.groupBox1.Controls.Add(this.txt_ApiKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(121, 130);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form_API_Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 179);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_API_Preferences";
            this.Text = "API Preferences";
            this.Load += new System.EventHandler(this.Form_API_Preferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_forApiUser;
        private System.Windows.Forms.Label lbl_forApiKey;
        private System.Windows.Forms.TextBox txt_ApiUser;
        private System.Windows.Forms.TextBox txt_ApiKey;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
    }
}