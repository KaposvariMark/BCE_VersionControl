using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName
        {
            get
            {
                return string.Format("{0} {1}",LastName,Firstname);
            }
        
        }

    }
}
