using static rgInfra.ViewModel.Usuario.LoginApiViewModel;

namespace rgInfra.Controller.Usuario
{
    public class LoginController
    {
        //public async Task<ResponseLogin> LoginAPI(RequestLogin loginApiViewModel)
        //{
        //    try
        //    {
        //        var retorno = new ResponseLogin();
        //        var response = await System.Net.Http.HttpClient.PostAsJsonAsync("api/login", loginApiViewModel);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var result = await response.Content.ReadFromJsonAsync<ResponseLogin>();
        //            // Handle the login response, e.g., store tokens, redirect, etc.
        //            return result;
        //        }
        //        else
        //        {
        //            return null;
        //            // Handle login failure
        //        }

        //        return retorno;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
