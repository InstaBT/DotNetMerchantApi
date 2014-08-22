InstaBT Payments .NET API
=========================

Below is a code snippet example of how to implement the InstaBT Payments API in .NET

```CSharp

var client = new InstaBT.Api.Merchant("https://api.instabt.com"
// Do not use these keys, create a new pair of API keys in the control panel
  , "ENTER_YOUR_API_KEY_HERE"
  , "ENTER_YOUR_API_SECRET_HERE");

var order = client.CreateOrder(invoice.Amount,"CAD");

order.Data = invoice.Id;
order.Ttl  = 30; // minutes

RedirectToUrl(order.url);

```
