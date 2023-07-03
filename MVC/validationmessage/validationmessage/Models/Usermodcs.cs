using System.ComponentModel.DataAnnotations;

namespace validationmessage.Models
{
    public class Usermodcs
    {
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        public string UserName { get; set; }
    }
}
