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
    public partial class VerLectura : System.Web.UI.Page
    {
        private ILecturaDAL lecturasDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            //    cargarDdl();
                cargarGrilla();
            }
        }

        private void cargarGrilla() {
            List<Lectura> lecturas = lecturasDAL.Obtener();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
            
        }

      /*  

        

        public static void Carga(object lecturas, DropDownList dropDownList, string pDataTextField, string pDataValueField) {
            try
            {
                dropDownList.Items.Clear();
                dropDownList.DataTextField = pDataTextField;
                dropDownList.DataValueField = pDataValueField;
                dropDownList.DataSource = lecturas;
                dropDownList.DataBind();
                dropDownList.Items.Insert(0, new ListItem("Seleccione un medidor", "-1"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void cargarGrilla(List<Lectura> carga)
        {

            this.grillaLecturas.DataSource = carga;
            this.grillaLecturas.DataBind();
        }

        protected void medidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        { 
            //medidorDdl.Text = medidorDdl.SelectedItem.Value; //(el valor que tiene el registro)

            if (this.medidorDdl.SelectedItem != null)
            {

                  string medidorLectura = Convert.ToString(this.medidorDdl.SelectedItem.Text);
                  List<Lectura> carga = lecturasDAL.Filtrar(medidorLectura);
                  cargarGrilla(carga); 
                cargarGrilla();
            }
        } */
    }
}