using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Speed_Up_App
{
    public partial class Raporty : Form
    {
        public Raporty()
        {
            InitializeComponent();
        }

        private void btn_menuraporty_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Raporty_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Reservation.clientList.Count; i++)
            {
                    int index = dataGridView1.Rows.Add();

                    dataGridView1.Rows[index].Cells[0].Value = Reservation.clientList[i].name;
                    dataGridView1.Rows[index].Cells[1].Value = Reservation.clientList[i].address;
                    dataGridView1.Rows[index].Cells[2].Value = Reservation.clientList[i].city;
                    dataGridView1.Rows[index].Cells[3].Value = Reservation.clientList[i].pesel;
                    dataGridView1.Rows[index].Cells[4].Value = Reservation.clientList[i].licenceNumber;
                    dataGridView1.Rows[index].Cells[5].Value = Reservation.clientList[i].reserveFrom.ToShortDateString();
                    dataGridView1.Rows[index].Cells[6].Value = Reservation.clientList[i].reserveTo.ToShortDateString();
            }

            for (int i = 0; i < Vehicle.vehicleList.Count; i++)
            {
                if (Vehicle.vehicleList[i].isDamaged)
                {
                    int index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells[0].Value = Vehicle.vehicleList[i].vehicleName;
                    dataGridView2.Rows[index].Cells[1].Value = Vehicle.vehicleList[i].damageInfo;
                }
            }
        }
    }
}
