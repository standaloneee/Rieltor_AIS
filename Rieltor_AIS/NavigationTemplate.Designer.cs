﻿using System.ComponentModel;

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
            this.deals_Bt = new System.Windows.Forms.Button();
            this.Realty_bt = new System.Windows.Forms.Button();
            this.Personnel_bt = new System.Windows.Forms.Button();
            this.Main_bt = new System.Windows.Forms.Button();
            this.exitBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deals_Bt
            // 
            this.deals_Bt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deals_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deals_Bt.Location = new System.Drawing.Point(595, 40);
            this.deals_Bt.Name = "deals_Bt";
            this.deals_Bt.Size = new System.Drawing.Size(144, 63);
            this.deals_Bt.TabIndex = 7;
            this.deals_Bt.Text = "Сделки";
            this.deals_Bt.UseVisualStyleBackColor = true;
            this.deals_Bt.Click += new System.EventHandler(this.deals_Bt_Click);
            // 
            // Realty_bt
            // 
            this.Realty_bt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Realty_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Realty_bt.Location = new System.Drawing.Point(395, 40);
            this.Realty_bt.Name = "Realty_bt";
            this.Realty_bt.Size = new System.Drawing.Size(178, 63);
            this.Realty_bt.TabIndex = 6;
            this.Realty_bt.Text = "Недвижимость";
            this.Realty_bt.UseVisualStyleBackColor = true;
            this.Realty_bt.Click += new System.EventHandler(this.realtyBt_Click);
            // 
            // Personnel_bt
            // 
            this.Personnel_bt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Personnel_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Personnel_bt.Location = new System.Drawing.Point(223, 40);
            this.Personnel_bt.Name = "Personnel_bt";
            this.Personnel_bt.Size = new System.Drawing.Size(144, 63);
            this.Personnel_bt.TabIndex = 5;
            this.Personnel_bt.Text = "Сотрудники";
            this.Personnel_bt.UseVisualStyleBackColor = true;
            this.Personnel_bt.Click += new System.EventHandler(this.personnelBt_Click);
            // 
            // Main_bt
            // 
            this.Main_bt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Main_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_bt.Location = new System.Drawing.Point(45, 40);
            this.Main_bt.Name = "Main_bt";
            this.Main_bt.Size = new System.Drawing.Size(144, 63);
            this.Main_bt.TabIndex = 4;
            this.Main_bt.Text = "Главная";
            this.Main_bt.UseVisualStyleBackColor = true;
            this.Main_bt.Click += new System.EventHandler(this.mainBt_Click);
            // 
            // exitBt
            // 
            this.exitBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBt.Location = new System.Drawing.Point(628, 486);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(144, 63);
            this.exitBt.TabIndex = 9;
            this.exitBt.Tag = "штш";
            this.exitBt.Text = "Выход";
            this.exitBt.UseVisualStyleBackColor = true;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 222);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добро пожаловать в систему!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavigationTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deals_Bt);
            this.Controls.Add(this.Realty_bt);
            this.Controls.Add(this.Personnel_bt);
            this.Controls.Add(this.Main_bt);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "NavigationTemplate";
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button exitBt;

        private System.Windows.Forms.Button deals_Bt;
        private System.Windows.Forms.Button Realty_bt;
        private System.Windows.Forms.Button Personnel_bt;
        private System.Windows.Forms.Button Main_bt;

        #endregion
    }
}