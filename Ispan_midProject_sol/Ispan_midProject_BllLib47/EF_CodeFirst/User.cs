namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
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

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string MembershipRole { get; set; }

        public DateTime DateOfRegister { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(10)]
        public string StarSign { get; set; }

        [StringLength(30)]
        public string Relationship { get; set; }

        [StringLength(50)]
        public string IconPhoto { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [StringLength(100)]
        public string PublicKey { get; set; }

        public virtual User Users1 { get; set; }

        public virtual User User1 { get; set; }
    }
}
