namespace Symulator_Transmisji_Szeregowej
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
            panel1 = new Panel();
            decode = new Button();
            toAscii = new Button();
            textBox2 = new TextBox();
            binLabel = new Label();
            wpiszLabel = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            odbiornik = new Label();
            nadajnik = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(decode);
            panel1.Controls.Add(toAscii);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(binLabel);
            panel1.Controls.Add(wpiszLabel);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 546);
            panel1.TabIndex = 0;
            // 
            // decode
            // 
            decode.Location = new Point(127, 459);
            decode.Name = "decode";
            decode.Size = new Size(204, 75);
            decode.TabIndex = 5;
            decode.Text = "DECODE";
            decode.UseVisualStyleBackColor = true;
            decode.Click += decode_Click;
            // 
            // toAscii
            // 
            toAscii.Location = new Point(127, 146);
            toAscii.Name = "toAscii";
            toAscii.Size = new Size(204, 94);
            toAscii.TabIndex = 4;
            toAscii.Text = "Konwertuj do ASCII";
            toAscii.UseVisualStyleBackColor = true;
            toAscii.Click += toAscii_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(36, 326);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(415, 106);
            textBox2.TabIndex = 3;
            // 
            // binLabel
            // 
            binLabel.AutoSize = true;
            binLabel.Location = new Point(36, 303);
            binLabel.Name = "binLabel";
            binLabel.Size = new Size(217, 20);
            binLabel.TabIndex = 2;
            binLabel.Text = "Binarnie (z bitem stopu i startu)";
            // 
            // wpiszLabel
            // 
            wpiszLabel.AutoSize = true;
            wpiszLabel.Location = new Point(36, 21);
            wpiszLabel.Name = "wpiszLabel";
            wpiszLabel.Size = new Size(84, 20);
            wpiszLabel.TabIndex = 1;
            wpiszLabel.Text = "Wpisz tekst";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(663, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 546);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(58, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightSeaGreen;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox3.Location = new Point(58, 237);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(374, 126);
            textBox3.TabIndex = 0;
            // 
            // odbiornik
            // 
            odbiornik.AutoSize = true;
            odbiornik.Location = new Point(852, 26);
            odbiornik.Name = "odbiornik";
            odbiornik.Size = new Size(88, 20);
            odbiornik.TabIndex = 2;
            odbiornik.Text = "ODBIORNIK";
            // 
            // nadajnik
            // 
            nadajnik.AutoSize = true;
            nadajnik.Location = new Point(226, 20);
            nadajnik.Name = "nadajnik";
            nadajnik.Size = new Size(81, 20);
            nadajnik.TabIndex = 3;
            nadajnik.Text = "NADAJNIK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1169, 625);
            Controls.Add(nadajnik);
            Controls.Add(odbiornik);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label odbiornik;
        private Label nadajnik;
        private TextBox textBox1;
        private Label binLabel;
        private Label wpiszLabel;
        private TextBox textBox2;
        private Button toAscii;
        private Button decode;
        private TextBox textBox3;
        private PictureBox pictureBox1;
    }
}
