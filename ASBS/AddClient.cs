using System;
using System.Windows.Forms;
using ASBS.Models;
using ASBS.SQLCommand;
using System.Configuration;

namespace ASBS
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.AddNewClient(new Client(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtmTel.Text,
                    txtEmail.Text));
                MessageBox.Show(this, "Клиент успешно добавлен", "Уведомление", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    ex.Message == "ClientExistsInTheDatabase" ? "Клиент существует в базе данных" : "Произошла ошибка", "Ошибка",
                    MessageBoxButtons.OK);
                MyLog.Log("Исключение в классе AddEmployee метод btnSave_Click: " + ex.Message);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
            => this.Close();

        private void CheckData()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                    !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                    txtmTel.Text.Length == 14 &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text))
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе AddClient метод CheckData: " + ex.Message);
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
    }
}
