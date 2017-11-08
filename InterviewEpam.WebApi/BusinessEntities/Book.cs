using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewEpam.BusinessEntities
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
        public string Publish_date { get; set; }
        public string Description { get; set; }
    }
}