namespace WebApplication.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public User()
        {
            File = new HashSet<File>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        public EClass Class { get; set; }

        public int XP { get; set; }

        public Guid Login { get; set; }

        public Guid Password { get; set; }

        public virtual ICollection<File> File { get; set; }
    }
}
