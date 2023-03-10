using System.ComponentModel.DataAnnotations;

namespace CinemaApiSql.Dtos
{
    public class ChangeDirectorDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
