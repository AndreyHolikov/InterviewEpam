using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewEpam.BusinessEntities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public string Department { get; set; }
        public string Mobileno { get; set; }
        public string City { get; set; }
        public string Age { get; set; }
    }
}