using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace HiNetProjectApi.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string FullName { get; set; }
        //Navigator property
        [JsonIgnore]
        public Cart Cart { get; set; }
    }
}
