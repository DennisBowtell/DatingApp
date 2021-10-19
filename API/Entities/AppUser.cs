using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Extentions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string UserName { get; set; }
        [MaxLength(200)]
        public byte[] PasswordHash { get; set; }
        [MaxLength(200)]
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(50)]
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        [MaxLength(20)]
        public string Gender { get; set; }
        [MaxLength(2000)]
        public string Introduction { get; set; }
        [MaxLength(2000)]
        public string LookingFor { get; set; }
        [MaxLength(2000)]
        public string Interests { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

        // public int GetAge()
        // {
        //     return  DateOfBirth.CalculateAge();
        // }

    }
}