namespace dryHobi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Photo
    {
        public int ID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(250)]
        public string FullPath { get; set; }

        [StringLength(250)]
        public string MiddlePath { get; set; }

        [StringLength(250)]
        public string SmallPath { get; set; }

        public byte? SquenceNo { get; set; }

        public bool? isActive { get; set; }

        public DateTime? UploadDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
