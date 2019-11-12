using System;
using System.Collections.Generic;
using System.Text;

namespace NetorkAccesForm.DAL.Entities
{
    public class RequestedApplication : BaseEntity
    {
        public int RequestId { get; set; }
        public int ApplicationId { get; set; }
        public string Description { get; set; }

        public Request Request { get; set; }
        public Application Application { get; set; }
    }
}
