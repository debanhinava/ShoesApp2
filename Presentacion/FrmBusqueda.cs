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

            //agregar columna de modificar y agregar botn de modificar
            //dgvProducts.Columns.Add(
            //    new DataGridViewButtonColumn()
            //    {
            //        HeaderText = "columntitle",
            //        Text = "modificar",
            //        UseColumnTextForButtonValue = true
            //    });


            //agregar columa de moddificar y LINK de modificar
            dgvProducts.Columns.Add(
                new DataGridViewLinkColumn()
                {
                    HeaderText = "Modificar",
                    Text = "modificar",
                    UseColumnTextForLinkValue = true
                }
                );

        }

        //public static string idtype;
        //public static string idcolor;

        //public void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    idtype = dgvProducts.Rows[e.RowIndex].Cells["idtype"].Value.ToString();
        //    idcolor = dgvProducts.Rows[e.RowIndex].Cells["idcolor"].Value.ToString();
        //}


            private List<dena_sp_MostrarTodo_Result> LLenarGrid()
        {
            //NegocioProducts negocioProducts = new NegocioProducts();
            return negocioProducts.ListaProducts();

        }

        public List<dena_sp_BusquedaProdId_Result> BusquedaId(int id)
        {

            return negocioProducts.ListaPorId(int.Parse(txtId.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BusquedaId(int.Parse(txtId.Text));
        }


        public List<dena_sp_BusquedaProdNom_Result>BusquedaPorNom(string Nombre)
        {
            return negocioProducts.ListaPorNom(txtNombre.Text);
        }


        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BusquedaPorNom(txtNombre.Text);
        }

        

        
        //este le dice que hacer cuando le dan al botn de modificar del grid
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // la clumna 16 pertenece a donde está el link de modificar 
            if (e.ColumnIndex == 16)
            {
                int idoficial = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
                //MessageBox.Show("mensaje" + idoficial.ToString());
                
                FrmEdicion form3 = new FrmEdicion();
                form3.txtIdProdEd.Text = idoficial.ToString();
                form3.ShowDialog();
            }

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmEdicion form2 = new FrmEdicion();
            form2.ShowDialog();
        }

        // este seria si da doble clic sobre una columna que tiene datos
        //no se ocupa por el momento, ya que en el anterior lo especifica, que solo sea el de la columna 16 
        //private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int idoficial = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
        //    MessageBox.Show("mensaje" + idoficial.ToString());

        //if (dgvProducts.SelectedRows != null)
        //{
        //    FrmEdicion form3 = new FrmEdicion();
        //    form3.ShowDialog();
        //}


        //}

    }
}
