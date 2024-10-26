namespace AdminWebHaiSan
{
    partial class Dang_Nhap
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
            this.login1 = new Log_in.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.login1.Location = new System.Drawing.Point(3, 1);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(620, 371);
            this.login1.TabIndex = 0;
            // 
            // Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(622, 369);
            this.Controls.Add(this.login1);
            this.Name = "Dang_Nhap";
            this.Text = "Dang_Nhap";
            this.ResumeLayout(false);

        }

        #endregion

        private Log_in.Login login1;
    }
}