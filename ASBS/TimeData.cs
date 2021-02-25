using System;
using System.Windows.Forms;
using ASBS.SQLCommand;
using System.Configuration;
namespace ASBS
{
    public partial class TimeData : Form
    {
        public TimeData()
        {
            InitializeComponent();
            LoadDataTime();
            CheckData();
        }

        private void CheckData()
        {
            try
            {
                if (txtETFM.Text.Length == 5 &&
                    txtETFullM.Text.Length == 5 &&
                    txtETSM.Text.Length == 5 &&
                    txtSTFM.Text.Length == 5 &&
                    txtSTFullM.Text.Length == 5 &&
                    txtSTSM.Text.Length == 5 &&
                    txtTime.Text.Length == 5)
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе TimeData метод CheckData: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void LoadDataTime()
        {
            try
            {
                var reader = new SQLReader(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                reader.LaodDataTimeEmployee();

                txtSTFM.Text = Convert.ToString(Data.StartTimeFirstMod);
                txtETFM.Text = Convert.ToString(Data.EndTimeFirstMod);
                txtSTSM.Text = Convert.ToString(Data.StartTimeSecondMod);
                txtETSM.Text = Convert.ToString(Data.EndTimeSecondMod);
                txtSTFullM.Text = Convert.ToString(Data.StartTimeFullMod);
                txtETFullM.Text = Convert.ToString(Data.EndTimeFullMod);
                txtTime.Text = Convert.ToString(Data.ReciptTime);
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе TimeData метод LoadDataTime: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
            => this.Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Data.StartTimeFirstMod = TimeSpan.Parse(txtSTFM.Text);
                Data.EndTimeFirstMod = TimeSpan.Parse(txtETFM.Text);
                Data.StartTimeSecondMod = TimeSpan.Parse(txtSTSM.Text);
                Data.EndTimeSecondMod = TimeSpan.Parse(txtETSM.Text);
                Data.StartTimeFullMod = TimeSpan.Parse(txtSTFullM.Text);
                Data.EndTimeFullMod = TimeSpan.Parse(txtETFullM.Text);
                Data.ReciptTime = TimeSpan.Parse(txtTime.Text);

                var write = new SQLWrite(ConfigurationManager.ConnectionStrings["ASBS.Properties.Settings.DBSK2ConnectionString"].ToString());
                write.ChangeDataTime();
                MessageBox.Show(this, "Данные успешно обновлены", "Уведомление", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе TimeData метод btnSave_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void txtSTFM_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtETFM_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtSTSM_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtETSM_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtSTFullM_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtETFullM_TextChanged(object sender, EventArgs e)
            => CheckData();

        private void txtTime_TextChanged(object sender, EventArgs e)
            => CheckData();
    }
}
