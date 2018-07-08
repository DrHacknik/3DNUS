namespace _3DNUS_Material_Edition
{
    partial class FmLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLoad));
            this.splash_timer = new System.Windows.Forms.Timer(this.components);
            this.tmr_get_upd_stat = new System.Windows.Forms.Timer(this.components);
            this.lbl_status = new System.Windows.Forms.Label();
            this.pic_splash_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_timer
            // 
            this.splash_timer.Interval = 4000;
            this.splash_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_get_upd_stat
            // 
            this.tmr_get_upd_stat.Interval = 10;
            this.tmr_get_upd_stat.Tick += new System.EventHandler(this.tmr_get_upd_stat_Tick);
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
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Preparing Config...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_splash_logo
            // 
            this.pic_splash_logo.BackColor = System.Drawing.Color.Transparent;
            this.pic_splash_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_splash_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_splash_logo.Image = global::_3DNUS_Material_Edition.Properties.Resources.new_3dnus_logo_128;
            this.pic_splash_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_splash_logo.Name = "pic_splash_logo";
            this.pic_splash_logo.Size = new System.Drawing.Size(400, 300);
            this.pic_splash_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_splash_logo.TabIndex = 1;
            this.pic_splash_logo.TabStop = false;
            // 
            // FmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_3DNUS_Material_Edition.Properties.Resources.Splash_new_with_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pic_splash_logo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmLoad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_load";
            this.Load += new System.EventHandler(this.main_load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_splash_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer splash_timer;
        private System.Windows.Forms.Timer tmr_get_upd_stat;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.PictureBox pic_splash_logo;
    }
}