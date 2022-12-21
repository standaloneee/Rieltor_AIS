using System.ComponentModel;

namespace Rieltor_AIS
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.surname_TextBox = new System.Windows.Forms.TextBox();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.register_Bt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back_Bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(358, 116);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(122, 20);
            this.name_TextBox.TabIndex = 0;
            // 
            // surname_TextBox
            // 
            this.surname_TextBox.Location = new System.Drawing.Point(358, 154);
            this.surname_TextBox.Name = "surname_TextBox";
            this.surname_TextBox.Size = new System.Drawing.Size(122, 20);
            this.surname_TextBox.TabIndex = 1;
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.Location = new System.Drawing.Point(358, 195);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(122, 20);
            this.phone_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(259, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(187, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер телефона";
            // 
            // register_Bt
            // 
            this.register_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_Bt.Location = new System.Drawing.Point(259, 317);
            this.register_Bt.Name = "register_Bt";
            this.register_Bt.Size = new System.Drawing.Size(277, 32);
            this.register_Bt.TabIndex = 7;
            this.register_Bt.Text = "Зарегестрироваться";
            this.register_Bt.UseVisualStyleBackColor = true;
            this.register_Bt.Click += new System.EventHandler(this.register_Bt_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(272, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(358, 267);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(122, 20);
            this.password_TextBox.TabIndex = 8;
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(358, 232);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(122, 20);
            this.login_TextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(283, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Логин";
            // 
            // back_Bt
            // 
            this.back_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_Bt.Location = new System.Drawing.Point(341, 355);
            this.back_Bt.Name = "back_Bt";
            this.back_Bt.Size = new System.Drawing.Size(118, 32);
            this.back_Bt.TabIndex = 12;
            this.back_Bt.Text = "Назад";
            this.back_Bt.UseVisualStyleBackColor = true;
            this.back_Bt.Click += new System.EventHandler(this.back_Bt_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.back_Bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.register_Bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_TextBox);
            this.Controls.Add(this.surname_TextBox);
            this.Controls.Add(this.name_TextBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button back_Bt;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_TextBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button register_Bt;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.TextBox surname_TextBox;
        private System.Windows.Forms.TextBox phone_TextBox;

        #endregion
    }
}