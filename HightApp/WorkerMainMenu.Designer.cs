namespace HightApp
{
    partial class WorkerMainMenu
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 93);
            this.button4.TabIndex = 11;
            this.button4.Text = "просмотр доступной техники";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(151, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 93);
            this.button3.TabIndex = 10;
            this.button3.Text = "просмотр назначений на работу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(166, 10);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(70, 25);
            this.userName.TabIndex = 13;
            this.userName.Text = "label2";
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info1.Location = new System.Drawing.Point(9, 10);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(151, 25);
            this.info1.TabIndex = 12;
            this.info1.Text = "Вы вошли как";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(297, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 93);
            this.button1.TabIndex = 14;
            this.button1.Text = "выйти из профиля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 149);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "WorkerMainMenu";
            this.Text = "WorkerMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Button button1;
    }
}