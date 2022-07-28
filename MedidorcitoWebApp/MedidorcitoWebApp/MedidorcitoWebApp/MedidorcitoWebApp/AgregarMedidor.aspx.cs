using ModeloClases.DAL;
using ModeloClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorcitoWebApp
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
 

            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid == true)
            {
                int tipo = Convert.ToInt32(this.tipoRbl.SelectedItem.Value);              
            int numeroSerie = Convert.ToInt32(this.numeroSerieTxt.Text.Trim());

            Medidor medidor = new Medidor()
            {
                NumeroSerie = numeroSerie,
                Tipo = tipo
            };
            medidoresDAL.Agregar(medidor);
            Response.Redirect("VerMedidor.aspx");
            }
            else
            {
                mensajesLbl.Text = "Por favor, revise los datos ingresados";
            }
        }


    }

    }
