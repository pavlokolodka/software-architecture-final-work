namespace FrontControllerPattern
{
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
}
