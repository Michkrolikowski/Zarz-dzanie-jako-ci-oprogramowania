
namespace Speed_Up_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.login_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpeedUp";
            // 
            // password_TB
            // 
            this.password_TB.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_TB.Location = new System.Drawing.Point(275, 215);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(240, 33);
            this.password_TB.TabIndex = 1;
            this.password_TB.Text = "Podas numer pracownika";
            this.password_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_BTN
            // 
            this.login_BTN.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_BTN.Location = new System.Drawing.Point(275, 291);
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.Size = new System.Drawing.Size(240, 60);
            this.login_BTN.TabIndex = 2;
            this.login_BTN.Text = "Zaakceptuj";
            this.login_BTN.UseVisualStyleBackColor = true;
            this.login_BTN.Click += new System.EventHandler(this.login_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(769, 424);
            this.Controls.Add(this.login_BTN);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Button login_BTN;
    }
}

