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


namespace GadgeteerApp1
{
    public partial class Program


    {

        

        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {

              // Subscribe to the event that will fire when an RFID tag is properly read
   // rfid.CardIDReceived += new RFID.CardIDRecievedEventHandler(rfid_CardIDRecieved);
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
            display_N18.SimpleGraphics.DisplayTextInRectangle("you are not still a loser alain",
                0, 0, 125, 200, GT.Color.Green, Resources.GetFont(Resources.FontResources.NinaB));

            
 
            
// The event handler that is called when the event is fired.
// The ID parameter contains the ID that was read from the card

           
            // Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            Debug.Print("Program Started");
        }

        //void rfid_CardIDRecieved(RFID sender, string ID)
        //{
        //    // Display the ID to the screen
        //    //Debug.Print(ID);

        //    display_N18.SimpleGraphics.DisplayTextInRectangle("NICE",
        //                0, 0, 150, 200, GT.Color.Green, Resources.GetFont(Resources.FontResources.NinaB));
        //}
    }

  
}
