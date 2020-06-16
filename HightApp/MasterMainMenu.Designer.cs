namespace HightApp
{
    partial class MasterMainMenu
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
            this.labelinfo2 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.emploeeListBtn = new System.Windows.Forms.Button();
            this.jobAssignmentBtn = new System.Windows.Forms.Button();
            this.availableTechnicBtn = new System.Windows.Forms.Button();
            this.partsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelinfo2
            // 
            this.labelinfo2.AutoSize = true;
            this.labelinfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinfo2.Location = new System.Drawing.Point(41, 19);
            this.labelinfo2.Name = "labelinfo2";
            this.labelinfo2.Size = new System.Drawing.Size(151, 25);
            this.labelinfo2.TabIndex = 0;
            this.labelinfo2.Text = "Вы вошли как";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.Location = new System.Drawing.Point(213, 19);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(70, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "label2";
            // 
            // emploeeListBtn
            // 
            this.emploeeListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emploeeListBtn.Location = new System.Drawing.Point(193, 190);
            this.emploeeListBtn.Name = "emploeeListBtn";
            this.emploeeListBtn.Size = new System.Drawing.Size(172, 130);
            this.emploeeListBtn.TabIndex = 3;
            this.emploeeListBtn.Text = "просмотр списка сотрудников";
            this.emploeeListBtn.UseVisualStyleBackColor = true;
            this.emploeeListBtn.Click += new System.EventHandler(this.emploeeListBtn_Click);
            // 
            // jobAssignmentBtn
            // 
            this.jobAssignmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobAssignmentBtn.Location = new System.Drawing.Point(13, 54);
            this.jobAssignmentBtn.Name = "jobAssignmentBtn";
            this.jobAssignmentBtn.Size = new System.Drawing.Size(172, 130);
            this.jobAssignmentBtn.TabIndex = 4;
            this.jobAssignmentBtn.Text = "просмотр назначений на работу";
            this.jobAssignmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jobAssignmentBtn.UseVisualStyleBackColor = true;
            this.jobAssignmentBtn.Click += new System.EventHandler(this.jobAssignmentBtn_Click);
            // 
            // availableTechnicBtn
            // 
            this.availableTechnicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availableTechnicBtn.Location = new System.Drawing.Point(196, 54);
            this.availableTechnicBtn.Name = "availableTechnicBtn";
            this.availableTechnicBtn.Size = new System.Drawing.Size(169, 130);
            this.availableTechnicBtn.TabIndex = 5;
            this.availableTechnicBtn.Text = "просмотр доступной техники";
            this.availableTechnicBtn.UseVisualStyleBackColor = true;
            this.availableTechnicBtn.Click += new System.EventHandler(this.availableTechnicBtn_Click);
            // 
            // partsBtn
            // 
            this.partsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partsBtn.Location = new System.Drawing.Point(13, 190);
            this.partsBtn.Name = "partsBtn";
            this.partsBtn.Size = new System.Drawing.Size(172, 130);
            this.partsBtn.TabIndex = 6;
            this.partsBtn.Text = "оформление заказа деталей со склада";
            this.partsBtn.UseVisualStyleBackColor = true;
            this.partsBtn.Click += new System.EventHandler(this.partsBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(474, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "выйти из профиля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MasterMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partsBtn);
            this.Controls.Add(this.availableTechnicBtn);
            this.Controls.Add(this.jobAssignmentBtn);
            this.Controls.Add(this.emploeeListBtn);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelinfo2);
            this.Name = "MasterMainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinfo2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button emploeeListBtn;
        private System.Windows.Forms.Button jobAssignmentBtn;
        private System.Windows.Forms.Button availableTechnicBtn;
        private System.Windows.Forms.Button partsBtn;
        private System.Windows.Forms.Button button1;
    }
}