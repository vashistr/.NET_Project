using System;
using Microsoft.EntityFrameworkCore;
using TestAPI2.Models;

namespace TestAPI2.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        public CompanyRepository()
        {
            using (var context = new ApiContext())
            {
                var companies = new List<Company>
                {
                    new Company
                    {
                        CompanyName ="Honda",
                        Country = "Japan",
                        Cars = new List<Car>()
                        {
                            new Car { CarName = "Civic"},
                            new Car { CarName = "City"},
                            new Car { CarName = "CRV"}
                        }
                    },
                    new Company
                    {
                        CompanyName ="BMW",
                        Country = "Germany",
                        Cars = new List<Car>()
                        {
                            new Car { CarName = "Z4"},
                            new Car { CarName = "7 Series"},
                            new Car { CarName = "GT"}
                        }
                    },
                };
                context.Company.AddRange(companies);
                context.SaveChanges();
            }
        }

        public List<Company> GetCompanies()
        {
            using (var context = new ApiContext())
            {
                var list = context.Company
                    .Include(a => a.Cars)
                    .ToList();
                return list;
            }
        }
    }
}

