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

namespace S_NKRN_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neuanlage_Nummernkreis recording.
    /// </summary>
    [TestModule("2d69665c-5c60-4027-8b0f-0365b6052a3d", ModuleType.Recording, 1)]
    public partial class Neuanlage_Nummernkreis : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_NKRN_Schnelltest.S_NKRN_SchnelltestRepository repository.
        /// </summary>
        public static global::S_NKRN_Schnelltest.S_NKRN_SchnelltestRepository repo = global::S_NKRN_Schnelltest.S_NKRN_SchnelltestRepository.Instance;

        static Neuanlage_Nummernkreis instance = new Neuanlage_Nummernkreis();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_Nummernkreis()
        {
            Nummernkreis_CD_Neu = "XX_BAR";
            Nummernkreis_CD_Bezeichnung = "Autotest_Neu";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_Nummernkreis Instance
        {
            get { return instance; }
        }

#region Variables

        string _Nummernkreis_CD_Bezeichnung;

        /// <summary>
        /// Gets or sets the value of variable Nummernkreis_CD_Bezeichnung.
        /// </summary>
        [TestVariable("d5e77abc-e6ae-465b-a292-3682806239b7")]
        public string Nummernkreis_CD_Bezeichnung
        {
            get { return _Nummernkreis_CD_Bezeichnung; }
            set { _Nummernkreis_CD_Bezeichnung = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Nummernkreis_CD_Neu.
        /// </summary>
        [TestVariable("4ba83993-f47d-411d-8b37-a5b14853c04d")]
        public string Nummernkreis_CD_Neu
        {
            get { return repo.Nummernkreis_CD_Neu; }
            set { repo.Nummernkreis_CD_Neu = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmNkr.PbNew' at Center.", repo.FrmNkr.PbNewInfo, new RecordItemIndex(0));
            repo.FrmNkr.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmNkr.TitleBar100Nummernkreisverwaltung'", repo.FrmNkr.TitleBar100NummernkreisverwaltungInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmNkr.TitleBar100NummernkreisverwaltungInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100{Tab}' with focus on 'FrmNkr.SplitterPanel.DfFirmNr'.", repo.FrmNkr.SplitterPanel.DfFirmNrInfo, new RecordItemIndex(2));
            repo.FrmNkr.SplitterPanel.DfFirmNr.PressKeys("100{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nummernkreis_CD_Neu' with focus on 'FrmNkr.SplitterPanel.DfNkrNr'.", repo.FrmNkr.SplitterPanel.DfNkrNrInfo, new RecordItemIndex(3));
            repo.FrmNkr.SplitterPanel.DfNkrNr.PressKeys(Nummernkreis_CD_Neu);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nummernkreis_CD_Bezeichnung' with focus on 'FrmNkr.SplitterPanel.DfNkrBez'.", repo.FrmNkr.SplitterPanel.DfNkrBezInfo, new RecordItemIndex(5));
            repo.FrmNkr.SplitterPanel.DfNkrBez.PressKeys(Nummernkreis_CD_Bezeichnung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Tab}' with focus on 'FrmNkr.SplitterPanel.DfNkrVon'.", repo.FrmNkr.SplitterPanel.DfNkrVonInfo, new RecordItemIndex(6));
            repo.FrmNkr.SplitterPanel.DfNkrVon.PressKeys("1{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99999{Tab}' with focus on 'FrmNkr.SplitterPanel.DfNkrBis'.", repo.FrmNkr.SplitterPanel.DfNkrBisInfo, new RecordItemIndex(7));
            repo.FrmNkr.SplitterPanel.DfNkrBis.PressKeys("99999{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'N{Tab}' with focus on 'FrmNkr.SplitterPanel.DfNkrStufe'.", repo.FrmNkr.SplitterPanel.DfNkrStufeInfo, new RecordItemIndex(8));
            repo.FrmNkr.SplitterPanel.DfNkrStufe.PressKeys("N{Tab}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}