namespace HiNetProjectApi.Models.DTO
{
    public class UpdateRequestNotificationDTO
    {
        public string? UserId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
