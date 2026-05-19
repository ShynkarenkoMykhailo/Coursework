namespace CinemaBookingSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxMovies = new ListBox();
            pictureBoxPoster = new PictureBox();
            buttonBook = new Button();
            label1 = new Label();
            richTextBoxDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).BeginInit();
            SuspendLayout();
            // 
            // listBoxMovies
            // 
            listBoxMovies.BackColor = Color.FromArgb(64, 64, 64);
            listBoxMovies.BorderStyle = BorderStyle.None;
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.Location = new Point(-1, -3);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(265, 440);
            listBoxMovies.TabIndex = 0;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // pictureBoxPoster
            // 
            pictureBoxPoster.Location = new Point(264, -3);
            pictureBoxPoster.Name = "pictureBoxPoster";
            pictureBoxPoster.Size = new Size(588, 245);
            pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPoster.TabIndex = 1;
            pictureBoxPoster.TabStop = false;
            // 
            // buttonBook
            // 
            buttonBook.BackColor = SystemColors.Highlight;
            buttonBook.Location = new Point(495, 391);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(139, 29);
            buttonBook.TabIndex = 3;
            buttonBook.Text = "Забронювати";
            buttonBook.UseVisualStyleBackColor = false;
            buttonBook.Click += buttonBook_Click;
            buttonBook.MouseEnter += buttonBook_MouseEnter;
            buttonBook.MouseLeave += buttonBook_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.BackColor = Color.FromArgb(45, 45, 48);
            richTextBoxDescription.BorderStyle = BorderStyle.None;
            richTextBoxDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxDescription.ForeColor = Color.White;
            richTextBoxDescription.Location = new Point(264, 238);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.Size = new Size(588, 147);
            richTextBoxDescription.TabIndex = 5;
            richTextBoxDescription.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(844, 432);
            Controls.Add(buttonBook);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label1);
            Controls.Add(pictureBoxPoster);
            Controls.Add(listBoxMovies);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMovies;
        private PictureBox pictureBoxPoster;
        private Button buttonBook;
        private Label label1;
        private RichTextBox richTextBoxDescription;
    }
}
