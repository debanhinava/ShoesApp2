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
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();
        }
        //DatoProducts metodos = new DatoProducts();

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = LLenarGrid();
            
        }

        private List<dena_sp_MostrarTodo_Result> LLenarGrid()
        {
            NegocioProducts negocioProducts = new NegocioProducts();
            return negocioProducts.ListaProducts();
        }
    }
}
