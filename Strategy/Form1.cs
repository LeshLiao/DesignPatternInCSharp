using System;
using System.Windows.Forms;



namespace Strategy
{
    public partial class Form1 : Form
    {
        public decimal total;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_detail.Items.Clear();
            comboBox_discount.Items.Clear();
            comboBox_discount.Items.AddRange(new object[] { "Original price", "20% off", "Buy $300 return $100" });
            comboBox_discount.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CashContext myCashContext = new CashContext(comboBox_discount.SelectedIndex);
            decimal sum = myCashContext.GetResult(Int32.Parse(textBox_price.Text) * Int32.Parse(textBox_number.Text));

            string detail = "price=" + textBox_price.Text + ",number=" + textBox_number.Text + ",discount=" + comboBox_discount.Text + ",item=" + sum.ToString();
            listBox_detail.Items.Add(detail);

            total = total + sum;
            label_total.Text = total.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox_price.Text = "0";
            textBox_number.Text = "0";
            label_total.Text = "0";
            comboBox_discount.SelectedIndex = 0;
            total = 0;
            listBox_detail.Items.Clear();
        }
    }
}
