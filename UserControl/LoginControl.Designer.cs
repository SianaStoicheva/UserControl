namespace UserControlApp
{
    partial class LoginControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUser = new System.Windows.Forms.Label();
            txtUser = new System.Windows.Forms.TextBox();
            lblPass = new System.Windows.Forms.Label();
            txtPass = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            SuspendLayout();
            // lblUser
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(10, 17);
            lblUser.Name = "lblUser";
            lblUser.Text = "Потребител:";
            // txtUser
            txtUser.Location = new System.Drawing.Point(105, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(190, 23);
            txtUser.TabIndex = 0;
            // lblPass
            lblPass.AutoSize = true;
            lblPass.Location = new System.Drawing.Point(10, 52);
            lblPass.Name = "lblPass";
            lblPass.Text = "Парола:";
            // txtPass
            txtPass.Location = new System.Drawing.Point(105, 47);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(190, 23);
            txtPass.UseSystemPasswordChar = true;
            txtPass.TabIndex = 1;
            // btnLogin
            btnLogin.Location = new System.Drawing.Point(105, 83);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(100, 28);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // lblResult
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(105, 125);
            lblResult.Name = "lblResult";
            lblResult.Text = "";
            // LoginControl
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            Controls.Add(lblResult);
            Name = "LoginControl";
            Size = new System.Drawing.Size(330, 160);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
