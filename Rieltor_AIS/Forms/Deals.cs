using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;

namespace Rieltor_AIS
{
    public partial class Deals : NavigationTemplate
    {
        private DateTimePicker cellDateTimePicker;
        public Deals()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(250, 250);
            conn.Open();
            adapter = new NpgsqlDataAdapter("SELECT * FROM \"deals\"", conn);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // choose from calendar when you press on cell with date
            // dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cellDateTimePicker = new DateTimePicker();
            this.cellDateTimePicker.ValueChanged += new EventHandler(cellDateTimePickerValueChanged);
            this.cellDateTimePicker.Visible = false;
            this.dataGridView1.Controls.Add(cellDateTimePicker);
         
            if (e.ColumnIndex == 1)

            {

                Rectangle tempRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                cellDateTimePicker.Location = tempRect.Location;

                cellDateTimePicker.Width = tempRect.Width;

                cellDateTimePicker.Visible = true;

            }
        }
        void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = cellDateTimePicker.Value.ToString();//convert the date as per your format
            cellDateTimePicker.Visible = false;
        }
    }
}