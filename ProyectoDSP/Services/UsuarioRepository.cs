using ProyectoDSP.Models;

namespace ProyectoDSP.Services
{
    public class UsuarioRepository : IUsuario
    {
        private List<Usuario> LstUsuarios = new List<Usuario>();
        public void Add(Usuario usuario)
        {
            LstUsuarios.Add(usuario);
        }

        public IEnumerable<Usuario> Listuser()
        {
            return LstUsuarios;
        }
    }
}