using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data
{
    interface ICompanyData
    {
        string AddNewCompany(Company ccompany);
        List<Company> GetCompanies();
        string UpdateCompany(Company company);
        string DeleteCompany(int id);
    }
}

