using System;
namespace TestAPI2.Models
{
	public class Company
	{
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        //public List<Car> Cars { get; set; }

        public Company()
        {

        }

        public Company(string CompanyName, string Country, List<Car> Cars)
        {
            this.CompanyName = CompanyName;
            this.Country = Country;
            //this.Cars = Cars;
        }
	}
}

