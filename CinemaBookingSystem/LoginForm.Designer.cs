namespace CinemaBookingSystem
{
    partial class LoginForm
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
            Username = new Label();
            Password = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            buttonLogin = new Button();
            CinemaName = new Label();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Username.Location = new Point(312, 225);
            Username.Name = "Username";
            Username.Size = new Size(80, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Password.Location = new Point(312, 278);
            Password.Name = "Password";
            Password.Size = new Size(76, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPassword.Location = new Point(403, 275);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(140, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(64, 64, 64);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(403, 222);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(140, 27);
            textBoxUsername.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Highlight;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(421, 318);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(106, 29);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // CinemaName
            // 
            CinemaName.AutoSize = true;
            CinemaName.BackColor = Color.FromArgb(45, 45, 48);
            CinemaName.FlatStyle = FlatStyle.Popup;
            CinemaName.Font = new Font("Algerian", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CinemaName.ForeColor = SystemColors.Highlight;
            CinemaName.ImageAlign = ContentAlignment.MiddleRight;
            CinemaName.Location = new Point(105, 55);
            CinemaName.Name = "CinemaName";
            CinemaName.Size = new Size(672, 134);
            CinemaName.TabIndex = 6;
            CinemaName.Text = "UNICINEMA";
            CinemaName.Click += CinemaName_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.Highlight;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(421, 364);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(106, 29);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(900, 450);
            Controls.Add(buttonRegister);
            Controls.Add(CinemaName);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(Password);
            Controls.Add(Username);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private Label CinemaName;
        private Button buttonRegister;
    }
}