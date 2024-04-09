using ATL_CF_NoSql_Redis_DAL.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATL_CF_NoSql_Redis_DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }    
        public UserGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set;}
        public string Email { get; set;}
        public string Password { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }


    }
}
