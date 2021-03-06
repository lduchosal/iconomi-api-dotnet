# IconomiApi - the C# library for the Iconomi API

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.3
- SDK version: 1.3
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class Example
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


```csharp
using System;
using System.Diagnostics;
using IconomiApi.Api;
using IconomiApi.Client;
using IconomiApi.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            string API_KEY = "API_KEY";
            string API_SECRET = "API_SECRET";

            var users = new UserApi();
            
            users.Configuration.ApiClient.SetAuthentication(API_KEY, API_SECRET, API_DEBUG);
            users.Configuration.ApiClient.RestClient.Timeout = TimeSpan.FromSeconds(5);

            try
            {
                var result = users.GetUserBalance();
                var j = JsonConvert.SerializeObject(result);
                Console.WriteLine(j);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.ErrorCode);
            }
        }
    }
}
```





<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.iconomi.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AssetApi* | [**AssetDetails**](docs/AssetApi.md#assetdetails) | **GET** /v1/assets/{ticker} | Asset details
*AssetApi* | [**AssetHistory**](docs/AssetApi.md#assethistory) | **GET** /v1/assets/{ticker}/pricehistory | Historical information
*AssetApi* | [**AssetList**](docs/AssetApi.md#assetlist) | **GET** /v1/assets | List of Assets
*AssetApi* | [**AssetStatistics**](docs/AssetApi.md#assetstatistics) | **GET** /v1/assets/{ticker}/statistics | Statistics
*AssetApi* | [**AssetTicker**](docs/AssetApi.md#assetticker) | **GET** /v1/assets/{ticker}/price | Current ticker
*StrategiesApi* | [**Charts**](docs/StrategiesApi.md#charts) | **GET** /v1/strategies/{ticker}/pricehistory | Historical information
*StrategiesApi* | [**DaaBalance**](docs/StrategiesApi.md#daabalance) | **GET** /v1/strategies/{ticker}/balance | Balance
*StrategiesApi* | [**DaaPrice**](docs/StrategiesApi.md#daaprice) | **GET** /v1/strategies/{ticker}/price | Current ticker
*StrategiesApi* | [**GetStatistics**](docs/StrategiesApi.md#getstatistics) | **GET** /v1/strategies/{ticker}/statistics | Statistics
*StrategiesApi* | [**Info**](docs/StrategiesApi.md#info) | **GET** /v1/strategies/{ticker} | Strategy details
*StrategiesApi* | [**StrategyList**](docs/StrategiesApi.md#strategylist) | **GET** /v1/strategies | List of Strategies
*StrategiesApi* | [**Structure**](docs/StrategiesApi.md#structure) | **GET** /v1/strategies/{ticker}/structure | Structure
*StrategiesApi* | [**SubmitStructure**](docs/StrategiesApi.md#submitstructure) | **POST** /v1/strategies/{ticker}/structure | Structure
*TradingApi* | [**CancelOrder**](docs/TradingApi.md#cancelorder) | **DELETE** /v1/order/{orderId} | Delete
*TradingApi* | [**ConfirmOffer**](docs/TradingApi.md#confirmoffer) | **POST** /v1/order/offer/{offerId}/confirm | Confirm trade offer
*TradingApi* | [**GetAllOrders**](docs/TradingApi.md#getallorders) | **GET** /v1/order/orders | List of orders
*TradingApi* | [**OrderOffer**](docs/TradingApi.md#orderoffer) | **POST** /v1/order/offer | Trade offer
*TradingApi* | [**OrderTrade**](docs/TradingApi.md#ordertrade) | **POST** /v1/order | Place order
*TradingApi* | [**Status**](docs/TradingApi.md#status) | **GET** /v1/order/{orderId} | Logical order
*UserApi* | [**GetActivities**](docs/UserApi.md#getactivities) | **GET** /v1/user/activity | Activity
*UserApi* | [**GetDepositAddress**](docs/UserApi.md#getdepositaddress) | **GET** /v1/user/deposit/{currency} | Deposit
*UserApi* | [**GetUserBalance**](docs/UserApi.md#getuserbalance) | **GET** /v1/user/balance | User Balance
*UserApi* | [**TransactionInfo**](docs/UserApi.md#transactioninfo) | **GET** /v1/user/transaction/{transactionId} | Transaction
*UserApi* | [**Withdraw**](docs/UserApi.md#withdraw) | **POST** /v1/user/withdraw | Withdraw

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Activity](docs/Activity.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetInfo](docs/AssetInfo.md)
 - [Model.Balance](docs/Balance.md)
 - [Model.BalanceEntry](docs/BalanceEntry.md)
 - [Model.Chart](docs/Chart.md)
 - [Model.ChartPoint](docs/ChartPoint.md)
 - [Model.Deposit](docs/Deposit.md)
 - [Model.EnumMapIntervalBigDecimal](docs/EnumMapIntervalBigDecimal.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderInfo](docs/OrderInfo.md)
 - [Model.OrderOffer](docs/OrderOffer.md)
 - [Model.Statistics](docs/Statistics.md)
 - [Model.StatisticsReturns](docs/StatisticsReturns.md)
 - [Model.Strategy](docs/Strategy.md)
 - [Model.StrategyBalance](docs/StrategyBalance.md)
 - [Model.StrategyBalanceElement](docs/StrategyBalanceElement.md)
 - [Model.Structure](docs/Structure.md)
 - [Model.StructureElement](docs/StructureElement.md)
 - [Model.StructureSubmit](docs/StructureSubmit.md)
 - [Model.SubmitStructureElement](docs/SubmitStructureElement.md)
 - [Model.Ticker](docs/Ticker.md)
 - [Model.TradeConfirm](docs/TradeConfirm.md)
 - [Model.TradeOffer](docs/TradeOffer.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.Withdraw](docs/Withdraw.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKey"></a>
### ApiKey

- **Type**: API key
- **API key parameter name**: ICN-API-KEY
- **Location**: HTTP header

<a name="ApiSign"></a>
### ApiSign

- **Type**: API key
- **API key parameter name**: ICN-SIGN
- **Location**: HTTP header

<a name="ApiTimestamp"></a>
### ApiTimestamp

- **Type**: API key
- **API key parameter name**: ICN-TIMESTAMP
- **Location**: HTTP header

