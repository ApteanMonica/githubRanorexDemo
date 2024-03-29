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

namespace N_ANLA_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_zusammengefuehrte_Anlagen recording.
    /// </summary>
    [TestModule("900e17a9-3f05-48a5-a705-d2c24321b63b", ModuleType.Recording, 1)]
    public partial class Kontrolle_zusammengefuehrte_Anlagen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_001.N_ANLA_001Repository repository.
        /// </summary>
        public static global::N_ANLA_001.N_ANLA_001Repository repo = global::N_ANLA_001.N_ANLA_001Repository.Instance;

        static Kontrolle_zusammengefuehrte_Anlagen instance = new Kontrolle_zusammengefuehrte_Anlagen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_zusammengefuehrte_Anlagen()
        {
            AHK_Betrag = "1.500,00";
            AHK_Betrag_aktuell_gesamt = "3.900,00";
            Anlage_B = "N_ANLA_001_02";
            Anlage_C = "N_ANLA_001_03";
            Anlage_A = "N_ANLA_001_01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_zusammengefuehrte_Anlagen Instance
        {
            get { return instance; }
        }

#region Variables

        string _AHK_Betrag;

        /// <summary>
        /// Gets or sets the value of variable AHK_Betrag.
        /// </summary>
        [TestVariable("8d46f30e-535f-4061-b476-d5f944d931d4")]
        public string AHK_Betrag
        {
            get { return _AHK_Betrag; }
            set { _AHK_Betrag = value; }
        }

        string _AHK_Betrag_aktuell_gesamt;

        /// <summary>
        /// Gets or sets the value of variable AHK_Betrag_aktuell_gesamt.
        /// </summary>
        [TestVariable("64ddc6ef-7b4b-411a-98a0-d8ab9396c630")]
        public string AHK_Betrag_aktuell_gesamt
        {
            get { return _AHK_Betrag_aktuell_gesamt; }
            set { _AHK_Betrag_aktuell_gesamt = value; }
        }

        string _Anlage_C;

        /// <summary>
        /// Gets or sets the value of variable Anlage_C.
        /// </summary>
        [TestVariable("d77a9fb5-da8d-4283-9503-d4acbce6073b")]
        public string Anlage_C
        {
            get { return _Anlage_C; }
            set { _Anlage_C = value; }
        }

        string _Anlage_A;

        /// <summary>
        /// Gets or sets the value of variable Anlage_A.
        /// </summary>
        [TestVariable("68ead818-4fa4-4d58-9e29-9d3f4418b11f")]
        public string Anlage_A
        {
            get { return _Anlage_A; }
            set { _Anlage_A = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Anlage_B.
        /// </summary>
        [TestVariable("cd3d9c9e-27fe-4702-a8bd-2a71412efe35")]
        public string Anlage_B
        {
            get { return repo.Anlage_B; }
            set { repo.Anlage_B = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'AVZ - Anlagen') on item 'FrmAnla.TitleBar100AVZAnlagen'.", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmAnla.TitleBar100AVZAnlagenInfo, "Text", "AVZ - Anlagen");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_B' with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(2));
            repo.FrmAnla.DfAnlaNr.PressKeys(Anlage_B);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.FrmAnla.DfAnlaNr);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Zusammengeführt') on item 'FrmAnla.CmbAnlagenStatus'.", repo.FrmAnla.CmbAnlagenStatusInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmAnla.CmbAnlagenStatusInfo, "Text", "Zusammengeführt");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbCommonNew' at Center.", repo.FrmAnla.PbCommonNewInfo, new RecordItemIndex(5));
            repo.FrmAnla.PbCommonNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_C' with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(6));
            repo.FrmAnla.DfAnlaNr.PressKeys(Anlage_C);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.FrmAnla.DfAnlaNr);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Zusammengeführt') on item 'FrmAnla.CmbAnlagenStatus'.", repo.FrmAnla.CmbAnlagenStatusInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmAnla.CmbAnlagenStatusInfo, "Text", "Zusammengeführt");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbCommonNew' at Center.", repo.FrmAnla.PbCommonNewInfo, new RecordItemIndex(9));
            repo.FrmAnla.PbCommonNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_A' with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(10));
            repo.FrmAnla.DfAnlaNr.PressKeys(Anlage_A);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.FrmAnla.DfAnlaNr);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='aktiv') on item 'FrmAnla.CmbAnlagenStatus'.", repo.FrmAnla.CmbAnlagenStatusInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmAnla.CmbAnlagenStatusInfo, "Text", "aktiv");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.Steuer' at Center.", repo.FrmAnla.SteuerInfo, new RecordItemIndex(13));
            repo.FrmAnla.Steuer.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AHK_Betrag) on item 'FrmAnla.DfAnlaAhkbetrag'.", repo.FrmAnla.DfAnlaAhkbetragInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmAnla.DfAnlaAhkbetragInfo, "Text", AHK_Betrag);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AHK_Betrag_aktuell_gesamt) on item 'FrmAnla.DfAnwe1Ahkbetrag'.", repo.FrmAnla.DfAnwe1AhkbetragInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmAnla.DfAnwe1AhkbetragInfo, "Text", AHK_Betrag_aktuell_gesamt);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
