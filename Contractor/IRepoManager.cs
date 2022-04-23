using System;
using System.Collections.Generic;
using System.Text;

namespace Contractor
{
    public interface IRepoManager
    {
        ICompanyRepo company { get; }
        IEmployeeRepo employee { get; }

        void Save();
    }
}
