using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLogger.Entities
{
    [Table("LogMessage")]
    public class LogMessage
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogMessageId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Message { get; set; }
        [Required]
        [MaxLength(1)]
        public char MessageKind { get; set; }
        [Required]
        [MaxLength(1)]
        public string ContextKind { get; set; }
        [Required]
        public DateTimeOffset Created { get; set; }
        [Required]
        [MaxLength(10)]
        public string CreatedBy { get; set; }
    }
}
