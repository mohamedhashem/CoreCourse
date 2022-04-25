using Contractor;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CompanyRepo : RepoBase<Company>, ICompanyRepo
    {

        public CompanyRepo(RepoContext repoContext) : base(repoContext)
        {

        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges).OrderBy(c => c.Name).ToList();

        public Company GetCompany(Guid CompanyId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(CompanyId), trackChanges).SingleOrDefault();

    }
}
