
namespace _090321Task
{
    partial class Form1
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
            this.UsernameTxtB = new System.Windows.Forms.TextBox();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameStatusLbl = new System.Windows.Forms.Label();
            this.PasswordStatusLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTxtB
            // 
            this.UsernameTxtB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UsernameTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTxtB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTxtB.Location = new System.Drawing.Point(12, 137);
            this.UsernameTxtB.MaxLength = 15;
            this.UsernameTxtB.Multiline = true;
            this.UsernameTxtB.Name = "UsernameTxtB";
            this.UsernameTxtB.Size = new System.Drawing.Size(318, 32);
            this.UsernameTxtB.TabIndex = 0;
            this.UsernameTxtB.Text = "User Name";
            this.UsernameTxtB.MouseEnter += new System.EventHandler(this.UsernameTxtB_MouseEnter);
            this.UsernameTxtB.MouseLeave += new System.EventHandler(this.UsernameTxtB_MouseLeave);
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PasswordTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordTxtB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTxtB.Location = new System.Drawing.Point(12, 204);
            this.PasswordTxtB.MaxLength = 15;
            this.PasswordTxtB.Multiline = true;
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.Size = new System.Drawing.Size(318, 32);
            this.PasswordTxtB.TabIndex = 1;
            this.PasswordTxtB.Text = "Password";
            this.PasswordTxtB.MouseEnter += new System.EventHandler(this.PasswordTxtB_MouseEnter);
            this.PasswordTxtB.MouseLeave += new System.EventHandler(this.PasswordTxtB_MouseLeave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(12, 268);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(318, 59);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameStatusLbl
            // 
            this.UsernameStatusLbl.AutoSize = true;
            this.UsernameStatusLbl.ForeColor = System.Drawing.Color.Red;
            this.UsernameStatusLbl.Location = new System.Drawing.Point(12, 178);
            this.UsernameStatusLbl.Name = "UsernameStatusLbl";
            this.UsernameStatusLbl.Size = new System.Drawing.Size(48, 17);
            this.UsernameStatusLbl.TabIndex = 3;
            this.UsernameStatusLbl.Text = "Status";
            this.UsernameStatusLbl.Visible = false;
            // 
            // PasswordStatusLbl
            // 
            this.PasswordStatusLbl.AutoSize = true;
            this.PasswordStatusLbl.ForeColor = System.Drawing.Color.Red;
            this.PasswordStatusLbl.Location = new System.Drawing.Point(12, 246);
            this.PasswordStatusLbl.Name = "PasswordStatusLbl";
            this.PasswordStatusLbl.Size = new System.Drawing.Size(48, 17);
            this.PasswordStatusLbl.TabIndex = 4;
            this.PasswordStatusLbl.Text = "Status";
            this.PasswordStatusLbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_090321Task.Properties.Resources.hippoCarsPng;
            this.pictureBox1.Location = new System.Drawing.Point(77, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordStatusLbl);
            this.Controls.Add(this.UsernameStatusLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.UsernameTxtB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Hippo Cars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtB;
        private System.Windows.Forms.TextBox PasswordTxtB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label UsernameStatusLbl;
        private System.Windows.Forms.Label PasswordStatusLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

