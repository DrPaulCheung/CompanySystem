namespace TempSys
{
    partial class MemberForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_employee = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.checkbox_showquit = new MetroFramework.Controls.MetroCheckBox();
            this.btn_edit = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_export = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.btn_addMember = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_findMember = new MetroFramework.Controls.MetroButton();
            this.text_serarch = new MetroFramework.Controls.MetroTextBox();
            this.grid_members = new MetroFramework.Controls.MetroGrid();
            this.coloum_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloum_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.printout = new System.Drawing.Printing.PrintDocument();
            this.tab_employee.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_members)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_employee
            // 
            this.tab_employee.Controls.Add(this.metroTabPage1);
            this.tab_employee.Controls.Add(this.metroTabPage2);
            this.tab_employee.Location = new System.Drawing.Point(23, 63);
            this.tab_employee.Name = "tab_employee";
            this.tab_employee.SelectedIndex = 0;
            this.tab_employee.Size = new System.Drawing.Size(912, 530);
            this.tab_employee.TabIndex = 0;
            this.tab_employee.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.checkbox_showquit);
            this.metroTabPage1.Controls.Add(this.btn_edit);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.btn_export);
            this.metroTabPage1.Controls.Add(this.btn_print);
            this.metroTabPage1.Controls.Add(this.btn_addMember);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.btn_findMember);
            this.metroTabPage1.Controls.Add(this.text_serarch);
            this.metroTabPage1.Controls.Add(this.grid_members);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(904, 488);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "全部职员";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // checkbox_showquit
            // 
            this.checkbox_showquit.AutoSize = true;
            this.checkbox_showquit.Checked = true;
            this.checkbox_showquit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_showquit.Location = new System.Drawing.Point(280, 406);
            this.checkbox_showquit.Name = "checkbox_showquit";
            this.checkbox_showquit.Size = new System.Drawing.Size(107, 15);
            this.checkbox_showquit.TabIndex = 11;
            this.checkbox_showquit.Text = "显示已离职员工";
            this.checkbox_showquit.UseSelectable = true;
            this.checkbox_showquit.CheckedChanged += new System.EventHandler(this.checkbox_showquit_CheckedChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(519, 398);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(92, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "编辑查看信息";
            this.btn_edit.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(399, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 25);
            this.label2.TabIndex = 9;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(746, 398);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(92, 23);
            this.btn_export.TabIndex = 8;
            this.btn_export.Text = "导出Excel表格";
            this.btn_export.UseSelectable = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(639, 398);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(92, 23);
            this.btn_print.TabIndex = 7;
            this.btn_print.Text = "打印";
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_addMember
            // 
            this.btn_addMember.Location = new System.Drawing.Point(415, 398);
            this.btn_addMember.Name = "btn_addMember";
            this.btn_addMember.Size = new System.Drawing.Size(92, 23);
            this.btn_addMember.TabIndex = 6;
            this.btn_addMember.Text = "添加新员工";
            this.btn_addMember.UseSelectable = true;
            this.btn_addMember.Click += new System.EventHandler(this.btn_addMember_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(622, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 25);
            this.label1.TabIndex = 5;
            // 
            // btn_findMember
            // 
            this.btn_findMember.Location = new System.Drawing.Point(179, 399);
            this.btn_findMember.Name = "btn_findMember";
            this.btn_findMember.Size = new System.Drawing.Size(92, 23);
            this.btn_findMember.TabIndex = 4;
            this.btn_findMember.Text = "查找员工";
            this.btn_findMember.UseSelectable = true;
            this.btn_findMember.Click += new System.EventHandler(this.btn_findMember_Click);
            // 
            // text_serarch
            // 
            // 
            // 
            // 
            this.text_serarch.CustomButton.Image = null;
            this.text_serarch.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.text_serarch.CustomButton.Name = "";
            this.text_serarch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_serarch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_serarch.CustomButton.TabIndex = 1;
            this.text_serarch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_serarch.CustomButton.UseSelectable = true;
            this.text_serarch.CustomButton.Visible = false;
            this.text_serarch.Lines = new string[0];
            this.text_serarch.Location = new System.Drawing.Point(25, 399);
            this.text_serarch.MaxLength = 32767;
            this.text_serarch.Name = "text_serarch";
            this.text_serarch.PasswordChar = '\0';
            this.text_serarch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_serarch.SelectedText = "";
            this.text_serarch.SelectionLength = 0;
            this.text_serarch.SelectionStart = 0;
            this.text_serarch.Size = new System.Drawing.Size(148, 23);
            this.text_serarch.TabIndex = 3;
            this.text_serarch.UseSelectable = true;
            this.text_serarch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_serarch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grid_members
            // 
            this.grid_members.AllowUserToAddRows = false;
            this.grid_members.AllowUserToResizeRows = false;
            this.grid_members.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_members.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_members.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_members.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coloum_name,
            this.coloum_sex,
            this.coloum_address,
            this.coloum_id,
            this.coloum_phone,
            this.coloum_email,
            this.coloum_job,
            this.coloum_state});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_members.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_members.EnableHeadersVisualStyles = false;
            this.grid_members.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_members.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_members.Location = new System.Drawing.Point(0, 6);
            this.grid_members.Name = "grid_members";
            this.grid_members.ReadOnly = true;
            this.grid_members.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_members.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_members.RowHeadersWidth = 45;
            this.grid_members.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_members.RowTemplate.Height = 23;
            this.grid_members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_members.Size = new System.Drawing.Size(901, 356);
            this.grid_members.TabIndex = 2;
            // 
            // coloum_name
            // 
            this.coloum_name.HeaderText = "姓名";
            this.coloum_name.Name = "coloum_name";
            this.coloum_name.ReadOnly = true;
            // 
            // coloum_sex
            // 
            this.coloum_sex.HeaderText = "性别";
            this.coloum_sex.Name = "coloum_sex";
            this.coloum_sex.ReadOnly = true;
            this.coloum_sex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // coloum_address
            // 
            this.coloum_address.HeaderText = "地址";
            this.coloum_address.Name = "coloum_address";
            this.coloum_address.ReadOnly = true;
            // 
            // coloum_id
            // 
            this.coloum_id.HeaderText = "身份证号";
            this.coloum_id.Name = "coloum_id";
            this.coloum_id.ReadOnly = true;
            // 
            // coloum_phone
            // 
            this.coloum_phone.HeaderText = "手机号码";
            this.coloum_phone.Name = "coloum_phone";
            this.coloum_phone.ReadOnly = true;
            // 
            // coloum_email
            // 
            this.coloum_email.HeaderText = "邮箱";
            this.coloum_email.Name = "coloum_email";
            this.coloum_email.ReadOnly = true;
            // 
            // coloum_job
            // 
            this.coloum_job.HeaderText = "岗位";
            this.coloum_job.Name = "coloum_job";
            this.coloum_job.ReadOnly = true;
            // 
            // coloum_state
            // 
            this.coloum_state.HeaderText = "状态";
            this.coloum_state.Name = "coloum_state";
            this.coloum_state.ReadOnly = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(904, 488);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "招聘管理";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 2;
            this.ClientSize = new System.Drawing.Size(964, 600);
            this.Controls.Add(this.tab_employee);
            this.DoubleBuffered = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "人事管理";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.tab_employee.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_members)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_employee;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid grid_members;
        private MetroFramework.Controls.MetroTextBox text_serarch;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroButton btn_findMember;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_addMember;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btn_export;
        private System.Drawing.Printing.PrintDocument printout;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_job;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloum_state;
        private MetroFramework.Controls.MetroButton btn_edit;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox checkbox_showquit;

    }
}