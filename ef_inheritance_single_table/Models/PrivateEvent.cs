using System;

namespace ef_inheritance_single_table.Models
{
    public class PrivateEvent : Event
    {
        public Guid ProjectActivityId { get; set; }
        public ProjectActivity ProjectActivity { get; set; }
    }
}