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

namespace K_AUSW_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Seite_zurueck recording.
    /// </summary>
    [TestModule("e0b6609a-65a7-4ccd-9fb5-6e84a407ee68", ModuleType.Recording, 1)]
    public partial class Seite_zurueck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_AUSW_002.K_AUSW_002Repository repository.
        /// </summary>
        public static global::K_AUSW_002.K_AUSW_002Repository repo = global::K_AUSW_002.K_AUSW_002Repository.Instance;

        static Seite_zurueck instance = new Seite_zurueck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Seite_zurueck()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Seite_zurueck Instance
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

            // Klick auf 1. Zeile, damit das Fenster sicher für F9 aktiv ist
            //Report.Log(ReportLevel.Info, "Mouse", "Klick auf 1. Zeile, damit das Fenster sicher für F9 aktiv ist\r\nMouse Left Click item 'TblAnzeige.ChildTableWindow.Row1Column0' at Center.", repo.TblAnzeige.ChildTableWindow.Row1Column0Info, new RecordItemIndex(0));
            //repo.TblAnzeige.ChildTableWindow.Row1Column0.Click();
            
            // F9 = Button "Anfang"
            //Report.Log(ReportLevel.Info, "Keyboard", "F9 = Button \"Anfang\"\r\nKey 'F9' Press.", new RecordItemIndex(1));
            //Keyboard.Press(System.Windows.Forms.Keys.F9, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            //Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblAnzeige.PbToolBarItemsAnfang' at Center.", repo.TblAnzeige.PbToolBarItemsAnfangInfo, new RecordItemIndex(3));
            repo.TblAnzeige.PbToolBarItemsAnfang.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblAnzeige.DfNr_Kostenstelle_20'", repo.TblAnzeige.DfNr_Kostenstelle_20Info, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.TblAnzeige.DfNr_Kostenstelle_20Info.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
