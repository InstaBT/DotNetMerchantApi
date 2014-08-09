DotNetMerchantApi
=================

This is a .NET client for the Merchant Payments API


Sample code.

```CSharp

var client = new InstaBT.Api.Merchant("https://api.instabt.com"
// Do not use these keys, create a new pair of API keys in the control panel
  , "38do1aiokq6mpgz0ge3232j1wba40a2fe5s7hd6efcv77ff3on5p3uacz67niina"
  , "k9d4pjphtffve62e35xg2ss2x8c8s0d9qxekyg9ezxed0fp8w631yu5ddikunffg");

var order = client.CreateOrder(invoice.Amount,"CAD"); 

RedirectToUrl(order.url);

```
