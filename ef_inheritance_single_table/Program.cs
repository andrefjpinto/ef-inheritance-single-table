using System;
using System.Collections.Generic;
using System.IO.Compression;
using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_inheritance_single_table
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                
                
                var activity = new Activity
                {
                    Name = "Activity 1"
                };
                
                var project = new Project
                {
                    Name = "Test 1",
                };

                var projectActivity = new ProjectActivity
                {
                    Project = project,
                    Activity = activity
                };
                
                db.Projects.Add(project);
                db.Activities.Add(activity);
                db.ProjectActivities.Add(projectActivity);
                
                
                db.PrivateEvents.Add(new PrivateEvent()
                {
                    Name = "Private Event",
                    ProjectActivity = projectActivity
                });
                
                db.AdHocEvents.Add(new AdHocEvent
                {
                    Name = "AdHoc Event",
                    ProjectActivity = projectActivity
                });

                
                var count = db.SaveChanges();
                
//                Console.WriteLine("{0} records saved to database", count);
//
//                Console.WriteLine();
//                Console.WriteLine("All projects in database:");
//                foreach (var p in db.Projects.Include(x => x.ProjectActivities))
//                {
//                    Console.WriteLine(p.ProjectActivities.Count);
//                    Console.WriteLine("{0} - {1}", p.Id, p.Name);
//                }
                
            }
        }
    }
}
