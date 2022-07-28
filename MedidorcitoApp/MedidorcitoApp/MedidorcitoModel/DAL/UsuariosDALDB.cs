using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorcitoModel.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {
        private MedidorcitoDBEntities medidorcitoDB = new MedidorcitoDBEntities();
        public void AgregarUsuario(Usuario usuario)
        {
            this.medidorcitoDB.Usuarios.Add(usuario);
            this.medidorcitoDB.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            Usuario usuario = this.medidorcitoDB.Usuarios.Find(id);
            this.medidorcitoDB.Usuarios.Remove(usuario);
            this.medidorcitoDB.SaveChanges();
        }

        public Usuario Obtener(int id)
        {
            return this.medidorcitoDB.Usuarios.Find(id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorcitoDB.Usuarios.ToList();
        }

    }
}
