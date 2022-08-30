using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naziv je obavezan")]
        public string Name { get; set; }
    }
}
