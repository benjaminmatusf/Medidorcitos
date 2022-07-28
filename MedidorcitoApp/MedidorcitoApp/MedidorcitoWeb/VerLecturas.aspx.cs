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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALDB();

        private void cargarGrilla(List<Lectura> lecturas)
        {
            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();
        }

        private void cargarGrilla()
        {
            List<Lectura> lecturas;
           
                lecturas = this.lecturasDAL.ObtenerLecturas();
            
            this.cargarGrilla(lecturas);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla();
            }

        }

        protected void grillaLectura_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.lecturasDAL.EliminarLectura(id);
                this.cargarGrilla();
            }

        }
    }
}