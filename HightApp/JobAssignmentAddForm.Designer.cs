namespace HightApp
{
    partial class JobAssignmentAddForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.AddJobBtn = new System.Windows.Forms.Button();
            this.plaseLabel = new System.Windows.Forms.Label();
            this.technicIdLabel = new System.Windows.Forms.Label();
            this.dateAppointmentLabel = new System.Windows.Forms.Label();
            this.masterLabel = new System.Windows.Forms.Label();
            this.executorLabel = new System.Windows.Forms.Label();
            this.plaseTextBox = new System.Windows.Forms.TextBox();
            this.technicIdComboBox = new System.Windows.Forms.ComboBox();
            this.masterComboBox = new System.Windows.Forms.ComboBox();
            this.executorComboBox = new System.Windows.Forms.ComboBox();
            this.dateAppointmentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(477, 198);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(137, 46);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Отмена";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJobBtn.Location = new System.Drawing.Point(17, 198);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.Size = new System.Drawing.Size(137, 46);
            this.AddJobBtn.TabIndex = 1;
            this.AddJobBtn.Text = "Сохранить";
            this.AddJobBtn.UseVisualStyleBackColor = true;
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click);
            // 
            // plaseLabel
            // 
            this.plaseLabel.AutoSize = true;
            this.plaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plaseLabel.Location = new System.Drawing.Point(12, 14);
            this.plaseLabel.Name = "plaseLabel";
            this.plaseLabel.Size = new System.Drawing.Size(199, 25);
            this.plaseLabel.TabIndex = 3;
            this.plaseLabel.Text = "Место исполнения";
            // 
            // technicIdLabel
            // 
            this.technicIdLabel.AutoSize = true;
            this.technicIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technicIdLabel.Location = new System.Drawing.Point(12, 51);
            this.technicIdLabel.Name = "technicIdLabel";
            this.technicIdLabel.Size = new System.Drawing.Size(142, 25);
            this.technicIdLabel.TabIndex = 4;
            this.technicIdLabel.Text = "Исп. техника";
            // 
            // dateAppointmentLabel
            // 
            this.dateAppointmentLabel.AutoSize = true;
            this.dateAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateAppointmentLabel.Location = new System.Drawing.Point(12, 88);
            this.dateAppointmentLabel.Name = "dateAppointmentLabel";
            this.dateAppointmentLabel.Size = new System.Drawing.Size(185, 25);
            this.dateAppointmentLabel.TabIndex = 5;
            this.dateAppointmentLabel.Text = "Дата назанчения";
            // 
            // masterLabel
            // 
            this.masterLabel.AutoSize = true;
            this.masterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterLabel.Location = new System.Drawing.Point(12, 125);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(87, 25);
            this.masterLabel.TabIndex = 6;
            this.masterLabel.Text = "Мастер";
            // 
            // executorLabel
            // 
            this.executorLabel.AutoSize = true;
            this.executorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorLabel.Location = new System.Drawing.Point(12, 162);
            this.executorLabel.Name = "executorLabel";
            this.executorLabel.Size = new System.Drawing.Size(143, 25);
            this.executorLabel.TabIndex = 7;
            this.executorLabel.Text = "Исполнитель";
            // 
            // plaseTextBox
            // 
            this.plaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plaseTextBox.Location = new System.Drawing.Point(215, 11);
            this.plaseTextBox.Name = "plaseTextBox";
            this.plaseTextBox.Size = new System.Drawing.Size(399, 31);
            this.plaseTextBox.TabIndex = 9;
            // 
            // technicIdComboBox
            // 
            this.technicIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technicIdComboBox.FormattingEnabled = true;
            this.technicIdComboBox.Location = new System.Drawing.Point(215, 48);
            this.technicIdComboBox.Name = "technicIdComboBox";
            this.technicIdComboBox.Size = new System.Drawing.Size(399, 33);
            this.technicIdComboBox.TabIndex = 14;
            // 
            // masterComboBox
            // 
            this.masterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterComboBox.FormattingEnabled = true;
            this.masterComboBox.Location = new System.Drawing.Point(215, 122);
            this.masterComboBox.Name = "masterComboBox";
            this.masterComboBox.Size = new System.Drawing.Size(399, 33);
            this.masterComboBox.TabIndex = 15;
            // 
            // executorComboBox
            // 
            this.executorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.executorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorComboBox.FormattingEnabled = true;
            this.executorComboBox.Location = new System.Drawing.Point(215, 159);
            this.executorComboBox.Name = "executorComboBox";
            this.executorComboBox.Size = new System.Drawing.Size(399, 33);
            this.executorComboBox.TabIndex = 16;
            // 
            // dateAppointmentTextBox
            // 
            this.dateAppointmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateAppointmentTextBox.Location = new System.Drawing.Point(215, 85);
            this.dateAppointmentTextBox.Mask = "00/00/0000";
            this.dateAppointmentTextBox.Name = "dateAppointmentTextBox";
            this.dateAppointmentTextBox.Size = new System.Drawing.Size(399, 31);
            this.dateAppointmentTextBox.TabIndex = 17;
            this.dateAppointmentTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // JobAssignmentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 263);
            this.Controls.Add(this.dateAppointmentTextBox);
            this.Controls.Add(this.executorComboBox);
            this.Controls.Add(this.masterComboBox);
            this.Controls.Add(this.technicIdComboBox);
            this.Controls.Add(this.plaseTextBox);
            this.Controls.Add(this.executorLabel);
            this.Controls.Add(this.masterLabel);
            this.Controls.Add(this.dateAppointmentLabel);
            this.Controls.Add(this.technicIdLabel);
            this.Controls.Add(this.plaseLabel);
            this.Controls.Add(this.AddJobBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "JobAssignmentAddForm";
            this.Text = "Добавление назначений на работу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button AddJobBtn;
        private System.Windows.Forms.Label plaseLabel;
        private System.Windows.Forms.Label technicIdLabel;
        private System.Windows.Forms.Label dateAppointmentLabel;
        private System.Windows.Forms.Label masterLabel;
        private System.Windows.Forms.Label executorLabel;
        private System.Windows.Forms.TextBox plaseTextBox;
        private System.Windows.Forms.ComboBox technicIdComboBox;
        private System.Windows.Forms.ComboBox masterComboBox;
        private System.Windows.Forms.ComboBox executorComboBox;
        private System.Windows.Forms.MaskedTextBox dateAppointmentTextBox;
    }
}