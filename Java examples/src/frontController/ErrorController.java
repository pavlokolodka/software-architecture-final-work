package frontController;

class ErrorController implements Controller {
    @Override
    public void processRequest() {
        System.out.println("Displaying Error Page");
    }
}
