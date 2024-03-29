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

namespace B_BUST_001_250.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Firma_250_auswaehlen recording.
    /// </summary>
    [TestModule("e57e484a-8c32-4cc3-b75f-40e66de1b770", ModuleType.Recording, 1)]
    public partial class Aufruf_Fa250_Fa250_aus_erw_Suche_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUST_001_250.B_BUST_001_250Repository repository.
        /// </summary>
        public static global::B_BUST_001_250.B_BUST_001_250Repository repo = global::B_BUST_001_250.B_BUST_001_250Repository.Instance;

        static Aufruf_Fa250_Fa250_aus_erw_Suche_laden instance = new Aufruf_Fa250_Fa250_aus_erw_Suche_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aufruf_Fa250_Fa250_aus_erw_Suche_laden()
        {
            Firma = "250";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aufruf_Fa250_Fa250_aus_erw_Suche_laden Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("c6087664-703c-445b-bdb1-b4ff517a2c30")]
        public string Firma
        {
            get { return repo.Firma; }
            set { repo.Firma = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'FrmBust.TitleBar100VerwaltenBuchungsSteuer'.", repo.FrmBust.TitleBar100VerwaltenBuchungsSteuerInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.FrmBust.TitleBar100VerwaltenBuchungsSteuerInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBust.Suchmaske.Button_erweiterte_Suche' at Center.", repo.FrmBust.Suchmaske.Button_erweiterte_SucheInfo, new RecordItemIndex(1));
            repo.FrmBust.Suchmaske.Button_erweiterte_Suche.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBust.Suchmaske.PbPerformSearch_Lupe_erw_Suche' at Center.", repo.FrmBust.Suchmaske.PbPerformSearch_Lupe_erw_SucheInfo, new RecordItemIndex(2));
            repo.FrmBust.Suchmaske.PbPerformSearch_Lupe_erw_Suche.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmBust.Suchmaske.Suchergebnis.Zeile_mit_Firma_250'", repo.FrmBust.Suchmaske.Suchergebnis.Zeile_mit_Firma_250Info, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.FrmBust.Suchmaske.Suchergebnis.Zeile_mit_Firma_250Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'FrmBust.Suchmaske.Suchergebnis.Zeile_mit_Firma_250'.", repo.FrmBust.Suchmaske.Suchergebnis.Zeile_mit_Firma_250Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmBust.Suchmaske.Suchergebnis.Zeile_mit_Firma_250Info, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBust.Suchmaske.Suchergebnis.Column0_in_Zeile_mit_Firma_250' at Center.", repo.FrmBust.Suchmaske.Suchergebnis.Column0_in_Zeile_mit_Firma_250Info, new RecordItemIndex(5));
            repo.FrmBust.Suchmaske.Suchergebnis.Column0_in_Zeile_mit_Firma_250.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmBust.DfFirmNr'", repo.FrmBust.DfFirmNrInfo, new ActionTimeout(60000), new RecordItemIndex(6));
            repo.FrmBust.DfFirmNrInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='250') on item 'FrmBust.DfFirmNr'.", repo.FrmBust.DfFirmNrInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBust.DfFirmNrInfo, "Text", "250");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='TEST_B_BUST') on item 'FrmBust.DfFirmKbez'.", repo.FrmBust.DfFirmKbezInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBust.DfFirmKbezInfo, "Text", "TEST_B_BUST");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
