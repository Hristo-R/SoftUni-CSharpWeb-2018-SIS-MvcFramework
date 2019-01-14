namespace ChushkaWebApp.Controllers
{
    using SIS.HTTP.Responses;

    public class HolidaysController : BaseController
    {
        public IHttpResponse Sithonia()
        {
            return this.View();
        }
    }
}