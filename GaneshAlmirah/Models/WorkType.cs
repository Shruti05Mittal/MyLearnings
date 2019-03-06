using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaneshAlmirah.Models
{
    public class WorkType
    {
        public int DesiginationId { get; set; }
        [Required(ErrorMessage = "please provide Name", AllowEmptyStrings = false)]
        public string Desgination { get; set; }
    }
}