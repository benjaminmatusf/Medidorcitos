using MedidorcitoModel;
using MedidorcitoModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorcitoWeb
{
    public partial class VerUsuarios : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();

        private void cargarGrilla(List<Usuario> usuarios)
        {
            this.grillaUsuario.DataSource = usuarios;
            this.grillaUsuario.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();

            }
        }

        private void cargarGrilla()
        {
            List<Usuario> usuarios;

            usuarios = this.usuariosDAL.ObtenerUsuarios();

            this.cargarGrilla(usuarios);
        }


        protected void grillaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.usuariosDAL.EliminarUsuario(id);
                this.cargarGrilla();
            }
        }
    }
}