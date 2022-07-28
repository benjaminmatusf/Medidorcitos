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
    public partial class VerMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    cargarGrilla();

            }

        }      

        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        private void cargarGrilla()
        {
            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }

        private void cargarGrilla(List<Medidor> filtracion)
        {

            this.grillaMedidores.DataSource = filtracion;
            this.grillaMedidores.DataBind();
        }

       

        protected void cargarBtn_Click(object sender, EventArgs e)
        {

            
                Medidor medidor = new Medidor()
                {
                    NumeroSerie = 1110,
                    Tipo = 1
                };

                Medidor medidor2 = new Medidor()
                {
                    NumeroSerie = 1111,
                    Tipo = 1
                };

                Medidor medidor3 = new Medidor()
                {
                    NumeroSerie = 1112,
                    Tipo = 2
                };

                Medidor medidor4 = new Medidor()
                {
                    NumeroSerie = 1113,
                    Tipo = 2
                };



                medidoresDAL.Agregar(medidor);
                medidoresDAL.Agregar(medidor2);
                medidoresDAL.Agregar(medidor3);
                medidoresDAL.Agregar(medidor4);
                cargarGrilla();
            
           
        }

        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDdl.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.tipoDdl.SelectedItem.Value);
                List<Medidor> filtracion = medidoresDAL.Filtrar(tipo);
                cargarGrilla(filtracion);
            }
        }
    }
}