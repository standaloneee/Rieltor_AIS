using System.ComponentModel;

namespace Rieltor_AIS
{
    partial class NavigationTemplate
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Personnel_bt = new System.Windows.Forms.Button();
            this.Main_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(603, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 63);
            this.button4.TabIndex = 7;
            this.button4.Text = "Сделки";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(403, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 63);
            this.button3.TabIndex = 6;
            this.button3.Text = "Недвижимость";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Personnel_bt
            // 
            this.Personnel_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personnel_bt.Location = new System.Drawing.Point(231, 40);
            this.Personnel_bt.Name = "Personnel_bt";
            this.Personnel_bt.Size = new System.Drawing.Size(144, 63);
            this.Personnel_bt.TabIndex = 5;
            this.Personnel_bt.Text = "Сотрудники";
            this.Personnel_bt.UseVisualStyleBackColor = true;
            this.Personnel_bt.Click += new System.EventHandler(this.personnelBt_Click);
            // 
            // Main_bt
            // 
            this.Main_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_bt.Location = new System.Drawing.Point(53, 40);
            this.Main_bt.Name = "Main_bt";
            this.Main_bt.Size = new System.Drawing.Size(144, 63);
            this.Main_bt.TabIndex = 4;
            this.Main_bt.Text = "Главная";
            this.Main_bt.UseVisualStyleBackColor = true;
            this.Main_bt.Click += new System.EventHandler(this.mainBt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 111);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добро пожаловать в систему!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBt
            // 
            this.exitBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBt.Location = new System.Drawing.Point(644, 375);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(144, 63);
            this.exitBt.TabIndex = 9;
            this.exitBt.Tag = "штш";
            this.exitBt.Text = "Выход";
            this.exitBt.UseVisualStyleBackColor = true;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // NavigationTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Personnel_bt);
            this.Controls.Add(this.Main_bt);
            this.Name = "NavigationTemplate";
            this.Text = "NavigationTemplate";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exitBt;

        public System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Personnel_bt;
        private System.Windows.Forms.Button Main_bt;

        #endregion
    }
}