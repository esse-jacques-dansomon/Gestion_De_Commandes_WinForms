
namespace GestionCommndesNaza.forms.security
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.buttonClearFileds = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCreateAnewAccount = new System.Windows.Forms.Label();
            this.labelLogin = new Guna.UI.WinForms.GunaTextBox();
            this.labelPassword = new Guna.UI.WinForms.GunaTextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO NAZA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username or Login";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textLabel.Location = new System.Drawing.Point(30, 216);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(66, 17);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Password";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(144, 278);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(120, 21);
            this.checkBoxShowPassword.TabIndex = 5;
            this.checkBoxShowPassword.Text = "Show Pawword";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.shopPassword);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(36, 325);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(225, 35);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOGIN IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // buttonClearFileds
            // 
            this.buttonClearFileds.BackColor = System.Drawing.Color.White;
            this.buttonClearFileds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFileds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonClearFileds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFileds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClearFileds.Location = new System.Drawing.Point(37, 382);
            this.buttonClearFileds.Name = "buttonClearFileds";
            this.buttonClearFileds.Size = new System.Drawing.Size(225, 35);
            this.buttonClearFileds.TabIndex = 7;
            this.buttonClearFileds.Text = "CLEAR";
            this.buttonClearFileds.UseVisualStyleBackColor = false;
            this.buttonClearFileds.Click += new System.EventHandler(this.buttonClearFileds_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(73, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Have You Not A Account ?";
            // 
            // labelCreateAnewAccount
            // 
            this.labelCreateAnewAccount.AutoSize = true;
            this.labelCreateAnewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateAnewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCreateAnewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelCreateAnewAccount.Location = new System.Drawing.Point(110, 471);
            this.labelCreateAnewAccount.Name = "labelCreateAnewAccount";
            this.labelCreateAnewAccount.Size = new System.Drawing.Size(85, 17);
            this.labelCreateAnewAccount.TabIndex = 9;
            this.labelCreateAnewAccount.Text = "CREATE ONE";
            this.labelCreateAnewAccount.Click += new System.EventHandler(this.labelCreateAnewAccount_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.labelLogin.BaseColor = System.Drawing.Color.Gainsboro;
            this.labelLogin.BorderColor = System.Drawing.Color.Silver;
            this.labelLogin.BorderSize = 0;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelLogin.FocusedBaseColor = System.Drawing.Color.Silver;
            this.labelLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.labelLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.Location = new System.Drawing.Point(31, 161);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.PasswordChar = '\0';
            this.labelLogin.SelectedText = "";
            this.labelLogin.Size = new System.Drawing.Size(230, 30);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "comptable@gmail.com";
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.BaseColor = System.Drawing.Color.Gainsboro;
            this.labelPassword.BorderColor = System.Drawing.Color.Silver;
            this.labelPassword.BorderSize = 0;
            this.labelPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelPassword.FocusedBaseColor = System.Drawing.Color.DarkGray;
            this.labelPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.labelPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPassword.Location = new System.Drawing.Point(34, 239);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.PasswordChar = '*';
            this.labelPassword.SelectedText = "";
            this.labelPassword.Size = new System.Drawing.Size(230, 30);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "passer@123";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(263, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 25);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Maroon;
            this.labelErrors.Location = new System.Drawing.Point(38, 104);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(214, 17);
            this.labelErrors.TabIndex = 15;
            this.labelErrors.Text = "Login ou mot de passe incorrecte";
            this.labelErrors.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 544);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelCreateAnewAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClearFileds);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button buttonClearFileds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCreateAnewAccount;
        private Guna.UI.WinForms.GunaTextBox labelLogin;
        private Guna.UI.WinForms.GunaTextBox labelPassword;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label labelErrors;
    }
}