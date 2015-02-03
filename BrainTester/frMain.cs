using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrainTester
{
    public partial class frMain : Form
    {
        int result = 0;
        int rowIndex = -1;
        int duration = 0;
        public frMain()
        {
            InitializeComponent();
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num1 = random.Next(100);
            int num2 = random.Next(100);

            result = num1 * num2;

            dataGridView1.Rows.Add(num1.ToString() + "x" + num2.ToString() + "=", "", "","");

            lbNumbersToMultiply.Items.Clear();
            txtMultiplicationResult.Clear();
            txtMultiplicationResult.Focus();
            lbNumbersToMultiply.Items.Add(num1.ToString());
            lbNumbersToMultiply.Items.Add(num2.ToString());
            rowIndex++;

            tmrOperationTime.Enabled = true;

            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                

                if (result.ToString() == dataGridView1.Rows[e.RowIndex].Cells["YourResult"].Value.ToString())
                    dataGridView1.Rows[e.RowIndex].Cells["TrueFalse"].Value = "TRUE";
                dataGridView1.Rows[e.RowIndex].Cells["RealResult"].Value = result.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (result.ToString() == txtMultiplicationResult.Text)
            dataGridView1.Rows[rowIndex].Cells["TrueFalse"].Value = "TRUE";
            else dataGridView1.Rows[rowIndex].Cells["TrueFalse"].Value = "FALSE";

            dataGridView1.Rows[rowIndex].Cells["YourResult"].Value = txtMultiplicationResult.Text;
            dataGridView1.Rows[rowIndex].Cells["RealResult"].Value = result.ToString();
            dataGridView1.Rows[rowIndex].Cells["Time"].Value = duration.ToString();

            duration = 0;
            tmrOperationTime.Enabled = false;


        }

        private void tmrOperationTime_Tick(object sender, EventArgs e)
        {
            duration++;
        }

        private void txtMultiplicationResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnOK_Click(null, null);
                btnGenerateNumbers.Focus();
            }
        }

        
    }
}
