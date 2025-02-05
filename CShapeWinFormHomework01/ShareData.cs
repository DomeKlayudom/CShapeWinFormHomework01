using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomework01
{
    internal class ShareData
    {
        public static void ShowWarningMSG(String mgs)
        {
            MessageBox.Show(mgs, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void CheckIsNumber(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                return;
            }


            if (e.KeyChar == '.' && ((TextBox)sender).Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
                return;
            }


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        public static void CheckIsInteger(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void CheckIsNotInteger(object sender, KeyPressEventArgs e)
        {
            // อนุญาตให้กดปุ่มควบคุม เช่น Backspace, Delete
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // ถ้ากดเป็นตัวเลข (0-9) ให้ป้องกันการพิมพ์
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public static void CalculateAndDisplay(string num1Text, string num2Text, string operation, int decimalPlaces, Label resultLabel)
        {
            // ตรวจสอบการกรอกข้อมูล
            if (string.IsNullOrWhiteSpace(num1Text) || string.IsNullOrWhiteSpace(num2Text))
            {
                resultLabel.Text = "กรุณาป้อนข้อมูลทั้งสองฟิลด์";
                return;
            }

            double num1, num2;

            // ตรวจสอบว่าผู้ใช้กรอกตัวเลขที่ถูกต้องหรือไม่
            if (!double.TryParse(num1Text, out num1) || !double.TryParse(num2Text, out num2))
            {
                resultLabel.Text = "กรุณาป้อนตัวเลขที่ถูกต้อง";
                return;
            }

            // คำนวณตามตัวดำเนินการ
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "÷":
                    if (num2 == 0)
                    {
                        resultLabel.Text = "ไม่สามารถหารด้วยศูนย์";
                        return;
                    }
                    result = num1 / num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2); // ยกกำลัง
                    break;
                default:
                    resultLabel.Text = "การดำเนินการไม่ถูกต้อง";
                    return;
            }

            // กำหนดจำนวนทศนิยมที่จะแสดง
            resultLabel.Text = result.ToString($"F{decimalPlaces}");

        }
    }
}
