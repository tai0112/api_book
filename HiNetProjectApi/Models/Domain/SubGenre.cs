using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HiNetProjectApi.Models.Domain
{
    public class SubGenre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid GenreId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        [JsonIgnore]
        public Genre Genre { get; set; }
    }
}
