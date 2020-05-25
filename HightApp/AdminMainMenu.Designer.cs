namespace HightApp
{
    partial class AdminMainMenu
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
            this.info1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button_reg_new_user = new System.Windows.Forms.Button();
            this.button_delete_user = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info1.Location = new System.Drawing.Point(29, 19);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(151, 25);
            this.info1.TabIndex = 0;
            this.info1.Text = "Вы вошли как";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.Location = new System.Drawing.Point(202, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(70, 25);
            this.userName.TabIndex = 1;
            this.userName.Text = "label2";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(526, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 26);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button_reg_new_user
            // 
            this.button_reg_new_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reg_new_user.Location = new System.Drawing.Point(312, 289);
            this.button_reg_new_user.Name = "button_reg_new_user";
            this.button_reg_new_user.Size = new System.Drawing.Size(240, 103);
            this.button_reg_new_user.TabIndex = 3;
            this.button_reg_new_user.Text = "зарегестировать нового пользователя";
            this.button_reg_new_user.UseVisualStyleBackColor = true;
            this.button_reg_new_user.Click += new System.EventHandler(this.button_reg_new_user_Click);
            // 
            // button_delete_user
            // 
            this.button_delete_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_user.Location = new System.Drawing.Point(312, 178);
            this.button_delete_user.Name = "button_delete_user";
            this.button_delete_user.Size = new System.Drawing.Size(240, 105);
            this.button_delete_user.TabIndex = 4;
            this.button_delete_user.Text = "удалить пользователя";
            this.button_delete_user.UseVisualStyleBackColor = true;
            this.button_delete_user.Click += new System.EventHandler(this.button_delete_user_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 111);
            this.button4.TabIndex = 9;
            this.button4.Text = "просмотр доступной техники";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 103);
            this.button3.TabIndex = 8;
            this.button3.Text = "просмотр назначений на работу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 105);
            this.button2.TabIndex = 7;
            this.button2.Text = "просмотр списка сотрудников";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_delete_user);
            this.Controls.Add(this.button_reg_new_user);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainMenu";
            this.Text = "AdminMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button_reg_new_user;
        private System.Windows.Forms.Button button_delete_user;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}