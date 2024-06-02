package frontController;

class HomeController implements Controller {
    private View view = new View();

    @Override
    public void processRequest() {
        view.show();
    }
}