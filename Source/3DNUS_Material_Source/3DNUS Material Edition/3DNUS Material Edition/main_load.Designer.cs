namespace _3DNUS_Material_Edition
{
    partial class main_load
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
            this.components = new System.ComponentModel.Container();
            this.dev_status = new System.Windows.Forms.Label();
            this.splash_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dev_status
            // 
            this.dev_status.AutoSize = true;
            this.dev_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dev_status.Location = new System.Drawing.Point(-1, 278);
            this.dev_status.Name = "dev_status";
            this.dev_status.Size = new System.Drawing.Size(104, 13);
            this.dev_status.TabIndex = 0;
            this.dev_status.Text = "Preparing Config...";
            // 
            // splash_timer
            // 
            this.splash_timer.Enabled = true;
            this.splash_timer.Interval = 1500;
            this.splash_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_3DNUS_Material_Edition.Properties.Resources.vyV7NzW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.dev_status);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_load";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_load";
            this.Load += new System.EventHandler(this.main_load_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dev_status;
        private System.Windows.Forms.Timer splash_timer;
    }
}