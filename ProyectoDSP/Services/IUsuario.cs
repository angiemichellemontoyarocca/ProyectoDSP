using ProyectoDSP.Models;


namespace ProyectoDSP.Services
{
    public interface IUsuario
    {
        void Add(Usuario usuario);
        IEnumerable<Usuario> Listuser();
    }
}
