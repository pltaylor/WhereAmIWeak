using System.ComponentModel.DataAnnotations;

namespace WhereAmIWeak.Models
{
	public class ExternalLoginConfirmationViewModel
	{
		[Required]
		[Display(Name = "User name")]
		public string UserName { get; set; }
	}
}