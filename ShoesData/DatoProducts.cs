using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesData
{
    public class DatoProducts
    {
        DataProductsEntities modeldb = new DataProductsEntities();
        public List<dena_sp_MostrarTodo_Result> ListaProducts()
        {
            List<dena_sp_MostrarTodo_Result> MostT = new List<dena_sp_MostrarTodo_Result>();
            foreach (var item in modeldb.dena_sp_MostrarTodo().ToList())
            {
                dena_sp_MostrarTodo_Result mdatos = new dena_sp_MostrarTodo_Result();
                mdatos.Id = item.Id;
                mdatos.IdType = item.IdType;
                mdatos.IdColor = item.IdColor;
                mdatos.IdBrand = item.IdBrand;
                mdatos.IdProvider = item.IdProvider;
                mdatos.IdCatalog = item.IdCatalog;
                mdatos.Title = item.Title;
                mdatos.Nombre = item.Nombre;
                mdatos.Description = item.Description;
                mdatos.Observations = item.Observations;
                mdatos.PriceDistributor = item.PriceDistributor;
                mdatos.PriceClient = item.PriceClient;
                mdatos.PriceMember = item.PriceMember;
                mdatos.IsEnabled = item.IsEnabled;
                mdatos.Keywords = item.Keywords;
                mdatos.DateUpdate = item.DateUpdate;

                MostT.Add(mdatos);
            }
            return MostT;
            
            
        }
        //segun yo aqui va lo del store de buscar por id
        //pruebas de busqueda por id
        public List<dena_sp_BusquedaProdId_Result> ListaPorId()
        {
            List<dena_sp_BusquedaProdId_Result> ListaId = new List<dena_sp_BusquedaProdId_Result>();
            foreach (var item in modeldb.dena_sp_BusquedaProdId().ToList())
            {
                dena_sp_BusquedaProdId_Result datosProdId = new dena_sp_BusquedaProdId_Result();
                datosProdId.Id = item.Id;
                datosProdId.IdType = item.IdType;
                datosProdId.IdColor = item.IdColor;
                datosProdId.IdBrand = item.IdBrand;
                datosProdId.IdProvider = item.IdProvider;
                datosProdId.IdCatalog = item.IdCatalog;
                datosProdId.Title = item.Title;
                datosProdId.Nombre = item.Nombre;
                datosProdId.Description = item.Description;
                datosProdId.Observations = item.Observations;
                datosProdId.PriceDistributor = item.PriceDistributor;
                datosProdId.PriceClient = item.PriceClient;
                datosProdId.PriceMember = item.PriceMember;
                datosProdId.IsEnabled = item.IsEnabled;
                datosProdId.Keywords = item.Keywords;
                datosProdId.DateUpdate = item.DateUpdate;
            }
        }
    }
}
