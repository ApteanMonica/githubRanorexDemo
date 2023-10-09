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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verbuchung_Dialog4_ER03_LF02_neue_Belegnr recording.
    /// </summary>
    [TestModule("0db30e68-cfdd-4345-ab87-8fabd00b07db", ModuleType.Recording, 1)]
    public partial class Verbuchung_Dialog4_ER03_LF02_neue_Belegnr : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Verbuchung_Dialog4_ER03_LF02_neue_Belegnr instance = new Verbuchung_Dialog4_ER03_LF02_neue_Belegnr();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchung_Dialog4_ER03_LF02_neue_Belegnr()
        {
            LF_02 = "303202";
            ER03_LF02 = "ER03_B_EXOPV_005";
            ER03_LF02_NEU = "ER03_B_EXOPV_005_NEU";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchung_Dialog4_ER03_LF02_neue_Belegnr Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_02;

        /// <summary>
        /// Gets or sets the value of variable LF_02.
        /// </summary>
        [TestVariable("ae75fbfa-b634-451c-9243-3b31d6a3a51e")]
        public string LF_02
        {
            get { return _LF_02; }
            set { _LF_02 = value; }
        }

        string _ER03_LF02;

        /// <summary>
        /// Gets or sets the value of variable ER03_LF02.
        /// </summary>
        [TestVariable("97043709-b40a-47b5-819b-810a3019d122")]
        public string ER03_LF02
        {
            get { return _ER03_LF02; }
            set { _ER03_LF02 = value; }
        }

        string _ER03_LF02_NEU;

        /// <summary>
        /// Gets or sets the value of variable ER03_LF02_NEU.
        /// </summary>
        [TestVariable("d4ab38d9-f2ee-4924-a50d-a70822bcdc50")]
        public string ER03_LF02_NEU
        {
            get { return _ER03_LF02_NEU; }
            set { _ER03_LF02_NEU = value; }
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

            // Meldung 4 Lieferant 02
            Report.Log(ReportLevel.Info, "Section", "Meldung 4 Lieferant 02", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgBelegnrFehler.TitleBar100BelegNrFehler'.", repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo, new RecordItemIndex(1));
            Validate.Exists(repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'DlgBelegnrFehler.Frame2.DfAdrNr'.", repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg im selben Jahr schon als OP vorhanden !') on item 'DlgBelegnrFehler.Frame2.Label3'.", repo.DlgBelegnrFehler.Frame2.Label3Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.Label3Info, "Text", "Beleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER03_LF02) on item 'DlgBelegnrFehler.Frame2.DfBelegNr'.", repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, "Text", ER03_LF02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER03_LF02) on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", ER03_LF02);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBelegnrFehler.Frame2.NeueBelegNr' at Center.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(6));
            repo.DlgBelegnrFehler.Frame2.NeueBelegNr.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgBelegnrFehler.Frame2.NeueBelegNr' at Center.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(7));
            repo.DlgBelegnrFehler.Frame2.NeueBelegNr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ER03_LF02_NEU' with focus on 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(11));
            repo.DlgBelegnrFehler.Frame2.NeueBelegNr.PressKeys(ER03_LF02_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER03_LF02_NEU) on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", ER03_LF02_NEU);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBelegnrFehler.PbOk' at Center.", repo.DlgBelegnrFehler.PbOkInfo, new RecordItemIndex(14));
            repo.DlgBelegnrFehler.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}