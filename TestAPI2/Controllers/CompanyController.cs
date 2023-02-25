using System;
using Microsoft.AspNetCore.Mvc;
using TestAPI2.Models;
using TestAPI2.Repository;

namespace TestAPI2.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class CompanyController: ControllerBase
    {
        readonly ICompanyRepository _companyRepository;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger, ICompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }
        
        [HttpGet]
        [Route("/api/getCompanies")]
        public ActionResult<List<Company>> GetCompanies()
        {
            return Ok(_companyRepository.GetCompanies());
        }

        [HttpPost]
        [Route("/api/setCompany")]
        public ActionResult<bool> SetCompany(Company data)
        {
            using (var _context = new ApiContext())
            {
                _context.Company.Add(data);
                _context.SaveChangesAsync();
            }

            return true;
        }


    }
}

