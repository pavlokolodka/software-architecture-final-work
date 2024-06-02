namespace FrontControllerPattern
{
    public class Dispatcher
    {
        private readonly HomeController _homeController;
        private readonly ErrorController _errorController;

        public Dispatcher()
        {
            _homeController = new HomeController();
            _errorController = new ErrorController();
        }

        public void Dispatch(string request)
        {
            if (request.Equals("HOME", StringComparison.OrdinalIgnoreCase))
            {
                _homeController.ProcessRequest();
            }
            else
            {
                _errorController.ProcessRequest();
            }
        }
    }
}
