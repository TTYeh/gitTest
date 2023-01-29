namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attraction
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Tel { get; set; }

        [Required]
        [StringLength(100)]
        public string Add { get; set; }

        [Required]
        [StringLength(100)]
        public string Town { get; set; }

        [StringLength(250)]
        public string Travellinginfo { get; set; }

        [StringLength(250)]
        public string Opentime { get; set; }

        [StringLength(200)]
        public string Picture1 { get; set; }

        [StringLength(200)]
        public string Picdescribe1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Class { get; set; }

        public short fee { get; set; }

        [StringLength(100)]
        public string feeInf { get; set; }

        public DateTime? Changetime { get; set; }
    }
}
