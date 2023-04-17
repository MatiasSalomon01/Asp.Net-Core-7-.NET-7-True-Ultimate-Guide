# Asp.Net-Core-7-.NET-7-True-Ultimate-Guide
## GitHub Course Source https://github.com/Harsha-Global/AspNetCore-Harsha

## Seccion 1
  
## Respuestas
What is Asp.Net Core?

    ASP.NET Core is a free, open-source, and cross-platform framework for building cloud-based applications, such as web apps, IoT apps, and mobile backends. It is designed to run on the cloud as well as on-premises.

    ASP.NET Core is not an upgraded version of ASP.NET. ASP.NET Core is completely rewriting that work with the .net Core framework. It is much faster, configurable, modular, scalable, extensible, and has cross-platform support. It is best suitable for developing cloud-based such as web applications, mobile applications, and IoT applications.



What are the features of Asp.Net Core?

    Following are the core features that are provided by the ASP.NET Core

    Built-in supports for Dependency Injection

    Built-in supports for the logging framework and it can be extensible

    Introduced a new, fast and cross-platform web server - Kestrel. So, a web application can run without IIS, Apache, and Nginx.

    Multiple hosting platforms are supported

    It supports modularity, so the developer needs to include the module required by the application.

    Command-line supports to creating, building, and running of the application

    There is no web .config file. We can store the custom configuration into an appsettings.json file

    It has good support for asynchronous programming



What are the advantages of ASP.NET Core over ASP.NET (.NET Framework)?

    There are the following advantages of ASP.NET Core over ASP.NET:

    It offers faster performance due to its minimalistic design

    It is cross-platform, so it can be run on Windows, Linux, and Mac.

    It is open-source

    There is no dependency on framework installation because all the required dependencies are shipped with our application to the production server

    Multiple deployment platforms available with ASP.NET Core



What is Asp.Net Core meta package?

    The ASP.NET Core shared framework (Microsoft.AspNetCore.App) contains assemblies that are developed and supported by Microsoft. Microsoft.AspNetCore.App is installed when the .NET Core 3.0 or later SDK is installed. The shared framework is the set of assemblies (.dll files) that are installed on the machine and includes a runtime component and a targeting pack.

    <Project Sdk="Microsoft.NET.Sdk.Web">
    <PropertyGroup>
        <TargetFramework>net6.0</TargetFramework>
    </PropertyGroup>
        ...
    </Project>


When do you choose classic ASP.NET MVC over ASP.NET Core?

    Though Asp.Net Core is a better choice in almost all the aspects, you don’t have to switch to ASP.NET Core if you are maintaining a legacy ASP.NET application that you are happy with and that is no longer actively developed.



    ASP.NET MVC is a better choice if you:

    Don’t need cross-platform support for your Web app.

    The existing team is already working on an existing app and extending its functionality.

    The existing developers needs a learning curve to upgrade themselves to Asp.Net Core



What is a web application framework, and what are its benefits?

    Learning to build a modern web application can be daunting. Most of the web applications have a standard set of functionality such as:



    Build a dynamic response that corresponds to an HTTP request.

    Allow users to log into the application and manage their data.

    Store the data in the database.

    Handle database connections and transactions.

    Route URLs to appropriate methods.

    Supporting sessions, cookies, and user authorization.

    Format output (e.g. HTML, JSON, XML)

    Improve security.

    Frameworks help developers to write, maintain and scale applications. They provide tools and libraries that simplify the above recurring tasks, eliminating a lot of unnecessary complexity.

## Seccion 2
  
## Respuestas
Asp.Net Core application uses Kestrel by default.

    Kestrel is an event-driven, I/O-based, open-source, cross-platform, and asynchronous server which hosts .NET applications. It is provided as a default server for .NET Core; therefore, it is compatible with all the platforms and their versions which .NET Core supports.

    It is a listening server with a command-line interface.

    It can be used to reverse proxy servers such as IIS, Nginx etc.

    Features of Kestrel are:

    Lightweight and fast.

    Cross-platform and supports all versions of .NET Core.

    Supports HTTP & HTTPS.

    Easy configuration

    Multiple apps on the same port is not supported

    Windows authentication is not supported



