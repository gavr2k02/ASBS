using System;
using System.Windows.Forms;
using ASBS.SQLCommand;
using System.Configuration;
using System.Linq;

namespace ASBS
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
            LoadEmployes();
            LoadListSpeciality();
            LoadListClients();
            dateTimePicker1.Enabled = false;
            btnSave.Enabled = false;
        }

        private void cbEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbSpeciality.Enabled = false;
                LoadDataSet();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод cbEmployes_SelectedIndexChanged: " + ex.Message);
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
                MyLog.Log("Исключение в классе AddRecord метод cbEmployes_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadListClients()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                cbClients.Items.AddRange(reader.GetListClients().OrderBy(x => x).ToArray());
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод cbEmployes_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadEmployes()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                cbEmployes.Items.AddRange(reader.GetListEmployes().ToArray());
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод LoadDataGird: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadDataSet()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                dataGridView1.DataSource = reader.GetDataSetFreeDateTime(cbEmployes.Text).Tables[0];
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Время";
                dataGridView1.Columns[3].HeaderText = "Свободно";
                dataGridView1.Columns[4].Visible = false;
                dateTimePicker1.Enabled = true;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод LoadDataSet: " + ex.Message);
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
                dataGridView1.DataSource = reader.GetDataSetFreeDateTime(cbEmployes.Text, dateTimePicker1.Value).Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Время";
                dataGridView1.Columns[3].HeaderText = "Занято";
                dataGridView1.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод dateTimePicker1_ValueChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void cbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                cbEmployes.Items.Clear();
                cbEmployes.Items.AddRange(reader.GetListEmployes(cbSpeciality.Text).ToArray());
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод cbSpeciality_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void CheckData()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cbEmployes.Text) &&
                    !string.IsNullOrWhiteSpace(cbClients.Text))
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод CheckData: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CheckData();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод cbClients_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedIndex = dataGridView1.SelectedRows[0].Index;

                        var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());

                        write.AddNewRecord(int.Parse(dataGridView1[0, selectedIndex].Value.ToString()), cbClients.Text, cbEmployes.Text);

                        LoadDataSet();

                        MessageBox.Show(this, "Запись добавлена", "Уведомление", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show(this, "Выберите время записи", "Ошибка", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод btnSave_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void MyFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            LoadListClients();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            try
            {
                var addClient = new AddClient();
                this.Enabled = false;
                addClient.Show();
                addClient.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddRecord метод btnNewClient_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
