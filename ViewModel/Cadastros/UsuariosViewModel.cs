namespace rgInfra.ViewModel.Cadastros
{
    public class UsuariosViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone {  get; set; }
        public bool Ativo {  get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Alteracao { get; set; }

    }
}
