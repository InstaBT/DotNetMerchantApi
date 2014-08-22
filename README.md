InstaBT Payments .NET API
=========================

Below is a code snippet example of how to implement the InstaBT Payments API in .NET

```CSharp

var client = new InstaBT.Api.Merchant("https://api.instabt.com"
// Do not use these keys, create a new pair of API keys in the control panel
  , "ENTER_YOUR_API_KEY_HERE"
  , "ENTER_YOUR_API_SECRET_HERE");
  
  
client.Data = invoice.Id;
client.Ttl  = 30; // minutes

var order = client.CreateOrder(invoice.Amount,"CAD");

RedirectToUrl(order.url);

```
