using System;
using System.Collections.Generic;
using System.Text;

namespace NetorkAccesForm.DAL.Entities
{
    public class Application : BaseEntity
    {
        public string Name { get; set; }

        public List<RequestedApplication> RequestedApplications { get; set; } = new List<RequestedApplication>();
    }
}
