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
    public partial class AgregarLectura : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALDB();
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorDdl.DataSource = this.medidoresDAL.ObtenerMedidores();
                this.medidorDdl.DataTextField = "Id";
                this.medidorDdl.DataValueField = "Id";
                this.medidorDdl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {

            Lectura lectura = new Lectura();
            lectura.IdMedidor = Convert.ToInt32(this.medidorDdl.Text.Trim());
            lectura.Fecha =  fechaCld.SelectedDate.ToShortDateString();
            lectura.Hora = Convert.ToInt32(this.horaTxt.Text.Trim());
            lectura.Minuto = Convert.ToInt32(this.minutoTxt.Text.Trim());
            lectura.Consumo = Convert.ToInt32(this.consumoTxt.Text.Trim());

            this.lecturasDAL.AgregarLectura(lectura);
            Response.Redirect("VerLecturas.aspx");

        }
    }
}