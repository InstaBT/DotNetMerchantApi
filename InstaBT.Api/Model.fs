namespace InstaBT.Api.Model

open System
open System.Runtime.Serialization


[<DataContract>]
type MerchantOrder =
  { 
  [<field: DataMember(Name = "id")>]
  id   : Guid;
  [<field: DataMember(Name = "total")>]
  total    : decimal;
  [<field: DataMember(Name = "currency")>]
  currency       : string;
  [<field: DataMember(Name = "btc_required")>]
  btc_required    : decimal;
  [<field: DataMember(Name = "btc_current")>]
  btc_current    : decimal;
  [<field: DataMember(Name = "btc_address")>]
  btc_address     : string;
  [<field: DataMember(Name = "data")>]
  data  : string;
  [<field: DataMember(Name = "created_on")>]
  created_on    : DateTime;
  [<field: DataMember(Name = "expires_on")>]
  expires_on    : DateTime;
  [<field: DataMember(Name = "status")>]
  status    : string;
  [<field: DataMember(Name = "last_update")>]
  last_update    : DateTime;
  [<field: DataMember(Name = "url")>]
  url    : string;
  }