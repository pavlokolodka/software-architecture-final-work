using FrontControllerPattern;

FrontController frontController = new FrontController();

frontController.HandleRequest("HOME");
frontController.HandleRequest("ERROR");