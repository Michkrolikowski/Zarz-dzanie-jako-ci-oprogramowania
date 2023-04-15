
namespace Speed_Up_App
{
    partial class Menu
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
            if (disposing && ( components != null))
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
            this.button_flota = new System.Windows.Forms.Button();
            this.button_raporty = new System.Windows.Forms.Button();
            this.button_rezerwacje = new System.Windows.Forms.Button();
            this.button_zwrot = new System.Windows.Forms.Button();
            this.button_pomoc = new System.Windows.Forms.Button();
            this.button_cennik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_flota
            // 
            this.button_flota.Location = new System.Drawing.Point(40, 12);
            this.button_flota.Name = "button_flota";
            this.button_flota.Size = new System.Drawing.Size(323, 107);
            this.button_flota.TabIndex = 0;
            this.button_flota.Text = "Flota";
            this.button_flota.UseVisualStyleBackColor = true;
            this.button_flota.Click += new System.EventHandler(this.button_flota_Click);
            // 
            // button_raporty
            // 
            this.button_raporty.Location = new System.Drawing.Point(422, 12);
            this.button_raporty.Name = "button_raporty";
            this.button_raporty.Size = new System.Drawing.Size(340, 107);
            this.button_raporty.TabIndex = 1;
            this.button_raporty.Text = "Raporty";
            this.button_raporty.UseVisualStyleBackColor = true;
            this.button_raporty.Click += new System.EventHandler(this.button_raporty_Click);
            // 
            // button_rezerwacje
            // 
            this.button_rezerwacje.Location = new System.Drawing.Point(40, 159);
            this.button_rezerwacje.Name = "button_rezerwacje";
            this.button_rezerwacje.Size = new System.Drawing.Size(323, 104);
            this.button_rezerwacje.TabIndex = 2;
            this.button_rezerwacje.Text = "Rezerwacja";
            this.button_rezerwacje.UseVisualStyleBackColor = true;
            this.button_rezerwacje.Click += new System.EventHandler(this.button_rezerwacje_Click);
            // 
            // button_zwrot
            // 
            this.button_zwrot.Location = new System.Drawing.Point(422, 159);
            this.button_zwrot.Name = "button_zwrot";
            this.button_zwrot.Size = new System.Drawing.Size(340, 104);
            this.button_zwrot.TabIndex = 3;
            this.button_zwrot.Text = "Zwrot";
            this.button_zwrot.UseVisualStyleBackColor = true;
            this.button_zwrot.Click += new System.EventHandler(this.button_zwrot_Click);
            // 
            // button_pomoc
            // 
            this.button_pomoc.Location = new System.Drawing.Point(40, 305);
            this.button_pomoc.Name = "button_pomoc";
            this.button_pomoc.Size = new System.Drawing.Size(323, 94);
            this.button_pomoc.TabIndex = 4;
            this.button_pomoc.Text = "Pomoc";
            this.button_pomoc.UseVisualStyleBackColor = true;
            this.button_pomoc.Click += new System.EventHandler(this.button_pomoc_Click);
            // 
            // button_cennik
            // 
            this.button_cennik.Location = new System.Drawing.Point(422, 305);
            this.button_cennik.Name = "button_cennik";
            this.button_cennik.Size = new System.Drawing.Size(340, 94);
            this.button_cennik.TabIndex = 5;
            this.button_cennik.Text = "Cennik";
            this.button_cennik.UseVisualStyleBackColor = true;
            this.button_cennik.Click += new System.EventHandler(this.button_cennik_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.button_cennik);
            this.Controls.Add(this.button_pomoc);
            this.Controls.Add(this.button_zwrot);
            this.Controls.Add(this.button_rezerwacje);
            this.Controls.Add(this.button_raporty);
            this.Controls.Add(this.button_flota);
            this.Name = "Menu";
            this.Text = "menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_flota;
        private System.Windows.Forms.Button button_raporty;
        private System.Windows.Forms.Button button_rezerwacje;
        private System.Windows.Forms.Button button_zwrot;
        private System.Windows.Forms.Button button_pomoc;
        private System.Windows.Forms.Button button_cennik;
    }
}