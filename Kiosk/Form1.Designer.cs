namespace Kiosk
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
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("휴먼둥근헤드라인", 60F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(0, 2);
            button1.Name = "button1";
            button1.Size = new Size(685, 658);
            button1.TabIndex = 0;
            button1.Text = "여기에서 \r\n주문하세요!\r\n\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Location = new Point(-2, 550);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 110);
            panel2.TabIndex = 1;
            panel2.Click += panel1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 119);
            panel1.TabIndex = 1;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("휴먼둥근헤드라인", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 422);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(410, 56);
            label1.TabIndex = 2;
            label1.Text = "화면을 터치해 주세요";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kiosk";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
    }
}