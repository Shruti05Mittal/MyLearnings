using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaneshAlmirah.Models
{
    public class Worker
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "please provide Name", AllowEmptyStrings = false)]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "please provide Phone No#", AllowEmptyStrings = false)]
        public string PhoneNo { get; set; }
        public string Desination { get; set; }

        public List<WorkType> lstDesination { get; set; }
    }
}