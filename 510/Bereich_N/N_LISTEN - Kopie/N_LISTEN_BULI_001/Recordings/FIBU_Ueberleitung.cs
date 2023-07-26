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

namespace N_LISTEN_BULI_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FIBU_Ueberleitung recording.
    /// </summary>
    [TestModule("2a2bec47-aca7-4c5f-a992-a09c20d8764c", ModuleType.Recording, 1)]
    public partial class FIBU_Ueberleitung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static FIBU_Ueberleitung instance = new FIBU_Ueberleitung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FIBU_Ueberleitung()
        {
            Belegnummer_Ueberleitung = "BULI_001_A";
            Belegdatum_Ueberleitung = "31.12.2022";
            Ust_Code_Ueberleitung = "V00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FIBU_Ueberleitung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Belegdatum_Ueberleitung;

        /// <summary>
        /// Gets or sets the value of variable Belegdatum_Ueberleitung.
        /// </summary>
        [TestVariable("5839be8f-7fb0-4bc7-ac42-ee97dab608d9")]
        public string Belegdatum_Ueberleitung
        {
            get { return _Belegdatum_Ueberleitung; }
            set { _Belegdatum_Ueberleitung = value; }
        }

        string _Ust_Code_Ueberleitung;

        /// <summary>
        /// Gets or sets the value of variable Ust_Code_Ueberleitung.
        /// </summary>
        [TestVariable("52609ef9-fd70-450c-9879-3117fa69470e")]
        public string Ust_Code_Ueberleitung
        {
            get { return _Ust_Code_Ueberleitung; }
            set { _Ust_Code_Ueberleitung = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Belegnummer_Ueberleitung.
        /// </summary>
        [TestVariable("e327bd7b-6d6d-40bb-8d3a-d60aa6eb4166")]
        public string Belegnummer_Ueberleitung
        {
            get { return repo.Belegnummer_Ueberleitung; }
            set { repo.Belegnummer_Ueberleitung = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Belegnummer_Ueberleitung' with focus on 'DlgFibu.Frame2.BelegNr'.", repo.DlgFibu.Frame2.BelegNrInfo, new RecordItemIndex(0));
            repo.DlgFibu.Frame2.BelegNr.PressKeys(Belegnummer_Ueberleitung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Belegnummer_Ueberleitung) on item 'DlgFibu.Frame2.BelegNr'.", repo.DlgFibu.Frame2.BelegNrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.BelegNrInfo, "Text", Belegnummer_Ueberleitung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Belegdatum_Ueberleitung' with focus on 'DlgFibu.Frame2.BelegDatum'.", repo.DlgFibu.Frame2.BelegDatumInfo, new RecordItemIndex(3));
            repo.DlgFibu.Frame2.BelegDatum.PressKeys(Belegdatum_Ueberleitung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Belegdatum_Ueberleitung) on item 'DlgFibu.Frame2.BelegDatum'.", repo.DlgFibu.Frame2.BelegDatumInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.BelegDatumInfo, "Text", Belegdatum_Ueberleitung);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022') on item 'DlgFibu.Frame2.Text_UEberleitung_Jahr'.", repo.DlgFibu.Frame2.Text_UEberleitung_JahrInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.Text_UEberleitung_JahrInfo, "Text", "2022");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='12') on item 'DlgFibu.Frame2.Text_UEberleitung_Monat'.", repo.DlgFibu.Frame2.Text_UEberleitung_MonatInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.Text_UEberleitung_MonatInfo, "Text", "12");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ust_Code_Ueberleitung' with focus on 'DlgFibu.Frame2.UstCode'.", repo.DlgFibu.Frame2.UstCodeInfo, new RecordItemIndex(8));
            repo.DlgFibu.Frame2.UstCode.PressKeys(Ust_Code_Ueberleitung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ust_Code_Ueberleitung) on item 'DlgFibu.Frame2.UstCode'.", repo.DlgFibu.Frame2.UstCodeInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.UstCodeInfo, "Text", Ust_Code_Ueberleitung);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'DlgFibu.Frame2.Firma'.", repo.DlgFibu.Frame2.FirmaInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.FirmaInfo, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFibu.PbStart' at Center.", repo.DlgFibu.PbStartInfo, new RecordItemIndex(12));
            repo.DlgFibu.PbStart.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
