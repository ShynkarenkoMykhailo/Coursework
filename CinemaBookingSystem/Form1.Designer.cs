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
            labelDescription = new Label();
            buttonBook = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).BeginInit();
            SuspendLayout();
            // 
            // listBoxMovies
            // 
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.Location = new Point(-1, 4);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(251, 444);
            listBoxMovies.TabIndex = 0;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // pictureBoxPoster
            // 
            pictureBoxPoster.Location = new Point(256, 4);
            pictureBoxPoster.Name = "pictureBoxPoster";
            pictureBoxPoster.Size = new Size(532, 201);
            pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPoster.TabIndex = 1;
            pictureBoxPoster.TabStop = false;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(256, 227);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(97, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Опис фільму";
            labelDescription.Click += labelDescription_Click;
            // 
            // buttonBook
            // 
            buttonBook.Location = new Point(468, 379);
            buttonBook.Name = "buttonBook";
            buttonBook.Size = new Size(139, 29);
            buttonBook.TabIndex = 3;
            buttonBook.Text = "Забронювати";
            buttonBook.UseVisualStyleBackColor = true;
            buttonBook.Click += buttonBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonBook);
            Controls.Add(labelDescription);
            Controls.Add(pictureBoxPoster);
            Controls.Add(listBoxMovies);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMovies;
        private PictureBox pictureBoxPoster;
        private Label labelDescription;
        private Button buttonBook;
        private Label label1;
    }
}
