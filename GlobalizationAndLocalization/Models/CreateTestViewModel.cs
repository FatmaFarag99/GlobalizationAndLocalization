namespace GlobalizationAndLocalization.Models
{
    using System.ComponentModel.DataAnnotations;
    public class CreateTestViewModel
    {
        [Display(Name = "Name"), Required(ErrorMessage = "Required")]
        public string Name { get; set; }
    }
}
