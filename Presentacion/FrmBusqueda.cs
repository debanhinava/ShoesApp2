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
        NegocioProducts negocioProducts = new NegocioProducts();
        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = LLenarGrid();

            //agregar columna de modificar
            dgvProducts.Columns.Add(
                new DataGridViewButtonColumn()
                {
                    HeaderText = "columntitle",
                    Text = "modificar",
                    UseColumnTextForButtonValue = true
                });
        }

        //este le dice que hacer cuando le dan al botn de modificar del grid
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)  //Dónde la columna con el botón es la 6 con posición 5
            {
                /*Hacer algo ...*/
                MessageBox.Show(string.Format("Hizo click en el botón de la fila {0}, posición {1}",
                                e.RowIndex + 1, e.RowIndex));
            }
        }




        private List<dena_sp_MostrarTodo_Result> LLenarGrid()
        {
            //NegocioProducts negocioProducts = new NegocioProducts();
            return negocioProducts.ListaProducts();

        }

        public List <dena_sp_BusquedaProdId_Result> BusquedaId(int id)
        {
            
            return negocioProducts.ListaPorId(int.Parse(txtId.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource= BusquedaId(int.Parse(txtId.Text));
        }


        public List<dena_sp_BusquedaProdNom_Result>BusquedaPorNom(string Nombre)
        {
            return negocioProducts.ListaPorNom(txtNombre.Text);
        }


        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BusquedaPorNom(txtNombre.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEdicion form2 = new FrmEdicion();
            form2.ShowDialog();
        }
        
    }
}
