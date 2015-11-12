namespace BzDemo1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail
    {
        public int DetailID { get; set; }

        public int OrderID { get; set; }

        public int ItemID { get; set; }

        public decimal Price { get; set; }

        public int Qty { get; set; }

        // Navigation

        public virtual Item Item { get; set; }

        public virtual Order Order { get; set; }
    }
}
