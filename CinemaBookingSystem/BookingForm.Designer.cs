using System.Drawing;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;

        private Button buttonSeat1;
        private Button buttonSeat2;
        private Button buttonSeat3;
        private Button buttonSeat4;
        private Button buttonSeat5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            buttonSeat1 = new Button();
            buttonSeat2 = new Button();
            buttonSeat3 = new Button();
            buttonSeat4 = new Button();
            buttonSeat5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            panelScreen = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelFree = new Panel();
            panelBusy = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(192, 32);
            label1.TabIndex = 0;
            label1.Text = "Виберіть місце";
            // 
            // buttonSeat1
            // 
            buttonSeat1.BackColor = Color.Green;
            buttonSeat1.FlatStyle = FlatStyle.Flat;
            buttonSeat1.ForeColor = Color.White;
            buttonSeat1.Location = new Point(473, 136);
            buttonSeat1.Name = "buttonSeat1";
            buttonSeat1.Size = new Size(60, 60);
            buttonSeat1.TabIndex = 1;
            buttonSeat1.Text = "1";
            buttonSeat1.UseVisualStyleBackColor = false;
            buttonSeat1.Click += buttonSeat1_Click;
            // 
            // buttonSeat2
            // 
            buttonSeat2.BackColor = Color.Green;
            buttonSeat2.FlatStyle = FlatStyle.Flat;
            buttonSeat2.ForeColor = Color.White;
            buttonSeat2.Location = new Point(539, 136);
            buttonSeat2.Name = "buttonSeat2";
            buttonSeat2.Size = new Size(60, 60);
            buttonSeat2.TabIndex = 2;
            buttonSeat2.Text = "2";
            buttonSeat2.UseVisualStyleBackColor = false;
            buttonSeat2.Click += buttonSeat1_Click;
            // 
            // buttonSeat3
            // 
            buttonSeat3.BackColor = Color.Green;
            buttonSeat3.FlatStyle = FlatStyle.Flat;
            buttonSeat3.ForeColor = Color.White;
            buttonSeat3.Location = new Point(605, 136);
            buttonSeat3.Name = "buttonSeat3";
            buttonSeat3.Size = new Size(60, 60);
            buttonSeat3.TabIndex = 3;
            buttonSeat3.Text = "3";
            buttonSeat3.UseVisualStyleBackColor = false;
            buttonSeat3.Click += buttonSeat1_Click;
            // 
            // buttonSeat4
            // 
            buttonSeat4.BackColor = Color.Green;
            buttonSeat4.FlatStyle = FlatStyle.Flat;
            buttonSeat4.ForeColor = Color.White;
            buttonSeat4.Location = new Point(671, 136);
            buttonSeat4.Name = "buttonSeat4";
            buttonSeat4.Size = new Size(60, 60);
            buttonSeat4.TabIndex = 4;
            buttonSeat4.Text = "4";
            buttonSeat4.UseVisualStyleBackColor = false;
            buttonSeat4.Click += buttonSeat1_Click;
            // 
            // buttonSeat5
            // 
            buttonSeat5.BackColor = Color.Green;
            buttonSeat5.FlatStyle = FlatStyle.Flat;
            buttonSeat5.ForeColor = Color.White;
            buttonSeat5.Location = new Point(737, 136);
            buttonSeat5.Name = "buttonSeat5";
            buttonSeat5.Size = new Size(60, 60);
            buttonSeat5.TabIndex = 5;
            buttonSeat5.Text = "5";
            buttonSeat5.UseVisualStyleBackColor = false;
            buttonSeat5.Click += buttonSeat1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(473, 202);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 7;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonSeat1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(539, 202);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSeat1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(605, 202);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonSeat1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(671, 202);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 10;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonSeat1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(737, 202);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 11;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonSeat1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(473, 334);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 12;
            button6.Text = "1";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonSeat1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Green;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(539, 466);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 13;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonSeat1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Green;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(605, 334);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 14;
            button8.Text = "3";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonSeat1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Green;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(671, 400);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 15;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonSeat1_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Green;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(737, 466);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 16;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += buttonSeat1_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Green;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.White;
            button11.Location = new Point(473, 268);
            button11.Name = "button11";
            button11.Size = new Size(60, 60);
            button11.TabIndex = 17;
            button11.Text = "1";
            button11.UseVisualStyleBackColor = false;
            button11.Click += buttonSeat1_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Green;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.White;
            button12.Location = new Point(539, 400);
            button12.Name = "button12";
            button12.Size = new Size(60, 60);
            button12.TabIndex = 18;
            button12.Text = "2";
            button12.UseVisualStyleBackColor = false;
            button12.Click += buttonSeat1_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Green;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.White;
            button13.Location = new Point(605, 268);
            button13.Name = "button13";
            button13.Size = new Size(60, 60);
            button13.TabIndex = 19;
            button13.Text = "3";
            button13.UseVisualStyleBackColor = false;
            button13.Click += buttonSeat1_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Green;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.White;
            button14.Location = new Point(671, 466);
            button14.Name = "button14";
            button14.Size = new Size(60, 60);
            button14.TabIndex = 20;
            button14.Text = "4";
            button14.UseVisualStyleBackColor = false;
            button14.Click += buttonSeat1_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Green;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.White;
            button15.Location = new Point(737, 268);
            button15.Name = "button15";
            button15.Size = new Size(60, 60);
            button15.TabIndex = 21;
            button15.Text = "5";
            button15.UseVisualStyleBackColor = false;
            button15.Click += buttonSeat1_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Green;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ForeColor = Color.White;
            button16.Location = new Point(473, 400);
            button16.Name = "button16";
            button16.Size = new Size(60, 60);
            button16.TabIndex = 22;
            button16.Text = "1";
            button16.UseVisualStyleBackColor = false;
            button16.Click += buttonSeat1_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Green;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ForeColor = Color.White;
            button17.Location = new Point(539, 334);
            button17.Name = "button17";
            button17.Size = new Size(60, 60);
            button17.TabIndex = 23;
            button17.Text = "2";
            button17.UseVisualStyleBackColor = false;
            button17.Click += buttonSeat1_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Green;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ForeColor = Color.White;
            button18.Location = new Point(605, 400);
            button18.Name = "button18";
            button18.Size = new Size(60, 60);
            button18.TabIndex = 24;
            button18.Text = "3";
            button18.UseVisualStyleBackColor = false;
            button18.Click += buttonSeat1_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Green;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ForeColor = Color.White;
            button19.Location = new Point(671, 334);
            button19.Name = "button19";
            button19.Size = new Size(60, 60);
            button19.TabIndex = 25;
            button19.Text = "4";
            button19.UseVisualStyleBackColor = false;
            button19.Click += buttonSeat1_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Green;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ForeColor = Color.White;
            button20.Location = new Point(737, 400);
            button20.Name = "button20";
            button20.Size = new Size(60, 60);
            button20.TabIndex = 26;
            button20.Text = "5";
            button20.UseVisualStyleBackColor = false;
            button20.Click += buttonSeat1_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Green;
            button21.FlatStyle = FlatStyle.Flat;
            button21.ForeColor = Color.White;
            button21.Location = new Point(473, 466);
            button21.Name = "button21";
            button21.Size = new Size(60, 60);
            button21.TabIndex = 27;
            button21.Text = "1";
            button21.UseVisualStyleBackColor = false;
            button21.Click += buttonSeat1_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.Green;
            button22.FlatStyle = FlatStyle.Flat;
            button22.ForeColor = Color.White;
            button22.Location = new Point(539, 268);
            button22.Name = "button22";
            button22.Size = new Size(60, 60);
            button22.TabIndex = 28;
            button22.Text = "2";
            button22.UseVisualStyleBackColor = false;
            button22.Click += buttonSeat1_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.Green;
            button23.FlatStyle = FlatStyle.Flat;
            button23.ForeColor = Color.White;
            button23.Location = new Point(605, 466);
            button23.Name = "button23";
            button23.Size = new Size(60, 60);
            button23.TabIndex = 29;
            button23.Text = "3";
            button23.UseVisualStyleBackColor = false;
            button23.Click += buttonSeat1_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.Green;
            button24.FlatStyle = FlatStyle.Flat;
            button24.ForeColor = Color.White;
            button24.Location = new Point(671, 268);
            button24.Name = "button24";
            button24.Size = new Size(60, 60);
            button24.TabIndex = 30;
            button24.Text = "4";
            button24.UseVisualStyleBackColor = false;
            button24.Click += buttonSeat1_Click;
            // 
            // button25
            // 
            button25.BackColor = Color.Green;
            button25.FlatStyle = FlatStyle.Flat;
            button25.ForeColor = Color.White;
            button25.Location = new Point(737, 334);
            button25.Name = "button25";
            button25.Size = new Size(60, 60);
            button25.TabIndex = 31;
            button25.Text = "5";
            button25.UseVisualStyleBackColor = false;
            button25.Click += buttonSeat1_Click;
            // 
            // panelScreen
            // 
            panelScreen.BackColor = Color.Silver;
            panelScreen.Location = new Point(473, 55);
            panelScreen.Name = "panelScreen";
            panelScreen.Size = new Size(324, 20);
            panelScreen.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(605, 24);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 33;
            label2.Text = "ЕКРАН";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 487);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 34;
            label3.Text = "Зайняте місце";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 440);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 35;
            label4.Text = "Вільне місце";
            // 
            // panelFree
            // 
            panelFree.BackColor = Color.Green;
            panelFree.Location = new Point(37, 440);
            panelFree.Name = "panelFree";
            panelFree.Size = new Size(20, 20);
            panelFree.TabIndex = 36;
            // 
            // panelBusy
            // 
            panelBusy.BackColor = Color.Red;
            panelBusy.Location = new Point(37, 487);
            panelBusy.Name = "panelBusy";
            panelBusy.Size = new Size(20, 20);
            panelBusy.TabIndex = 37;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(913, 547);
            Controls.Add(panelBusy);
            Controls.Add(panelFree);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelScreen);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(buttonSeat1);
            Controls.Add(buttonSeat2);
            Controls.Add(buttonSeat3);
            Controls.Add(buttonSeat4);
            Controls.Add(buttonSeat5);
            Name = "BookingForm";
            Text = "Бронювання";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Panel panelScreen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelFree;
        private Panel panelBusy;
    }
}