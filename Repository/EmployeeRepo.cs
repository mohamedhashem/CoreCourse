using Contractor;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EmployeeRepo : RepoBase<Employee> , IEmployeeRepo
    {
        public EmployeeRepo(RepoContext repoContext) : base(repoContext)
        {

        }
    }
}
