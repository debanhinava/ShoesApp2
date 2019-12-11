using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesData;

namespace ShoesNegocio
{

    public class NegocioProducts
    {
        DataProductsEntities modeldb = new DataProductsEntities();

        public List<dena_sp_MostrarTodo_Result> ListaProducts()
        {
            DatoProducts datoProducts = new DatoProducts();
            return datoProducts.ListaProducts();
        }
    }
}
