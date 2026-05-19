namespace CinemaBookingSystem
{
    partial class AdminForm
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
            AdminPanel = new Label();
            listBoxUsers = new ListBox();
            listBoxTickets = new ListBox();
            buttonClearTickets = new Button();
            BOOKINGS = new Label();
            USERS = new Label();
            SuspendLayout();
            // 
            // AdminPanel
            // 
            AdminPanel.AutoSize = true;
            AdminPanel.BorderStyle = BorderStyle.FixedSingle;
            AdminPanel.FlatStyle = FlatStyle.Flat;
            AdminPanel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AdminPanel.ForeColor = Color.White;
            AdminPanel.Location = new Point(476, 13);
            AdminPanel.Margin = new Padding(4, 0, 4, 0);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(186, 40);
            AdminPanel.TabIndex = 0;
            AdminPanel.Text = "Admin Panel";
            AdminPanel.Click += AdminPanel_Click;
            // 
            // listBoxUsers
            // 
            listBoxUsers.BackColor = Color.FromArgb(64, 64, 64);
            listBoxUsers.BorderStyle = BorderStyle.None;
            listBoxUsers.ForeColor = Color.White;
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(769, 130);
            listBoxUsers.Margin = new Padding(4, 4, 4, 4);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(400, 420);
            listBoxUsers.TabIndex = 1;
            // 
            // listBoxTickets
            // 
            listBoxTickets.BackColor = Color.FromArgb(64, 64, 64);
            listBoxTickets.BorderStyle = BorderStyle.None;
            listBoxTickets.ForeColor = Color.White;
            listBoxTickets.FormattingEnabled = true;
            listBoxTickets.Location = new Point(41, 130);
            listBoxTickets.Margin = new Padding(4, 4, 4, 4);
            listBoxTickets.Name = "listBoxTickets";
            listBoxTickets.Size = new Size(400, 420);
            listBoxTickets.TabIndex = 2;
            // 
            // buttonClearTickets
            // 
            buttonClearTickets.BackColor = Color.FromArgb(220, 53, 69);
            buttonClearTickets.FlatStyle = FlatStyle.Flat;
            buttonClearTickets.ForeColor = Color.White;
            buttonClearTickets.Location = new Point(467, 551);
            buttonClearTickets.Margin = new Padding(4, 4, 4, 4);
            buttonClearTickets.Name = "buttonClearTickets";
            buttonClearTickets.Size = new Size(273, 41);
            buttonClearTickets.TabIndex = 3;
            buttonClearTickets.Text = "Очистити бронювання";
            buttonClearTickets.UseVisualStyleBackColor = false;
            // 
            // BOOKINGS
            // 
            BOOKINGS.AutoSize = true;
            BOOKINGS.ForeColor = Color.White;
            BOOKINGS.Location = new Point(877, 84);
            BOOKINGS.Margin = new Padding(4, 0, 4, 0);
            BOOKINGS.Name = "BOOKINGS";
            BOOKINGS.Size = new Size(115, 28);
            BOOKINGS.TabIndex = 4;
            BOOKINGS.Text = "BOOKINGS";
            // 
            // USERS
            // 
            USERS.AutoSize = true;
            USERS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            USERS.ForeColor = Color.White;
            USERS.Location = new Point(201, 84);
            USERS.Margin = new Padding(4, 0, 4, 0);
            USERS.Name = "USERS";
            USERS.Size = new Size(72, 28);
            USERS.TabIndex = 5;
            USERS.Text = "USERS";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1200, 630);
            Controls.Add(USERS);
            Controls.Add(BOOKINGS);
            Controls.Add(buttonClearTickets);
            Controls.Add(listBoxTickets);
            Controls.Add(listBoxUsers);
            Controls.Add(AdminPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdminForm";
            Text = "AdminForm";
            Click += buttonClearTickets_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminPanel;
        private ListBox listBoxUsers;
        private ListBox listBoxTickets;
        private Button buttonClearTickets;
        private Label BOOKINGS;
        private Label USERS;
    }
}