
namespace Speed_Up_App
{
    partial class Raporty
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
            this.btn_menuraporty = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptPesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptLicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_menuraporty
            // 
            this.btn_menuraporty.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_menuraporty.Location = new System.Drawing.Point(305, 423);
            this.btn_menuraporty.Name = "btn_menuraporty";
            this.btn_menuraporty.Size = new System.Drawing.Size(173, 74);
            this.btn_menuraporty.TabIndex = 4;
            this.btn_menuraporty.Text = "MENU";
            this.btn_menuraporty.UseVisualStyleBackColor = true;
            this.btn_menuraporty.Click += new System.EventHandler(this.btn_menuraporty_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rptName,
            this.rptAddress,
            this.rptCity,
            this.rptPesel,
            this.rptLicenseNumber,
            this.rptFrom,
            this.rptTo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(759, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rptVehicle,
            this.rptDamage});
            this.dataGridView2.Location = new System.Drawing.Point(12, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(759, 155);
            this.dataGridView2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rezerwacje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uszkodzenia";
            // 
            // rptName
            // 
            this.rptName.HeaderText = "Imię Nazwisko";
            this.rptName.Name = "rptName";
            // 
            // rptAddress
            // 
            this.rptAddress.HeaderText = "Adres";
            this.rptAddress.Name = "rptAddress";
            // 
            // rptCity
            // 
            this.rptCity.HeaderText = "Miasto";
            this.rptCity.Name = "rptCity";
            // 
            // rptPesel
            // 
            this.rptPesel.HeaderText = "PESEL";
            this.rptPesel.Name = "rptPesel";
            // 
            // rptLicenseNumber
            // 
            this.rptLicenseNumber.HeaderText = "Nr prawa jazdy";
            this.rptLicenseNumber.Name = "rptLicenseNumber";
            // 
            // rptFrom
            // 
            this.rptFrom.HeaderText = "Od";
            this.rptFrom.Name = "rptFrom";
            // 
            // rptTo
            // 
            this.rptTo.HeaderText = "Do";
            this.rptTo.Name = "rptTo";
            // 
            // rptVehicle
            // 
            this.rptVehicle.HeaderText = "Pojazd";
            this.rptVehicle.Name = "rptVehicle";
            // 
            // rptDamage
            // 
            this.rptDamage.HeaderText = "Opis uszkodzenia";
            this.rptDamage.Name = "rptDamage";
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_menuraporty);
            this.Name = "Raporty";
            this.Text = "Raporty";
            this.Load += new System.EventHandler(this.Raporty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_menuraporty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptPesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptLicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn rptDamage;
    }
}