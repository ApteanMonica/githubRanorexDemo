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

namespace B_EBUEB_B_EBERF_Schnelltest.Recordings_B_JAHR
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Periode_0_sperren_zuruecksetzen recording.
    /// </summary>
    [TestModule("fa96ba49-947e-4219-8030-5a5dcbe225c2", ModuleType.Recording, 1)]
    public partial class Periode_0_sperren_zuruecksetzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository repository.
        /// </summary>
        public static global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository repo = global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository.Instance;

        static Periode_0_sperren_zuruecksetzen instance = new Periode_0_sperren_zuruecksetzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Periode_0_sperren_zuruecksetzen()
        {
            Jahr = "2022";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Periode_0_sperren_zuruecksetzen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("d4baca92-853e-4517-9363-9d3c38b841d8")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrBez_mit_22_2022' at Center.", repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrBez_mit_22_2022Info, new RecordItemIndex(0));
            repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrBez_mit_22_2022.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrPerivon_mit_22_2022'.", repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrPerivon_mit_22_2022Info, new RecordItemIndex(2));
            repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrPerivon_mit_22_2022.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'frmMail_Geschaeftsjahr_verwalten.PbStandard1' at Center.", repo.frmMail_Geschaeftsjahr_verwalten.PbStandard1Info, new RecordItemIndex(4));
            repo.frmMail_Geschaeftsjahr_verwalten.PbStandard1.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrBez_mit_22_2022'.", repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrBez_mit_22_2022Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrBez_mit_22_2022Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrPerivon_mit_22_2022'.", repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrPerivon_mit_22_2022Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.frmMail_Geschaeftsjahr_verwalten.Tabelle.ColGjhrPerivon_mit_22_2022Info, "Text", "1");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
