using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;


namespace Helperland.ViewModel
{
    public class createviewmodel
    {
        [Required(ErrorMessage ="First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Must contain at least 8 characters(at least 1 uppercase letter, 1 lowercase letter, and 1 number)")]
        public string Password { get; set; }
        [Required(ErrorMessage ="mobile number is required")]
        public string Mobile { get; set;}

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="password and confirm password does not match")]
        public string Confirmpassword { get; set; }
        
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


        [Required(ErrorMessage ="Required field")]
        public bool Ischecked { get; set; }


        
    }
}