What is the difference between IIS and Kestrel? Why do we need two web servers?

    The main difference between IIS and Kestrel is that Kestrel is a cross-platform server. It runs on Windows, Linux, and Mac, whereas IIS only runs on Windows.



    Another essential difference between the two is that Kestrel is fully open-source, whereas IIS is closed-source and developed and maintained only by Microsoft.



    IIS is very old software and comes with a considerable legacy and bloat. With Kestrel, Microsoft started with high-performance in mind. They developed it from scratch, which allowed them to ignore the legacy/compatibility issues and focus on speed and efficiency.



    However, Kestrel doesn’t provide all the rich functionality of a full-fledged web server such as IIS, Nginx, or Apache. Hence, we typically use it as an application server, with one of the above servers acting as a reverse proxy.



What is the purpose of launchSettings.json in asp.net core?

    The launchSettings.json file is used to store the configuration information, which describes how to start the ASP.NET Core application, in Visual Studio.

    It mainly contains the run time profiles to configure application urls’ and environment.

    The file is used only during the development of the application using Visual Studio. It contains only those settings that required to run the application.

    launchSettings.json is only used by Visual Studio.

    You don't need launchSettings.json for publishing an app (on production server).



What is generic host or HostBuilder in .NET Core?

    .NET generic host called ‘HostBuilder’ helps us to manage all the below tasks.

    Dependency Injection

    Service lifetime management

    Configuration

    Logging



    The generic host was previously present as ‘Web Host’, in .NET Core for web applications. Later, the ‘Web Host’ was deprecated and a generic host was introduced to cater to the web, Windows, Linux, and console applications.



What is the purpose of the .csproj file?

    The project file is one of the most important files in our application. It tells .NET how to build (compile) the project.

    The csproj file stores list of package dependencies of the current project, target .net version and other compilation settings.



    The .csproj file also contains all the information that .NET tooling needs to build the project. It includes the type of project you are building (console, web, desktop, etc.), the platform this project targets, and any dependencies on other projects or 3rd party libraries.



    Here is an example of a .csproj file that lists the NuGet packages and their specific versions.



    <Project Sdk="Microsoft.NET.Sdk.Web">
    <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    </PropertyGroup>

    <ItemGroup>
    <PackageReference Include="PackageName" Version="1.0.0.0" />
    </ItemGroup>
    </Project>


What is IIS?

    IIS stands for Internet Information Services. It is a powerful web server developed by Microsoft. IIS can also act as a load balancer to distribute incoming HTTP requests to different application servers to allow high reliability and scalability.



    It can also act as a reverse proxy, i.e. accept a client’s request, forward it to an application server, and return the client’s response. A reverse proxy improves the security, reliability, and performance of your application.



    A limitation of IIS is that it only runs on Windows. However, it is very configurable. You can configure it to suit your application’s specific needs.



What is the “Startup” class in ASP.NET core prior to Asp.Net Core 6?

    The startup class is the entry point of the ASP.NET Core application. Every Asp.NET Core (Asp.Net Core 5 and earlier) application must have this class. It contains the necessary code to bootstrap the application. This class contains two methods Configure() and ConfigureServices().

    Configure(): The Configure() method is used to essential middleware(s) to the application request pipeline.

    ConfigureServices(): The ConfigureServices() method is used to add services to the IoC container.

    In Asp.Net Core 6 (.NET 6), Microsoft unifies Startup.cs and Program.cs into a single Program.cs.

    In asp.net core 6 (and up), we need to add all such as registering middleware to the application pipeline, adding services to the IoC container, configuring the ‘application configuration’, configuring the logger, authentication and adding DbContext in Program.cs file.



