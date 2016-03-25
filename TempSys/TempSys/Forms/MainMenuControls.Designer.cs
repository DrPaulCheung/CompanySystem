namespace TempSys.Forms
{
    partial class MainMenuControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menus = new MetroFramework.Controls.MetroPanel();
            this.list_menus = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menus
            // 
            this.panel_menus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_menus.Controls.Add(this.list_menus);
            this.panel_menus.Controls.Add(this.pictureBox1);
            this.panel_menus.HorizontalScrollbarBarColor = true;
            this.panel_menus.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_menus.HorizontalScrollbarSize = 10;
            this.panel_menus.Location = new System.Drawing.Point(0, 0);
            this.panel_menus.Name = "panel_menus";
            this.panel_menus.Padding = new System.Windows.Forms.Padding(10, 60, 10, 0);
            this.panel_menus.Size = new System.Drawing.Size(172, 489);
            this.panel_menus.TabIndex = 0;
            this.panel_menus.VerticalScrollbarBarColor = true;
            this.panel_menus.VerticalScrollbarHighlightOnWheel = false;
            this.panel_menus.VerticalScrollbarSize = 10;
            // 
            // list_menus
            // 
            this.list_menus.BackColor = System.Drawing.SystemColors.Control;
            this.list_menus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_menus.HorizontalScrollbarBarColor = true;
            this.list_menus.HorizontalScrollbarHighlightOnWheel = false;
            this.list_menus.HorizontalScrollbarSize = 10;
            this.list_menus.Location = new System.Drawing.Point(10, 60);
            this.list_menus.Name = "list_menus";
            this.list_menus.Size = new System.Drawing.Size(152, 429);
            this.list_menus.TabIndex = 3;
            this.list_menus.VerticalScrollbarBarColor = true;
            this.list_menus.VerticalScrollbarHighlightOnWheel = false;
            this.list_menus.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TempSys.Properties.Resources.system_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.pictureBox1.Size = new System.Drawing.Size(172, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(167, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1, 489);
            this.panel1.TabIndex = 4;
            // 
            // MainMenuControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menus);
            this.Name = "MainMenuControls";
            this.Size = new System.Drawing.Size(646, 489);
            this.panel_menus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_menus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel list_menus;
        private System.Windows.Forms.Panel panel1;
    }
}
