using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewEpam.BusinessEntities
{
    public class Phone : Entity
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Price { get; set; }
    }
}