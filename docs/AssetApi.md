# IconomiApi.Api.AssetApi

All URIs are relative to *https://api.iconomi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssetDetails**](AssetApi.md#assetdetails) | **GET** /v1/assets/{ticker} | Asset details
[**AssetHistory**](AssetApi.md#assethistory) | **GET** /v1/assets/{ticker}/pricehistory | Historical information
[**AssetList**](AssetApi.md#assetlist) | **GET** /v1/assets | List of Assets
[**AssetStatistics**](AssetApi.md#assetstatistics) | **GET** /v1/assets/{ticker}/statistics | Statistics
[**AssetTicker**](AssetApi.md#assetticker) | **GET** /v1/assets/{ticker}/price | Current ticker

<a name="assetdetails"></a>
# **AssetDetails**
> AssetInfo AssetDetails (string ticker)

Asset details

Returns information about one specific Asset.

### Example
```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class AssetDetailsExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var ticker = ticker_example;  // string | 

            try
            {
                // Asset details
                AssetInfo result = apiInstance.AssetDetails(ticker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**|  | 

### Return type

[**AssetInfo**](AssetInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assethistory"></a>
# **AssetHistory**
> Chart AssetHistory (string ticker, string currency = null, long? from = null, long? to = null, string granulation = null)

Historical information

The price history returns data points for the given period. Different granulation of data can be returned based on the length of the period provided from daily to 5 minute (one  price point per period).  From and to are optional parameters (both are either supplied or neither is supplied). If from/to are not supplied a default of last month is returned with hourly granulation.

### Example
```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class AssetHistoryExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)
            var from = 789;  // long? |  (optional) 
            var to = 789;  // long? |  (optional) 
            var granulation = granulation_example;  // string |  (optional) 

            try
            {
                // Historical information
                Chart result = apiInstance.AssetHistory(ticker, currency, from, to, granulation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**|  | 
 **currency** | **string**|  | [optional] [default to USD]
 **from** | **long?**|  | [optional] 
 **to** | **long?**|  | [optional] 
 **granulation** | **string**|  | [optional] 

### Return type

[**Chart**](Chart.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetlist"></a>
# **AssetList**
> List<Asset> AssetList ()

List of Assets

Returns a list of all assets on platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class AssetListExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();

            try
            {
                // List of Assets
                List&lt;Asset&gt; result = apiInstance.AssetList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Asset>**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetstatistics"></a>
# **AssetStatistics**
> Statistics AssetStatistics (string ticker, string currency = null)

Statistics

Returns statistics of the strategy; returns, max drawdown and volatility for strategy.

### Example
```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class AssetStatisticsExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)

            try
            {
                // Statistics
                Statistics result = apiInstance.AssetStatistics(ticker, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**|  | 
 **currency** | **string**|  | [optional] [default to USD]

### Return type

[**Statistics**](Statistics.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="assetticker"></a>
# **AssetTicker**
> Ticker AssetTicker (string ticker, string currency = null)

Current ticker

Returns the current ticker of the Asset. The price is refreshed every minute.

### Example
```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class AssetTickerExample
    {
        public void main()
        {
            var apiInstance = new AssetApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)

            try
            {
                // Current ticker
                Ticker result = apiInstance.AssetTicker(ticker, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetApi.AssetTicker: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**|  | 
 **currency** | **string**|  | [optional] [default to USD]

### Return type

[**Ticker**](Ticker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