What does WebApplication.CreateBuilder() do?

    This method does the following things.

    Configure the app to use Kestrel as web server.

    Specify to use the current project directory as root directory for the application.

    Setup the configuration sub-system to read setting from appsettings.json and appsettings.{env}.json to environment specific configuration.

    Set Local user secrets storage only for the development environment.

    Configure environment variables to allow for server-specific settings.

    Configure command line arguments (if any).

    Configure logging to read from the Logging section of the appsettings.json file and log to the Console and Debug window.

    Configure integration with IIS

    Configure the default service provider.

## Seccion 3
## Respuestas
What is HTTP?

    HTTP stands for Hypertext Transfer Protocol. It is a set of rule which is used for transferring the information like text, audio, video, graphic image and other multimedia files on the WWW (World Wide Web).

    HTTP is a protocol that is used to transfer the hypertext from the client end to the server.

What is the format of a Request Message?

    HTTP Requests are messages which are sent by the client to initiate an action on the server.

    It consists of various things:

    1. Request Line: The Request-Line includes with HTTP method, Url, HTTP version.

    2. Request Headers: Contains request-header fields that allow the client to pass additional information to the server, logically equivalent to the parameters while method invocation in a programming language.

    3. Request body: Contains actual content to send to server; such as query string, JSON, XML etc.

What are the important HTTP methods (or HTTP verbs) – (GET, POST, PUT, PATCH, HEAD, DELETE)?

    HTTP defines a set of request methods to indicate the desired action to be performed for a given resource.

    The “GET” and “POST” are most used in HTML forms. The default request type in browsers while opening a page, is “GET”.

    The “GET”, “POST”, “PUT”, “PATCH”, “HEAD” and “DELETE” are used in RESTful HTTP services, such as “Web API controllers”.

    GET: This method retrieves information from the given server using a given URI. GET request can retrieve the data. It cannot apply other side effects (changes) on the data.

    POST: The POST request sends the data to the server. For example sending user details in a registration form, or in a login form.

    PUT: The PUT method is used to replace (update) an existing record with the provided new record. The client sends the entire record that needs to be updated.

    PATCH: The PATCH method is to update a part of an existing record. The client sends part of the record that needs to be updated.

    HEAD: The HEAD method is the same as the GET method. It is used to transfer the response start line and headers section only (without response body). It can be used when there is no need of sending response body to server; but the server wants to communicate to the client that the necessary operation (such as database updation) has been completed.

    DELETE: The DELETE method is used to remove an existing record based on the parameters supplied in the request.

What are the important HTTP status codes?

    An HTTP status code is a server response to a browser’s request. It indicates status of completed action as a response to the request.

    HTTP status code classes:

    1xx – Informational

    2xx – Success

    3xx – Redirection

    4xx – Client errors

    5xx – Server errors



    Important HTTP status codes:

    200 – OK: The ideal & commonly-used status code that represents normal functioning of a server resource (Eg: page)

    201 – Created: Indicates that the server has created (inserted) a record in the data store. It is generally used as response in POST request in RESTful services using as Web API.

    301 – Moved Permanently: Represents one URL needs to be redirected to another permanently. A 301 redirect means that visitors and bots that land on that page will be passed to the new URL. That means the first URL will no longer work in future.

    302 – Found: Represents a temporary redirection from one URL to another. That means, the first URL might work in the near future.

    400 – Bad Request: The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).

    401 – Unauthorized: Although the HTTP standard specifies "unauthorized", semantically this response means "unauthenticated". That is, the client must authenticate itself to get the requested response.

    404 – Not Found: This means the file or page that the browser is requesting wasn’t found by the server. 404s don’t indicate whether the missing page or resource is missing permanently or only temporarily.

    405 – Method Not Allowed: This is mostly used for RESTful services such as Web API. It indicates that the request method is known by the server but the HTTP method is not supported by the server resource. For example, an API may allow GET and POST only; may not allow calling PUT request.

    500 – Internal Server Error: Indicates there is some runtime error (exception) while executing the code at server side.

