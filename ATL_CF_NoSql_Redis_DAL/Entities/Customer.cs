using ATL_CF_NoSql_Redis_DAL.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATL_CF_NoSql_Redis_DAL.Entities
{
    public class Customer : User
    {
        public PlatformRank PlatformRank { get; set; } = PlatformRank.Bronze;
        public UserRole Role { get; set; } = UserRole.Customer;
    }
}
