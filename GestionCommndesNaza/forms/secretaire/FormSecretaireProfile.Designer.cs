
namespace GestionCommndesNaza.forms.secretaire
{
    partial class FormSecretaireProfile
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.userInformationsForm1 = new GestionCommndesNaza.components.UserInformationsForm();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dansboardCardMessages = new GestionCommndesNaza.components.DansboardCard();
            this.dansboardCardIOrderMonth = new GestionCommndesNaza.components.DansboardCard();
            this.dansboardCardOrder = new GestionCommndesNaza.components.DansboardCard();
            this.dansboardCardSlde = new GestionCommndesNaza.components.DansboardCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userInfoCard = new GestionCommndesNaza.components.UserInfoCard();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // userInformationsForm1
            // 
            this.userInformationsForm1.Fistanme = "";
            this.userInformationsForm1.Lastname = "";
            this.userInformationsForm1.Location = new System.Drawing.Point(237, 88);
            this.userInformationsForm1.Login = "";
            this.userInformationsForm1.Name = "userInformationsForm1";
            this.userInformationsForm1.Password = "";
            this.userInformationsForm1.Phone = "";
            this.userInformationsForm1.Size = new System.Drawing.Size(696, 311);
            this.userInformationsForm1.TabIndex = 1;
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
            this.guna2Panel1.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.userInformationsForm1);
            this.panel1.Controls.Add(this.userInfoCard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 606);
            this.panel1.TabIndex = 4;
            // 
            // userInfoCard
            // 
            this.userInfoCard.Location = new System.Drawing.Point(3, 88);
            this.userInfoCard.Name = "userInfoCard";
            this.userInfoCard.Size = new System.Drawing.Size(208, 311);
            this.userInfoCard.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 416);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(912, 178);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // FormSecretaireProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 606);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSecretaireProfile";
            this.Text = "FormSecretaireProfile";
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private components.UserInformationsForm userInformationsForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private components.DansboardCard dansboardCardMessages;
        private components.DansboardCard dansboardCardIOrderMonth;
        private components.DansboardCard dansboardCardOrder;
        private components.DansboardCard dansboardCardSlde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private components.UserInfoCard userInfoCard;
    }
}