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
    public partial class AgregarLectura : System.Web.UI.Page
       
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturasDAL = new LecturaDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.medidorDdl.DataSource = medidores;
                this.medidorDdl.DataTextField = "NumeroSerie";
                this.medidorDdl.DataValueField = "NumeroSerie";
                this.medidorDdl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {

            if (Page.IsValid == true)
            {
                string fecha = fechaCld.SelectedDate.ToShortDateString();
                string consumoTxt = this.consumoTxt.Text.Trim();
                int consumo = Int32.Parse(consumoTxt);
                string horaTxt = this.horaTxt.Text.Trim();
                int hora = Int32.Parse(horaTxt);
                string minutoTxt = this.minutoTxt.Text.Trim();
                int minuto = Int32.Parse(minutoTxt);

                string medidorValor = this.medidorDdl.SelectedValue;
                string medidorTexto = this.medidorDdl.SelectedItem.Value;
                int medidorNumero = Int32.Parse(medidorValor);

                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                Medidor medidor = medidores.Find(m => m.NumeroSerie == medidorNumero);


                Lectura lectura = new Lectura()
                {
                    MedidorLectura = medidor,
                    Fecha = fecha,
                    Hora = hora,
                    Minuto = minuto,
                    Consumo = consumo
                };
                lecturasDAL.Agregar(lectura);
                Response.Redirect("VerLectura.aspx");
            }
            else
            {
                mensajesLbl.Text = "Por favor, revise los datos ingresados";
            }

           
           

        }

    }
}