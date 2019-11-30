using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstMigration.Context
{
    public class Issues
    {
        public int IssuesId { get; set; }
        public string Subject { get; set; }
        public List<Status> StatusId { get; set; }
        public string Description { get; set; }
        public int AssignedTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Tags { get; set; }
    }
}
