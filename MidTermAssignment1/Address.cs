using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment1
{
    class Address
    {
        private int roadNo, houseNo;
        private string city, country;

        public Address(int roadNo, int houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }


        public int RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public int HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address:Road No-{0}, House No-{1}, City-{2}, Country-{3}", this.roadNo, this.houseNo, this.city, this.country);
        }
    }
}
