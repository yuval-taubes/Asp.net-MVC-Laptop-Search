using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.ViewModels
{
    public class CreateBrandViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
