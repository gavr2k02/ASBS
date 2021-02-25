
namespace ASBS
{
    partial class TimeData
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
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSTFM = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.txtETFullM = new System.Windows.Forms.MaskedTextBox();
            this.txtSTFullM = new System.Windows.Forms.MaskedTextBox();
            this.txtETSM = new System.Windows.Forms.MaskedTextBox();
            this.txtSTSM = new System.Windows.Forms.MaskedTextBox();
            this.txtETFM = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCanel
            // 
            this.btnCanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanel.Location = new System.Drawing.Point(409, 307);
            this.btnCanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(113, 28);
            this.btnCanel.TabIndex = 5;
            this.btnCanel.Text = "Отмена";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(290, 307);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время начала первой смены:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время конца первой смены:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время начала второй смены:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время конца второй смены:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Время начала полной смены:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Время конца полной смены:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Время приема:";
            // 
            // txtSTFM
            // 
            this.txtSTFM.Location = new System.Drawing.Point(194, 35);
            this.txtSTFM.Mask = "00:00";
            this.txtSTFM.Name = "txtSTFM";
            this.txtSTFM.Size = new System.Drawing.Size(299, 23);
            this.txtSTFM.TabIndex = 17;
            this.txtSTFM.TextChanged += new System.EventHandler(this.txtSTFM_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtETFullM);
            this.groupBox1.Controls.Add(this.txtSTFullM);
            this.groupBox1.Controls.Add(this.txtETSM);
            this.groupBox1.Controls.Add(this.txtSTSM);
            this.groupBox1.Controls.Add(this.txtETFM);
            this.groupBox1.Controls.Add(this.txtSTFM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(503, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные времени смен";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(194, 226);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(299, 23);
            this.txtTime.TabIndex = 23;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // txtETFullM
            // 
            this.txtETFullM.Location = new System.Drawing.Point(194, 194);
            this.txtETFullM.Mask = "00:00";
            this.txtETFullM.Name = "txtETFullM";
            this.txtETFullM.Size = new System.Drawing.Size(299, 23);
            this.txtETFullM.TabIndex = 22;
            this.txtETFullM.ValidatingType = typeof(System.DateTime);
            this.txtETFullM.TextChanged += new System.EventHandler(this.txtETFullM_TextChanged);
            // 
            // txtSTFullM
            // 
            this.txtSTFullM.Location = new System.Drawing.Point(194, 162);
            this.txtSTFullM.Mask = "00:00";
            this.txtSTFullM.Name = "txtSTFullM";
            this.txtSTFullM.Size = new System.Drawing.Size(299, 23);
            this.txtSTFullM.TabIndex = 21;
            this.txtSTFullM.ValidatingType = typeof(System.DateTime);
            this.txtSTFullM.TextChanged += new System.EventHandler(this.txtSTFullM_TextChanged);
            // 
            // txtETSM
            // 
            this.txtETSM.Location = new System.Drawing.Point(194, 131);
            this.txtETSM.Mask = "00:00";
            this.txtETSM.Name = "txtETSM";
            this.txtETSM.Size = new System.Drawing.Size(299, 23);
            this.txtETSM.TabIndex = 20;
            this.txtETSM.ValidatingType = typeof(System.DateTime);
            this.txtETSM.TextChanged += new System.EventHandler(this.txtETSM_TextChanged);
            // 
            // txtSTSM
            // 
            this.txtSTSM.Location = new System.Drawing.Point(194, 99);
            this.txtSTSM.Mask = "00:00";
            this.txtSTSM.Name = "txtSTSM";
            this.txtSTSM.Size = new System.Drawing.Size(299, 23);
            this.txtSTSM.TabIndex = 19;
            this.txtSTSM.ValidatingType = typeof(System.DateTime);
            this.txtSTSM.TextChanged += new System.EventHandler(this.txtSTSM_TextChanged);
            // 
            // txtETFM
            // 
            this.txtETFM.Location = new System.Drawing.Point(194, 67);
            this.txtETFM.Mask = "00:00";
            this.txtETFM.Name = "txtETFM";
            this.txtETFM.Size = new System.Drawing.Size(299, 23);
            this.txtETFM.TabIndex = 18;
            this.txtETFM.ValidatingType = typeof(System.DateTime);
            this.txtETFM.TextChanged += new System.EventHandler(this.txtETFM_TextChanged);
            // 
            // TimeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 352);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimeData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение времени работы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtSTFM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.MaskedTextBox txtETFullM;
        private System.Windows.Forms.MaskedTextBox txtSTFullM;
        private System.Windows.Forms.MaskedTextBox txtETSM;
        private System.Windows.Forms.MaskedTextBox txtSTSM;
        private System.Windows.Forms.MaskedTextBox txtETFM;
    }
}