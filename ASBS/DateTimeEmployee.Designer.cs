
namespace ASBS
{
    partial class DateTimeEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmployes = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirstMode = new System.Windows.Forms.Button();
            this.btnFullMode = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSecondMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сотрудник";
            // 
            // cbEmployes
            // 
            this.cbEmployes.FormattingEnabled = true;
            this.cbEmployes.Location = new System.Drawing.Point(324, 39);
            this.cbEmployes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmployes.Name = "cbEmployes";
            this.cbEmployes.Size = new System.Drawing.Size(290, 24);
            this.cbEmployes.TabIndex = 9;
            this.cbEmployes.SelectedIndexChanged += new System.EventHandler(this.cbEmployes_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(325, 511);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(290, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(305, 523);
            this.dataGridView1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 23);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Дата";
            // 
            // btnFirstMode
            // 
            this.btnFirstMode.Location = new System.Drawing.Point(326, 187);
            this.btnFirstMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFirstMode.Name = "btnFirstMode";
            this.btnFirstMode.Size = new System.Drawing.Size(142, 28);
            this.btnFirstMode.TabIndex = 13;
            this.btnFirstMode.Text = "1-ая смена";
            this.btnFirstMode.UseVisualStyleBackColor = true;
            this.btnFirstMode.Click += new System.EventHandler(this.btnFirstMode_Click);
            // 
            // btnFullMode
            // 
            this.btnFullMode.Location = new System.Drawing.Point(325, 116);
            this.btnFullMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFullMode.Name = "btnFullMode";
            this.btnFullMode.Size = new System.Drawing.Size(290, 28);
            this.btnFullMode.TabIndex = 11;
            this.btnFullMode.Text = "Полный рабочий день";
            this.btnFullMode.UseVisualStyleBackColor = true;
            this.btnFullMode.Click += new System.EventHandler(this.btnFullMode_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(325, 151);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(290, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Удалить запись";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSecondMode
            // 
            this.btnSecondMode.Location = new System.Drawing.Point(474, 187);
            this.btnSecondMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSecondMode.Name = "btnSecondMode";
            this.btnSecondMode.Size = new System.Drawing.Size(142, 28);
            this.btnSecondMode.TabIndex = 14;
            this.btnSecondMode.Text = "2-ая смена";
            this.btnSecondMode.UseVisualStyleBackColor = true;
            this.btnSecondMode.Click += new System.EventHandler(this.btnSecondMode_Click);
            // 
            // DateTimeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSecondMode);
            this.Controls.Add(this.btnFirstMode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFullMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmployes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DateTimeEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График сотрудникоа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmployes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirstMode;
        private System.Windows.Forms.Button btnFullMode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSecondMode;
    }
}