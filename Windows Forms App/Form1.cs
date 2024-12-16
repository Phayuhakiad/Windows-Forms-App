using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input  รับค่าจาก Textboxชื่อ txtRadius  (แปลงชนิดข้อมูลเป็น Double)
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRaduis.Text);
            if (double.TryParse(txtRaduis.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error");
                txtRaduis.Focus();    //ให้มี Cursor ที่ Textbox
                txtRaduis.SelectAll();  //ให้ Selected ข้อความใน Textbox
                return;
            }
            //process คำนวณพื้นที่ สูตร  pi*r*r
            double CircleArea = CalculateCircleArea(Radius);
            //Math.PI  ให้ค่า Pi
            //Math.Pow(x,y)   x ยกกำลัง y
            //output  นำไปแสดงผลที่ lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRaduis.Focus();
            txtRaduis.SelectAll();
        }
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับสู่โปรแกรม", "Welcome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าความสูง
            CalculateCircleTriangleArea();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าความยาวด้าน
            CalculateCircleHexagonArea();
        }

        private void txtRaduis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดโปรแกรมใช่หรือไม่?", "Close Windows?"
                                        , MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void CalculateCircleTriangleArea()
        {
            if (double.TryParse(txtHeitght.Text, out double Height) == false)
            {
                MessageBox.Show("กรอกค่าความสูงไม่ถูกต้อง", "Error");
                txtHeitght.Focus();
                txtHeitght.SelectAll();
                return;
            }

            // ตรวจสอบค่าฐาน
            if (double.TryParse(txtWidth.Text, out double Base) == false)
            {
                MessageBox.Show("กรอกค่าฐานไม่ถูกต้อง", "Error");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            // คำนวณพื้นที่สามเหลี่ยม (สูตร: 0.5 * ฐาน * ความสูง)
            double TriangleArea = 0.5 * Base * Height;

            // แสดงผลลัพธ์ใน lblResult
            lblResult.Text = TriangleArea.ToString("0.00");

            // ตั้งค่าโฟกัสให้กับ txtHeight
            txtHeitght.Focus();
            txtHeitght.SelectAll();
        }
        private void CalculateCircleHexagonArea()
        {
            if (double.TryParse(txtHexagonWidth.Text, out double Width) == false)
            {
                MessageBox.Show("กรอกค่าความยาวด้านไม่ถูกต้อง", "Error");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า
            double HexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Width, 2);

            // แสดงผลลัพธ์ใน lblResult
            lblResult.Text = HexagonArea.ToString("0.00");

            // ตั้งค่าโฟกัสให้กับ txtHexagonWidth
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }
    }
}
