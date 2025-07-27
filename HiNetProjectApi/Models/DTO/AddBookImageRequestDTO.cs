using System.ComponentModel.DataAnnotations.Schema;

namespace HiNetProjectApi.Models.DTO
{
    public class AddBookImageRequestDTO
    {
        public Guid BookId { get; set; }
        public IFormFile File { get; set; }
        public string? FileDescription { get; set; }
        public bool IsMain { get; set; } = false;
    }
}
