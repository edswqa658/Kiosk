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
    public partial class 추천메뉴Control : UserControl
    {
        public int quantity { get; set; }
        public 추천메뉴Control()
        {
            InitializeComponent();
        }
        public event EventHandler<string> LabelClicked;
        public event EventHandler<string> Label2Clicked;
        public event EventHandler<string> Label3Clicked;
        public event EventHandler<string> Label4Clicked;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 추천메뉴_Load(object sender, EventArgs e)
        {

        }
        private int quantity1 = 0;
        private int quantity2 = 0;
        private int quantity3 = 0;
        private int quantity4 = 0;


        private void label3_Click(object sender, EventArgs e)
        {
            quantity3++;
            UpdateLabelQuantity(label3, quantity3);
            string customText = $"한우연인팩                                                                   {quantity3}개                                                                      {quantity3 * 15500}원";
            Label3Clicked?.Invoke(this, customText);

            // Update only the quantity part of label3
            string[] labelTextParts = label3.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label3.Text = $"{labelTextParts[0]} ";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            quantity1++;
            UpdateLabelQuantity(label1, quantity1);
            string customText = $"마라로드 비프                                                               {quantity1}개                                                                       {quantity1 * 6900}원";
            LabelClicked?.Invoke(this, customText);

            // Update only the quantity part of label1
            string[] labelTextParts = label1.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label1.Text = $"{labelTextParts[0]}";
            }
        }

        private void LoadListBoxDataFromForm2()
        {
            Form2 form2 = (Form2)Application.OpenForms["Form2"];
            ListBox form1ListBox = form2.AccessibleListBox;

            foreach (var item in form1ListBox.Items)
            {
                // 여기서 item은 Form1의 ListBox 항목입니다.
                // 필요한 작업을 실행하세요.
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            quantity2++;
            UpdateLabelQuantity(label2, quantity2);
            string customText = $"마라로드 치킨                                                               {quantity2}개                                                                       {quantity2 * 5400}원";
            Label2Clicked?.Invoke(this, customText);

            // Update only the quantity part of label2
            string[] labelTextParts = label2.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label2.Text = $"{labelTextParts[0]}";
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            quantity4++;
            UpdateLabelQuantity(label4, quantity4);
            string customText = $"한우명품팩                                                                   {quantity4}개                                                                      {quantity4 * 17300}원";
            Label4Clicked?.Invoke(this, customText);

            // Update only the quantity part of label4
            string[] labelTextParts = label4.Text.Split('~');
            if (labelTextParts.Length == 2)
            {
                label4.Text = $"{labelTextParts[0]}";
            }
        }
        private void UpdateLabelQuantity(Label label, int quantity)
        {
            int pricePerItem = 0;

            if (label.Name == "label1")
            {
                quantity1 = quantity;
                pricePerItem = 6900;
                UpdateCustomText();
            }
            else if (label.Name == "label2")
            {
                quantity2 = quantity;
                pricePerItem = 5400;
                UpdateCustomText2();
            }
            else if (label.Name == "label3")
            {
                quantity3 = quantity;
                pricePerItem = 15500;
                UpdateCustomText3();
            }
            else if (label.Name == "label4")
            {
                quantity4 = quantity;
                pricePerItem = 17300;
                UpdateCustomText4();
            }
        }

        private void UpdateCustomText()
        {
            string customText = $"마라로드 비프                                                               {quantity1}개                                                                        {quantity1 * 6900}원";
            LabelClicked?.Invoke(this, customText);
        }

        private void UpdateCustomText2()
        {
            string customText = $"마라로드 치킨                                                               {quantity2}개                                                                        {quantity2 * 5400}원";
            Label2Clicked?.Invoke(this, customText);
        }

        private void UpdateCustomText3()
        {
            string customText = $"한우연인팩                                                                  {quantity3}개                                                                       {quantity3 * 15500}원";
            Label3Clicked?.Invoke(this, customText);
        }

        private void UpdateCustomText4()
        {
            string customText = $"한우명품팩                                                                  {quantity4}개                                                                       {quantity4 * 17300}원";
            Label4Clicked?.Invoke(this, customText);
        }

    }
}
