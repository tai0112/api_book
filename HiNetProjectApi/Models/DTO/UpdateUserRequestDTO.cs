﻿namespace HiNetProjectApi.Models.DTO
{
    public class UpdateUserRequestDTO
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
    }
}
