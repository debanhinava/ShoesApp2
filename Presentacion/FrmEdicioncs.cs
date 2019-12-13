using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesNegocio;
using ShoesData;

namespace Presentacion
{
    public partial class FrmEdicion : Form
    {
        public FrmEdicion()
        {
            InitializeComponent();
        }
        private void FrmEdicion_Load(object sender, EventArgs e)
        {
            if (txtIdProdEd.Text != null)
            {
                DataProductsEntities dtp = new DataProductsEntities();
                NegocioProducts negoPro = new NegocioProducts();
                List<dena_sp_BusquedaProdId_Result> LstId = negoPro.ListaPorId(int.Parse(txtIdProdEd.Text));
                foreach (var item in LstId.ToList())
                {
                    try
                    {
                        txtNombrePro.Text = item.Nombre;
                        txtIdBrand.Text = item.IdBrand.ToString();
                        txtIdCatalog.Text = item.IdCatalog.ToString();
                        txtIdColor.Text = item.IdColor.ToString();
                        txtIdProvider.Text = item.IdProvider.ToString();
                        txtIdType.Text = item.IdType.ToString();
                        txtKeywords.Text = item.Keywords.ToString();
                        txtDescription.Text = item.Description.ToString();
                        txtPriceClient.Text = item.PriceClient.ToString();
                        txtObservations.Text = item.Observations.ToString();
                        txtPriceD.Text = item.PriceDistributor.ToString();
                        txtPriceMem.Text = item.PriceMember.ToString();
                        txtTitle.Text = item.Title.ToString();
                        chkIsEnabled.Checked = item.IsEnabled;
                        dateTimePicker1.Value = item.DateUpdate.Value;
                    }
                    catch (Exception)
                    {
                
                        
                    }
                    

                }


            }




        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int IdType = int.Parse(txtIdType.Text);
            int IdColor = int.Parse(txtIdColor.Text);
            int IdBrand = int.Parse(txtIdBrand.Text);
            int IdProvider = int.Parse(txtIdProvider.Text);
            int IdCatalog = int.Parse(txtIdCatalog.Text);
            string Title = txtTitle.Text;
            string Nombre = txtNombrePro.Text;
            string Description = txtDescription.Text;
            string Observations = txtObservations.Text;
            decimal PriceDistributor = decimal.Parse(txtPriceD.Text);
            decimal PriceClient = decimal.Parse(txtPriceClient.Text);
            decimal PriceMember = decimal.Parse(txtPriceMem.Text);
            bool IsEnabled = chkIsEnabled.Checked;
            string Keywords = txtKeywords.Text;
            DateTime DateUpdate = dateTimePicker1.Value;

            AgregarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUpdate);
            lblMensaje2.Text = "Agregado";
        }

        
        public void AgregarProd(int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUpdate)
        {
            NegocioProducts objNegocio = new NegocioProducts();
            objNegocio.AgregarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUpdate);
        }

        private void btnModificar_Click(object sender, EventArgs e)

        {
            int Id = int.Parse(txtIdProdEd.Text);
            int IdType = int.Parse(txtIdType.Text);
            int IdColor = int.Parse(txtIdColor.Text);
            int IdBrand = int.Parse(txtIdBrand.Text);
            int IdProvider = int.Parse(txtIdProvider.Text);
            int IdCatalog = int.Parse(txtIdCatalog.Text);
            string Title = txtTitle.Text;
            string Nombre = txtNombrePro.Text;
            string Description = txtDescription.Text;
            string Observations = txtObservations.Text;
            decimal PriceDistributor = decimal.Parse(txtPriceD.Text);
            decimal PriceClient = decimal.Parse(txtPriceClient.Text);
            decimal PriceMember = decimal.Parse(txtPriceMem.Text);
            bool IsEnabled = chkIsEnabled.Checked;
            string Keywords = txtKeywords.Text;
            DateTime DateUpdate = dateTimePicker1.Value;
            ModificarProd(Id, IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUpdate);
            lblMensaje2.Text = "Actualizado";

        }
        public void ModificarProd(int Id,int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUpdate)
        {
            NegocioProducts objNegocio = new NegocioProducts();
            objNegocio.ModificarProd(Id, IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUpdate);
        }
    }
}
