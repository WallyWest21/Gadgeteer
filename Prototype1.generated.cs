//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GadgeteerApp1 {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Prototype1 : Gadgeteer.Program {
        
        private Gadgeteer.Modules.GHIElectronics.Display_N18 display_N18;
        
        private Gadgeteer.Modules.GHIElectronics.UsbClientDP usbClientDP;
        
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.usbClientDP = new GTM.GHIElectronics.UsbClientDP(1);
            this.display_N18 = new GTM.GHIElectronics.Display_N18(9);
        }
    }
}
