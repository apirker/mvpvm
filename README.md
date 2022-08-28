# Overview

This project shows the MVPVM pattern. This pattern is actually quite some time out there, however, I added additional enhancements to it. The main components in this pattern for UI application are:

* View: The view/page which gets shown to the end user
* ViewModel: Defines all the properties which the view requires to show a user interface
* Presenter: Some sort of controller which handles the communication between ViewModel and Model (i.e. capturing events from model and propagating changes to the viewmodel)
* Model: The domain model of your application.

The presenter is the main component here declaring the entry point to a UI component. It offers a Show method, and a Close method. On show, it returns an instance of the view to be shown. 

The main exension points here to the original pattern are the following:

* Navigation Service: Unifies navigation across platforms in terms of an interface
* UI commands: For each triggerable action there exists a UI command class which cover exactly this interaction
* Environments: Presenters run in an environment which defines which interface maps to which class to abstract production/testing or other environments
* Containers: Abstraction of the underlying dependency injection framework

The ultimate goal is to create reusable UI components, by separating clearly the responsibilities. In case extensions are required, it is straightforward to implement them by extendning presenters, view models or changing environments. Furthermore, moving UI components across platforms is also straightforward by changing the implementation of the view, navigation service and environment. This enables for a very flexible, testable, but also modifyable UI framework.
