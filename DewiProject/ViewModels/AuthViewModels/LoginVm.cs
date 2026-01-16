using System.ComponentModel.DataAnnotations;

namespace DewiProject.ViewModels.AuthViewModels;

public class LoginVm
{
    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string EmailAddress { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
}
