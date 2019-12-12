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

namespace Presentacion
{
    public partial class FrmEdicion : Form
    {
        public FrmEdicion()
        {
            InitializeComponent();
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

        private void FrmEdicion_Load(object sender, EventArgs e)
        {

        }
        public void AgregarProd(int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal PriceDistributor, decimal PriceClient, decimal PriceMember, bool IsEnabled, string Keywords, DateTime DateUpdate)
        {
            NegocioProducts objNegocio = new NegocioProducts();
            objNegocio.AgregarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, PriceDistributor, PriceClient, PriceMember, IsEnabled, Keywords, DateUpdate);
        }
    }
}
