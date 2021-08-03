using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerBookApplication.Data
{
    public class Category
    {

        [Key]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "This needs to be longer.")]
        [Display(Name = "Name Token", Description = "Category  Name")]
        [Required(ErrorMessage = "Nake Token is Required", AllowEmptyStrings = false)]
    

        public string NameToken { get; set; }


        [StringLength(200, MinimumLength = 10, ErrorMessage = "This needs to be longer.")]
        [Display(Name = "Category Description")]
        public string Decription { get; set; }


        public ICollection<CategoryType> CategoryType { get; set; }
    }
}
