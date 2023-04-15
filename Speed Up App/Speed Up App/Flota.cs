using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Speed_Up_App
{
    public partial class Flota : Form
    {
        public Flota()
        {
            InitializeComponent();
        }

        private void Raporty_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Vehicle.vehicleList.Count; i++)
            {
                listBox1.Items.Add(Vehicle.vehicleList[i].vehicleName);
            }
            label2.Text = Vehicle.ReturnFreeCarsNumber();
        }

        private void btn_menuflota_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle.vehicleList.Add(new Vehicle(textBox1.Text, false, false, null));
            listBox1.Items.Clear();
            for (int i = 0; i < Vehicle.vehicleList.Count; i++)
            {
                listBox1.Items.Add(Vehicle.vehicleList[i].vehicleName);
            }
            textBox1.Text = "Nazwa samochodu";
            MessageBox.Show("Pojazd został dodany");
        }
    }
}
