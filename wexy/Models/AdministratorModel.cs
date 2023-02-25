using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace wexy.Models
{
    class AdministratorModel
    {
        //Fields

        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string userName;
        private string password;

        //Properties
        public int Id { get => id; set => id = value; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be atleast 3 characters")]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be atleast 3 characters")]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Email must be atleast 5 characters")]
        public string Email { get => email; set => email = value; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "User Name must be atleast 5 characters")]
        public string UserName { get => userName; set => userName = value; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must be atleast 5 characters")]
        public string Password { get => password; set => password = value; }
    }
}
