namespace WebApplication.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("File")]
    public partial class File
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public short Type { get; set; }

        public int Size { get; set; }

        public ERestrict? Restrict { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
