using System.ComponentModel.DataAnnotations;

namespace CoreAngular4DemoApp.Server.ViewModels
{
    public class UserNameViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
