namespace _3DNUS.Core.Tour
{
    partial class dev_tour_setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dev_tour_setup));
            this.lbl_body = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.b_fin = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbl_sys_type = new MaterialSkin.Controls.MaterialLabel();
            this.old_3ds = new MaterialSkin.Controls.MaterialRadioButton();
            this.new_3ds = new MaterialSkin.Controls.MaterialRadioButton();
            this.chck_auto_upd = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_dump_info = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_auto_dump = new MaterialSkin.Controls.MaterialCheckBox();
            this.chck_darktheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // lbl_body
            // 
            this.lbl_body.BackColor = System.Drawing.Color.Transparent;
            this.lbl_body.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(0, 108);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(579, 58);
            this.lbl_body.TabIndex = 6;
            this.lbl_body.Text = "Go ahead and select what Features and Options you want enabled.";
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(579, 108);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Let\'s get things Setup:";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // b_fin
            // 
            this.b_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_fin.AutoSize = true;
            this.b_fin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_fin.BackColor = System.Drawing.Color.Transparent;
            this.b_fin.Depth = 0;
            this.b_fin.Icon = null;
            this.b_fin.Location = new System.Drawing.Point(513, 413);
            this.b_fin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_fin.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_fin.Name = "b_fin";
            this.b_fin.Primary = false;
            this.b_fin.Size = new System.Drawing.Size(64, 36);
            this.b_fin.TabIndex = 4;
            this.b_fin.Text = "finish";
            this.b_fin.UseVisualStyleBackColor = false;
            this.b_fin.Click += new System.EventHandler(this.b_fin_Click);
            // 
            // lbl_sys_type
            // 
            this.lbl_sys_type.AutoSize = true;
            this.lbl_sys_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sys_type.Depth = 0;
            this.lbl_sys_type.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_sys_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_sys_type.Location = new System.Drawing.Point(3, 302);
            this.lbl_sys_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_sys_type.Name = "lbl_sys_type";
            this.lbl_sys_type.Size = new System.Drawing.Size(120, 19);
            this.lbl_sys_type.TabIndex = 21;
            this.lbl_sys_type.Text = "Default Titlelist: ";
            // 
            // old_3ds
            // 
            this.old_3ds.AutoSize = true;
            this.old_3ds.BackColor = System.Drawing.Color.Transparent;
            this.old_3ds.Checked = true;
            this.old_3ds.Depth = 0;
            this.old_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.old_3ds.Location = new System.Drawing.Point(4, 361);
            this.old_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.old_3ds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.old_3ds.MouseState = MaterialSkin.MouseState.HOVER;
            this.old_3ds.Name = "old_3ds";
            this.old_3ds.Ripple = true;
            this.old_3ds.Size = new System.Drawing.Size(78, 30);
            this.old_3ds.TabIndex = 20;
            this.old_3ds.TabStop = true;
            this.old_3ds.Text = "Old 3DS";
            this.old_3ds.UseVisualStyleBackColor = false;
            // 
            // new_3ds
            // 
            this.new_3ds.AutoSize = true;
            this.new_3ds.BackColor = System.Drawing.Color.Transparent;
            this.new_3ds.Depth = 0;
            this.new_3ds.Font = new System.Drawing.Font("Roboto", 10F);
            this.new_3ds.Location = new System.Drawing.Point(4, 331);
            this.new_3ds.Margin = new System.Windows.Forms.Padding(0);
            this.new_3ds.MouseLocation = new System.Drawing.Point(-1, -1);
            this.new_3ds.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_3ds.Name = "new_3ds";
            this.new_3ds.Ripple = true;
            this.new_3ds.Size = new System.Drawing.Size(85, 30);
            this.new_3ds.TabIndex = 19;
            this.new_3ds.Text = "New 3DS";
            this.new_3ds.UseVisualStyleBackColor = false;
            // 
            // chck_auto_upd
            // 
            this.chck_auto_upd.AutoSize = true;
            this.chck_auto_upd.BackColor = System.Drawing.Color.Transparent;
            this.chck_auto_upd.Checked = true;
            this.chck_auto_upd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_auto_upd.Depth = 0;
            this.chck_auto_upd.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_auto_upd.Location = new System.Drawing.Point(5, 189);
            this.chck_auto_upd.Margin = new System.Windows.Forms.Padding(0);
            this.chck_auto_upd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_auto_upd.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_auto_upd.Name = "chck_auto_upd";
            this.chck_auto_upd.Ripple = true;
            this.chck_auto_upd.Size = new System.Drawing.Size(166, 30);
            this.chck_auto_upd.TabIndex = 18;
            this.chck_auto_upd.Text = "Enable Auto-Updates? ";
            this.chck_auto_upd.UseVisualStyleBackColor = false;
            // 
            // chck_dump_info
            // 
            this.chck_dump_info.AutoSize = true;
            this.chck_dump_info.BackColor = System.Drawing.Color.Transparent;
            this.chck_dump_info.Depth = 0;
            this.chck_dump_info.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_dump_info.Location = new System.Drawing.Point(5, 159);
            this.chck_dump_info.Margin = new System.Windows.Forms.Padding(0);
            this.chck_dump_info.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_dump_info.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_dump_info.Name = "chck_dump_info";
            this.chck_dump_info.Ripple = true;
            this.chck_dump_info.Size = new System.Drawing.Size(271, 30);
            this.chck_dump_info.TabIndex = 17;
            this.chck_dump_info.Text = "When dumping log, Dump System Info? ";
            this.chck_dump_info.UseVisualStyleBackColor = false;
            // 
            // chck_auto_dump
            // 
            this.chck_auto_dump.AutoSize = true;
            this.chck_auto_dump.BackColor = System.Drawing.Color.Transparent;
            this.chck_auto_dump.Depth = 0;
            this.chck_auto_dump.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_auto_dump.Location = new System.Drawing.Point(5, 249);
            this.chck_auto_dump.Margin = new System.Windows.Forms.Padding(0);
            this.chck_auto_dump.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_auto_dump.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_auto_dump.Name = "chck_auto_dump";
            this.chck_auto_dump.Ripple = true;
            this.chck_auto_dump.Size = new System.Drawing.Size(207, 30);
            this.chck_auto_dump.TabIndex = 23;
            this.chck_auto_dump.Text = "Automatically Dump the log?";
            this.chck_auto_dump.UseVisualStyleBackColor = false;
            // 
            // chck_darktheme
            // 
            this.chck_darktheme.AutoSize = true;
            this.chck_darktheme.BackColor = System.Drawing.Color.Transparent;
            this.chck_darktheme.Depth = 0;
            this.chck_darktheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.chck_darktheme.Location = new System.Drawing.Point(5, 219);
            this.chck_darktheme.Margin = new System.Windows.Forms.Padding(0);
            this.chck_darktheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chck_darktheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.chck_darktheme.Name = "chck_darktheme";
            this.chck_darktheme.Ripple = true;
            this.chck_darktheme.Size = new System.Drawing.Size(157, 30);
            this.chck_darktheme.TabIndex = 22;
            this.chck_darktheme.Text = "Use the Dark theme?";
            this.chck_darktheme.UseVisualStyleBackColor = false;
            // 
            // dev_tour_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 451);
            this.ControlBox = false;
            this.Controls.Add(this.chck_auto_dump);
            this.Controls.Add(this.chck_darktheme);
            this.Controls.Add(this.lbl_sys_type);
            this.Controls.Add(this.old_3ds);
            this.Controls.Add(this.new_3ds);
            this.Controls.Add(this.chck_auto_upd);
            this.Controls.Add(this.chck_dump_info);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.b_fin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dev_tour_setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DNUS: Tour";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Label lbl_title;
        private MaterialSkin.Controls.MaterialFlatButton b_fin;
        private MaterialSkin.Controls.MaterialLabel lbl_sys_type;
        private MaterialSkin.Controls.MaterialRadioButton old_3ds;
        private MaterialSkin.Controls.MaterialRadioButton new_3ds;
        private MaterialSkin.Controls.MaterialCheckBox chck_auto_upd;
        private MaterialSkin.Controls.MaterialCheckBox chck_dump_info;
        private MaterialSkin.Controls.MaterialCheckBox chck_auto_dump;
        private MaterialSkin.Controls.MaterialCheckBox chck_darktheme;
    }
}