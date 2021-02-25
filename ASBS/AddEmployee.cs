using System;
using System.Windows.Forms;
using ASBS.Models;
using ASBS.SQLCommand;
using System.Configuration;

namespace ASBS
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            LoadListSpeciality();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.AddNewEmployee(new Employee(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtmTel.Text,
                    txtEmail.Text,
                    cbSpeciality.Text));
                MessageBox.Show(this, "Сотрудник успешно добавлен", "Уведомление", MessageBoxButtons.OK);
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message == "EmployeeExistsInTheDatabase" ? "Сотрудник существует в базе данных" : "Произошла ошибка", "Ошибка",
                    MessageBoxButtons.OK);
                MyLog.Log("Исключение в классе AddEmployee метод btnSave_Click: " + ex.Message);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
            => this.Close();

        private void LoadListSpeciality()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                cbSpeciality.Items.AddRange(reader.GetListSpeciiality().ToArray());
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddEmployee метод cbEmployes_SelectedIndexChanged: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void CheckData()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                    !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                    txtmTel.Text.Length == 14 &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(cbSpeciality.Text))
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddEmployee метод CheckData: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtLastName_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtmTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            => CheckData();

        private void txtEmail_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void cbSpeciality_TextUpdate(object sender, EventArgs e)
            => CheckData();

        private void cbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
            => CheckData();
    }
}
