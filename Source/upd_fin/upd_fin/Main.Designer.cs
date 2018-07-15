namespace upd_fin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tmr_failure = new System.Windows.Forms.Timer(this.components);
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_main.BackgroundImage")));
            this.pnl_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_main.Controls.Add(this.lbl_status);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(400, 300);
            this.pnl_main.TabIndex = 0;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(0, 277);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(400, 23);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "%stat%";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_failure
            // 
            this.tmr_failure.Interval = 5500;
            this.tmr_failure.Tick += new System.EventHandler(this.tmr_failure_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::upd_fin.Properties.Resources.Splash_new_with_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Updating ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer tmr_failure;
    }
}