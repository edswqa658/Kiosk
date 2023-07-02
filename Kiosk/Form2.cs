using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form2 : Form
    {
        private int quantity = 0;
        private string lastClickedHamburgerLabel;
        private string lastClickedSideLabel;
        private string lastClickedDrinkLabel;

        private Dictionary<string, int> selectedItems = new Dictionary<string, int>();
        public Form2()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

        private void 추천메뉴1_LabelClicked(object sender, string itemText)
        {
            lastClickedHamburgerLabel = itemText;
            AddItemToListBox(itemText, 0);
        }

        private void 추천메뉴1_Label2Clicked(object sender, string itemText)
        {
            lastClickedHamburgerLabel = itemText;
            AddItemToListBox(itemText, 1);
        }

        // Similarly, handle other label click events for 추천메뉴Control
        // ...

        // Handle label click events for 햄버거Control
        private void 햄버거Control1_LabelClicked(object sender, string itemText)
        {
            lastClickedHamburgerLabel = itemText;
            AddItemToListBox(itemText, 0);
        }

        private void 햄버거Control1_Label2Clicked(object sender, string itemText)
        {
            lastClickedHamburgerLabel = itemText;
            AddItemToListBox(itemText, 1);
        }

        // Similarly, handle other label click events for 햄버거Control
        // ...

        // Handle label click events for 사이드Control
        private void 사이드Control1_LabelClicked(object sender, string itemText)
        {
            lastClickedSideLabel = itemText;
            AddItemToListBox(itemText, 0);
        }

        // Similarly, handle other label click events for 사이드Control
        // ...

        // Handle label click events for 음료Control
        private void 음료Control1_LabelClicked(object sender, string itemText)
        {
            lastClickedDrinkLabel = itemText;
            AddItemToListBox(itemText, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 추천메뉴1_Load(object sender, EventArgs e)
        {

        }

        private void 추천메뉴1_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public ListBox AccessibleListBox
        {
            get { return listBox1; }
        }
        private void SetupEventHandlers()
        {
            추천메뉴1.LabelClicked += OnLabelClicked;
            추천메뉴1.Label2Clicked += OnLabel2Clicked;
            추천메뉴1.Label3Clicked += OnLabel3Clicked;
            추천메뉴1.Label4Clicked += OnLabel4Clicked;

            햄버거Control1.LabelClicked += OnLabelClicked;
            햄버거Control1.Label2Clicked += OnLabel2Clicked;
            햄버거Control1.Label3Clicked += OnLabel3Clicked;
            햄버거Control1.Label4Clicked += OnLabel4Clicked;

            사이드Control1.LabelClicked += OnLabelClicked;
            사이드Control1.Label2Clicked += OnLabel2Clicked;
            사이드Control1.Label3Clicked += OnLabel3Clicked;
            사이드Control1.Label4Clicked += OnLabel4Clicked;

            음료Control1.LabelClicked += OnLabelClicked;
            음료Control1.Label2Clicked += OnLabel2Clicked;
            음료Control1.Label3Clicked += OnLabel3Clicked;
            음료Control1.Label4Clicked += OnLabel4Clicked;
        }
        private void OnLabelClicked(object sender, string itemText)
        {
            AddItemToListBox(itemText, 0);

        }
        private void OnLabel2Clicked(object sender, string itemText)
        {
            AddItemToListBox(itemText, 1);

        }
        private void OnLabel3Clicked(object sender, string itemText)
        {
            AddItemToListBox(itemText, 2);

        }
        private void OnLabel4Clicked(object sender, string itemText)
        {
            AddItemToListBox(itemText, 3);

        }

        private void AddItemToListBox(string itemText, int index)
        {
            // Determine the last clicked label for the current category
            string lastClickedLabel = GetLastClickedLabelForCategory(index);

            if (listBox1.Items.Count <= index)
            {
                listBox1.Items.Add(lastClickedLabel + ": " + itemText);
            }
            else
            {
                listBox1.Items[index] = lastClickedLabel + ": " + itemText;
            }
        }
        private string GetLastClickedLabelForCategory(int index)
        {
            if (index == 0) // Category: 추천메뉴Control
            {
                return lastClickedHamburgerLabel;
            }
            else if (index == 1) // Category: 햄버거Control
            {
                return lastClickedSideLabel;
            }
            else if (index == 2) // Category: 사이드Control
            {
                return lastClickedDrinkLabel;
            }
            // Add more conditions if you have additional categories

            return ""; // Return an empty string as a default value
        }
        private 추천메뉴Control Get추천메뉴Instance()
        {
            return 추천메뉴1;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            var 추천메뉴Instance = Get추천메뉴Instance();
            추천메뉴Instance.quantity++; // 수량 증가

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var 추천메뉴Instance = Get추천메뉴Instance();
            추천메뉴Instance.quantity--; // 수량 감소
            if (추천메뉴Instance.quantity < 0) 추천메뉴Instance.quantity = 0;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Bring 추천메뉴Control to the front
            추천메뉴1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bring 햄버거Control to the front
            햄버거Control1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Bring 사이드Control to the front
            사이드Control1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Bring 음료Control to the front
            음료Control1.BringToFront();
        }

        private void 사이드1_Load(object sender, EventArgs e)
        {

        }

        private void 햄버거Control1_Load(object sender, EventArgs e)
        {

        }

        private void 음료Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
