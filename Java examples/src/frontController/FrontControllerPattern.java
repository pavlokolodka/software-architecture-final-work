package frontController;

public class FrontControllerPattern {
    public static void main(String[] args) {
        FrontController frontController = new FrontController();

        frontController.handleRequest("HOME");
        frontController.handleRequest("ERROR");
    }
}
