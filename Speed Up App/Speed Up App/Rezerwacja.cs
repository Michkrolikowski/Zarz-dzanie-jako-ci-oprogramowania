using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Speed_Up_App
{
    public partial class Rezerwacja : Form
    {
        public Rezerwacja()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_rezerwuj_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox2.Text != null || textBox3.Text != null || textBox4.Text != null || textBox1.Text != null)
            {
                if (Vehicle.vehicleList[domainUpDown1.SelectedIndex].isReserved != true && Vehicle.vehicleList[domainUpDown1.SelectedIndex].isDamaged != true)
                {
                    Reservation.clientList.Add(new Reservation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, domainUpDown1.SelectedIndex, dateTimePicker1.Value, dateTimePicker2.Value));
                    Vehicle.ReserveVehicle(domainUpDown1.SelectedIndex);

                    MessageBox.Show("Rezerwacja została dodana");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dany pojazd nie jest dostępny na ten moment.");
                }
            }
            else
            {
                MessageBox.Show("Należy uzupełnić wszystkie pola.");
            }
        }

        private void btn_rezerwacja_wroc_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Rezerwacja_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Vehicle.vehicleList.Count; i++)
            {
                domainUpDown1.Items.Add(Vehicle.vehicleList[i].vehicleName);
            }
        }
    }
}
