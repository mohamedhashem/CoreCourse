using Contractor;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CompanyRepo : RepoBase<Company> , ICompanyRepo
    {

        public CompanyRepo(RepoContext repoContext) : base(repoContext)
        {

        }
    }
}
