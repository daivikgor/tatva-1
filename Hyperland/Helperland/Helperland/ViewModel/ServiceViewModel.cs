using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Helperland.ViewModel
{
    public class ServiceViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "password must be more than eigth characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "mobile number is required")]
        public string Mobile { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "password and confirm password does not match")]
        public string Confirmpassword { get; set; }
        public int? UserTypeId { get; set; }
        public bool? IsRegisteredUser { get; set; }
        public bool? WorksWithPets { get; set; }
        public int? LanguageId { get; set; }
        public int? NationalityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool Terms { get; set; }
        [Required(ErrorMessage = "Required")]
        public bool Privacy { get; set; }
    }
}
