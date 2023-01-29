namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KeyPair
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string PublicKeys { get; set; }

        [Required]
        [StringLength(100)]
        public string PrivateKeys { get; set; }

        public virtual KeyPair KeyPairs1 { get; set; }

        public virtual KeyPair KeyPair1 { get; set; }
    }
}
