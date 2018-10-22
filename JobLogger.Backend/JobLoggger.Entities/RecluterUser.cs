using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLogger.Entities
{
    [Table("RecluterUser")]
    public class RecluterUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecluterUserId { get; set; }
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Created { get; set; }
        [Required]
        [MaxLength(10)]
        public string CreatedBy { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        [Required]
        [MaxLength(10)]
        public string LastUpdatedBy { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
