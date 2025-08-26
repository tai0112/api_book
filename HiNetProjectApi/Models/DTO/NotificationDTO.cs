namespace HiNetProjectApi.Models.DTO
{
    public class NotificationDTO
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
    }
}
