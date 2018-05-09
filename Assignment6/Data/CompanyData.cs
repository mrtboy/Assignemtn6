using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Models;

namespace Assignment6.Data
{
    public class CompanyData : ICompanyData
    {
        string path = String.Format(@".\{0}.xml", "Company");
        public string AddNewCompany(Company company)
        {
            List<Company> companies = new List<Company>();
            if (File.Exists(path))
            {
                companies = XMLReadWrite.ReadXML<List<Company>>(path);
            }

            companies.Add(company);
            return XMLReadWrite.WriteXML<List<Company>>(companies, path);
        }

        public string DeleteCompany(int id)
        {
            List<Company> newCompanies = new List<Company>();
            List<Company> companies = XMLReadWrite.ReadXML<List<Company>>(path);
            foreach (Company c in companies)
            {
                if (c.Id != id)
                {
                    newCompanies.Add(c);
                }
            }
            XMLReadWrite.WriteXML<List<Company>>(newCompanies, path);
            return "";
        }

        public List<Company> GetCompanies()
        {
            return XMLReadWrite.ReadXML<List<Company>>(path);
        }

        public string UpdateCompany(Company company)
        {
            List<Company> newCompanies = new List<Company>();
            List<Company> companies = XMLReadWrite.ReadXML<List<Company>>(path);
            foreach (Company c in companies)
            {
                if (c.Id != company.Id)
                {
                    newCompanies.Add(c);
                }
            }
            return "";
        }
    }
}
