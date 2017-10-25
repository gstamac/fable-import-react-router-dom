// node_modules/@types/react-router/index.d.ts
namespace rec Fable.Helpers.ReactRouterDom
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactRouterDom

type RouterChildContext<'P> =
    abstract router: obj with get, set

type MemoryRouterProps =
    abstract initialEntries: ResizeArray<LocationDescriptor> option with get, set
    abstract initialIndex: float option with get, set
    abstract getUserConfirmation: (unit -> unit) option with get, set
    abstract keyLength: float option with get, set

type IMemoryRouterProp = inherit Fable.Helpers.React.Props.IHTMLProp
type MemoryRouterProp = 
    | [<CompiledName("initialEntries")>] InitialEntriesA of ResizeArray<LocationDescriptor> 
    | InitialIndex of float 
    | GetUserConfirmation of (unit -> unit) 
    | KeyLength of float 
    interface IMemoryRouterProp
    static member InitialEntries (l: LocationDescriptor list) = InitialEntriesA (l |> ResizeArray<LocationDescriptor>) 

module MemoryRouter =
    [<Import("MemoryRouter", from="react-router-dom")>]
    let MemoryRouterComp: React.ComponentClass<IMemoryRouterProp> = jsNative 

    let inline comp (b: IMemoryRouterProp list) c = Fable.Helpers.React.from MemoryRouterComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from MemoryRouterComp !!(keyValueList CaseRules.LowerFirst b) c



type PromptProps =
    abstract message: U2<string, (Location -> unit)> with get, set
    abstract ``when``: bool option with get, set

type IPromptProp = inherit Fable.Helpers.React.Props.IHTMLProp
type PromptProp = 
    | Message of U2<string, (Location -> unit)> 
    | When of bool 
    interface IPromptProp


module Prompt =
    [<Import("Prompt", from="react-router-dom")>]
    let PromptComp: React.ComponentClass<IPromptProp> = jsNative 

    let inline comp (b: IPromptProp list) c = Fable.Helpers.React.from PromptComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from PromptComp !!(keyValueList CaseRules.LowerFirst b) c



type RedirectProps =
    abstract ``to``: LocationDescriptor with get, set
    abstract push: bool option with get, set
    abstract from: string option with get, set
    abstract path: string option with get, set
    abstract exact: bool option with get, set
    abstract strict: bool option with get, set

type IRedirectProp = inherit Fable.Helpers.React.Props.IHTMLProp
type RedirectProp = 
    | To of LocationDescriptor 
    | Push of bool 
    | From of string 
    | Path of string 
    | Exact of bool 
    | Strict of bool 
    interface IRedirectProp


module Redirect =
    [<Import("Redirect", from="react-router-dom")>]
    let RedirectComp: React.ComponentClass<IRedirectProp> = jsNative 

    let inline comp (b: IRedirectProp list) c = Fable.Helpers.React.from RedirectComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from RedirectComp !!(keyValueList CaseRules.LowerFirst b) c



type RouteComponentProps<'P> =
    abstract ``match``: ``match``<'P> with get, set
    abstract location: Location with get, set
    abstract history: History with get, set
    abstract staticContext: obj option with get, set

type RouteProps =
    abstract location: Location option with get, set
    abstract ``component``: ReactEx.ComponentType<obj> option with get, set
    abstract render: (RouteComponentProps<obj> -> React.ReactNode) option with get, set
    abstract children: U2<(RouteComponentProps<obj> -> React.ReactNode), React.ReactNode> option with get, set
    abstract path: string option with get, set
    abstract exact: bool option with get, set
    abstract strict: bool option with get, set

type IRouteProp = inherit Fable.Helpers.React.Props.IHTMLProp
type RouteProp = 
    | Location of Location 
    | Component of ReactEx.ComponentType<obj> 
    | Render of (RouteComponentProps<obj> -> React.ReactNode) 
    | Children of U2<(RouteComponentProps<obj> -> React.ReactNode), React.ReactNode> 
    | Path of string 
    | Exact of bool 
    | Strict of bool 
    interface IRouteProp


module Route =
    [<Import("Route", from="react-router-dom")>]
    let RouteComp: React.ComponentClass<IRouteProp> = jsNative 

    let inline comp (b: IRouteProp list) c = Fable.Helpers.React.from RouteComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from RouteComp !!(keyValueList CaseRules.LowerFirst b) c



type RouterProps =
    abstract history: obj with get, set

type IRouterProp = inherit Fable.Helpers.React.Props.IHTMLProp
type RouterProp = 
    | History of obj 
    interface IRouterProp


module Router =
    [<Import("Router", from="react-router-dom")>]
    let RouterComp: React.ComponentClass<IRouterProp> = jsNative 

    let inline comp (b: IRouterProp list) c = Fable.Helpers.React.from RouterComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from RouterComp !!(keyValueList CaseRules.LowerFirst b) c



type StaticRouterProps =
    abstract basename: string option with get, set
    abstract location: U2<string, obj> option with get, set
    abstract context: obj option with get, set

type IStaticRouterProp = inherit Fable.Helpers.React.Props.IHTMLProp
type StaticRouterProp = 
    | Basename of string 
    | Location of U2<string, obj> 
    | Context of obj 
    interface IStaticRouterProp


module StaticRouter =
    [<Import("StaticRouter", from="react-router-dom")>]
    let StaticRouterComp: React.ComponentClass<IStaticRouterProp> = jsNative 

    let inline comp (b: IStaticRouterProp list) c = Fable.Helpers.React.from StaticRouterComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from StaticRouterComp !!(keyValueList CaseRules.LowerFirst b) c



type SwitchProps =
    abstract children: React.ReactNode option with get, set
    abstract location: Location option with get, set

type ISwitchProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SwitchProp = 
    | Children of React.ReactNode 
    | Location of Location 
    interface ISwitchProp


module Switch =
    [<Import("Switch", from="react-router-dom")>]
    let SwitchComp: React.ComponentClass<ISwitchProp> = jsNative 

    let inline comp (b: ISwitchProp list) c = Fable.Helpers.React.from SwitchComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SwitchComp !!(keyValueList CaseRules.LowerFirst b) c



type ``match``<'P> =
    abstract ``params``: 'P with get, set
    abstract isExact: bool with get, set
    abstract path: string with get, set
    abstract url: string with get, set


