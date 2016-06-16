using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData : BaseDataAccess<Client>
    {
        public Client GetClient(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Clients.FirstOrDefault(x => x.ID == id);

                //Este método no debemos utilizarlo, ya que traemos todo el listado de los clientes.
                //return this.GetList().Where(c => c.ID == id).FirstOrDefault();
            }
        }
    }
}
