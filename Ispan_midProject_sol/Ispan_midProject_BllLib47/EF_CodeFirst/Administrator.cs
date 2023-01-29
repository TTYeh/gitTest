namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administrator
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Account { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string PublicKey { get; set; }
    }
}
