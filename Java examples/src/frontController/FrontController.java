package frontController;

class FrontController {
    private Dispatcher dispatcher;

    public FrontController() {
        dispatcher = new Dispatcher();
    }

    public void handleRequest(String request) {
        dispatcher.dispatch(request);
    }
}
