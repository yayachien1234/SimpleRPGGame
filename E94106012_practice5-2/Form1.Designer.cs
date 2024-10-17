namespace E94106012_practice5_2
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
            components = new System.ComponentModel.Container();
            Startbutton = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Leftlabel = new Label();
            Rightlabel = new Label();
            Turnlabel = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Startbutton
            // 
            Startbutton.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Startbutton.Location = new Point(300, 300);
            Startbutton.Name = "Startbutton";
            Startbutton.Size = new Size(191, 37);
            Startbutton.TabIndex = 0;
            Startbutton.Text = "開始遊戲";
            Startbutton.UseVisualStyleBackColor = true;
            Startbutton.Click += Startbutton_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.White;
            Btn1.Location = new Point(200, 200);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(98, 34);
            Btn1.TabIndex = 1;
            Btn1.Text = "Berserker";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.White;
            Btn2.Location = new Point(350, 200);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(98, 34);
            Btn2.TabIndex = 2;
            Btn2.Text = "Saber";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.White;
            Btn3.Location = new Point(500, 200);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(98, 34);
            Btn3.TabIndex = 3;
            Btn3.Text = "Caster";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 4;
            label1.Text = "準備階段";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(383, 53);
            label2.Name = "label2";
            label2.Size = new Size(36, 27);
            label2.TabIndex = 5;
            label2.Text = "10";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Leftlabel
            // 
            Leftlabel.AutoSize = true;
            Leftlabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Leftlabel.ImageAlign = ContentAlignment.TopCenter;
            Leftlabel.Location = new Point(61, 176);
            Leftlabel.Name = "Leftlabel";
            Leftlabel.Size = new Size(55, 21);
            Leftlabel.TabIndex = 6;
            Leftlabel.Text = "label3";
            Leftlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Rightlabel
            // 
            Rightlabel.AutoSize = true;
            Rightlabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Rightlabel.Location = new Point(678, 176);
            Rightlabel.Name = "Rightlabel";
            Rightlabel.Size = new Size(55, 21);
            Rightlabel.TabIndex = 7;
            Rightlabel.Text = "label4";
            Rightlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Turnlabel
            // 
            Turnlabel.AutoSize = true;
            Turnlabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Turnlabel.Location = new Point(367, 431);
            Turnlabel.Name = "Turnlabel";
            Turnlabel.Size = new Size(42, 21);
            Turnlabel.TabIndex = 8;
            Turnlabel.Text = "turn";
            Turnlabel.Click += Turnlabel_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 461);
            Controls.Add(Turnlabel);
            Controls.Add(Rightlabel);
            Controls.Add(Leftlabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(Startbutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Startbutton;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label Leftlabel;
        private Label Rightlabel;
        private Label Turnlabel;
        private System.Windows.Forms.Timer timer2;
    }
}