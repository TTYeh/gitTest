namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttractionsOpendata")]
    public partial class AttractionsOpendata
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Zone { get; set; }

        [Required]
        [StringLength(2000)]
        public string Toldescribe { get; set; }

        [StringLength(450)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string Add { get; set; }

        [StringLength(10)]
        public string Zipcode { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(250)]
        public string Travellinginfo { get; set; }

        [StringLength(250)]
        public string Opentime { get; set; }

        [StringLength(200)]
        public string Picture1 { get; set; }

        [StringLength(200)]
        public string Picdescribe1 { get; set; }

        [StringLength(200)]
        public string Picture2 { get; set; }

        [StringLength(200)]
        public string Picdescribe2 { get; set; }

        [StringLength(200)]
        public string Picture3 { get; set; }

        [StringLength(200)]
        public string Picdescribe3 { get; set; }

        [StringLength(100)]
        public string Map { get; set; }

        [StringLength(50)]
        public string Gov { get; set; }

        public double Px { get; set; }

        public double Py { get; set; }

        [StringLength(50)]
        public string Orgclass { get; set; }

        [Required]
        [StringLength(50)]
        public string Class1 { get; set; }

        [StringLength(50)]
        public string Class2 { get; set; }

        [StringLength(50)]
        public string Class3 { get; set; }

        [StringLength(50)]
        public string Level { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        [StringLength(100)]
        public string Parkinginfo { get; set; }

        public double? Parkinginfo_Px { get; set; }

        public double? Parkinginfo_Py { get; set; }

        [StringLength(100)]
        public string Ticketinfo { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string Keyword { get; set; }

        public DateTime? Changetime { get; set; }
    }
}
