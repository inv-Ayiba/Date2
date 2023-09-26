using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    // [Keyless]
    public class AppUser
    {
      // [Key]
      public int Id { get; set; } 
      public string UserName { get; set; } 

      public byte[] PasswordHash { get; set; } 

      public byte[] PasswordSalt { get; set; } 

    }

    
}

