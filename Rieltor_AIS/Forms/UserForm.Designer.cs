using System.ComponentModel;

namespace Rieltor_AIS
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choose_Bt = new System.Windows.Forms.Button();
            this.back_Bt = new System.Windows.Forms.Button();
            this.exit_Bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите интересующую вас недвижимость";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // choose_Bt
            // 
            this.choose_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_Bt.Location = new System.Drawing.Point(305, 334);
            this.choose_Bt.Name = "choose_Bt";
            this.choose_Bt.Size = new System.Drawing.Size(205, 39);
            this.choose_Bt.TabIndex = 2;
            this.choose_Bt.Text = "Выбрать";
            this.choose_Bt.UseVisualStyleBackColor = true;
            this.choose_Bt.Click += new System.EventHandler(this.choose_Bt_Click);
            // 
            // back_Bt
            // 
            this.back_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_Bt.Location = new System.Drawing.Point(305, 379);
            this.back_Bt.Name = "back_Bt";
            this.back_Bt.Size = new System.Drawing.Size(205, 39);
            this.back_Bt.TabIndex = 3;
            this.back_Bt.Text = "Назад";
            this.back_Bt.UseVisualStyleBackColor = true;
            this.back_Bt.Click += new System.EventHandler(this.back_Bt_Click);
            // 
            // exit_Bt
            // 
            this.exit_Bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_Bt.Location = new System.Drawing.Point(685, 399);
            this.exit_Bt.Name = "exit_Bt";
            this.exit_Bt.Size = new System.Drawing.Size(103, 39);
            this.exit_Bt.TabIndex = 4;
            this.exit_Bt.Text = "Выход";
            this.exit_Bt.UseVisualStyleBackColor = true;
            this.exit_Bt.Click += new System.EventHandler(this.exit_Bt_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_Bt);
            this.Controls.Add(this.back_Bt);
            this.Controls.Add(this.choose_Bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button choose_Bt;
        private System.Windows.Forms.Button back_Bt;
        private System.Windows.Forms.Button exit_Bt;

        #endregion
    }
}