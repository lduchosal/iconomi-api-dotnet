# IO.Swagger.Api.StrategiesApi

All URIs are relative to *https://api.iconomi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Charts**](StrategiesApi.md#charts) | **GET** /v1/strategies/{ticker}/pricehistory | Historical information
[**DaaBalance**](StrategiesApi.md#daabalance) | **GET** /v1/strategies/{ticker}/balance | Balance
[**DaaPrice**](StrategiesApi.md#daaprice) | **GET** /v1/strategies/{ticker}/price | Current ticker
[**GetStatistics**](StrategiesApi.md#getstatistics) | **GET** /v1/strategies/{ticker}/statistics | Statistics
[**Info**](StrategiesApi.md#info) | **GET** /v1/strategies/{ticker} | Strategy details
[**StrategyList**](StrategiesApi.md#strategylist) | **GET** /v1/strategies | List of Strategies
[**Structure**](StrategiesApi.md#structure) | **GET** /v1/strategies/{ticker}/structure | Structure
[**SubmitStructure**](StrategiesApi.md#submitstructure) | **POST** /v1/strategies/{ticker}/structure | Structure

<a name="charts"></a>
# **Charts**
> Chart Charts (string ticker, string currency = null, long? from = null, long? to = null, string granulation = null)

Historical information

The price history returns data points for the given period. Different granulation of data can be returned based on the length of the period provided from daily to 5 minute (one  price point per period).  From and to are optional parameters (both are either suplied or neither is supplied). If from/to are not supplied a default of last month is returned with hourly granulation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChartsExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)
            var from = 789;  // long? |  (optional) 
            var to = 789;  // long? |  (optional) 
            var granulation = granulation_example;  // string | Granulation for price points. See granulation enumeration section for more details. (optional) 

            try
            {
                // Historical information
                Chart result = apiInstance.Charts(ticker, currency, from, to, granulation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.Charts: " + e.Message );
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
 **granulation** | **string**| Granulation for price points. See granulation enumeration section for more details. | [optional] 

### Return type

[**Chart**](Chart.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="daabalance"></a>
# **DaaBalance**
> StrategyBalance DaaBalance (string ticker)

Balance

Endpoint requires manager authentication with institutional role. Returns live balances underlying assets of strategy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DaaBalanceExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | 

            try
            {
                // Balance
                StrategyBalance result = apiInstance.DaaBalance(ticker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.DaaBalance: " + e.Message );
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

[**StrategyBalance**](StrategyBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="daaprice"></a>
# **DaaPrice**
> Ticker DaaPrice (string ticker, string currency = null)

Current ticker

Returns the current ticker of the Strategy. The price is refreshed every minute.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DaaPriceExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)

            try
            {
                // Current ticker
                Ticker result = apiInstance.DaaPrice(ticker, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.DaaPrice: " + e.Message );
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
<a name="getstatistics"></a>
# **GetStatistics**
> Statistics GetStatistics (string ticker, string currency = null)

Statistics

Returns statistics of the strategy; returns, max drawdown and volatility for strategy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatisticsExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)

            try
            {
                // Statistics
                Statistics result = apiInstance.GetStatistics(ticker, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.GetStatistics: " + e.Message );
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
<a name="info"></a>
# **Info**
> Strategy Info (string ticker)

Strategy details

Returns information about one specific strategy.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InfoExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | Ticker of structure

            try
            {
                // Strategy details
                Strategy result = apiInstance.Info(ticker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.Info: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**| Ticker of structure | 

### Return type

[**Strategy**](Strategy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="strategylist"></a>
# **StrategyList**
> List<Strategy> StrategyList ()

List of Strategies

Returns a list of all public Strategies.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StrategyListExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();

            try
            {
                // List of Strategies
                List&lt;Strategy&gt; result = apiInstance.StrategyList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.StrategyList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Strategy>**](Strategy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="structure"></a>
# **Structure**
> Structure Structure (string ticker, string currency = null)

Structure

Returns the current structure of a strategy. The same result entity is returned  for both PASSIVE and ACTIVE type DAAs, but for ACTIVE DAAs rebalancedWeight  and targetWeight are always set to 0.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StructureExample
    {
        public void main()
        {
            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | 
            var currency = currency_example;  // string |  (optional)  (default to USD)

            try
            {
                // Structure
                Structure result = apiInstance.Structure(ticker, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.Structure: " + e.Message );
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

[**Structure**](Structure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="submitstructure"></a>
# **SubmitStructure**
> Structure SubmitStructure (string ticker, StructureSubmit body = null)

Structure

Endpoint requires authentication. Creates and submits a new structure for a given strategy.   Response is the same object as GET to /v1/strategies/{ticker}/structure.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SubmitStructureExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ICN-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ICN-API-KEY", "Bearer");
            // Configure API key authorization: ApiSign
            Configuration.Default.AddApiKey("ICN-SIGN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ICN-SIGN", "Bearer");
            // Configure API key authorization: ApiTimestamp
            Configuration.Default.AddApiKey("ICN-TIMESTAMP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ICN-TIMESTAMP", "Bearer");

            var apiInstance = new StrategiesApi();
            var ticker = ticker_example;  // string | 
            var body = new StructureSubmit(); // StructureSubmit |  (optional) 

            try
            {
                // Structure
                Structure result = apiInstance.SubmitStructure(ticker, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StrategiesApi.SubmitStructure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**|  | 
 **body** | [**StructureSubmit**](StructureSubmit.md)|  | [optional] 

### Return type

[**Structure**](Structure.md)

### Authorization

[ApiKey](../README.md#ApiKey), [ApiSign](../README.md#ApiSign), [ApiTimestamp](../README.md#ApiTimestamp)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
