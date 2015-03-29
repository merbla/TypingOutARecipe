open FSharp.Data
open System.Net
open System.IO
[<Literal>]
let sample = "https://s3-ap-southeast-2.amazonaws.com/cloudformation-templates-ap-southeast-2/Windows_Roles_And_Features.template"
let apiUrl = "https://s3-ap-southeast-2.amazonaws.com/cloudformation-templates-ap-southeast-2/Windows_Roles_And_Features.template"


type windowsTemplate = JsonProvider<sample>

let myTemplate = windowsTemplate.Load(apiUrl)

myTemplate.Resources.