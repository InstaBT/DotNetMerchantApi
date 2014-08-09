namespace InstaBT.Api

open Romeo.Common
open Romeo.Client

type Merchant(url : string, api_key : string, api_secret : string ) =
  let config = { server_url = url; api_key = api_key; app_secret = api_secret; debug = false}
  member this.CreateOrder(amount : decimal, currency : string ) = 
   call config "/create_order" [| ("amount", amount.ToString()); ("currency", currency)|]
