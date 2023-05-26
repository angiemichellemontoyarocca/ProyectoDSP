using ProyectoDSP.Models;
namespace ProyectoDSP.Services
{
    public class CitaRepository:ICita
    {
        private citas conexion = new citas();

        public void add(citas obj)
        {
            conexion.citas.Add(obj);
            conexion.SaveChanges();
        }

        public citas edit(string id)
        {
            var objEncontrado = (from tcita in conexion.citas
                                 where tcita.Id_cita == id
                                 select tcita).Single();
            return objEncontrado;
        }

        public void editDetails(citas obj)
        {
            {
                var objAModificar = (from tcita in conexion.citas
                                     where tcita.Id_cita == id
                                     select tcita).FirstOrDefault();
                if (objAModificar != null)
                {
                    objAModificar.Id_cita = obj.Id_cita;
                }
                conexion.SaveChanges();
            }
        }

        public IEnumerable<citas> GetAllCitas()
        {
            return conexion.cita;
        }

        public void remove(string id)
        {
            var objEncontrado = (from tcita in conexion.citas
                                 where tcita.Id_cita == id
                                 select tcita).Single();
            conexion.cita.Remove(objEncontrado);
            conexion.SaveChanges();
        }
    }
}
