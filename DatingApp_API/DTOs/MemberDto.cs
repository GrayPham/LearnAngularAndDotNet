using DatingApp_API.Entities;
using System.Collections.Generic;
using System;

namespace DatingApp_API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string PhotoUrl { get; set; }
        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Coutry { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}
