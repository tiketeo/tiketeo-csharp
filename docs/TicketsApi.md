# Org.OpenAPITools.Api.TicketsApi

All URIs are relative to *https://api.tiketeo.mx/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTicket**](TicketsApi.md#createticket) | **POST** /tickets | Create Ticket



## CreateTicket

> InlineResponse2011 CreateTicket (Body1 body1 = null)

Create Ticket

Crea un ticket de lotería utilizando el número del cliente. En `external_id` puedes agregar un ID interno (como número de ticket); ésta información será devuelta al checar si un ticket es ganador.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTicketExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.tiketeo.mx/v1";
            // Configure HTTP bearer authorization: BearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TicketsApi(Configuration.Default);
            var body1 = new Body1(); // Body1 |  (optional) 

            try
            {
                // Create Ticket
                InlineResponse2011 result = apiInstance.CreateTicket(body1);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TicketsApi.CreateTicket: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body1** | [**Body1**](Body1.md)|  | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create Ticket |  -  |
| **422** | There are errors in the request body |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

