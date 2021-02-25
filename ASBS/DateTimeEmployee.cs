using System;
using System.Windows.Forms;
using ASBS.SQLCommand;
using System.Configuration;

namespace ASBS
{
    public partial class DateTimeEmployee : Form
    {
        public DateTimeEmployee()
        {
            InitializeComponent();
            LoadEmployesAndDataTime();
            dateTimePicker1.Enabled = false;
        }

        private void cbEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDataSet();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод cbEmployes_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadEmployesAndDataTime()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                cbEmployes.Items.AddRange(reader.GetListEmployes().ToArray());
                cbEmployes.DropDownStyle = ComboBoxStyle.DropDownList;
                reader.LaodDataTimeEmployee();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод LoadDataGird: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadDataSet()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                dataGridView1.DataSource = reader.GetDataSetDateTime(cbEmployes.Text).Tables[0];
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Время";
                dataGridView1.Columns[3].HeaderText = "Занято";
                dataGridView1.Columns[4].Visible = false;
                dateTimePicker1.Enabled = true;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод LoadDataSet: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
            => this.Close();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                dataGridView1.DataSource = reader.GetDataSetDateTime(cbEmployes.Text, dateTimePicker1.Value).Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Время";
                dataGridView1.Columns[3].HeaderText = "Занято";
                dataGridView1.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод dateTimePicker1_ValueChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnFullMode_Click(object sender, EventArgs e)
        {
            try
            {
                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.AddTimeRecords(dateTimePicker1.Value, cbEmployes.Text, Data.StartTimeFullMod, Data.EndTimeFullMod);
                dateTimePicker1_ValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод btnFullMode_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnFirstMode_Click(object sender, EventArgs e)
        {
            try
            {
                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.AddTimeRecords(dateTimePicker1.Value, cbEmployes.Text, Data.StartTimeFirstMod, Data.EndTimeFirstMod);
                dateTimePicker1_ValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод btnFirstMode_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnSecondMode_Click(object sender, EventArgs e)
        {
            try
            {
                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.AddTimeRecords(dateTimePicker1.Value, cbEmployes.Text, Data.StartTimeSecondMod, Data.EndTimeSecondMod);
                dateTimePicker1_ValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе DateTimeEmployee метод btnFullMode_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());

                    write.DeleteDateTime(int.Parse(dataGridView1[0, selectedIndex].Value.ToString()));
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                }
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод btnDelete_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
