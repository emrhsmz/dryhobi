namespace dryHobi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ID { get; set; }

        public int? OrderStateID { get; set; }

        public int? CustomerID { get; set; }

        public int? UserID { get; set; }

        public int? AdressID { get; set; }

        public int? ShipperID { get; set; }

        public bool? Cart { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }

        [StringLength(25)]
        public string ShipNumber { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Adress Adress { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual OrderState OrderState { get; set; }

        public virtual Shipper Shipper { get; set; }

        public virtual User User { get; set; }
    }
}
