using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Speed_Up_App
{
    public partial class Zwrot : Form
    {
        public Zwrot()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_zwrot_cofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_zwrot_Click(object sender, EventArgs e)
        {
            int vehID = Reservation.ReturnVehicleID(domainUpDown1.SelectedIndex);
            Vehicle.UnReserveVehicle(vehID);
            if (checkBox1.Checked)
            {
                Vehicle.DamageVehicle(vehID);
                Vehicle.ChangeDamageInfo(vehID, textBox1.Text);
            }

            Reservation.RemoveReservation(domainUpDown1.SelectedIndex);

            domainUpDown1.Items.Clear();
            for (int i = 0; i < Reservation.clientList.Count; i++)
            {
                domainUpDown1.Items.Add(Reservation.clientList[i].name);
            }

            MessageBox.Show("Zwrot został uwzględniony");
        }

        private void Zwrot_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Reservation.clientList.Count; i++)
            {
                domainUpDown1.Items.Add(Reservation.clientList[i].name);
            }
        }
    }
}
