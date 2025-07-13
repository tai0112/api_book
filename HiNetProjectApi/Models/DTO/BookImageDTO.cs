using HiNetProjectApi.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiNetProjectApi.Models.DTO
{
    public class BookImageDTO
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FilePath { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInBytes { get; set; }
        public bool IsMain { get; set; } = false;
        public Book Book { get; set; }
    }
}
