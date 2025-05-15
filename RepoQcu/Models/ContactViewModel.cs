using System.ComponentModel.DataAnnotations;

namespace RepoQcu.Models
{
    public class ContactViewModel
    {
        private string phone;

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public required string Email { get; set; }

        public ContactViewModel(string phone)
        {
            Phone = phone;
        }

        [Phone(ErrorMessage = "Enter a valid phone number.")]
        public string Phone { get => phone; set => phone = value; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }
    }
}
