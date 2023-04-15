using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace Speed_Up_App
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_rezerwacje_Click(object sender, EventArgs e)
        {
            Rezerwacja rezerwacja = new Rezerwacja();
            rezerwacja.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("vehicleList.dat", FileMode.Open, FileAccess.Read);

                BinaryFormatter bf = new BinaryFormatter();

                Vehicle.vehicleList = (List<Vehicle>)bf.Deserialize(fs);

                fs.Close();

            }
            catch (Exception ex)
            {
                Vehicle.vehicleList.Add(new Vehicle("Nissan Patrol", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Jepp Grand Cherokee", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Jepp Wrangler", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Toyota Land Cruiser", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Mitsubishi Pajero", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Mitsubishi Lancer", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Land Rover Discovery", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Nissan 370z", false, false, null));
                Vehicle.vehicleList.Add(new Vehicle("Suzuki Samurai", false, false, null));
            }

            try
            {
                FileStream fs = new FileStream("clientList.dat", FileMode.Open, FileAccess.Read);

                BinaryFormatter bf = new BinaryFormatter();

                Reservation.clientList = (List<Reservation>)bf.Deserialize(fs);

                fs.Close();

            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Brak pliku clientList.dat - lista rezerwacji będzie pusta.");
            }
        }

        private void button_raporty_Click(object sender, EventArgs e)
        {
            Raporty raporty = new Raporty();
            raporty.Show();
        }

        private void button_flota_Click(object sender, EventArgs e)
        {
            Flota flota = new Flota();
            flota.Show();
        }

        private void button_zwrot_Click(object sender, EventArgs e)
        {
            if (Reservation.clientList.Count == 0)
            {
                MessageBox.Show("Brak rezerwacji na obecny moment.");
            }
            else
            {
                Zwrot zwrot = new Zwrot();
                zwrot.Show();
            }
        }

        private void button_pomoc_Click(object sender, EventArgs e)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.Show();
        }

        private void button_cennik_Click(object sender, EventArgs e)
        {
            Cennik cennik = new Cennik();
            cennik.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fs = new FileStream("vehicleList.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, Vehicle.vehicleList);
            fs.Close();

            FileStream fs2 = new FileStream("clientList.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs2, Reservation.clientList);
            fs2.Close();

            Application.Exit();
        }
    }
}
