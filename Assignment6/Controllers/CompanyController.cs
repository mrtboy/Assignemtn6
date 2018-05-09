using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Data;
using Assignment6.Models;

namespace Assignment6.Controllers
{
    public class CompanyController : ICompanyController
    {
        ICompanyData data;

        public CompanyController()
        {
            data = new CompanyData();
        }

        public string AddNewCompany(Company company)
        {
            return data.AddNewCompany(company);
        }

        public string DeleteCompany(int id)
        {
            return data.DeleteCompany(id);
        }

        public string EditCompany(Company company)
        {
            return data.UpdateCompany(company);
        }

        public List<Company> GetCompanies()
        {
            return data.GetCompanies();
        }
    }
}
