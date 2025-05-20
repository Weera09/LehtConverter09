using System;
using System.Windows.Forms;

namespace AreaConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // กำหนดรายการหน่วยพื้นที่
            string[] areaUnits = { "ตารางเมตร", "ตารางเซนติเมตร", "ตารางกิโลเมตร" };

            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();
            cmbFrom.Items.AddRange(areaUnits);
            cmbTo.Items.AddRange(areaUnits);

            cmbFrom.SelectedIndex = 0;
            cmbTo.SelectedIndex = 1;

            lblResult.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("กรุณาป้อนตัวเลขที่ต้องการแปลง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            if (!double.TryParse(txtInput.Text, out double inputValue))
            {
                MessageBox.Show("กรุณาป้อนตัวเลขที่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return;
            }

            if (cmbFrom.SelectedItem == null || cmbTo.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกหน่วยให้ครบทั้งสองช่อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fromUnit = cmbFrom.SelectedItem.ToString();
            string toUnit = cmbTo.SelectedItem.ToString();

            // ถ้าหน่วยเดียวกัน แสดงค่าเดิม
            if (fromUnit == toUnit)
            {
                lblResult.Text = $"{inputValue} {fromUnit} = {inputValue:N4} {toUnit}";
                return;
            }

            double valueInSqMeters = ConvertToSquareMeters(inputValue, fromUnit);
            double resultValue = ConvertFromSquareMeters(valueInSqMeters, toUnit);

            lblResult.Text = $"{inputValue} {fromUnit} = {resultValue:N4} {toUnit}";
        }

        private double ConvertToSquareMeters(double value, string fromUnit)
        {
            switch (fromUnit)
            {
                case "ตารางเมตร":
                    return value;
                case "ตารางเซนติเมตร":
                    return value * 0.0001;
                case "ตารางกิโลเมตร":
                    return value * 1_000_000;
                default:
                    throw new ArgumentException("หน่วยไม่ถูกต้อง");
            }
        }

        private double ConvertFromSquareMeters(double value, string toUnit)
        {
            switch (toUnit)
            {
                case "ตารางเมตร":
                    return value;
                case "ตารางเซนติเมตร":
                    return value / 0.0001;
                case "ตารางกิโลเมตร":
                    return value / 1_000_000;
                default:
                    throw new ArgumentException("หน่วยไม่ถูกต้อง");
            }
        }
    }
}