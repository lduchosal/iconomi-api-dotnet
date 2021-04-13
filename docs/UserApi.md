# IO.Swagger.Api.UserApi

All URIs are relative to *https://api.iconomi.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActivities**](UserApi.md#getactivities) | **GET** /v1/user/activity | Activity
[**GetDepositAddress**](UserApi.md#getdepositaddress) | **GET** /v1/user/deposit/{currency} | Deposit
[**GetUserBalance**](UserApi.md#getuserbalance) | **GET** /v1/user/balance | User Balance
[**TransactionInfo**](UserApi.md#transactioninfo) | **GET** /v1/user/transaction/{transactionId} | Transaction
[**Withdraw**](UserApi.md#withdraw) | **POST** /v1/user/withdraw | Withdraw

<a name="getactivities"></a>
# **GetActivities**
> Activity GetActivities (string type = null, int? pageSize = null, int? pageNumber = null)

Activity

Endpoint returns user's activity (buy, sell, deposit, withdraw).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivitiesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var type = type_example;  // string |  (optional)  (default to MY_ACTIVITIES)
            var pageSize = 56;  // int? |  (optional) 
            var pageNumber = 56;  // int? |  (optional) 

            try
            {
                // Activity
                Activity result = apiInstance.GetActivities(type, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | [optional] [default to MY_ACTIVITIES]
 **pageSize** | **int?**|  | [optional] 
 **pageNumber** | **int?**|  | [optional] 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdepositaddress"></a>
# **GetDepositAddress**
> Deposit GetDepositAddress (string currency)

Deposit

Endpoint returns user's crypto address.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDepositAddressExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var currency = currency_example;  // string | 

            try
            {
                // Deposit
                Deposit result = apiInstance.GetDepositAddress(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetDepositAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**|  | 

### Return type

[**Deposit**](Deposit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuserbalance"></a>
# **GetUserBalance**
> Balance GetUserBalance (string currency = null)

User Balance

Endpoint requires authentication. Returns the balance based on the authentication of the user.   There is an optional query parameter currency that changes the resulting fiat value calculation to chosen currency. Possibly values are EUR or USD.  ##### Request  Empty body.  ##### Response  | Parameter  | Description   | Sample  | |- --|- --|- --| | **currency** <br> *String*        |   Currency in which the values are returned | USD  | | **daaList** <br> *BalanceEntry*     | Array of portfolios balances   |   | | **assetList** <br> *BalanceEntry*     | Array of cryptocurrency balances  |   |  BalanceEntry is of the following structure:  | Parameter  | Description   | Sample  | | - --|- --|- --| | **name** <br> _String_ | Name of asset | Blockchain index  | | **ticker** <br> _String_  | Ticker of asset  | BLX  | | **balance** <br> _String_  | Balance of the asset  | 1337  | | **value** <br> _String_  | Value in USD or EUR (depending on the optional currency in query string)  | 4700  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserBalanceExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var currency = currency_example;  // string |  (optional)  (default to USD)

            try
            {
                // User Balance
                Balance result = apiInstance.GetUserBalance(currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**|  | [optional] [default to USD]

### Return type

[**Balance**](Balance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="transactioninfo"></a>
# **TransactionInfo**
> Transaction TransactionInfo (string transactionId)

Transaction

Endpoint returns details about user's transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransactionInfoExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var transactionId = transactionId_example;  // string | 

            try
            {
                // Transaction
                Transaction result = apiInstance.TransactionInfo(transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.TransactionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**|  | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="withdraw"></a>
# **Withdraw**
> Transaction Withdraw (Withdraw body = null)

Withdraw

Endpoint allows to make withdraw asset from user's account to recipient's address. Recipient's address must be whitelisted at ICONOMI platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WithdrawExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var body = new Withdraw(); // Withdraw |  (optional) 

            try
            {
                // Withdraw
                Transaction result = apiInstance.Withdraw(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.Withdraw: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Withdraw**](Withdraw.md)|  | [optional] 

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
