namespace InstaBT.Api.Model

open System
open System.Runtime.Serialization

open Newtonsoft.Json

[<DataContract>]
type MerchantOrder() = 

  let mutable id : string = ""
  let mutable total    : decimal = 0.00M
  let mutable currency       : string = "btc"
  let mutable btc_required    : decimal = 0.00M
  let mutable btc_address     : string = ""
  let mutable data  : string  = ""
  let mutable created_on    : DateTime = DateTime.UtcNow
  let mutable expires_on    : DateTime = DateTime.UtcNow
  let mutable status    : string = "active"
  let mutable last_update    : DateTime = DateTime.UtcNow
  let mutable url    : string = ""

  [<JsonProperty("Id")>]
  member x.Id with get() = id and set(v) = id <- v

  [<JsonProperty("Total")>]
  member x.Total with get() = total and set(v) = total <- v
  
  [<JsonProperty("Currency")>]
  member x.Currency with get() = currency and set(v) = currency <- v
  
  [<JsonProperty("BtcRequired")>]
  member x.BtcRequired with get() = btc_required and set(v) = btc_required <- v
  
  [<JsonProperty("BtcAddress")>]
  member x.BtcAddress with get() = btc_address and set(v) = btc_address <- v

  [<JsonProperty("Data")>]
  member x.Data with get() = data and set(v) = data <- v

  [<JsonProperty("CreatedOn")>]
  member x.CreatedOn with get() = created_on and set(v) = created_on <- v

  [<JsonProperty("ExpiresOn")>]
  member x.ExpiresOn with get() = expires_on and set(v) = expires_on <- v

  [<JsonProperty("Status")>]
  member x.Status with get() = status and set(v) = status <- v

  [<JsonProperty("LastUpdate")>]
  member x.LastUpdate with get() = last_update and set(v) = last_update <- v

  [<JsonProperty("Url")>]
  member x.Url with get() = url and set(v) = url <- v