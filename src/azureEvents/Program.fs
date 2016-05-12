open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Suave.Web             // for config
open Suave.Filters
open Suave.Operators

let app =
    GET >=> (OK "Hello world")


[<EntryPoint>]
let main args =
    startWebServer defaultConfig app
    0
