
namespace GestionCommndesNaza.components
{
    partial class UserInfoCard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoCard));
            this.userCard = new Guna.UI.WinForms.GunaPanel();
            this.CardUserAvatarButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cardUserMessage = new Guna.UI.WinForms.GunaButton();
            this.cardUserName = new Guna.UI.WinForms.GunaTextBox();
            this.cardUserPhone = new Guna.UI.WinForms.GunaTextBox();
            this.cardUserRoleName = new Guna.UI.WinForms.GunaTextBox();
            this.userCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // userCard
            // 
            this.userCard.BackColor = System.Drawing.Color.White;
            this.userCard.Controls.Add(this.cardUserRoleName);
            this.userCard.Controls.Add(this.cardUserPhone);
            this.userCard.Controls.Add(this.cardUserName);
            this.userCard.Controls.Add(this.CardUserAvatarButton);
            this.userCard.Controls.Add(this.cardUserMessage);
            this.userCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCard.Location = new System.Drawing.Point(0, 0);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(208, 298);
            this.userCard.TabIndex = 0;
            // 
            // CardUserAvatarButton
            // 
            this.CardUserAvatarButton.BackColor = System.Drawing.Color.Transparent;
            this.CardUserAvatarButton.CheckedState.Parent = this.CardUserAvatarButton;
            this.CardUserAvatarButton.CustomImages.Parent = this.CardUserAvatarButton;
            this.CardUserAvatarButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.CardUserAvatarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CardUserAvatarButton.ForeColor = System.Drawing.Color.Transparent;
            this.CardUserAvatarButton.HoverState.Parent = this.CardUserAvatarButton;
            this.CardUserAvatarButton.Image = global::GestionCommndesNaza.Properties.Resources.Male_User_128px;
            this.CardUserAvatarButton.ImageSize = new System.Drawing.Size(70, 70);
            this.CardUserAvatarButton.Location = new System.Drawing.Point(45, 3);
            this.CardUserAvatarButton.Name = "CardUserAvatarButton";
            this.CardUserAvatarButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CardUserAvatarButton.ShadowDecoration.Parent = this.CardUserAvatarButton;
            this.CardUserAvatarButton.Size = new System.Drawing.Size(118, 118);
            this.CardUserAvatarButton.TabIndex = 8;
            // 
            // cardUserMessage
            // 
            this.cardUserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardUserMessage.AnimationHoverSpeed = 0.07F;
            this.cardUserMessage.AnimationSpeed = 0.03F;
            this.cardUserMessage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cardUserMessage.BorderColor = System.Drawing.Color.Black;
            this.cardUserMessage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cardUserMessage.FocusedColor = System.Drawing.Color.Empty;
            this.cardUserMessage.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.cardUserMessage.ForeColor = System.Drawing.Color.White;
            this.cardUserMessage.Image = ((System.Drawing.Image)(resources.GetObject("cardUserMessage.Image")));
            this.cardUserMessage.ImageSize = new System.Drawing.Size(0, 0);
            this.cardUserMessage.Location = new System.Drawing.Point(0, 262);
            this.cardUserMessage.Name = "cardUserMessage";
            this.cardUserMessage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cardUserMessage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cardUserMessage.OnHoverForeColor = System.Drawing.Color.White;
            this.cardUserMessage.OnHoverImage = null;
            this.cardUserMessage.OnPressedColor = System.Drawing.Color.Black;
            this.cardUserMessage.Size = new System.Drawing.Size(208, 36);
            this.cardUserMessage.TabIndex = 7;
            this.cardUserMessage.Text = "Message";
            this.cardUserMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardUserName
            // 
            this.cardUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cardUserName.BaseColor = System.Drawing.Color.White;
            this.cardUserName.BorderColor = System.Drawing.Color.Silver;
            this.cardUserName.BorderSize = 0;
            this.cardUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardUserName.Enabled = false;
            this.cardUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.cardUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cardUserName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardUserName.Location = new System.Drawing.Point(3, 136);
            this.cardUserName.Name = "cardUserName";
            this.cardUserName.PasswordChar = '\0';
            this.cardUserName.SelectedText = "";
            this.cardUserName.Size = new System.Drawing.Size(205, 32);
            this.cardUserName.TabIndex = 9;
            this.cardUserName.Text = "gunaTextBox1";
            this.cardUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardUserPhone
            // 
            this.cardUserPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cardUserPhone.BaseColor = System.Drawing.Color.White;
            this.cardUserPhone.BorderColor = System.Drawing.Color.Silver;
            this.cardUserPhone.BorderSize = 0;
            this.cardUserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardUserPhone.Enabled = false;
            this.cardUserPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.cardUserPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cardUserPhone.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardUserPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardUserPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardUserPhone.Location = new System.Drawing.Point(3, 175);
            this.cardUserPhone.Name = "cardUserPhone";
            this.cardUserPhone.PasswordChar = '\0';
            this.cardUserPhone.SelectedText = "";
            this.cardUserPhone.Size = new System.Drawing.Size(205, 32);
            this.cardUserPhone.TabIndex = 10;
            this.cardUserPhone.Text = "gunaTextBox1";
            this.cardUserPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardUserRoleName
            // 
            this.cardUserRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cardUserRoleName.BaseColor = System.Drawing.Color.White;
            this.cardUserRoleName.BorderColor = System.Drawing.Color.Silver;
            this.cardUserRoleName.BorderSize = 0;
            this.cardUserRoleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardUserRoleName.Enabled = false;
            this.cardUserRoleName.FocusedBaseColor = System.Drawing.Color.White;
            this.cardUserRoleName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cardUserRoleName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardUserRoleName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardUserRoleName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cardUserRoleName.Location = new System.Drawing.Point(3, 210);
            this.cardUserRoleName.Name = "cardUserRoleName";
            this.cardUserRoleName.PasswordChar = '\0';
            this.cardUserRoleName.SelectedText = "";
            this.cardUserRoleName.Size = new System.Drawing.Size(205, 32);
            this.cardUserRoleName.TabIndex = 11;
            this.cardUserRoleName.Text = "gunaTextBox1";
            this.cardUserRoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userCard);
            this.Name = "UserInfoCard";
            this.Size = new System.Drawing.Size(208, 298);
            this.userCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton cardUserMessage;
        public Guna.UI.WinForms.GunaPanel userCard;
        public Guna.UI2.WinForms.Guna2CircleButton CardUserAvatarButton;
        public Guna.UI.WinForms.GunaTextBox cardUserName;
        public Guna.UI.WinForms.GunaTextBox cardUserPhone;
        public Guna.UI.WinForms.GunaTextBox cardUserRoleName;
    }
}
