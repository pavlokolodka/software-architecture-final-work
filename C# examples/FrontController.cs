using System;

namespace FrontControllerPattern
{
    public class View
    {
        public void Show()
        {
            Console.WriteLine("Displaying Home Page");
        }
    }

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

    public interface IController
    {
        void ProcessRequest();
    }

    public class HomeController : IController
    {
        private readonly View _view = new View();

        public void ProcessRequest()
        {
            _view.Show();
        }
    }

    public class ErrorController : IController
    {
        public void ProcessRequest()
        {
            Console.WriteLine("Displaying Error Page");
        }
    }

    public class FrontController
    {
        private readonly Dispatcher _dispatcher;

        public FrontController()
        {
            _dispatcher = new Dispatcher();
        }

        public void HandleRequest(string request)
        {
            _dispatcher.Dispatch(request);
        }
    }

    static class Program
    {
        public static void RunExample()
        {
            FrontController frontController = new FrontController();

            frontController.HandleRequest("HOME");
            frontController.HandleRequest("ERROR");
        }
    }
}
