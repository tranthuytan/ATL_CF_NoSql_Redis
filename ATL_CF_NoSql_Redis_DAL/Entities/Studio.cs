using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATL_CF_NoSql_Redis_DAL.Entities
{
    public class Studio : User
    {
        public string StudioName { get; set; }
        public string TaxCode { get; set; }
        public string OwnerIdNumber { get; set; }
        public byte? City { get; set; }
        public decimal? Rating { get; set; }

    }
}
