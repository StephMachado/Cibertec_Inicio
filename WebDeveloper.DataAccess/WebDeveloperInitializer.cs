using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name="Jose", LastName = "Perez"},
                new Client {Name="Juan", LastName = "Perez"},
                new Client {Name="Juanelo", LastName = "Perez"},
                new Client {Name="Alan", LastName = "Perez"},
                new Client {Name="Pedro", LastName = "Perez"}
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }

        //protected override void Seed(WebContextDb context)
        //{
        //    var products = new List<Product>
        //    {
        //        new Product {Name="CELOTIN 5 MG TAB. CX 14", UM="UN", EANCode="12345678914",
        //                    ExpirationDate = DateTime.Parse("19/08/2016"),
        //                    ProductionDate = (DateTime?)null, ConversionRate=10},

        //        new Product {Name="BETAMETASONA 0,05% CR. CX1 TB. X 20 G",  UM="UN", EANCode="5789655",
        //                    ExpirationDate = DateTime.Parse("20/09/2016"),
        //                    ProductionDate = DateTime.Parse("01/03/2015"), ConversionRate=100},

        //        new Product {Name="ADENOSINA 6 MG /2 ML SOL. INY. CX 1",  UM="UN", EANCode="879663225",
        //                    ExpirationDate = DateTime.Parse("18/11/2016"),
        //                    ProductionDate = (DateTime?)null, ConversionRate=100},

        //        new Product {Name="ESPIRONOLACTONA 25 MG TAB. CX 1 000",  UM="UN", EANCode="9632587",
        //                    ExpirationDate = DateTime.Parse("05/09/2017"),
        //                    ProductionDate = (DateTime?)null, ConversionRate=100},
        //    };

        //    products.ForEach(c => context.Products.Add(c));
        //    context.SaveChanges();
        //}


    }
}
