using ATL_CF_NoSql_Redis_DAL.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATL_CF_NoSql_Redis_DAL.Entities
{
    public class Artist : User
    {
        public decimal? Rating { get; set; }
        public UserRole Role { get; set; } = UserRole.Artist;
    }
}
