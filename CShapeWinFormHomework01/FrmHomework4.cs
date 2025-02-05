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
    public partial class FrmHomework4 : Form
    {
        public FrmHomework4()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            rbJava.Checked = true;
            tbPeople.Text = "";
            lbCostName.Text = "XXXX";
            tbPeople.Focus();
            lbPeopleJoin.Text = "XXXX";
            lbResult.Text = "XXXX";
        }

        private void FrmHomework4_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            // Determine cost and role name
            int costPrice = rbJava.Checked ? 1000 : rbAndroid.Checked ? 1200 : rbIos.Checked ? 1400 : 1800;
            string costName = rbJava.Checked ? "Java Developer" : rbAndroid.Checked ? "Android Developer" : rbIos.Checked ? "IOS Developer" : "PHP Developer";

            // Parse people count safely
            int peopleCount = string.IsNullOrEmpty(tbPeople.Text) || !int.TryParse(tbPeople.Text, out int temp) ? 0 : temp;

            // Calculate total cost
            double totalCost = costPrice * peopleCount;

            // Apply discount based on number of people
            if (peopleCount >= 2 && peopleCount <= 4)
            {
                totalCost *= 0.95; // 5% discount
            }
            else if (peopleCount >= 5)
            {
                totalCost *= 0.90; // 10% discount
            }

            // Update labels
            lbResult.Text = totalCost.ToString("0.00"); // Format with 2 decimal places
            lbPeopleJoin.Text = peopleCount.ToString();
            lbCostName.Text = costName;
        }

    }
}
