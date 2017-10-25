// node_modules/@types/history/index.d.ts
namespace rec Fable.Helpers.ReactRouterDom
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactRouterDom

[<StringEnum>] 
type Action =
    | [<CompiledName("PUSH")>] PUSH | [<CompiledName("POP")>] POP | [<CompiledName("REPLACE")>] REPLACE

type UnregisterCallback =
    (unit -> unit)

type History =
    abstract length: float with get, set
    abstract action: Action with get, set
    abstract location: Location with get, set
    abstract push: path: Path * ?state: LocationState -> unit
    abstract push: location: LocationDescriptorObject -> unit
    abstract replace: path: Path * ?state: LocationState -> unit
    abstract replace: location: LocationDescriptorObject -> unit
    abstract go: n: float -> unit
    abstract goBack: unit -> unit
    abstract goForward: unit -> unit
    abstract block: ?prompt: bool -> UnregisterCallback
    abstract listen: listener: LocationListener -> UnregisterCallback
    abstract createHref: location: LocationDescriptorObject -> Href

type Location =
    abstract pathname: Pathname with get, set
    abstract search: Search with get, set
    abstract state: LocationState with get, set
    abstract hash: Hash with get, set
    abstract key: LocationKey option with get, set

type LocationDescriptorObject =
    abstract pathname: Pathname option with get, set
    abstract search: Search option with get, set
    abstract state: LocationState option with get, set
    abstract hash: Hash option with get, set
    abstract key: LocationKey option with get, set

type LocationDescriptor =
    History.LocationDescriptor

type LocationKey =
    History.LocationKey

type LocationListener =
    History.LocationListener

type LocationState =
    History.LocationState

type Path =
    History.Path

type Pathname =
    History.Pathname

type Search =
    History.Search

type TransitionHook =
    History.TransitionHook

type Hash =
    History.Hash

type Href =
    History.Href

type Module =
    abstract createBrowserHistory: obj with get, set
    abstract createHashHistory: obj with get, set
    abstract createMemoryHistory: obj with get, set
    abstract createLocation: obj with get, set
    abstract locationsAreEqual: obj with get, set
    abstract parsePath: obj with get, set
    abstract createPath: obj with get, set

module History =
    type LocationDescriptor =
        U2<Path, LocationDescriptorObject>

    type LocationKey =
        string

    type LocationListener =
        (Location -> Action -> unit)

    type LocationState =
        obj

    type Path =
        string

    type Pathname =
        string

    type Search =
        string

    type TransitionHook =
        (Location -> (obj -> unit) -> obj)

    type Hash =
        string

    type Href =
        string


