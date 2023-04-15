using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Up_App
{
    [Serializable]
    class Reservation
    {
        public string name;

        public string address;

        public string city;

        public string pesel;

        public string licenceNumber;

        public int vehicleID;

        public DateTime reserveFrom;

        public DateTime reserveTo;

        public static List<Reservation> clientList = new List<Reservation>();

        public Reservation(string _name, string _address, string _city, string _pesel, string _licenceNumber, int _vehicleID, DateTime _reserveFrom, DateTime _reserveTo)
        {
            name = _name;
            address = _address;
            city = _city;
            pesel = _pesel;
            licenceNumber = _licenceNumber;
            vehicleID = _vehicleID;
            reserveFrom = _reserveFrom;
            reserveTo = _reserveTo;
        }

        public override string ToString()
        {
            return name;
        }

        public static void RemoveReservation(int ID)
        {
            clientList.RemoveAt(ID);
        }

        public static int ReturnVehicleID(int ID)
        {
            return clientList[ID].vehicleID;
        }

    }

    [Serializable]
    class Vehicle
    {
        public string vehicleName;

        public bool isReserved;

        public bool isDamaged;

        public string damageInfo;

        public static List<Vehicle> vehicleList = new List<Vehicle>();

        public Vehicle(string _vehicleName, bool _isReserved, bool _isDamaged, string _damageInfo)
        {
            vehicleName = _vehicleName;
            isReserved = _isReserved;
            isDamaged = _isDamaged;
            damageInfo = _damageInfo;
        }

        public static string ReturnFreeCarsNumber()
        {
            int freeCars = 0;
            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].isReserved != true && vehicleList[i].isDamaged != true)
                {
                    freeCars = freeCars + 1;
                }
            }
            return freeCars.ToString();
        }

        public static void ReserveVehicle(int ID)
        {
            vehicleList[ID].isReserved = true;
        }
        public static void UnReserveVehicle(int ID)
        {
            vehicleList[ID].isReserved = false;
        }
        public static void DamageVehicle(int ID)
        {
            vehicleList[ID].isDamaged = true;
        }
        public static void RepairVehicle(int ID)
        {
            vehicleList[ID].isDamaged = false;
        }
        public static void ChangeDamageInfo(int ID, string damInfo)
        {
            vehicleList[ID].damageInfo = damInfo;
        }
    }
}