What is Content Negotiation in HTTP?

    In HTTP, content negotiation is the mechanism that is used for serving different representations of a resource to the same URI to help the user agent specify which representation is best suited for the user (for example, which document language, which image format, or which content encoding).

    For example, the client may ask for XML data instead of receiving content in JSON format.

    It is generally done using “Accept” request header.

    Eg:

    Accept: application/xml

Explain how HTTP protocol works?

    Hypertext Transfer Protocol (HTTP) is an application-layer protocol for transmitting hypermedia documents, such as HTML. It handles communication between web browsers and web servers. HTTP follows a classical client-server model. A client, such as a web browser, opens a connection to make a request, then waits until it receives a response from the server.



    HTTP is a protocol that allows the fetching of resources, such as HTML documents. It is the foundation of any data exchange on the Web, and it is a client-server protocol, which means requests are initiated by the recipient, usually the Web browser.

What is a web server?

    The term web server can refer to both hardware and software, working separately or together.



    On the hardware side, a web server is a computer with more processing power and memory that stores the application’s back-end code and static assets such as images and JavaScript, CSS, HTML files. This computer is connected to the internet and allows data flow between connected devices.



    On the software side, a web server is a program that accepts HTTP requests from the clients, such as a web browser, processes the request, and returns a response. The response can be static, i.e. image/text, or dynamic, i.e. calculated total of the shopping cart.



    Popular examples of web servers include Apache, Nginx, and IIS.

## Seccion4
## Respuestas
What is middleware?

    It is the code that is injected into the application pipeline to handle requests and responses. They are just like chained to each other and form as a pipeline. The incoming requests are passed through this pipeline where all middleware is configured, and middleware can perform some action on the request before passing it to the next middleware. Same as for the responses, they are also passing through the middleware but in reverse order.

    The main responsibilities of a middleware:

    Generate an HTTP response for an incoming HTTP request

    Intercept and make changes to an incoming HTTP request and pass it on to the next piece of middleware.

    Intercept and make changes to an outgoing HTTP response, and pass it on to the next piece of middleware.




What is the difference between IApplicationBuilder.Use() and IApplicationBuilder.Run()?

    We can use both the methods while defining application request pipeline. Both are used to add middleware delegates to the application request pipeline. The middleware that is added using IApplicationBuilder.Use() may call the next middleware in the pipeline whereas the middleware that is added using the IApplicationBuilder.Run() method never calls the subsequent middleware. After IApplicationBuilder.Run method, system stop adding middleware in the request pipeline.

    The IApplicationBuilder.Run() adds a terminating middleware; so no other middleware will run after the middleware added with Run().

    What is the use of the "Map" extension while adding middleware to the ASP.NET Core pipeline?

    It is used for branching the pipeline. It branches the ASP.NET Core pipeline based on request path matching. If the request path starts with the given path, middleware on to that branch will execute.

    How do you create a custom middleware?

    The custom middleware class can be used to separate the middleware code from the Program.cs (or Startup.cs in earlier versions).

    You can create a custom middleware either by implementing IMiddleware interface or by using convention middleware



    Implementing IMiddleware:

    public class MyCustomMiddleware : IMiddleware
    {
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
    //TO DO: before logic
    await next(context);
    //TO DO: after logic
    }
    }


    Convention Middleware:

    public class MyCustomMiddleware
    {
    private readonly RequestDelegate _next:
    public MiddlewareClassName(RequestDeletegate next)
    {
    }

    public async Task InvokeAsync(HttpContext context)
    {
    //TO DO: before logic
    await _next(context);
    //TO DO: after logic
    }
    }
What is the right order of middleware used in production-level applications?

    You can see how, in a typical app, existing middlewares are ordered and where custom middlewares are added. You have full control over how to reorder existing middlewares or inject new custom middlewares as necessary for your scenarios.

