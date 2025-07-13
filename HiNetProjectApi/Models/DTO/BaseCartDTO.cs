using HiNetProjectApi.Models.Domain;

namespace HiNetProjectApi.Models.DTO
{
    public class BaseCartDTO
    {
        public string UserId { get; set; }
        public float TotalPrice { get; set; }
    }
}
