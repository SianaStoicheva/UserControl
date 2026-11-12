
namespace UserControlApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private UserControlApp.LoginControl loginControl1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.loginControl1 = new UserControlApp.LoginControl();
            this.SuspendLayout();

            // loginControl1
            this.loginControl1.Location = new System.Drawing.Point(35, 35);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(330, 160);
            this.loginControl1.TabIndex = 0;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.loginControl1);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControl - Вход";

            this.ResumeLayout(false);
        }
    }
}
