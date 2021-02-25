using System;
using System.Windows.Forms;

namespace ASBS
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void ChangeDataEmployes_Click(object sender, EventArgs e)
        {
            try
            {
                var changeEmployee = new ChangeEmployee();
                this.Enabled = false;
                changeEmployee.Show();
                changeEmployee.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе Index метод changeDataEmployes_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
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
                MyLog.Log("Исключение в классе Index метод AddEmployeeToolStripMenuItem_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void MyFormClosed(object sender, FormClosedEventArgs e)
            => this.Enabled = true;

        private void AddClientToolStripMenuItem_Click(object sender, EventArgs e)
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
                MyLog.Log("Исключение в классе Index метод AddClientToolStripMenuItem_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ChangeDataClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var chaneClient = new ChaneClient();
                this.Enabled = false;
                chaneClient.Show();
                chaneClient.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе Index метод ChangeDataClientToolStripMenuItem_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ChangeDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var dateTimeEmployee = new DateTimeEmployee();
                this.Enabled = false;
                dateTimeEmployee.Show();
                dateTimeEmployee.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе Index метод ChangeDateTimeToolStripMenuItem_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ChangeWorkTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var timeData = new TimeData();
                this.Enabled = false;
                timeData.Show();
                timeData.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе Index метод ChangeWorkTimeToolStripMenuItem_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void AddRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var addRecord = new AddRecord();
                this.Enabled = false;
                addRecord.Show();
                addRecord.FormClosed += MyFormClosed;
            }
            catch (Exception ex)
            {
                MyLog.Log("Исключение в классе Index метод AddRecordToolStripMenuItem_Click: " + ex.Message);
                MessageBox.Show(this, "Произошла ошибка", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
