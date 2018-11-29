// Copyright 2018 Fabulous contributors. See LICENSE.md for license.

namespace TicTacToe

open Fabulous.Core
open Fabulous.DynamicViews
open Xamarin.Forms

/// Represents an update to the game
type Msg =
    
type Model = {

}
/// The model, update and view content of the app. This is placed in an 
/// independent model to facilitate unit testing.
module App = 
    open System.Windows.Input
    open System.Runtime.CompilerServices
     

    /// The 'update' function to update the model
    let update gameOver msg model =
                
    /// The dynamic 'view' function giving the updated content for the view
    let view model dispatch =
      View.NavigationPage()

    let program = 
        Program.mkSimple init update  view
        |> Program.withConsoleTrace

#if TESTEVAL
    let testInit = init ()
    let testView = view testInit (fun _ -> ())
#endif

/// Stitch the model, update and view content into a single app.
type App() as app =
    inherit Application()

    let runner = 
        App.program
        |> Program.runWithDynamicView app
        
#if DEBUG && !TESTEVAL
    do runner.EnableLiveUpdate ()
#endif
