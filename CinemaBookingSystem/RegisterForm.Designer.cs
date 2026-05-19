namespace CinemaBookingSystem
{
    partial class RegisterForm
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
            textBoxUsername = new TextBox();
            Password = new Label();
            textBoxPassword = new TextBox();
            buttonCreate = new Button();
            CinemaName = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Username.ForeColor = Color.White;
            Username.Location = new Point(272, 232);
            Username.Name = "Username";
            Username.Size = new Size(80, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(64, 64, 64);
            textBoxUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(353, 232);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(125, 27);
            textBoxUsername.TabIndex = 1;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Password.ForeColor = Color.White;
            Password.Location = new Point(272, 278);
            Password.Name = "Password";
            Password.Size = new Size(76, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(353, 278);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = SystemColors.Highlight;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(340, 338);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(138, 29);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Create Account";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // CinemaName
            // 
            CinemaName.AutoSize = true;
            CinemaName.BackColor = Color.FromArgb(45, 45, 48);
            CinemaName.FlatStyle = FlatStyle.Popup;
            CinemaName.Font = new Font("Algerian", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CinemaName.ForeColor = SystemColors.Highlight;
            CinemaName.ImageAlign = ContentAlignment.MiddleRight;
            CinemaName.Location = new Point(70, 43);
            CinemaName.Name = "CinemaName";
            CinemaName.Size = new Size(672, 134);
            CinemaName.TabIndex = 7;
            CinemaName.Text = "UNICINEMA";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(800, 450);
            Controls.Add(CinemaName);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPassword);
            Controls.Add(Password);
            Controls.Add(textBoxUsername);
            Controls.Add(Username);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox textBoxUsername;
        private Label Password;
        private TextBox textBoxPassword;
        private Button buttonCreate;
        private Label CinemaName;
    }
}