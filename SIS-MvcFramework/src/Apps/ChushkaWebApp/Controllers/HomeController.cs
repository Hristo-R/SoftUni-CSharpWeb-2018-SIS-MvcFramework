using ChushkaWebApp.ViewModels.Home;
using SIS.HTTP.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChushkaWebApp.Controllers
{
    public class HomeController : BaseController
    {
        public IHttpResponse Index()
        {
            if (this.User.IsLoggedIn)
            {
                var products = this.Db.Products.Select(
                    p => new ProductViewModel
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Price = p.Price,
                        Description = p.Description
                    });

                var model = new IndexViewModel
                {
                    Products = products
                };
                return this.View("Home/IndexLoggedIn", model);
            }

            return this.View();
        }
    }
}
