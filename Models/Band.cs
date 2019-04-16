namespace FinalProjectCSharp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Band
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Band()
        {
            Customers = new HashSet<Customer>();
        }

        public int BandID { get; set; }

        [StringLength(50)]
        public string BandName { get; set; }

        [StringLength(50)]
        public string MusicalGenre { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public int? BandMemembers { get; set; }

        [StringLength(1)]
        public string InTour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
