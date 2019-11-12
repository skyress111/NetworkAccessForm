using System;
using System.Collections.Generic;
using System.Text;

namespace NetorkAccesForm.DAL.Entities
{
    public class Request : BaseEntity
    {
        public string UserName { get; set; }
        public string RequestReason { get; set; }
        public DateTime? ExipryDate { get; set; }
        public string RequestedBy { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Notes { get; set; }

        public User User { get; set; }
        public List<RequestedApplication> RequestedApplications { get; set; } = new List<RequestedApplication>();
    }
}
