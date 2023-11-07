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

namespace B_EBUEB_B_EBERF_Schnelltest.Recordings_B_EBERF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkung_B_EBERF recording.
    /// </summary>
    [TestModule("3f6f3f37-70d3-4526-9ddc-8442fca6041a", ModuleType.Recording, 1)]
    public partial class Einschraenkung_B_EBERF : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_SchnelltestRepository repository.
        /// </summary>
        public static global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_SchnelltestRepository repo = global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_SchnelltestRepository.Instance;

        static Einschraenkung_B_EBERF instance = new Einschraenkung_B_EBERF();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_B_EBERF()
        {
            Jahr = "2018";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_B_EBERF Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("6819a8cb-a0ac-4fda-8ebb-a0fde2fc10d8")]
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'FrmEB.Jahr'.", repo.FrmEB.JahrInfo, new RecordItemIndex(0));
            repo.FrmEB.Jahr.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'FrmEB.Jahr'.", repo.FrmEB.JahrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmEB.JahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmEB.CbAktiv'.", repo.FrmEB.CbAktivInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmEB.CbAktivInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEB.PbDataAccessLoad' at Center.", repo.FrmEB.PbDataAccessLoadInfo, new RecordItemIndex(4));
            repo.FrmEB.PbDataAccessLoad.Click();
            
            // Spalte Soll sortieren mit 2 x klick (sonst sind nicht alle Beträge am Bildschirm sichtbar)
            Report.Log(ReportLevel.Info, "Section", "Spalte Soll sortieren mit 2 x klick (sonst sind nicht alle Beträge am Bildschirm sichtbar)", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEB.ColSollRow0' at Center.", repo.FrmEB.ColSollRow0Info, new RecordItemIndex(6));
            repo.FrmEB.ColSollRow0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEB.ColSollRow0' at Center.", repo.FrmEB.ColSollRow0Info, new RecordItemIndex(8));
            repo.FrmEB.ColSollRow0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
