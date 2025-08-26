namespace HiNetProjectApi.Models.DTO
{
    public class AddRequestNotificationDTO
    {
        public string? UserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; } = false;
    }
}
