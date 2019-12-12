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
        DatoProducts datoProducts = new DatoProducts();

        public List<dena_sp_MostrarTodo_Result> ListaProducts()
        {
             //DatoProducts datoProducts = new DatoProducts();
             return datoProducts.ListaProducts();   
        }

        public List<dena_sp_BusquedaProdId_Result> ListaPorId(int Id)
        {
            return datoProducts.ListaPorId(Id);
            
        }
        public List<dena_sp_BusquedaProdNom_Result> ListaPorNom (string Nombre)

        {
            return datoProducts.ListaPorNom(Nombre);
        }


        public void AgregarProd(int IdType, int IdColor, int IdBrand, int IdProvider, int IdCatalog, string Title, string Nombre, string Description, string Observations, decimal priceDistributor, decimal priceClient, decimal priceMember, bool IsEnabled, string Keywords, DateTime DateUpdate)
        {
            DatoProducts objDatos = new DatoProducts();
            objDatos.AgregarProd(IdType, IdColor, IdBrand, IdProvider, IdCatalog, Title, Nombre, Description, Observations, priceDistributor, priceClient, priceMember, IsEnabled, Keywords, DateUpdate);
        }
    }
}
