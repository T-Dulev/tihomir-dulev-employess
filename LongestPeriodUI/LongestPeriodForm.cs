using LongestPeriod;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LongestPeriodUI
{
    public partial class LongestPeriodForm : Form
    {
        public LongestPeriodForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new();

            openFileDialog1.Filter = "Data files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;
            labelFileName.Text = selectedFileName;

            var employess = new List<Employee>(Employee.ReadFromFile(selectedFileName));
            var resJoin = new List<JoinEmployess>(JoinEmployess.JoinEmp(employess));

            foreach (var item in resJoin)
            {
                dataGridView.Rows.Add(item.EmpFirstId, item.EmpSecondId, item.ProjectId, item.Interval);
            }

            var res = JoinEmployess.GetMaxInterval(resJoin);

            labelMaxInterval.Text = "Мaximum days together: EmpId1=" + res.EmpFirstId + ", EmpId2=" + res.EmpSecondId + ", DaysWorked=" + res.DaysWorked;
        }
    }
}
