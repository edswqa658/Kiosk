using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class 사이드Control : UserControl
    {
        public int Quantity { get; set; }
        public 사이드Control()
        {
            InitializeComponent();
        }
        public event EventHandler<string> LabelClicked;
        public event EventHandler<string> Label2Clicked;
        public event EventHandler<string> Label3Clicked;
        public event EventHandler<string> Label4Clicked;

        private int Quantity1 = 0;
        private int Quantity2 = 0;
        private int Quantity3 = 0;
        private int Quantity4 = 0;

        private void label1_Click(object sender, EventArgs e)
        {
            Quantity1++;
            UpdateLabelQuantity(label1, Quantity1);
            string customText = $"감자튀김                                                                      {Quantity1}개                                                                       {Quantity1 * 1800}원";
            LabelClicked?.Invoke(this, customText);

            // Update only the quantity part of label1
            string[] labelTextParts = label1.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label1.Text = $"{labelTextParts[0]}개";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Quantity2++;
            UpdateLabelQuantity(label2, Quantity2);
            string customText = $"양념감자                                                                      {Quantity2}개                                                                       {Quantity2 * 2300}원";
            Label2Clicked?.Invoke(this, customText);

            // Update only the quantity part of label2
            string[] labelTextParts = label2.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label2.Text = $"{labelTextParts[0]}개";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Quantity3++;
            UpdateLabelQuantity(label3, Quantity3);
            string customText = $"치즈스틱                                                                      {Quantity3}개                                                                       {Quantity3 * 2400}원";
            Label3Clicked?.Invoke(this, customText);

            // Update only the quantity part of label3
            string[] labelTextParts = label3.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label3.Text = $"{labelTextParts[0]}개";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Quantity4++;
            UpdateLabelQuantity(label4, Quantity4);
            string customText = $"치킨1조각                                                                    {Quantity4}개                                                                       {Quantity4 * 2800}원";
            Label4Clicked?.Invoke(this, customText);

            // Update only the quantity part of label4
            string[] labelTextParts = label4.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label4.Text = $"{labelTextParts[0]}개";
            }
        }
        private void UpdateLabelQuantity(Label label, int quantity)
        {
            // Implement the quantity update logic if needed, similar to the 햄버거Control.cs
        }
    }
}
