namespace BzDemo1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public Order()
        {
            Details = new HashSet<Detail>();
        }

        public int OrderID { get; set; }

        public int CustID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DropDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PickDate { get; set; }

        public virtual Customer Customer { get; set; }

        //Navigation

        public virtual ICollection<Detail> Details { get; set; }
    }
}
