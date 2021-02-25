
namespace ASBS
{
    partial class Index
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDataEmployes = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDataClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeWorkTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запсьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.графикToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.запсьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem,
            this.changeDataEmployes});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            this.добавитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // changeDataEmployes
            // 
            this.changeDataEmployes.Name = "changeDataEmployes";
            this.changeDataEmployes.Size = new System.Drawing.Size(257, 22);
            this.changeDataEmployes.Text = "Изменить данные сотрудников";
            this.changeDataEmployes.Click += new System.EventHandler(this.ChangeDataEmployes_Click);
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeDateTimeToolStripMenuItem});
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.графикToolStripMenuItem.Text = "График ";
            // 
            // ChangeDateTimeToolStripMenuItem
            // 
            this.ChangeDateTimeToolStripMenuItem.Name = "ChangeDateTimeToolStripMenuItem";
            this.ChangeDateTimeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ChangeDateTimeToolStripMenuItem.Text = "Изменить график";
            this.ChangeDateTimeToolStripMenuItem.Click += new System.EventHandler(this.ChangeDateTimeToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientToolStripMenuItem,
            this.ChangeDataClientToolStripMenuItem});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // AddClientToolStripMenuItem
            // 
            this.AddClientToolStripMenuItem.Name = "AddClientToolStripMenuItem";
            this.AddClientToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.AddClientToolStripMenuItem.Text = "Добавить клиента";
            this.AddClientToolStripMenuItem.Click += new System.EventHandler(this.AddClientToolStripMenuItem_Click);
            // 
            // ChangeDataClientToolStripMenuItem
            // 
            this.ChangeDataClientToolStripMenuItem.Name = "ChangeDataClientToolStripMenuItem";
            this.ChangeDataClientToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.ChangeDataClientToolStripMenuItem.Text = "Изменить данные клиентов";
            this.ChangeDataClientToolStripMenuItem.Click += new System.EventHandler(this.ChangeDataClientToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeWorkTimeToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // ChangeWorkTimeToolStripMenuItem
            // 
            this.ChangeWorkTimeToolStripMenuItem.Name = "ChangeWorkTimeToolStripMenuItem";
            this.ChangeWorkTimeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ChangeWorkTimeToolStripMenuItem.Text = "Изменить рабочее время";
            this.ChangeWorkTimeToolStripMenuItem.Click += new System.EventHandler(this.ChangeWorkTimeToolStripMenuItem_Click);
            // 
            // запсьToolStripMenuItem
            // 
            this.запсьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecordToolStripMenuItem});
            this.запсьToolStripMenuItem.Name = "запсьToolStripMenuItem";
            this.запсьToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.запсьToolStripMenuItem.Text = "Запсь";
            // 
            // AddRecordToolStripMenuItem
            // 
            this.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem";
            this.AddRecordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AddRecordToolStripMenuItem.Text = "Добавить запись";
            this.AddRecordToolStripMenuItem.Click += new System.EventHandler(this.AddRecordToolStripMenuItem_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Салон красоты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDataEmployes;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeDateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeDataClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeWorkTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запсьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRecordToolStripMenuItem;
    }
}

