namespace FinalProjectCSharp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        public int? BandID { get; set; }

        public virtual Band Band { get; set; }
    }
}
