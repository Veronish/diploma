namespace HightApp
{
    partial class JobAssignmentEditForm
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
            this.dateAppointmentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.executorComboBox = new System.Windows.Forms.ComboBox();
            this.masterComboBox = new System.Windows.Forms.ComboBox();
            this.technicIdComboBox = new System.Windows.Forms.ComboBox();
            this.plaseTextBox = new System.Windows.Forms.TextBox();
            this.executorLabel = new System.Windows.Forms.Label();
            this.masterLabel = new System.Windows.Forms.Label();
            this.dateAppointmentLabel = new System.Windows.Forms.Label();
            this.technicIdLabel = new System.Windows.Forms.Label();
            this.plaseLabel = new System.Windows.Forms.Label();
            this.editJobBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateAppointmentTextBox
            // 
            this.dateAppointmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateAppointmentTextBox.Location = new System.Drawing.Point(215, 80);
            this.dateAppointmentTextBox.Mask = "00/00/0000";
            this.dateAppointmentTextBox.Name = "dateAppointmentTextBox";
            this.dateAppointmentTextBox.Size = new System.Drawing.Size(399, 31);
            this.dateAppointmentTextBox.TabIndex = 29;
            this.dateAppointmentTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // executorComboBox
            // 
            this.executorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.executorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorComboBox.FormattingEnabled = true;
            this.executorComboBox.Location = new System.Drawing.Point(215, 154);
            this.executorComboBox.Name = "executorComboBox";
            this.executorComboBox.Size = new System.Drawing.Size(399, 33);
            this.executorComboBox.TabIndex = 28;
            // 
            // masterComboBox
            // 
            this.masterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterComboBox.FormattingEnabled = true;
            this.masterComboBox.Location = new System.Drawing.Point(215, 117);
            this.masterComboBox.Name = "masterComboBox";
            this.masterComboBox.Size = new System.Drawing.Size(399, 33);
            this.masterComboBox.TabIndex = 27;
            // 
            // technicIdComboBox
            // 
            this.technicIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technicIdComboBox.FormattingEnabled = true;
            this.technicIdComboBox.Location = new System.Drawing.Point(215, 43);
            this.technicIdComboBox.Name = "technicIdComboBox";
            this.technicIdComboBox.Size = new System.Drawing.Size(399, 33);
            this.technicIdComboBox.TabIndex = 26;
            // 
            // plaseTextBox
            // 
            this.plaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plaseTextBox.Location = new System.Drawing.Point(215, 6);
            this.plaseTextBox.Name = "plaseTextBox";
            this.plaseTextBox.Size = new System.Drawing.Size(399, 31);
            this.plaseTextBox.TabIndex = 25;
            // 
            // executorLabel
            // 
            this.executorLabel.AutoSize = true;
            this.executorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorLabel.Location = new System.Drawing.Point(12, 157);
            this.executorLabel.Name = "executorLabel";
            this.executorLabel.Size = new System.Drawing.Size(143, 25);
            this.executorLabel.TabIndex = 24;
            this.executorLabel.Text = "Исполнитель";
            // 
            // masterLabel
            // 
            this.masterLabel.AutoSize = true;
            this.masterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterLabel.Location = new System.Drawing.Point(12, 120);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(87, 25);
            this.masterLabel.TabIndex = 23;
            this.masterLabel.Text = "Мастер";
            // 
            // dateAppointmentLabel
            // 
            this.dateAppointmentLabel.AutoSize = true;
            this.dateAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateAppointmentLabel.Location = new System.Drawing.Point(12, 83);
            this.dateAppointmentLabel.Name = "dateAppointmentLabel";
            this.dateAppointmentLabel.Size = new System.Drawing.Size(185, 25);
            this.dateAppointmentLabel.TabIndex = 22;
            this.dateAppointmentLabel.Text = "Дата назанчения";
            // 
            // technicIdLabel
            // 
            this.technicIdLabel.AutoSize = true;
            this.technicIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.technicIdLabel.Location = new System.Drawing.Point(12, 46);
            this.technicIdLabel.Name = "technicIdLabel";
            this.technicIdLabel.Size = new System.Drawing.Size(142, 25);
            this.technicIdLabel.TabIndex = 21;
            this.technicIdLabel.Text = "Исп. техника";
            // 
            // plaseLabel
            // 
            this.plaseLabel.AutoSize = true;
            this.plaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plaseLabel.Location = new System.Drawing.Point(12, 9);
            this.plaseLabel.Name = "plaseLabel";
            this.plaseLabel.Size = new System.Drawing.Size(199, 25);
            this.plaseLabel.TabIndex = 20;
            this.plaseLabel.Text = "Место исполнения";
            // 
            // editJobBtn
            // 
            this.editJobBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editJobBtn.Location = new System.Drawing.Point(17, 193);
            this.editJobBtn.Name = "editJobBtn";
            this.editJobBtn.Size = new System.Drawing.Size(137, 46);
            this.editJobBtn.TabIndex = 19;
            this.editJobBtn.Text = "Сохранить";
            this.editJobBtn.UseVisualStyleBackColor = true;
            this.editJobBtn.Click += new System.EventHandler(this.EditJobBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(477, 193);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(137, 46);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Отмена";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // JobAssignmentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 246);
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
            this.Controls.Add(this.editJobBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "JobAssignmentEditForm";
            this.Text = "JobAssignmentEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox dateAppointmentTextBox;
        private System.Windows.Forms.ComboBox executorComboBox;
        private System.Windows.Forms.ComboBox masterComboBox;
        private System.Windows.Forms.ComboBox technicIdComboBox;
        private System.Windows.Forms.TextBox plaseTextBox;
        private System.Windows.Forms.Label executorLabel;
        private System.Windows.Forms.Label masterLabel;
        private System.Windows.Forms.Label dateAppointmentLabel;
        private System.Windows.Forms.Label technicIdLabel;
        private System.Windows.Forms.Label plaseLabel;
        private System.Windows.Forms.Button editJobBtn;
        private System.Windows.Forms.Button backBtn;
    }
}