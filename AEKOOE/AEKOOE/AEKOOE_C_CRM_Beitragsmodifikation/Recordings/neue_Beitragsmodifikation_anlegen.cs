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

namespace AEKOOE_C_CRM_Beitragsmodifikation.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The neue_Beitragsmodifikation_anlegen recording.
    /// </summary>
    [TestModule("6a949b8a-a837-4875-b1ec-453b4c19b1b2", ModuleType.Recording, 1)]
    public partial class neue_Beitragsmodifikation_anlegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_C_CRM_Beitragsmodifikation.AEKOOE_C_CRM_BeitragsmodifikationRepository repository.
        /// </summary>
        public static global::AEKOOE_C_CRM_Beitragsmodifikation.AEKOOE_C_CRM_BeitragsmodifikationRepository repo = global::AEKOOE_C_CRM_Beitragsmodifikation.AEKOOE_C_CRM_BeitragsmodifikationRepository.Instance;

        static neue_Beitragsmodifikation_anlegen instance = new neue_Beitragsmodifikation_anlegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public neue_Beitragsmodifikation_anlegen()
        {
            Modifikation_Code = "";
            Datum_von_unformatiert = "";
            Datum_bis_unformatiert = "";
            Beitrag_Sparte = "";
            Modifikationsgrund_Code = "";
            Zusatztext = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static neue_Beitragsmodifikation_anlegen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Modifikation_Code;

        /// <summary>
        /// Gets or sets the value of variable Modifikation_Code.
        /// </summary>
        [TestVariable("ba7d0aab-6920-4bb3-bbcf-a271717daef2")]
        public string Modifikation_Code
        {
            get { return _Modifikation_Code; }
            set { _Modifikation_Code = value; }
        }

        string _Datum_von_unformatiert;

        /// <summary>
        /// Gets or sets the value of variable Datum_von_unformatiert.
        /// </summary>
        [TestVariable("8f34434b-c839-431b-a9a1-b0ecf4d36e41")]
        public string Datum_von_unformatiert
        {
            get { return _Datum_von_unformatiert; }
            set { _Datum_von_unformatiert = value; }
        }

        string _Datum_bis_unformatiert;

        /// <summary>
        /// Gets or sets the value of variable Datum_bis_unformatiert.
        /// </summary>
        [TestVariable("253a69db-44b0-4a80-bcfd-ee8ed7c50bfa")]
        public string Datum_bis_unformatiert
        {
            get { return _Datum_bis_unformatiert; }
            set { _Datum_bis_unformatiert = value; }
        }

        string _Beitrag_Sparte;

        /// <summary>
        /// Gets or sets the value of variable Beitrag_Sparte.
        /// </summary>
        [TestVariable("013db42e-3092-4cdb-91b5-59125ae85170")]
        public string Beitrag_Sparte
        {
            get { return _Beitrag_Sparte; }
            set { _Beitrag_Sparte = value; }
        }

        string _Modifikationsgrund_Code;

        /// <summary>
        /// Gets or sets the value of variable Modifikationsgrund_Code.
        /// </summary>
        [TestVariable("d967bdea-cccc-40a7-8ec8-66d2526fadfa")]
        public string Modifikationsgrund_Code
        {
            get { return _Modifikationsgrund_Code; }
            set { _Modifikationsgrund_Code = value; }
        }

        string _Zusatztext;

        /// <summary>
        /// Gets or sets the value of variable Zusatztext.
        /// </summary>
        [TestVariable("9d0607d4-a25c-435a-b785-b93a0065790e")]
        public string Zusatztext
        {
            get { return _Zusatztext; }
            set { _Zusatztext = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiCRM.Form_Beitragsmodifikation.PbCustomCreate_Neu' at Center.", repo.MdiCRM.Form_Beitragsmodifikation.PbCustomCreate_NeuInfo, new RecordItemIndex(0));
            repo.MdiCRM.Form_Beitragsmodifikation.PbCustomCreate_Neu.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgWizard_Beitragsmodifikation_anlegen.TitleBarWFKBeitragsmodifikationAnlegen'", repo.DlgWizard_Beitragsmodifikation_anlegen.TitleBarWFKBeitragsmodifikationAnlegenInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.DlgWizard_Beitragsmodifikation_anlegen.TitleBarWFKBeitragsmodifikationAnlegenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgWizard_Beitragsmodifikation_anlegen.RbSingleContribution' at Center.", repo.DlgWizard_Beitragsmodifikation_anlegen.RbSingleContributionInfo, new RecordItemIndex(2));
            repo.DlgWizard_Beitragsmodifikation_anlegen.RbSingleContribution.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgWizard_Beitragsmodifikation_anlegen.PbNext' at Center.", repo.DlgWizard_Beitragsmodifikation_anlegen.PbNextInfo, new RecordItemIndex(4));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PbNext.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgWizard_Beitragsmodifikation_anlegen.Beitragssparte'", repo.DlgWizard_Beitragsmodifikation_anlegen.BeitragssparteInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.DlgWizard_Beitragsmodifikation_anlegen.BeitragssparteInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beitrag_Sparte' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.Beitragssparte'.", repo.DlgWizard_Beitragsmodifikation_anlegen.BeitragssparteInfo, new RecordItemIndex(6));
            repo.DlgWizard_Beitragsmodifikation_anlegen.Beitragssparte.PressKeys(Beitrag_Sparte);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modifikationsgrund_Code' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Begruendung'.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.BegruendungInfo, new RecordItemIndex(8));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Begruendung.EnsureVisible();
            Keyboard.Press(Modifikationsgrund_Code);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_von_unformatiert' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.GueltigVon'.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.GueltigVonInfo, new RecordItemIndex(10));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.GueltigVon.PressKeys(Datum_von_unformatiert);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_bis_unformatiert' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Gueltig_bis'.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Gueltig_bisInfo, new RecordItemIndex(12));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Gueltig_bis.PressKeys(Datum_bis_unformatiert);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_von_unformatiert' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.LautVAVom'.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.LautVAVomInfo, new RecordItemIndex(14));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.LautVAVom.PressKeys(Datum_von_unformatiert);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(15));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modifikation_Code' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Modifikationsart'.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.ModifikationsartInfo, new RecordItemIndex(16));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.Modifikationsart.PressKeys(Modifikation_Code);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.CbBemoKzbeitrfrei' at Center.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.CbBemoKzbeitrfreiInfo, new RecordItemIndex(18));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.CbBemoKzbeitrfrei.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Zusatztext' with focus on 'DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.ZusaetzlicheInformation'.", repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.ZusaetzlicheInformationInfo, new RecordItemIndex(20));
            repo.DlgWizard_Beitragsmodifikation_anlegen.PnlDetails.ZusaetzlicheInformation.PressKeys(Zusatztext);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(21));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
