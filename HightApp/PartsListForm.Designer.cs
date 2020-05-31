namespace HightApp
{
    partial class PartsListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPartButton = new System.Windows.Forms.Button();
            this.delitePartBtn = new System.Windows.Forms.Button();
            this.editPartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.Mark,
            this.Model,
            this.Description,
            this.Remains,
            this.Prise});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(659, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // PartId
            // 
            this.PartId.DataPropertyName = "PartId";
            this.PartId.HeaderText = "Инв №";
            this.PartId.Name = "PartId";
            // 
            // Mark
            // 
            this.Mark.DataPropertyName = "Mark";
            this.Mark.HeaderText = "Название";
            this.Mark.Name = "Mark";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // Remains
            // 
            this.Remains.DataPropertyName = "Remains";
            this.Remains.HeaderText = "Остаток(шт\\л)";
            this.Remains.Name = "Remains";
            // 
            // Prise
            // 
            this.Prise.DataPropertyName = "Prise";
            this.Prise.HeaderText = "Стоимость";
            this.Prise.Name = "Prise";
            // 
            // addPartButton
            // 
            this.addPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPartButton.Location = new System.Drawing.Point(12, 251);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(122, 42);
            this.addPartButton.TabIndex = 1;
            this.addPartButton.Text = "Добавить";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // delitePartBtn
            // 
            this.delitePartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delitePartBtn.Location = new System.Drawing.Point(557, 251);
            this.delitePartBtn.Name = "delitePartBtn";
            this.delitePartBtn.Size = new System.Drawing.Size(114, 42);
            this.delitePartBtn.TabIndex = 2;
            this.delitePartBtn.Text = "Удалить";
            this.delitePartBtn.UseVisualStyleBackColor = true;
            this.delitePartBtn.Click += new System.EventHandler(this.DelitePartBtn_Click);
            // 
            // editPartBtn
            // 
            this.editPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPartBtn.Location = new System.Drawing.Point(140, 251);
            this.editPartBtn.Name = "editPartBtn";
            this.editPartBtn.Size = new System.Drawing.Size(125, 42);
            this.editPartBtn.TabIndex = 3;
            this.editPartBtn.Text = "Изменить";
            this.editPartBtn.UseVisualStyleBackColor = true;
            this.editPartBtn.Click += new System.EventHandler(this.EditPartBtn_Click);
            // 
            // PartsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 305);
            this.Controls.Add(this.editPartBtn);
            this.Controls.Add(this.delitePartBtn);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartsListForm";
            this.Text = "PartsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remains;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prise;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button delitePartBtn;
        private System.Windows.Forms.Button editPartBtn;
    }
}