using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLogger.Entities
{
    [Table("Candidate")]
    public class Candidate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CandidateId { get; set; }
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public int RecluterUserId { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset Created { get; set; }
        [Required]
        [MaxLength(10)]
        public string CreatedBy { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        [Required]
        [MaxLength(10)]
        public string LastUpdatedBy { get; set; }
    }
}
