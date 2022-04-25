using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contractor
{
    public interface ICompanyRepo
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(Guid CompanyId, bool trackChanges);

    }
}
