namespace FrontControllerPattern
{
    public class HomeController : IController
    {
        private readonly View _view = new View();

        public void ProcessRequest()
        {
            _view.Show();
        }
    }
}
