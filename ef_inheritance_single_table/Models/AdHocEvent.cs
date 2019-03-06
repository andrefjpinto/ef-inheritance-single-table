using System;

namespace ef_inheritance_single_table.Models
{
    public class AdHocEvent : Event
    {
        public Guid ProjectActivityId { get; set; }
        public bool? IsCentrallyCreated { get; set; }
        
        public ProjectActivity ProjectActivity { get; set; }
    }
}