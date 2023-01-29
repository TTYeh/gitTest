namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IDX { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(30)]
        public string Account { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public DateTime PublishedTimes { get; set; }

        public DateTime? LastReviewTimes { get; set; }

        public DateTime? BannedTimes { get; set; }

        public DateTime? BannedFinishTimes { get; set; }

        [Required]
        [StringLength(50)]
        public string Posttypes { get; set; }

        [Required]
        [StringLength(50)]
        public string Classification { get; set; }

        public int TitleID { get; set; }

        public virtual Content001 Content001 { get; set; }
    }
}
