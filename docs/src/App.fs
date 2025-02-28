module App

open Feliz
open Feliz.AntDesign
open Elmish

type State = { Count: int }

type Msg =
    | Increment
    | Decrement

let init() = { Count = 0 }, Cmd.none

let update (msg: Msg) (state: State) =
    match msg with
    | Increment -> { state with Count = state.Count + 1 }, Cmd.none
    | Decrement -> { state with Count = state.Count - 1 }, Cmd.none

let render (state: State) (dispatch: Msg -> unit) =
    Ant.layout [
        Ant.layoutSider [
            Ant.menu [
                menu.theme.light
                menu.selectedKeys [| "1" |]
                menu.mode.inline'
                menu.children [
                    Ant.menuIem [
                        menuItem.key "1"
                        menuItem.text "Introduction"
                    ]

                    Ant.menuIem [
                        menuItem.key "2"
                        menuItem.text "Installation"
                    ]
                ]
            ]
        ]

        Ant.layout [
            Ant.layoutContent [
                layoutContent.style [ style.padding 20 ]
                layoutContent.children [
                    Ant.button [
                        button.primary
                        button.size.large
                        button.icon.search
                        button.text "Click"
                    ]
                ]
            ]
        ]
    ]
