using System;
using System.Collections.Generic;

namespace ef_inheritance_single_table.Models
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProjectActivity> ProjectActivities { get; set; }
    }
}