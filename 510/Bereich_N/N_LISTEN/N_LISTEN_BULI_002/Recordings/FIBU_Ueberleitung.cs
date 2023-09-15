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

namespace N_LISTEN_BULI_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FIBU_Ueberleitung recording.
    /// </summary>
    [TestModule("b9b1fdfd-a396-45cf-a38e-d4f6af062db6", ModuleType.Recording, 1)]
    public partial class FIBU_Ueberleitung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repo = global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository.Instance;

        static FIBU_Ueberleitung instance = new FIBU_Ueberleitung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FIBU_Ueberleitung()
        {
            Belegnr = "BULI_002_01";
            Belegdatum = "31.07.2022";
            Ustcode = "V00";
            GJ = "2022";
            Ueberleitungsmonat = "7";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FIBU_Ueberleitung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Belegnr;

        /// <summary>
        /// Gets or sets the value of variable Belegnr.
        /// </summary>
        [TestVariable("bffe5474-4aa2-4e7f-b9e7-4afb9cbeeb6b")]
        public string Belegnr
        {
            get { return _Belegnr; }
            set { _Belegnr = value; }
        }

        string _Belegdatum;

        /// <summary>
        /// Gets or sets the value of variable Belegdatum.
        /// </summary>
        [TestVariable("2d218043-72b9-45e0-8c0f-9f47b190e898")]
        public string Belegdatum
        {
            get { return _Belegdatum; }
            set { _Belegdatum = value; }
        }

        string _Ustcode;

        /// <summary>
        /// Gets or sets the value of variable Ustcode.
        /// </summary>
        [TestVariable("3b40c430-7d8e-43a4-8f0a-e95e14a21b8d")]
        public string Ustcode
        {
            get { return _Ustcode; }
            set { _Ustcode = value; }
        }

        string _GJ;

        /// <summary>
        /// Gets or sets the value of variable GJ.
        /// </summary>
        [TestVariable("74238157-65ac-4373-a814-be3763c6187e")]
        public string GJ
        {
            get { return _GJ; }
            set { _GJ = value; }
        }

        string _Ueberleitungsmonat;

        /// <summary>
        /// Gets or sets the value of variable Ueberleitungsmonat.
        /// </summary>
        [TestVariable("df7f9bd5-9be5-4412-80ea-21002d8f6efe")]
        public string Ueberleitungsmonat
        {
            get { return _Ueberleitungsmonat; }
            set { _Ueberleitungsmonat = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgFibu.TitleBar100AVZUEberleitungFibuMIT'", repo.DlgFibu.TitleBar100AVZUEberleitungFibuMITInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgFibu.TitleBar100AVZUEberleitungFibuMITInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100]  AVZ-Überleitung') on item 'DlgFibu.TitleBar100AVZUEberleitungFibuMIT'.", repo.DlgFibu.TitleBar100AVZUEberleitungFibuMITInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgFibu.TitleBar100AVZUEberleitungFibuMITInfo, "Text", "[100]  AVZ-Überleitung");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Belegnr' with focus on 'DlgFibu.Frame2.BelegNr'.", repo.DlgFibu.Frame2.BelegNrInfo, new RecordItemIndex(2));
            repo.DlgFibu.Frame2.BelegNr.PressKeys(Belegnr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Belegnr) on item 'DlgFibu.Frame2.BelegNr'.", repo.DlgFibu.Frame2.BelegNrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.BelegNrInfo, "Text", Belegnr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Belegdatum' with focus on 'DlgFibu.Frame2.BelegDatum'.", repo.DlgFibu.Frame2.BelegDatumInfo, new RecordItemIndex(5));
            repo.DlgFibu.Frame2.BelegDatum.PressKeys(Belegdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Belegdatum) on item 'DlgFibu.Frame2.BelegDatum'.", repo.DlgFibu.Frame2.BelegDatumInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.BelegDatumInfo, "Text", Belegdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ustcode' with focus on 'DlgFibu.Frame2.UstCode'.", repo.DlgFibu.Frame2.UstCodeInfo, new RecordItemIndex(8));
            repo.DlgFibu.Frame2.UstCode.PressKeys(Ustcode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ustcode) on item 'DlgFibu.Frame2.UstCode'.", repo.DlgFibu.Frame2.UstCodeInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.UstCodeInfo, "Text", Ustcode);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GJ) on item 'DlgFibu.Frame2.Text_UEberleitung_Jahr'.", repo.DlgFibu.Frame2.Text_UEberleitung_JahrInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.Text_UEberleitung_JahrInfo, "Text", GJ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ueberleitungsmonat) on item 'DlgFibu.Frame2.Text_UEberleitung_Monat'.", repo.DlgFibu.Frame2.Text_UEberleitung_MonatInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.Text_UEberleitung_MonatInfo, "Text", Ueberleitungsmonat);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'DlgFibu.Frame2.Firma'.", repo.DlgFibu.Frame2.FirmaInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgFibu.Frame2.FirmaInfo, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFibu.PbStart' at Center.", repo.DlgFibu.PbStartInfo, new RecordItemIndex(14));
            repo.DlgFibu.PbStart.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}