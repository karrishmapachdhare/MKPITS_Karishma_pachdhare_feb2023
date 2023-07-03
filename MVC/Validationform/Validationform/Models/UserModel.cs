using System.ComponentModel.DataAnnotations;

namespace Validationform.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }

        
    } 

}
