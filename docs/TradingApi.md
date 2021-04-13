# IO.Swagger.Api.TradingApi

All URIs are relative to *https://api.iconomi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelOrder**](TradingApi.md#cancelorder) | **DELETE** /v1/order/{orderId} | Delete
[**ConfirmOffer**](TradingApi.md#confirmoffer) | **POST** /v1/order/offer/{offerId}/confirm | Confirm trade offer
[**GetAllOrders**](TradingApi.md#getallorders) | **GET** /v1/order/orders | List of orders
[**OrderOffer**](TradingApi.md#orderoffer) | **POST** /v1/order/offer | Trade offer
[**OrderTrade**](TradingApi.md#ordertrade) | **POST** /v1/order | Place order
[**Status**](TradingApi.md#status) | **GET** /v1/order/{orderId} | Logical order

<a name="cancelorder"></a>
# **CancelOrder**
> OrderInfo CancelOrder (string orderId, string accountId = null)

Delete

Remove user's logical order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelOrderExample
    {
        public void main()
        {
            var apiInstance = new TradingApi();
            var orderId = orderId_example;  // string | 
            var accountId = accountId_example;  // string |  (optional) 

            try
            {
                // Delete
                OrderInfo result = apiInstance.CancelOrder(orderId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradingApi.CancelOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**|  | 
 **accountId** | **string**|  | [optional] 

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="confirmoffer"></a>
# **ConfirmOffer**
> TradeConfirm ConfirmOffer (string offerId)

Confirm trade offer

This endpoint confirms generated trade offer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfirmOfferExample
    {
        public void main()
        {
            var apiInstance = new TradingApi();
            var offerId = offerId_example;  // string | 

            try
            {
                // Confirm trade offer
                TradeConfirm result = apiInstance.ConfirmOffer(offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradingApi.ConfirmOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **string**|  | 

### Return type

[**TradeConfirm**](TradeConfirm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallorders"></a>
# **GetAllOrders**
> List<OrderInfo> GetAllOrders (string accountId = null)

List of orders

Returns a list of all user's logical orders.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllOrdersExample
    {
        public void main()
        {
            var apiInstance = new TradingApi();
            var accountId = accountId_example;  // string |  (optional) 

            try
            {
                // List of orders
                List&lt;OrderInfo&gt; result = apiInstance.GetAllOrders(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradingApi.GetAllOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**|  | [optional] 

### Return type

[**List<OrderInfo>**](OrderInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="orderoffer"></a>
# **OrderOffer**
> TradeOffer OrderOffer (OrderOffer body = null)

Trade offer

Generating trade offer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderOfferExample
    {
        public void main()
        {
            var apiInstance = new TradingApi();
            var body = new OrderOffer(); // OrderOffer |  (optional) 

            try
            {
                // Trade offer
                TradeOffer result = apiInstance.OrderOffer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradingApi.OrderOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OrderOffer**](OrderOffer.md)|  | [optional] 

### Return type

[**TradeOffer**](TradeOffer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ordertrade"></a>
# **OrderTrade**
> OrderInfo OrderTrade (Order body = null)

Place order

Placing user's logical order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OrderTradeExample
    {
        public void main()
        {
            var apiInstance = new TradingApi();
            var body = new Order(); // Order |  (optional) 

            try
            {
                // Place order
                OrderInfo result = apiInstance.OrderTrade(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradingApi.OrderTrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Order**](Order.md)|  | [optional] 

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="status"></a>
# **Status**
> OrderInfo Status (string orderId, string accountId = null)

Logical order

Returns a user's logical order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StatusExample
    {
        public void main()
        {
            var apiInstance = new TradingApi();
            var orderId = orderId_example;  // string | 
            var accountId = accountId_example;  // string |  (optional) 

            try
            {
                // Logical order
                OrderInfo result = apiInstance.Status(orderId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradingApi.Status: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**|  | 
 **accountId** | **string**|  | [optional] 

### Return type

[**OrderInfo**](OrderInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
