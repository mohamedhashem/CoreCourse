using System;
using System.Collections.Generic;
using System.Text;

namespace Contractor
{
    public interface IRepoManager
    {
        ICompanyRepo Company { get; }
        IEmployeeRepo Employee { get; }

        void Save();
    }
}
