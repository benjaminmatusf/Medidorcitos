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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
            }

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.Rut = this.rutTxt.Text.Trim();
            usuario.Nombre = this.nombreTxt.Text.Trim();
            usuario.Email = this.emailTxt.Text.Trim();
            usuario.Contraseña = this.contraTxt.Text.Trim();

            this.usuariosDAL.AgregarUsuario(usuario);
            Response.Redirect("VerUsuarios.aspx");


        }
    }
}