# Org.OpenAPITools.Api.WinnersApi

All URIs are relative to *https://api.tiketeo.mx/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckWinner**](WinnersApi.md#checkwinner) | **POST** /winners/check | Check Winner
[**ClaimWinner**](WinnersApi.md#claimwinner) | **POST** /winners/{winnerId}/claim | Claim Winner



## CheckWinner

> InlineResponse2001 CheckWinner (Body2 body2 = null)

Check Winner

Obtiene la información de un ganaddor

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CheckWinnerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.tiketeo.mx/v1";
            // Configure HTTP bearer authorization: BearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WinnersApi(Configuration.Default);
            var body2 = new Body2(); // Body2 |  (optional) 

            try
            {
                // Check Winner
                InlineResponse2001 result = apiInstance.CheckWinner(body2);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WinnersApi.CheckWinner: " + e.Message );
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
 **body2** | [**Body2**](Body2.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Check Winner |  -  |
| **404** | The specified resource was not found |  -  |
| **422** | There are errors in the request body |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClaimWinner

> InlineResponse2001 ClaimWinner (Guid winnerId)

Claim Winner

Confirma que un ganador haya obtenido su premio

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClaimWinnerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.tiketeo.mx/v1";
            // Configure HTTP bearer authorization: BearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WinnersApi(Configuration.Default);
            var winnerId = new Guid(); // Guid | El ID del ganador obtenido en `/winners/check`

            try
            {
                // Claim Winner
                InlineResponse2001 result = apiInstance.ClaimWinner(winnerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WinnersApi.ClaimWinner: " + e.Message );
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
 **winnerId** | [**Guid**](Guid.md)| El ID del ganador obtenido en &#x60;/winners/check&#x60; | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Claim winner |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

