namespace DatabaseFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        public int IdComment { get; set; }

        public int? IdUser { get; set; }

        [Column("Comment")]
        [StringLength(300)]
        public string Comment1 { get; set; }

        public virtual Users Users { get; set; }
    }
}
