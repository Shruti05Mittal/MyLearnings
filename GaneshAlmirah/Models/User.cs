namespace GaneshAlmirah
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public  class User
    {
        [Key]
        [StringLength(100)]
        [Required(ErrorMessage ="please provide username",AllowEmptyStrings =false)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
       
        public string Password { get; set; }
    }
}
