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
    public partial class FrmHomework2 : Form
    {
        public FrmHomework2()
        {
            InitializeComponent();
        }

        private void tbStudentNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsInteger(sender, e);
        }

        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsNotInteger(sender, e);
        }

        private void tbMidtermScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsInteger(sender, e);
        }

        private void tbFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsInteger(sender, e);
        }

        private void tbScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            ShareData.CheckIsInteger(sender, e);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbStudentNum.Text = "";
            tbFullName.Text = "";
            tbMidtermScore.Text = "";
            tbFinal.Text = "";
            tbScore.Text = "";

            tbStudentNum.Focus();

            lbStudentNum.Text = "xxxxxxxxx";
            lbFullName.Text = "xxxxxxxxx";
            lbTotalScore.Text = "xxx";
            lbGrade.Text = "x";
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            lbStudentNum.Text = tbStudentNum.Text;
            lbFullName.Text = tbFullName.Text;
            int totalScore = int.Parse(tbMidtermScore.Text) + int.Parse(tbFinal.Text) + int.Parse(tbScore.Text);
            lbTotalScore.Text =totalScore.ToString();
            String stuGrade = totalScore >= 80 ? "A" : totalScore >= 70 ? "B" : totalScore >= 60 ? "C" : totalScore >= 50 ? "D" : "F";
            lbGrade.Text = stuGrade;
        }

        private void FrmHomework2_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }
    }
}
