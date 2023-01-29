namespace Ispan_midProject_BllLib47.EF_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItineraryDetail
    {
        public int id { get; set; }

        public int AttractionsID { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal unitprice { get; set; }

        [Column(TypeName = "money")]
        public decimal partialprice { get; set; }

        public virtual Itinerary Itinerary { get; set; }

        public virtual ItineraryDetail ItineraryDetails1 { get; set; }

        public virtual ItineraryDetail ItineraryDetail1 { get; set; }
    }
}
