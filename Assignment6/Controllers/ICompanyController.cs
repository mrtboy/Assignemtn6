using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Controllers
{
    public interface ICompanyController
    {
        string AddNewCompany(Company company);
        string EditCompany (Company company);
        List<Company> GetCompanies();
        string DeleteCompany(int id);
    }
}
