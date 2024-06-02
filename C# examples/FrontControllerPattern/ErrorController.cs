namespace FrontControllerPattern
{
    public class ErrorController : IController
    {
        public void ProcessRequest()
        {
            Console.WriteLine("Displaying Error Page");
        }
    }
}
