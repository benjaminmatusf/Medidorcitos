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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();

        private void cargarGrilla(List<Medidor> medidores)
        {
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
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
            List<Medidor> medidores;

            medidores = this.medidoresDAL.ObtenerMedidores();

            this.cargarGrilla(medidores);
        }



        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.medidoresDAL.EliminarMedidor(id);
                this.cargarGrilla();
            }

        }

      
    }
}