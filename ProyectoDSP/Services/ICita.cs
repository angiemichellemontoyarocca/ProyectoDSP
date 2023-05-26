using ProyectoDSP.Models;

namespace ProyectoDSP.Services
{
    public interface ICita
    {
        void add(citas obj);
        IEnumerable<citas> GetAllCitas();
        void remove(string id);
        citas edit(string id);
        void editDetails(citas obj);

    }
}
