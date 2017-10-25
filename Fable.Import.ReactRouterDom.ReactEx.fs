namespace rec Fable.Import.ReactRouterDom
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS

module ReactEx =
    type ComponentType<'P> = U2<React.ComponentClass<'P>, React.StatelessComponent<'P>>
    
    type AnchorHTMLAttributes =
        inherit React.HTMLAttributes 
        abstract download: obj option with get, set
        abstract href: string option with get, set
        abstract hrefLang: string option with get, set
        abstract media: string option with get, set
        abstract rel: string option with get, set
        abstract target: string option with get, set
