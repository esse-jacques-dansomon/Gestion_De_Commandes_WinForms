
namespace GestionCommndesNaza.forms.security
{
    partial class FormRegister
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateNewAccount = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.labelFirstaname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textFristanme = new Guna.UI.WinForms.GunaTextBox();
            this.textLastanme = new Guna.UI.WinForms.GunaTextBox();
            this.textPhone = new Guna.UI.WinForms.GunaTextBox();
            this.textPassword = new Guna.UI.WinForms.GunaTextBox();
            this.textConfirmedPassword = new Guna.UI.WinForms.GunaTextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonClearFileds = new System.Windows.Forms.Button();
            this.textLogin = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(124, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "SIGN IN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(85, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Have You A Account ?";
            // 
            // buttonCreateNewAccount
            // 
            this.buttonCreateNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonCreateNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNewAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateNewAccount.Location = new System.Drawing.Point(28, 452);
            this.buttonCreateNewAccount.Name = "buttonCreateNewAccount";
            this.buttonCreateNewAccount.Size = new System.Drawing.Size(260, 35);
            this.buttonCreateNewAccount.TabIndex = 16;
            this.buttonCreateNewAccount.Text = "CREATE AN  ACCOUNT";
            this.buttonCreateNewAccount.UseVisualStyleBackColor = false;
            this.buttonCreateNewAccount.Click += new System.EventHandler(this.buttonCreateNewAccount_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(168, 417);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(120, 17);
            this.checkBoxShowPassword.TabIndex = 15;
            this.checkBoxShowPassword.Text = "Show Pawword";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textLabel.Location = new System.Drawing.Point(28, 353);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(139, 13);
            this.textLabel.TabIndex = 13;
            this.textLabel.Text = "Confirmed Password";
            // 
            // labelFirstaname
            // 
            this.labelFirstaname.AutoSize = true;
            this.labelFirstaname.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelFirstaname.Location = new System.Drawing.Point(27, 50);
            this.labelFirstaname.Name = "labelFirstaname";
            this.labelFirstaname.Size = new System.Drawing.Size(102, 13);
            this.labelFirstaname.TabIndex = 11;
            this.labelFirstaname.Text = "Your Fistname";
            this.labelFirstaname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(98, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(28, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(27, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Your Lastname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(26, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Your phone";
            // 
            // textFristanme
            // 
            this.textFristanme.BackColor = System.Drawing.Color.Gainsboro;
            this.textFristanme.BaseColor = System.Drawing.Color.Gainsboro;
            this.textFristanme.BorderColor = System.Drawing.Color.Silver;
            this.textFristanme.BorderSize = 0;
            this.textFristanme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFristanme.FocusedBaseColor = System.Drawing.Color.Silver;
            this.textFristanme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textFristanme.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textFristanme.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFristanme.ForeColor = System.Drawing.Color.Black;
            this.textFristanme.Location = new System.Drawing.Point(28, 71);
            this.textFristanme.Name = "textFristanme";
            this.textFristanme.PasswordChar = '\0';
            this.textFristanme.SelectedText = "";
            this.textFristanme.Size = new System.Drawing.Size(259, 30);
            this.textFristanme.TabIndex = 25;
            // 
            // textLastanme
            // 
            this.textLastanme.BackColor = System.Drawing.Color.Gainsboro;
            this.textLastanme.BaseColor = System.Drawing.Color.Gainsboro;
            this.textLastanme.BorderColor = System.Drawing.Color.Silver;
            this.textLastanme.BorderSize = 0;
            this.textLastanme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLastanme.FocusedBaseColor = System.Drawing.Color.Silver;
            this.textLastanme.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textLastanme.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textLastanme.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastanme.ForeColor = System.Drawing.Color.Black;
            this.textLastanme.Location = new System.Drawing.Point(28, 130);
            this.textLastanme.Name = "textLastanme";
            this.textLastanme.PasswordChar = '\0';
            this.textLastanme.SelectedText = "";
            this.textLastanme.Size = new System.Drawing.Size(259, 30);
            this.textLastanme.TabIndex = 26;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.textPhone.BaseColor = System.Drawing.Color.Gainsboro;
            this.textPhone.BorderColor = System.Drawing.Color.Silver;
            this.textPhone.BorderSize = 0;
            this.textPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhone.FocusedBaseColor = System.Drawing.Color.Silver;
            this.textPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textPhone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.ForeColor = System.Drawing.Color.Black;
            this.textPhone.Location = new System.Drawing.Point(28, 250);
            this.textPhone.Name = "textPhone";
            this.textPhone.PasswordChar = '\0';
            this.textPhone.SelectedText = "";
            this.textPhone.Size = new System.Drawing.Size(259, 30);
            this.textPhone.TabIndex = 27;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textPassword.BaseColor = System.Drawing.Color.Gainsboro;
            this.textPassword.BorderColor = System.Drawing.Color.Silver;
            this.textPassword.BorderSize = 0;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.FocusedBaseColor = System.Drawing.Color.Silver;
            this.textPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Black;
            this.textPassword.Location = new System.Drawing.Point(28, 311);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(259, 30);
            this.textPassword.TabIndex = 28;
            // 
            // textConfirmedPassword
            // 
            this.textConfirmedPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textConfirmedPassword.BaseColor = System.Drawing.Color.Gainsboro;
            this.textConfirmedPassword.BorderColor = System.Drawing.Color.Silver;
            this.textConfirmedPassword.BorderSize = 0;
            this.textConfirmedPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textConfirmedPassword.FocusedBaseColor = System.Drawing.Color.Silver;
            this.textConfirmedPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textConfirmedPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textConfirmedPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmedPassword.ForeColor = System.Drawing.Color.Black;
            this.textConfirmedPassword.Location = new System.Drawing.Point(28, 376);
            this.textConfirmedPassword.Name = "textConfirmedPassword";
            this.textConfirmedPassword.PasswordChar = '*';
            this.textConfirmedPassword.SelectedText = "";
            this.textConfirmedPassword.Size = new System.Drawing.Size(259, 30);
            this.textConfirmedPassword.TabIndex = 29;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(281, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 25);
            this.guna2ControlBox1.TabIndex = 30;
            // 
            // buttonClearFileds
            // 
            this.buttonClearFileds.BackColor = System.Drawing.Color.White;
            this.buttonClearFileds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFileds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonClearFileds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFileds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClearFileds.Location = new System.Drawing.Point(29, 504);
            this.buttonClearFileds.Name = "buttonClearFileds";
            this.buttonClearFileds.Size = new System.Drawing.Size(258, 35);
            this.buttonClearFileds.TabIndex = 31;
            this.buttonClearFileds.Text = "CLEAR";
            this.buttonClearFileds.UseVisualStyleBackColor = false;
            this.buttonClearFileds.Click += new System.EventHandler(this.buttonClearFileds_Click);
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.textLogin.BaseColor = System.Drawing.Color.Gainsboro;
            this.textLogin.BorderColor = System.Drawing.Color.Silver;
            this.textLogin.BorderSize = 0;
            this.textLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLogin.FocusedBaseColor = System.Drawing.Color.Silver;
            this.textLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.ForeColor = System.Drawing.Color.Black;
            this.textLogin.Location = new System.Drawing.Point(28, 192);
            this.textLogin.Name = "textLogin";
            this.textLogin.PasswordChar = '\0';
            this.textLogin.SelectedText = "";
            this.textLogin.Size = new System.Drawing.Size(259, 30);
            this.textLogin.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(27, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Your Login";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 612);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearFileds);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.textConfirmedPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textLastanme);
            this.Controls.Add(this.textFristanme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateNewAccount);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.labelFirstaname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateNewAccount;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label labelFirstaname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox textFristanme;
        private Guna.UI.WinForms.GunaTextBox textLastanme;
        private Guna.UI.WinForms.GunaTextBox textPhone;
        private Guna.UI.WinForms.GunaTextBox textPassword;
        private Guna.UI.WinForms.GunaTextBox textConfirmedPassword;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button buttonClearFileds;
        private Guna.UI.WinForms.GunaTextBox textLogin;
        private System.Windows.Forms.Label label2;
    }
}