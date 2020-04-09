using System.ComponentModel.DataAnnotations;

namespace yyapp.api.Dtos
{
    public class UserForRegisterDto
    {
            [Required]
            public string Username { get; set; } 
            [StringLength(8,MinimumLength=4,ErrorMessage="كلمة السر لاتقل عن 4 احرف ولاتويد عن 8")]

            public string Password { get; set; }       
    }
}