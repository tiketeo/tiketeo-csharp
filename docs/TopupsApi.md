# Org.OpenAPITools.Api.TopupsApi

All URIs are relative to *https://api.tiketeo.mx/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTopup**](TopupsApi.md#createtopup) | **POST** /topups | Create topup
[**ListBillersTopups**](TopupsApi.md#listbillerstopups) | **GET** /topups/billers | List topups billers



## CreateTopup

> InlineResponse201 CreateTopup (Body body = null)

Create topup

Crear una recarga

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateTopupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.tiketeo.mx/v1";
            // Configure HTTP bearer authorization: BearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TopupsApi(Configuration.Default);
            var body = new Body(); // Body |  (optional) 

            try
            {
                // Create topup
                InlineResponse201 result = apiInstance.CreateTopup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TopupsApi.CreateTopup: " + e.Message );
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
 **body** | [**Body**](Body.md)|  | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create topup |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListBillersTopups

> InlineResponse200 ListBillersTopups ()

List topups billers

Lista de billers

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListBillersTopupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.tiketeo.mx/v1";
            // Configure HTTP bearer authorization: BearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TopupsApi(Configuration.Default);

            try
            {
                // List topups billers
                InlineResponse200 result = apiInstance.ListBillersTopups();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TopupsApi.ListBillersTopups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

