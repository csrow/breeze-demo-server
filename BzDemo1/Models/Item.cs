namespace BzDemo1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public Item()
        {
            Details = new HashSet<Detail>();
        }

        public int ItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        //Navigation

        public virtual ICollection<Detail> Details { get; set; }
    }
}
