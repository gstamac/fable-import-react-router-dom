// node_modules/@types/react-router-dom/index.d.ts
namespace rec Fable.Helpers.ReactRouterDom
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactRouterDom

type BrowserRouterProps =
    abstract basename: string option with get, set
    abstract forceRefresh: bool option with get, set
    abstract keyLength: float option with get, set
    abstract getUserConfirmation: unit -> unit

type IBrowserRouterProp = inherit Fable.Helpers.React.Props.IHTMLProp
type BrowserRouterProp = 
    | Basename of string 
    | ForceRefresh of bool 
    | KeyLength of float 
    interface IBrowserRouterProp


module BrowserRouter =
    [<Import("BrowserRouter", from="react-router-dom")>]
    let BrowserRouterComp: React.ComponentClass<IBrowserRouterProp> = jsNative 

    let inline comp (b: IBrowserRouterProp list) c = Fable.Helpers.React.from BrowserRouterComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from BrowserRouterComp !!(keyValueList CaseRules.LowerFirst b) c



type HashRouterProps =
    abstract basename: string option with get, set
    abstract hashType: (* TODO StringEnum  |  |  *) string option with get, set
    abstract getUserConfirmation: unit -> unit

type IHashRouterProp = inherit Fable.Helpers.React.Props.IHTMLProp
type HashRouterProp = 
    | Basename of string 
    | HashType of (* TODO StringEnum  |  |  *) string 
    interface IHashRouterProp


module HashRouter =
    [<Import("HashRouter", from="react-router-dom")>]
    let HashRouterComp: React.ComponentClass<IHashRouterProp> = jsNative 

    let inline comp (b: IHashRouterProp list) c = Fable.Helpers.React.from HashRouterComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from HashRouterComp !!(keyValueList CaseRules.LowerFirst b) c



type LinkProps =
    inherit ReactEx.AnchorHTMLAttributes
    abstract ``to``: LocationDescriptor with get, set
    abstract replace: bool option with get, set

type ILinkProp = inherit Fable.Helpers.React.Props.IHTMLProp
type LinkProp = 
    | To of LocationDescriptor 
    | Replace of bool 
    interface ILinkProp


module Link =
    [<Import("Link", from="react-router-dom")>]
    let LinkComp: React.ComponentClass<ILinkProp> = jsNative 

    let inline comp (b: ILinkProp list) c = Fable.Helpers.React.from LinkComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from LinkComp !!(keyValueList CaseRules.LowerFirst b) c



type NavLinkProps =
    inherit LinkProps
    abstract activeClassName: string option with get, set
    abstract activeStyle: React.CSSProperties option with get, set
    abstract exact: bool option with get, set
    abstract strict: bool option with get, set
    abstract isActive: ``match``: ``match``<'P> * location: Location -> bool

type INavLinkProp = inherit Fable.Helpers.React.Props.IHTMLProp
type NavLinkProp = 
    | To of LocationDescriptor // LinkProps
    | Replace of bool // LinkProps
    | ActiveClassName of string 
    | ActiveStyle of React.CSSProperties 
    | Exact of bool 
    | Strict of bool 
    interface INavLinkProp


module NavLink =
    [<Import("NavLink", from="react-router-dom")>]
    let NavLinkComp: React.ComponentClass<INavLinkProp> = jsNative 

    let inline comp (b: INavLinkProp list) c = Fable.Helpers.React.from NavLinkComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from NavLinkComp !!(keyValueList CaseRules.LowerFirst b) c




