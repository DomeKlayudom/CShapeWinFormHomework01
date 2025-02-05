using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomework01
{
    public partial class FrmHomework3 : Form
    {
        public FrmHomework3()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbTotalMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNumber(sender, e);
        }

        private void tbTotalPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsInteger(sender, e);
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if(tbTotalMoney.Text.Trim().Length == 0 || tbTotalPeople.Text.Trim().Length == 0)
            {
                ShareData.ShowWarningMSG("กรุณากรอกข้อมูลให้ครบ");
                return;
            }
            lbResult.Text = (Convert.ToDouble(tbTotalMoney.Text) / Convert.ToInt32(tbTotalPeople.Text)).ToString("0.00");
        }
    }
}
