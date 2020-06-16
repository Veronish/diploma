namespace HightApp
{
    partial class TechnicList
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
            this.labelMark = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.labelDateRepair = new System.Windows.Forms.Label();
            this.labelDefect = new System.Windows.Forms.Label();
            this.labelDatePrepairSet = new System.Windows.Forms.Label();
            this.labelAvailSet = new System.Windows.Forms.Label();
            this.labelModelSet = new System.Windows.Forms.Label();
            this.labelMarkSet = new System.Windows.Forms.Label();
            this.textBoxDefectSet = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMark.Location = new System.Drawing.Point(132, 12);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(60, 25);
            this.labelMark.TabIndex = 0;
            this.labelMark.Text = "Mark";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 404);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(132, 37);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(71, 25);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvailability.Location = new System.Drawing.Point(132, 62);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(115, 25);
            this.labelAvailability.TabIndex = 3;
            this.labelAvailability.Text = "Availability";
            // 
            // labelDateRepair
            // 
            this.labelDateRepair.AutoSize = true;
            this.labelDateRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateRepair.Location = new System.Drawing.Point(132, 87);
            this.labelDateRepair.Name = "labelDateRepair";
            this.labelDateRepair.Size = new System.Drawing.Size(173, 25);
            this.labelDateRepair.TabIndex = 4;
            this.labelDateRepair.Text = "Date Last Repair";
            // 
            // labelDefect
            // 
            this.labelDefect.AutoSize = true;
            this.labelDefect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDefect.Location = new System.Drawing.Point(132, 112);
            this.labelDefect.Name = "labelDefect";
            this.labelDefect.Size = new System.Drawing.Size(74, 25);
            this.labelDefect.TabIndex = 5;
            this.labelDefect.Text = "Defect";
            // 
            // labelDatePrepairSet
            // 
            this.labelDatePrepairSet.AutoSize = true;
            this.labelDatePrepairSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDatePrepairSet.Location = new System.Drawing.Point(311, 87);
            this.labelDatePrepairSet.Name = "labelDatePrepairSet";
            this.labelDatePrepairSet.Size = new System.Drawing.Size(18, 25);
            this.labelDatePrepairSet.TabIndex = 9;
            this.labelDatePrepairSet.Text = ".";
            // 
            // labelAvailSet
            // 
            this.labelAvailSet.AutoSize = true;
            this.labelAvailSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvailSet.Location = new System.Drawing.Point(311, 62);
            this.labelAvailSet.Name = "labelAvailSet";
            this.labelAvailSet.Size = new System.Drawing.Size(18, 25);
            this.labelAvailSet.TabIndex = 8;
            this.labelAvailSet.Text = ".";
            // 
            // labelModelSet
            // 
            this.labelModelSet.AutoSize = true;
            this.labelModelSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModelSet.Location = new System.Drawing.Point(311, 37);
            this.labelModelSet.Name = "labelModelSet";
            this.labelModelSet.Size = new System.Drawing.Size(18, 25);
            this.labelModelSet.TabIndex = 7;
            this.labelModelSet.Text = ".";
            // 
            // labelMarkSet
            // 
            this.labelMarkSet.AutoSize = true;
            this.labelMarkSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarkSet.Location = new System.Drawing.Point(311, 9);
            this.labelMarkSet.Name = "labelMarkSet";
            this.labelMarkSet.Size = new System.Drawing.Size(18, 25);
            this.labelMarkSet.TabIndex = 6;
            this.labelMarkSet.Text = ".";
            // 
            // textBoxDefectSet
            // 
            this.textBoxDefectSet.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDefectSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDefectSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDefectSet.Location = new System.Drawing.Point(316, 112);
            this.textBoxDefectSet.Multiline = true;
            this.textBoxDefectSet.Name = "textBoxDefectSet";
            this.textBoxDefectSet.ReadOnly = true;
            this.textBoxDefectSet.Size = new System.Drawing.Size(200, 302);
            this.textBoxDefectSet.TabIndex = 11;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(132, 220);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(173, 46);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(132, 168);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(173, 46);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(132, 272);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(173, 46);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // TechnicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 435);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.textBoxDefectSet);
            this.Controls.Add(this.labelDatePrepairSet);
            this.Controls.Add(this.labelAvailSet);
            this.Controls.Add(this.labelModelSet);
            this.Controls.Add(this.labelMarkSet);
            this.Controls.Add(this.labelDefect);
            this.Controls.Add(this.labelDateRepair);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelMark);
            this.Name = "TechnicList";
            this.Text = "Список техники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelDateRepair;
        private System.Windows.Forms.Label labelDefect;
        private System.Windows.Forms.Label labelDatePrepairSet;
        private System.Windows.Forms.Label labelAvailSet;
        private System.Windows.Forms.Label labelModelSet;
        private System.Windows.Forms.Label labelMarkSet;
        private System.Windows.Forms.TextBox textBoxDefectSet;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}