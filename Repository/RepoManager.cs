using Contractor;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepoManager : IRepoManager
    {
        private RepoContext _repoContext;
        private ICompanyRepo _companyRepo;
        private IEmployeeRepo _employeeRepo;

        public RepoManager(RepoContext repoContext) 
        {
            _repoContext = repoContext;
        }
        public ICompanyRepo Company
        {
            get
            {
                if (_companyRepo == null) _companyRepo = new CompanyRepo(_repoContext);
                return _companyRepo;
            }
        }


        public IEmployeeRepo Employee
        {
            get
            {
                if (_employeeRepo == null) _employeeRepo = new EmployeeRepo(_repoContext);
                return _employeeRepo;
            }
        }


        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
