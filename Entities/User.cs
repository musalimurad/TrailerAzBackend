using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User:IdentityUser
    {
        



        public string ProfilPhoto { get; set; }

       

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
