package frontController;

class Dispatcher {
    private HomeController homeController;
    private ErrorController errorController;

    public Dispatcher() {
        homeController = new HomeController();
        errorController = new ErrorController();
    }

    public void dispatch(String request) {
        if ("HOME".equalsIgnoreCase(request)) {
            homeController.processRequest();
        } else {
            errorController.processRequest();
        }
    }
}