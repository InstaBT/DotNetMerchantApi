namespace InstaBT.Api

open System.Text

open Romeo.Common
open Romeo.Client

open Newtonsoft.Json

type Merchant(url : string, api_key : string, api_secret : string ) =

  let config = 
    { server_url = url
    ; api_key = api_key
    ; app_secret = api_secret
    ; debug = false }

  let mutable data  : string  = ""
  let mutable priority : int = 0;
  let mutable ttl : int = 15;

  let mutable url_call_back = ""
  let mutable url_success = ""
  let mutable url_failure = ""

  member this.CreateOrder(amount : decimal, currency : string ) = 

   let bytes = 
     call config "/create_order" 
       [| ("amount", amount.ToString())
        ; ("currency", currency)
        ; ("data", data) 
        ; ("priority", priority.ToString()) 
        ; ("ttl", ttl.ToString()) 
        ; ("url_call_back", url_call_back) 
        ; ("url_success", url_success) 
        ; ("url_failure", url_failure) |]

   let str = Encoding.UTF8.GetString bytes

   JsonConvert.DeserializeObject<Model.MerchantOrder> str

  member this.CreateOrderString(amount : decimal, currency : string ) = 

   let bytes = call config "/create_order" [| ("amount", amount.ToString()); ("currency", currency)|]

   Encoding.UTF8.GetString bytes

  member x.Data with get() = data and set(v) = data <- v
  member x.Priority with get() = priority and set(v) = priority <- v
  member x.Ttl with get() = ttl and set(v) = ttl <- v

  member x.UrlCallback with get() = url_call_back and set(v) = url_call_back <- v
  member x.UrlSuccess with get() = url_success and set(v) = url_success <- v
  member x.UrlFailure with get() = url_failure and set(v) = url_failure <- v