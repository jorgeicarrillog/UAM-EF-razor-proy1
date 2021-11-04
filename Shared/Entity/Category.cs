using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Proy1.Shared.Entity
{
    public class Category
    {
        public int Id{get;set;}
        [Required(ErrorMessage="El {0} es requerido")]
        public string Name{get;set;}
        public List<CategoryMovie> CategoryMovie {get;set;}
    }
}