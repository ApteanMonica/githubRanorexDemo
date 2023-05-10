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

namespace B_EXOPV_003.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_BUAB_Belege_laden recording.
    /// </summary>
    [TestModule("1d552dc0-025d-4db6-9c33-04b6b8237a57", ModuleType.Recording, 1)]
    public partial class B_BUAB_Belege_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_003.B_EXOPV_003Repository repository.
        /// </summary>
        public static global::B_EXOPV_003.B_EXOPV_003Repository repo = global::B_EXOPV_003.B_EXOPV_003Repository.Instance;

        static B_BUAB_Belege_laden instance = new B_BUAB_Belege_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_BUAB_Belege_laden()
        {
            Jahr = "2020";
            Monat = "02";
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_BUAB_Belege_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("8b998911-7a4d-4b63-911c-e6f63c937ee0")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Monat;

        /// <summary>
        /// Gets or sets the value of variable Monat.
        /// </summary>
        [TestVariable("dbe55980-7495-44a1-9921-fbdb23ad5a75")]
        public string Monat
        {
            get { return _Monat; }
            set { _Monat = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("1eaa3858-72a5-482e-b22c-d06f24a5e4db")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.CDCCTools_Einschraenkungen.Monat_Jahr_von' at Center.", repo.TblB.CDCCTools_Einschraenkungen.Monat_Jahr_vonInfo, new RecordItemIndex(0));
            repo.TblB.CDCCTools_Einschraenkungen.Monat_Jahr_von.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblB.CDCCTools_Einschraenkungen.Monat_Jahr_von'.", repo.TblB.CDCCTools_Einschraenkungen.Monat_Jahr_vonInfo, new RecordItemIndex(1));
            repo.TblB.CDCCTools_Einschraenkungen.Monat_Jahr_von.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monat' with focus on 'TblB.CDCCTools_Einschraenkungen.Text_Monat_von'.", repo.TblB.CDCCTools_Einschraenkungen.Text_Monat_vonInfo, new RecordItemIndex(3));
            repo.TblB.CDCCTools_Einschraenkungen.Text_Monat_von.PressKeys(Monat);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblB.CDCCTools_Einschraenkungen.Text2_Jahr_bis'.", repo.TblB.CDCCTools_Einschraenkungen.Text2_Jahr_bisInfo, new RecordItemIndex(5));
            repo.TblB.CDCCTools_Einschraenkungen.Text2_Jahr_bis.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monat' with focus on 'TblB.CDCCTools_Einschraenkungen.Text3_Monat_bis'.", repo.TblB.CDCCTools_Einschraenkungen.Text3_Monat_bisInfo, new RecordItemIndex(7));
            repo.TblB.CDCCTools_Einschraenkungen.Text3_Monat_bis.PressKeys(Monat);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.CDCCTools_Einschraenkungen.TextKL' at Center.", repo.TblB.CDCCTools_Einschraenkungen.TextKLInfo, new RecordItemIndex(9));
            repo.TblB.CDCCTools_Einschraenkungen.TextKL.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'K' with focus on 'TblB.CDCCTools_Einschraenkungen.TextKL'.", repo.TblB.CDCCTools_Einschraenkungen.TextKLInfo, new RecordItemIndex(10));
            repo.TblB.CDCCTools_Einschraenkungen.TextKL.PressKeys("K");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.CDCCTools_Einschraenkungen.Benutzer' at Center.", repo.TblB.CDCCTools_Einschraenkungen.BenutzerInfo, new RecordItemIndex(12));
            repo.TblB.CDCCTools_Einschraenkungen.Benutzer.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'EXTERN' with focus on 'TblB.CDCCTools_Einschraenkungen.Benutzer'.", repo.TblB.CDCCTools_Einschraenkungen.BenutzerInfo, new RecordItemIndex(13));
            repo.TblB.CDCCTools_Einschraenkungen.Benutzer.PressKeys("EXTERN");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbDataAccessLoad' at Center.", repo.TblB.PbDataAccessLoadInfo, new RecordItemIndex(15));
            repo.TblB.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblB.Buchungszeilen_Tabelle.Zeile1.Row1'", repo.TblB.Buchungszeilen_Tabelle.Zeile1.Row1Info, new ActionTimeout(120000), new RecordItemIndex(16));
            repo.TblB.Buchungszeilen_Tabelle.Zeile1.Row1Info.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
