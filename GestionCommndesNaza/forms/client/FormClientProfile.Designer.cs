
namespace GestionCommndesNaza.forms.client
{
    partial class FormClientProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridViewAddresses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressForm = new GestionCommndesNaza.components.AdressForm();
            this.userInformationsForm1 = new GestionCommndesNaza.components.UserInformationsForm();
            this.userInfoCard = new GestionCommndesNaza.components.UserInfoCard();
            this.dansboardCardMessages = new GestionCommndesNaza.components.DansboardCard();
            this.dansboardCardIOrderMonth = new GestionCommndesNaza.components.DansboardCard();
            this.dansboardCardOrder = new GestionCommndesNaza.components.DansboardCard();
            this.dansboardCardSlde = new GestionCommndesNaza.components.DansboardCard();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.dansboardCardMessages);
            this.guna2Panel1.Controls.Add(this.dansboardCardIOrderMonth);
            this.guna2Panel1.Controls.Add(this.dansboardCardOrder);
            this.guna2Panel1.Controls.Add(this.dansboardCardSlde);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(936, 66);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.adressForm);
            this.panel1.Controls.Add(this.userInformationsForm1);
            this.panel1.Controls.Add(this.userInfoCard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 540);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.DataGridViewAddresses);
            this.panel2.Location = new System.Drawing.Point(472, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 200);
            this.panel2.TabIndex = 3;
            // 
            // DataGridViewAddresses
            // 
            this.DataGridViewAddresses.AllowUserToAddRows = false;
            this.DataGridViewAddresses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddresses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAddresses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridViewAddresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAddresses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewAddresses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAddresses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAddresses.ColumnHeadersHeight = 30;
            this.DataGridViewAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.VILLE,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAddresses.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAddresses.EnableHeadersVisualStyles = false;
            this.DataGridViewAddresses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAddresses.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewAddresses.Name = "DataGridViewAddresses";
            this.DataGridViewAddresses.ReadOnly = true;
            this.DataGridViewAddresses.RowHeadersVisible = false;
            this.DataGridViewAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAddresses.Size = new System.Drawing.Size(452, 200);
            this.DataGridViewAddresses.TabIndex = 4;
            this.DataGridViewAddresses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewAddresses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddresses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewAddresses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewAddresses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewAddresses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewAddresses.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridViewAddresses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAddresses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewAddresses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewAddresses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewAddresses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewAddresses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewAddresses.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridViewAddresses.ThemeStyle.ReadOnly = true;
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewAddresses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewAddresses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAddresses_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Zone";
            this.Column1.HeaderText = "ZONE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VILLE
            // 
            this.VILLE.DataPropertyName = "City";
            this.VILLE.HeaderText = "VILLE";
            this.VILLE.Name = "VILLE";
            this.VILLE.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Country";
            this.Column2.HeaderText = "PAYS";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PostCode";
            this.Column3.HeaderText = "ZIP CODE ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // adressForm
            // 
            this.adressForm.Location = new System.Drawing.Point(10, 332);
            this.adressForm.Name = "adressForm";
            this.adressForm.Size = new System.Drawing.Size(452, 200);
            this.adressForm.TabIndex = 2;
            // 
            // userInformationsForm1
            // 
            this.userInformationsForm1.Fistanme = "";
            this.userInformationsForm1.Lastname = "";
            this.userInformationsForm1.Location = new System.Drawing.Point(228, 12);
            this.userInformationsForm1.Login = "";
            this.userInformationsForm1.Name = "userInformationsForm1";
            this.userInformationsForm1.Password = "";
            this.userInformationsForm1.Phone = "";
            this.userInformationsForm1.Size = new System.Drawing.Size(696, 310);
            this.userInformationsForm1.TabIndex = 1;
            // 
            // userInfoCard
            // 
            this.userInfoCard.Location = new System.Drawing.Point(8, 11);
            this.userInfoCard.Name = "userInfoCard";
            this.userInfoCard.Size = new System.Drawing.Size(208, 311);
            this.userInfoCard.TabIndex = 0;
            // 
            // dansboardCardMessages
            // 
            this.dansboardCardMessages.Location = new System.Drawing.Point(706, 10);
            this.dansboardCardMessages.Name = "dansboardCardMessages";
            this.dansboardCardMessages.Size = new System.Drawing.Size(207, 47);
            this.dansboardCardMessages.TabIndex = 4;
            // 
            // dansboardCardIOrderMonth
            // 
            this.dansboardCardIOrderMonth.Location = new System.Drawing.Point(472, 10);
            this.dansboardCardIOrderMonth.Name = "dansboardCardIOrderMonth";
            this.dansboardCardIOrderMonth.Size = new System.Drawing.Size(207, 47);
            this.dansboardCardIOrderMonth.TabIndex = 3;
            // 
            // dansboardCardOrder
            // 
            this.dansboardCardOrder.Location = new System.Drawing.Point(239, 10);
            this.dansboardCardOrder.Name = "dansboardCardOrder";
            this.dansboardCardOrder.Size = new System.Drawing.Size(207, 47);
            this.dansboardCardOrder.TabIndex = 2;
            // 
            // dansboardCardSlde
            // 
            this.dansboardCardSlde.Location = new System.Drawing.Point(16, 10);
            this.dansboardCardSlde.Name = "dansboardCardSlde";
            this.dansboardCardSlde.Size = new System.Drawing.Size(207, 47);
            this.dansboardCardSlde.TabIndex = 1;
            // 
            // FormClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(936, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientProfile";
            this.Text = "FormClientProfile";
            this.Load += new System.EventHandler(this.FormClientProfile_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAddresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private components.UserInfoCard userInfoCard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private components.DansboardCard dansboardCardMessages;
        private components.DansboardCard dansboardCardIOrderMonth;
        private components.DansboardCard dansboardCardOrder;
        private components.DansboardCard dansboardCardSlde;
        private components.UserInformationsForm userInformationsForm1;
        private components.AdressForm adressForm;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}