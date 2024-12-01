namespace WinFormsmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับ", "โปรมแกรมทดสอบคำนวณ BMI");
            clearFrom();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //double heigth = Convert.ToDouble(txtHeight.Text); //แบบที่1
            /* double heigth = 0;
             if (double.TryParse(txtHeight.Text, out heigth) == false) //แบบที่2
             {
                 MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง","เกิดข้อผิดพลาด");
                 return;
             }*/
            //double weigth = Convert.ToDouble(txtWeigth.Text); //แบบที่1
            /*double weigth = 0;
            if (double.TryParse(txtWeigth.Text, out weigth) == false) //แบบที่2
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }*/
            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeigth, txtHeight) == true) 
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeigth.Text);
            }
            double bmi = BMI( height,weight);
            //double bmi = weigth / Math.Pow(heigth / 100, 2);

            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFrom();
        }


        private void clearFrom()
        {
            txtAge.TextAlign = HorizontalAlignment.Left;
            txtWeigth.TextAlign = HorizontalAlignment.Left;
            txtHeight.TextAlign = HorizontalAlignment.Left;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeigth.Text = "0";
            txtName.Focus();

        }
        private void Input(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.DarkBlue;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) != 0)
            {
                age.ForeColor = Color.DarkRed;
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Input(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            Input(txtName, txtAge);
        }
        private double BMI(double h, double w) 
        {
            double bmi = w/Math.Pow(h/100, 2);
            return bmi;
        }
        private bool CheckDouble(TextBox txtW, TextBox txtH) 
        {
            double w = 0;
            double h = 0;
            if (double.TryParse(txtW.Text, out w)==false || double.TryParse(txtH.Text,out h) == false) 
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผดพลาด");
                return false;
            }
            return true;
        }
    }

}
