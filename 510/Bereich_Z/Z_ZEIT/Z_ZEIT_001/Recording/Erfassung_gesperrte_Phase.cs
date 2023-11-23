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

namespace Z_ZEIT_001.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Erfassung_gesperrte_Phase recording.
    /// </summary>
    [TestModule("c2e608d6-a609-4409-a212-99337167b407", ModuleType.Recording, 1)]
    public partial class Erfassung_gesperrte_Phase : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_ZEIT_001.Z_ZEIT_001Repository repository.
        /// </summary>
        public static global::Z_ZEIT_001.Z_ZEIT_001Repository repo = global::Z_ZEIT_001.Z_ZEIT_001Repository.Instance;

        static Erfassung_gesperrte_Phase instance = new Erfassung_gesperrte_Phase();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung_gesperrte_Phase()
        {
            Personalnr = "ZEIT_001_G";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung_gesperrte_Phase Instance
        {
            get { return instance; }
        }

#region Variables

        string _Personalnr;

        /// <summary>
        /// Gets or sets the value of variable Personalnr.
        /// </summary>
        [TestVariable("54b6123a-d604-49b6-9468-d3e89053f0db")]
        public string Personalnr
        {
            get { return _Personalnr; }
            set { _Personalnr = value; }
        }

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'MdiZeit.Tabelle.Row_3'", repo.MdiZeit.Tabelle.Row_3Info, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.MdiZeit.Tabelle.Row_3Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Personalnr) on item 'MdiZeit.Mitarbeiter'.", repo.MdiZeit.MitarbeiterInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiZeit.MitarbeiterInfo, "Text", Personalnr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ZEIT_001' with focus on 'MdiZeit.Tabelle.Zeile_3.ColProjNrRow3'.", repo.MdiZeit.Tabelle.Zeile_3.ColProjNrRow3Info, new RecordItemIndex(2));
            repo.MdiZeit.Tabelle.Zeile_3.ColProjNrRow3.PressKeys("ZEIT_001");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ZEIT_001') on item 'MdiZeit.Tabelle.Zeile_3.ColProjNrRow3'.", repo.MdiZeit.Tabelle.Zeile_3.ColProjNrRow3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiZeit.Tabelle.Zeile_3.ColProjNrRow3Info, "Text", "ZEIT_001");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10' with focus on 'MdiZeit.Tabelle.Zeile_3.ColPhasCdRow3'.", repo.MdiZeit.Tabelle.Zeile_3.ColPhasCdRow3Info, new RecordItemIndex(6));
            repo.MdiZeit.Tabelle.Zeile_3.ColPhasCdRow3.PressKeys("10");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'MdiZeit.Tabelle.Zeile_3.ColPhasCdRow3'.", repo.MdiZeit.Tabelle.Zeile_3.ColPhasCdRow3Info, new RecordItemIndex(8));
            //Validate.AttributeEqual(repo.MdiZeit.Tabelle.Zeile_3.ColPhasCdRow3Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
