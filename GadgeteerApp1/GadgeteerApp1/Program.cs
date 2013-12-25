using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;
using LCD = Gadgeteer.Modules.GHIElectronics.Display_N18;


namespace GadgeteerApp1
{
    public partial class Program
    {
        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            /*******************************************************************************************
            Modules added in the Program.gadgeteer designer view are used by typing 
            their name followed by a period, e.g.  button.  or  camera.
            
            Many modules generate useful events. Type +=<tab><tab> to add a handler to an event, e.g.:
                button.ButtonPressed +=<tab><tab>
            
            If you want to do something periodically, use a GT.Timer and handle its Tick event, e.g.:
                GT.Timer timer = new GT.Timer(1000); // every second (1000ms)
                timer.Tick +=<tab><tab>
                timer.Start();
            *******************************************************************************************/

            //display.Initialize(4000);
            //mMainWindow = display.WPFWindow;
            //mCanvas = new Canvas();
            //mMainWindow.Child = mCanvas;

            ////Add a gray background.
            //mBackground = new Border();
            //mBackground.Background = new SolidColorBrush(Colors.Gray);
            //mBackground.Width = 128;
            //mBackground.Height = 160;
            //mCanvas.Children.Add(mBackground);
            //Canvas.SetLeft(mBackground, 0);
            //Canvas.SetTop(mBackground, 0);
            //// Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            //Debug.Print("Program Started");

            





        }
    }
}
