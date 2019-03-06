using System;

namespace ef_inheritance_single_table.Models
{
    public abstract class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}