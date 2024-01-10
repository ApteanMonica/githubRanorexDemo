﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_B_ELSTER
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Fenstersteuerung_AnlageUN recording.
    /// </summary>
    [TestModule("dc742907-a68e-4f79-a61d-b6cff22d5bb7", ModuleType.Recording, 1)]
    public partial class Fenstersteuerung_AnlageUN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Fenstersteuerung_AnlageUN instance = new Fenstersteuerung_AnlageUN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fenstersteuerung_AnlageUN()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fenstersteuerung_AnlageUN Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgElsterUN.TitleBar300AnlageUN'", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgElsterUN.TitleBar300AnlageUNInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anlage UN') on item 'DlgElsterUN.TitleBar300AnlageUN'.", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgElsterUN.TitleBar300AnlageUNInfo, "Text", "Anlage UN");
            
            // verschiebt das Fenster auf einen ev. rechten (kleinen) Bildschirm, damit eine Scrolbar erscheint = Server
            //Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. rechten (kleinen) Bildschirm, damit eine Scrolbar erscheint = Server\r\nKey sequence '{LWin down}{LShiftKey down}{Left}{LShiftKey up}{LWin up}' with focus on 'DlgElsterUN.TitleBar300AnlageUN'.", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new RecordItemIndex(2));
            //repo.DlgElsterUN.TitleBar300AnlageUN.PressKeys("{LWin down}{LShiftKey down}{Left}{LShiftKey up}{LWin up}");
            
            // verschiebt das Fenster auf einen ev. rechten (kleinen) Bildschirm, damit eine Scrolbar erscheint = Server
            //Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. rechten (kleinen) Bildschirm, damit eine Scrolbar erscheint = Server\r\nKey sequence '{LWin down}{LShiftKey down}{Right}{LShiftKey up}{LWin up}' with focus on 'DlgElsterUN.TitleBar300AnlageUN'.", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new RecordItemIndex(3));
            //repo.DlgElsterUN.TitleBar300AnlageUN.PressKeys("{LWin down}{LShiftKey down}{Right}{LShiftKey up}{LWin up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElsterUN.TitleBar300AnlageUN' at CenterLeft.", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new RecordItemIndex(4));
            repo.DlgElsterUN.TitleBar300AnlageUN.Click(Location.CenterLeft);
            
            // verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.
            Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.\r\nKey sequence '{LWin down}'.", new RecordItemIndex(5));
            Keyboard.Press("{LWin down}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            // verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.
            Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.\r\nKey sequence '{LShiftKey down}'.", new RecordItemIndex(7));
            Keyboard.Press("{LShiftKey down}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            // verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.
            Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.\r\nKey sequence '{Left}'.", new RecordItemIndex(9));
            Keyboard.Press("{Left}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            // verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.
            Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.\r\nKey sequence '{LShiftKey up}'.", new RecordItemIndex(11));
            Keyboard.Press("{LShiftKey up}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            // verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.
            Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. linken (großen) Bildschirm, damit das Formular vollständig dargestellt wird.\r\nKey sequence '{LWin up}'.", new RecordItemIndex(13));
            Keyboard.Press("{LWin up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElsterUN.Text_IBAN' at Center.", repo.DlgElsterUN.Text_IBANInfo, new RecordItemIndex(14));
            repo.DlgElsterUN.Text_IBAN.Click();
            
            // verschiebt das Fenster auf einen ev. rechten (kleinen) Bildschirm, damit eine Scrolbar erscheint = Server
            //Report.Log(ReportLevel.Info, "Keyboard", "verschiebt das Fenster auf einen ev. rechten (kleinen) Bildschirm, damit eine Scrolbar erscheint = Server\r\nKey sequence '{LWin down}{LShiftKey down}{Right}{LShiftKey up}{LWin up}' with focus on 'DlgElsterUN.TitleBar300AnlageUN'.", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new RecordItemIndex(15));
            //repo.DlgElsterUN.TitleBar300AnlageUN.PressKeys("{LWin down}{LShiftKey down}{Right}{LShiftKey up}{LWin up}");
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            //Delay.Duration(1000, false);
            
            // Button "Weiter" nicht im sichtbaren Bereich und kein Shortcut, deshalb maximieren und scrollen
            //Report.Log(ReportLevel.Info, "Keyboard", "Button \"Weiter\" nicht im sichtbaren Bereich und kein Shortcut, deshalb maximieren und scrollen\r\nKey sequence '{LWin down}{Up}{LWin up}' with focus on 'DlgElsterUN.TitleBar300AnlageUN'.", repo.DlgElsterUN.TitleBar300AnlageUNInfo, new RecordItemIndex(17));
            //repo.DlgElsterUN.TitleBar300AnlageUN.PressKeys("{LWin down}{Up}{LWin up}");
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(18));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElsterUN.PageDown' at Center.", repo.DlgElsterUN.PageDownInfo, new RecordItemIndex(19));
            //repo.DlgElsterUN.PageDown.Click();
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(20));
            //Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}