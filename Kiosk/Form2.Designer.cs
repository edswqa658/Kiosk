namespace Kiosk
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            listBox1 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            추천메뉴1 = new 추천메뉴Control();
            햄버거Control1 = new 햄버거Control();
            사이드Control1 = new 사이드Control();
            음료Control1 = new 음료Control();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(688, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(-1, 128);
            button1.Name = "button1";
            button1.Size = new Size(172, 69);
            button1.TabIndex = 1;
            button1.Text = "추천메뉴";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(170, 128);
            button2.Name = "button2";
            button2.Size = new Size(172, 69);
            button2.TabIndex = 1;
            button2.Text = "햄버거";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(341, 128);
            button3.Name = "button3";
            button3.Size = new Size(172, 69);
            button3.TabIndex = 1;
            button3.Text = "사이드";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(512, 128);
            button4.Name = "button4";
            button4.Size = new Size(172, 69);
            button4.TabIndex = 1;
            button4.Text = "음료/커피";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 464);
            label5.Name = "label5";
            label5.Size = new Size(684, 35);
            label5.TabIndex = 3;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(1, 499);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(683, 94);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(52, 605);
            button5.Name = "button5";
            button5.Size = new Size(266, 45);
            button5.TabIndex = 5;
            button5.Text = "취소하기";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Salmon;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(341, 605);
            button6.Name = "button6";
            button6.Size = new Size(275, 45);
            button6.TabIndex = 5;
            button6.Text = "결제하기";
            button6.UseVisualStyleBackColor = false;
            // 
            // 추천메뉴1
            // 
            추천메뉴1.Location = new Point(-1, 193);
            추천메뉴1.Name = "추천메뉴1";
            추천메뉴1.quantity = 0;
            추천메뉴1.Size = new Size(685, 265);
            추천메뉴1.TabIndex = 6;
            추천메뉴1.Load += 추천메뉴1_Load_1;
            // 
            // 햄버거Control1
            // 
            햄버거Control1.Location = new Point(-1, 193);
            햄버거Control1.Name = "햄버거Control1";
            햄버거Control1.Quantity = 0;
            햄버거Control1.Size = new Size(685, 265);
            햄버거Control1.TabIndex = 7;
            햄버거Control1.Load += 햄버거Control1_Load;
            // 
            // 사이드Control1
            // 
            사이드Control1.Location = new Point(0, 193);
            사이드Control1.Name = "사이드Control1";
            사이드Control1.Quantity = 0;
            사이드Control1.Size = new Size(685, 265);
            사이드Control1.TabIndex = 8;
            // 
            // 음료Control1
            // 
            음료Control1.Location = new Point(-1, 193);
            음료Control1.Name = "음료Control1";
            음료Control1.Quantity = 0;
            음료Control1.Size = new Size(685, 265);
            음료Control1.TabIndex = 9;
            음료Control1.Load += 음료Control1_Load;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(추천메뉴1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(음료Control1);
            Controls.Add(사이드Control1);
            Controls.Add(햄버거Control1);
            Name = "Form2";
            Text = "Kiosk";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private ListBox listBox1;
        private Button button5;
        private Button button6;
        private 추천메뉴Control 추천메뉴1;
        private 햄버거Control 햄버거Control1;
        private 사이드Control 사이드Control1;
        private 음료Control 음료Control1;
    }
}