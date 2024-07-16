using System.ComponentModel.DataAnnotations;

namespace rgInfra.ViewModel.Usuario
{
	public class LoginApiViewModel
	{
		public class RequestLogin
		{
            [Required(ErrorMessage = "Email de login é obrigatório!!")]
            public string login { get; set; }
            [Required(ErrorMessage = "Campo senha deve ser preenchido")]
			public string senha { get; set; }
		}

		public class ResponseLogin
		{
			public string accessToken { get; set; }
			public string refreshToken { get; set; }
			public string description { get; set; }
		}
	}
}
