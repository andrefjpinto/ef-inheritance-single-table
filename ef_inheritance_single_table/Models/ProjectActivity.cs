using System;
using System.Collections.Generic;

namespace ef_inheritance_single_table.Models
{
    public class ProjectActivity
    {
        public Guid Id { get; set; }
        
        public Guid ProjectId { get; set; }
        public Guid ActivityId { get; set; }
        
        public virtual Project Project { get; set; }
        public virtual Activity Activity { get; set; }
        public ICollection<PrivateEvent> PrivateEvents { get; set; }
        public ICollection<AdHocEvent> AdHocEvents { get; set; }
    }
}