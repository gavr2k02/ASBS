using System;
using System.Windows.Forms;
using ASBS.SQLCommand;
using System.Configuration;
using System.Data;

namespace ASBS
{
    public partial class ChangeEmployee : Form
    {
        public ChangeEmployee()
        {
            InitializeComponent();
            LoadListSpeciality();
            LoadDataGird();
        }

        private void LoadDataGird()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                dataGridView1.DataSource = reader.GetDataSetEmployes().Tables[0];
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Почта";
                dataGridView1.Columns[4].HeaderText = "Телефон";
                dataGridView1.Columns[5].HeaderText = "Cпециальность";
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод LoadDataGird: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadListSpeciality()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                cbSpeciality.Items.AddRange(reader.GetListSpeciiality().ToArray());
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод LoadListSpeciality: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var addEmployee = new AddEmployee();
                this.Enabled = false;
                addEmployee.Show();
                addEmployee.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод btnNewEmployee_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void MyFormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataGird();
            this.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
            => this.Close();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Удалить клиента?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());

                    write.DeleteEmployee(int.Parse(dataGridView1[0, selectedIndex].Value.ToString()));
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    }
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод btnDelete_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void cbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                dataGridView1.DataSource = reader.GetDataSetEmployes(cbSpeciality.Text).Tables[0];
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Телефон";
                dataGridView1.Columns[4].HeaderText = "Почта";
                dataGridView1.Columns[5].HeaderText = "Cпециальность";
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод cbSpeciality_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_Validated(object sender, EventArgs e)
        {
            try
            {
                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.UpdateDataEmployee((DataTable)dataGridView1.DataSource);
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе ChangeEmployee метод dataGridView1_Validated: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

