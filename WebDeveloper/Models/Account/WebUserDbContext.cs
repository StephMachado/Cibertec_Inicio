using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebDeveloper.Models.Account
{
    public class WebUserDbContext : IdentityDbContext<WebDeveloperUser>
    {
        public WebUserDbContext() : base("IdentityConnectionString")
        {

        }
    }

    public class WebDeveloperUser : IdentityUser
    {
        //Se está creando esta clase con el fin de extender las funcionalidades
        //de la clase WebUserDbContext
    }
}

