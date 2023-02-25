using System;
using TestAPI2.Models;

namespace TestAPI2.Repository
{
	public interface ICompanyRepository
	{
        public List<Company> GetCompanies();
    }
}

