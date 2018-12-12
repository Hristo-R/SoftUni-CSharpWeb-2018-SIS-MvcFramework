using ChushkaWebApp.ViewModels.Products;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System.Linq;

namespace ChushkaWebApp.Controllers
{
    public class ProductsController : BaseController
    {
        [Authorize]
        public IHttpResponse Details(int id)
        {
            var viewModel = this.Db.Products
                .Select(p => new ProductDetailsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Type = p.Type,
                    Price = p.Price,
                })
                .FirstOrDefault(p => p.Id == id);

            if (viewModel == null)
            {
                return this.BadRequestError("Invalid product id.");
            }

            return this.View(viewModel);
        }
    }
}
