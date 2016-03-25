namespace TempSys.Forms
{
    partial class SystemForm
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
            this.sys_close = new MetroFramework.Controls.MetroLink();
            this.btn_setting = new MetroFramework.Controls.MetroLink();
            this.styMain = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.styMain)).BeginInit();
            this.SuspendLayout();
            // 
            // sys_close
            // 
            this.sys_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sys_close.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.sys_close.Image = global::TempSys.Properties.Resources.mainClose;
            this.sys_close.ImageSize = 32;
            this.sys_close.Location = new System.Drawing.Point(599, 10);
            this.sys_close.Name = "sys_close";
            this.sys_close.Size = new System.Drawing.Size(37, 40);
            this.sys_close.TabIndex = 1;
            this.sys_close.UseSelectable = true;
            this.sys_close.Click += new System.EventHandler(this.sys_close_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setting.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btn_setting.Image = global::TempSys.Properties.Resources.mainSet;
            this.btn_setting.ImageSize = 32;
            this.btn_setting.Location = new System.Drawing.Point(552, 10);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(37, 40);
            this.btn_setting.TabIndex = 0;
            this.btn_setting.UseSelectable = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // styMain
            // 
            this.styMain.Owner = this;
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 403);
            this.ControlBox = false;
            this.Controls.Add(this.sys_close);
            this.Controls.Add(this.btn_setting);
            this.Name = "SystemForm";
            ((System.ComponentModel.ISupportInitialize)(this.styMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink btn_setting;
        private MetroFramework.Controls.MetroLink sys_close;
        private MetroFramework.Components.MetroStyleManager styMain;
    }
}