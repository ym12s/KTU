namespace Khanq.View
{
    partial class UCLogin
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
            this.btnNo = new Khang.WinForms.KhangButton();
            this.khang = new Khang.WinForms.Khang(this.components);
            this.labelThongbao = new Khang.WinForms.KhangMessageDialog();
            this.checkToogle = new Khang.WinForms.KhangToggleSwitch();
            this.txtPass = new Khang.WinForms.KhangTextBox();
            this.txtUsers = new Khang.WinForms.KhangTextBox();
            this.btnLogin = new Khang.WinForms.KhangButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelLogin = new Khang.WinForms.KhangPanel();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Animated = true;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BorderColor = System.Drawing.Color.Transparent;
            this.btnNo.BorderRadius = 4;
            this.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNo.FillColor = System.Drawing.Color.Silver;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnNo.Location = new System.Drawing.Point(311, 16);
            this.btnNo.Name = "btnNo";
            this.btnNo.ShadowDecoration.BorderRadius = 8;
            this.btnNo.ShadowDecoration.Depth = 20;
            this.btnNo.Size = new System.Drawing.Size(30, 20);
            this.btnNo.TabIndex = 22;
            this.btnNo.Text = "X";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // khang
            // 
            this.khang.AnimateWindow = true;
            this.khang.BorderRadius = 15;
            this.khang.ContainerControl = this;
            this.khang.DockForm = false;
            this.khang.DockIndicatorTransparencyValue = 0.6D;
            this.khang.DragForm = false;
            this.khang.ResizeForm = false;
            this.khang.TransparentWhileDrag = true;
            // 
            // labelThongbao
            // 
            this.labelThongbao.Buttons = Khang.WinForms.MessageDialogButtons.OK;
            this.labelThongbao.Caption = null;
            this.labelThongbao.Icon = Khang.WinForms.MessageDialogIcon.Information;
            this.labelThongbao.Parent = this;
            this.labelThongbao.Style = Khang.WinForms.MessageDialogStyle.Dark;
            this.labelThongbao.Text = "Đăng nhập thành công";
            // 
            // checkToogle
            // 
            this.checkToogle.Animated = true;
            this.checkToogle.BackColor = System.Drawing.Color.Transparent;
            this.checkToogle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkToogle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkToogle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.checkToogle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.checkToogle.Location = new System.Drawing.Point(57, 287);
            this.checkToogle.Name = "checkToogle";
            this.checkToogle.ShadowDecoration.BorderRadius = 10;
            this.checkToogle.ShadowDecoration.Enabled = true;
            this.checkToogle.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.checkToogle.Size = new System.Drawing.Size(40, 20);
            this.checkToogle.TabIndex = 20;
            this.checkToogle.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkToogle.UncheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.checkToogle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.checkToogle.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // txtPass
            // 
            this.txtPass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPass.Animated = true;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BorderColor = System.Drawing.Color.White;
            this.txtPass.BorderRadius = 5;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(58, 218);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Enabled = true;
            this.txtPass.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPass.Size = new System.Drawing.Size(238, 37);
            this.txtPass.TabIndex = 19;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsers
            // 
            this.txtUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUsers.Animated = true;
            this.txtUsers.BackColor = System.Drawing.Color.Transparent;
            this.txtUsers.BorderColor = System.Drawing.Color.White;
            this.txtUsers.BorderRadius = 5;
            this.txtUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsers.DefaultText = "";
            this.txtUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsers.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsers.Location = new System.Drawing.Point(58, 153);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.PasswordChar = '\0';
            this.txtUsers.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsers.PlaceholderText = "Users";
            this.txtUsers.SelectedText = "";
            this.txtUsers.ShadowDecoration.Enabled = true;
            this.txtUsers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtUsers.Size = new System.Drawing.Size(238, 43);
            this.txtUsers.TabIndex = 18;
            this.txtUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(130, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 22;
            this.btnLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnLogin.Size = new System.Drawing.Size(110, 35);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLogin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lblLogin.Location = new System.Drawing.Point(83, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(122, 47);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "LOGIN";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Location = new System.Drawing.Point(38, 53);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.ShadowDecoration.Enabled = true;
            this.panelLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelLogin.Size = new System.Drawing.Size(279, 71);
            this.panelLogin.TabIndex = 21;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 398);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.checkToogle);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UCLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCLogin";
            this.TopMost = true;
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Khang.WinForms.KhangButton btnNo;
        private Khang.WinForms.Khang khang;
        private Khang.WinForms.KhangToggleSwitch checkToogle;
        private Khang.WinForms.KhangTextBox txtPass;
        private Khang.WinForms.KhangTextBox txtUsers;
        private Khang.WinForms.KhangButton btnLogin;
        private Khang.WinForms.KhangPanel panelLogin;
        private System.Windows.Forms.Label lblLogin;
        private Khang.WinForms.KhangMessageDialog labelThongbao;
    }
}