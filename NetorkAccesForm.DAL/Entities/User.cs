using System;
using System.Collections.Generic;
using System.Text;

namespace NetorkAccesForm.DAL.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public int EmployeeNo { get; set; }
        public int DepartmentId { get; set; }
        public string TitleJob { get; set; }
        public string Phone { get; set; }

        public City City { get; set; }
        public Department Department { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();
    }
}
