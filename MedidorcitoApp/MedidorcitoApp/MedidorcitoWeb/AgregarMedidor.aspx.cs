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
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        private ILecturasDAL lecturaDAL = new LecturasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            Medidor medidor = new Medidor();
           
            medidor.Tipo = this.tipoRbl.SelectedItem.Value;
            medidor.Id = Convert.ToInt32(this.numeroSerieTxt.Text.Trim());

            this.medidoresDAL.Agregar(medidor);
            Response.Redirect("VerMedidores.aspx");

        }
    }
}