## Webservice/WebAPI/SOAP/Resful  开发/调用/协议/代码实例

#### 1.SOAP

- SOAP (Simple Object Access Protocol) 是一种基于XML的通信协议，主要用于Web服务（Web Services）中的应用程序之间的通信。它定义了一种格式，使得应用程序可以在网络上交换结构化的信息。SOAP使用HTTP作为底层通信协议，但它并不仅限于HTTP，它也可以使用SMTP等其他协议。SOAP消息的格式可以自定义，但通常包括一个envelope元素，用于包装整个消息，并定义消息头和消息体。
- 使用C#开发的ASMX（Active Server Pages .NET Web Services）默认使用SOAP（Simple Object Access Protocol）协议进行通信。ASMX是一种早期的Web服务技术，它使用SOAP协议作为其默认协议，以在Web应用程序之间进行通信。
- ASMX默认使用SOAP（Simple Object Access Protocol）协议来实现Web服务，但是ASMX还支持使用非SOAP方式实现Web服务。除了使用SOAP协议外，ASMX还支持使用GET和POST等HTTP方法来实现Web服务。这种方式可以返回文本、XML或JSON等格式的数据，而不需要使用SOAP协议。
- 对于复杂的自定义类型参数，使用SOAP协议可能是更好的选择，因为它可以轻松地传递任意类型的参数。如果您需要使用HTTP GET/POST请求传递自定义类型的参数，您可能需要进行序列化和反序列化处理才能在客户端和服务器之间传输数据。



#### 2.RESTful API

- Web API 可以使用 SOAP 协议，但是现在已经不再流行。SOAP（Simple Object Access Protocol）是一种基于 XML 的协议，用于在 Web 服务中交换结构化的信息。SOAP 主要用于企业级应用程序集成，其中需要进行高度可靠和安全的通信。
- 现在更多的 Web API 使用的是基于 HTTP 的 REST（Representational State Transfer）协议格式进行传输。RESTful API 是一种基于资源的架构风格，使用统一的接口进行通信。它使用 HTTP 动词（GET、POST、PUT、DELETE 等）对资源进行操作，并使用 HTTP 状态码（200、201、400、404 等）表示操作结果。RESTful API 的请求和响应通常使用 JSON（JavaScript Object Notation）或 XML（Extensible Markup Language）格式进行序列化和反序列化。
- RESTful API 是一种基于资源的架构风格，而不是一种协议。实际上，REST（Representational State Transfer）并不是一种协议，而是一组架构原则和约束条件，可以帮助我们设计出符合 REST 风格的 API。但是在实际应用中，我们通常将符合 REST 风格的 API 称为 RESTful API，并将其视为一种协议。这是因为 RESTful API 通常使用 HTTP 协议作为通信协议，使用统一的接口（URI、HTTP 方法、HTTP 头部和消息体）进行通信。这些接口规范了客户端和服务器之间的数据传输方式和格式，因此也被视为一种协议。因此，在实际应用中，我们可以将 RESTful API 看作是一种符合 REST 风格的协议，而不仅仅是一种风格或规范。



#### 3.Webservice的调用

1. ##### **WSDL**

   - WSDL（Web Services Description Language）是一种基于 XML 的语言，用于描述 Web 服务的接口、数据格式和通信协议。WSDL 文件通常包含 Web 服务的地址、可用方法、参数、返回值和数据类型等信息，客户端可以根据 WSDL 文件生成代码，并使用代码与 Web 服务进行交互。WSDL 文件使得 Web 服务的开发和调用变得更加简单和可靠。

   - 使用Visual Studio 的命令提示符（或在开始菜单中找到 Developer Command Prompt）可以生成相应文件

     ```
     wsdl.exe http://localhost/MyWebService/MyService.asmx?wsdl /out:C:\MyService.cs
     ```

   

2. ##### 返回值为基本参数的Invoke

3. ##### 输入信息为基本参数的XML请求

##### 