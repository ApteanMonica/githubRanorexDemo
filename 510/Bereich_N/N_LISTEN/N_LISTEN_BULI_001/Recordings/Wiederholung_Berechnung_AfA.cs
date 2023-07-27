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
    ///The Wiederholung_Berechnung_AfA recording.
    /// </summary>
    [TestModule("e56ccb67-eb92-48de-b73e-a3f27c9956db", ModuleType.Recording, 1)]
    public partial class Wiederholung_Berechnung_AfA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static Wiederholung_Berechnung_AfA instance = new Wiederholung_Berechnung_AfA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Wiederholung_Berechnung_AfA()
        {
            Beginn_GJ = "01.01.2022";
            Ende_GJ = "31.12.2022";
            Anlagennr_001 = "N_LISTEN_001_01";
            Anlagennr_002 = "N_LISTEN_001_02";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Wiederholung_Berechnung_AfA Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beginn_GJ;

        /// <summary>
        /// Gets or sets the value of variable Beginn_GJ.
        /// </summary>
        [TestVariable("b8032de5-f2d5-48c0-ae91-b7289204c982")]
        public string Beginn_GJ
        {
            get { return _Beginn_GJ; }
            set { _Beginn_GJ = value; }
        }

        string _Ende_GJ;

        /// <summary>
        /// Gets or sets the value of variable Ende_GJ.
        /// </summary>
        [TestVariable("bc31104d-8d6e-4129-8eb1-cf6896134e2a")]
        public string Ende_GJ
        {
            get { return _Ende_GJ; }
            set { _Ende_GJ = value; }
        }

        string _Anlagennr_001;

        /// <summary>
        /// Gets or sets the value of variable Anlagennr_001.
        /// </summary>
        [TestVariable("22110fbb-ccfd-42d6-b811-7f06c536e460")]
        public string Anlagennr_001
        {
            get { return _Anlagennr_001; }
            set { _Anlagennr_001 = value; }
        }

        string _Anlagennr_002;

        /// <summary>
        /// Gets or sets the value of variable Anlagennr_002.
        /// </summary>
        [TestVariable("d692a6c6-826e-4870-a8d5-0504c4132d0f")]
        public string Anlagennr_002
        {
            get { return _Anlagennr_002; }
            set { _Anlagennr_002 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBuchungsliste.PbDataAccessNeu' at Center.", repo.FrmBuchungsliste.PbDataAccessNeuInfo, new RecordItemIndex(0));
            repo.FrmBuchungsliste.PbDataAccessNeu.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmBuchungsliste.RbMonat'.", repo.FrmBuchungsliste.RbMonatInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBuchungsliste.RbMonatInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beginn_GJ) on item 'FrmBuchungsliste.TextVon'.", repo.FrmBuchungsliste.TextVonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBuchungsliste.TextVonInfo, "Text", Beginn_GJ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ende_GJ) on item 'FrmBuchungsliste.TextBis'.", repo.FrmBuchungsliste.TextBisInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBuchungsliste.TextBisInfo, "Text", Ende_GJ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlagennr_001' with focus on 'FrmBuchungsliste.AnlageNrVon'.", repo.FrmBuchungsliste.AnlageNrVonInfo, new RecordItemIndex(4));
            repo.FrmBuchungsliste.AnlageNrVon.PressKeys(Anlagennr_001);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Anlagennr_001) on item 'FrmBuchungsliste.AnlageNrVon'.", repo.FrmBuchungsliste.AnlageNrVonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBuchungsliste.AnlageNrVonInfo, "Text", Anlagennr_001);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlagennr_002' with focus on 'FrmBuchungsliste.DfAnlaNrBis'.", repo.FrmBuchungsliste.DfAnlaNrBisInfo, new RecordItemIndex(6));
            repo.FrmBuchungsliste.DfAnlaNrBis.PressKeys(Anlagennr_002);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Anlagennr_002) on item 'FrmBuchungsliste.DfAnlaNrBis'.", repo.FrmBuchungsliste.DfAnlaNrBisInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBuchungsliste.DfAnlaNrBisInfo, "Text", Anlagennr_002);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBuchungsliste.PbOptionenTabelle' at Center.", repo.FrmBuchungsliste.PbOptionenTabelleInfo, new RecordItemIndex(8));
            repo.FrmBuchungsliste.PbOptionenTabelle.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.AVZAuswertungen'", repo.DlgMessageBox.AVZAuswertungenInfo, new ActionTimeout(120000), new RecordItemIndex(9));
            repo.DlgMessageBox.AVZAuswertungenInfo.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}