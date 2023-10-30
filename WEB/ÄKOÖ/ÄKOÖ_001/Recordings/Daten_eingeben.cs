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

namespace AEKOOE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Daten_eingeben recording.
    /// </summary>
    [TestModule("60e57da4-e037-4924-a40b-b934f5712eff", ModuleType.Recording, 1)]
    public partial class Daten_eingeben : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_001.AEKOOE_001Repository repository.
        /// </summary>
        public static global::AEKOOE_001.AEKOOE_001Repository repo = global::AEKOOE_001.AEKOOE_001Repository.Instance;

        static Daten_eingeben instance = new Daten_eingeben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Daten_eingeben()
        {
            berufsunfaehig_ab = "02.01.2023";
            berugsunfaehig_bis = "10.01.2023";
            SVNR = "1679050956";
            Bankverbindung_1 = "AT351100018481974718";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Daten_eingeben Instance
        {
            get { return instance; }
        }

#region Variables

        string _berufsunfaehig_ab;

        /// <summary>
        /// Gets or sets the value of variable berufsunfaehig_ab.
        /// </summary>
        [TestVariable("cf14cf99-63ff-4e7e-a423-0a064763a006")]
        public string berufsunfaehig_ab
        {
            get { return _berufsunfaehig_ab; }
            set { _berufsunfaehig_ab = value; }
        }

        string _berugsunfaehig_bis;

        /// <summary>
        /// Gets or sets the value of variable berugsunfaehig_bis.
        /// </summary>
        [TestVariable("c816944d-0fd4-4dfd-ae4f-9810927fc148")]
        public string berugsunfaehig_bis
        {
            get { return _berugsunfaehig_bis; }
            set { _berugsunfaehig_bis = value; }
        }

        string _SVNR;

        /// <summary>
        /// Gets or sets the value of variable SVNR.
        /// </summary>
        [TestVariable("8411f75b-d750-46cb-9056-bbdbda43b5e1")]
        public string SVNR
        {
            get { return _SVNR; }
            set { _SVNR = value; }
        }

        string _Bankverbindung_1;

        /// <summary>
        /// Gets or sets the value of variable Bankverbindung_1.
        /// </summary>
        [TestVariable("2f74c417-ab9d-4fb6-a39b-0a2319b5dc3c")]
        public string Bankverbindung_1
        {
            get { return _Bankverbindung_1; }
            set { _Bankverbindung_1 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Login.AlertAlertInfo'", repo.Login.AlertAlertInfoInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.Login.AlertAlertInfoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Krankengeld') on item 'Login.FormControl'.", repo.Login.FormControlInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Login.FormControlInfo, "InnerText", "Krankengeld");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$berufsunfaehig_ab' with focus on 'Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_ab'.", repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_abInfo, new RecordItemIndex(2));
            repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_ab.PressKeys(berufsunfaehig_ab);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$berufsunfaehig_ab) on item 'Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_ab'.", repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_abInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_abInfo, "InnerText", berufsunfaehig_ab);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$berugsunfaehig_bis' with focus on 'Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bis'.", repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bisInfo, new RecordItemIndex(5));
            repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bis.PressKeys(berugsunfaehig_bis);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$berugsunfaehig_bis) on item 'Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bis'.", repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bisInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_Zeitraum_Berufsunfaehigkeit_bisInfo, "InnerText", berugsunfaehig_bis);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$SVNR) on item 'Login.AKAT011RequestFormRow.Text_SVNR'.", repo.Login.AKAT011RequestFormRow.Text_SVNRInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.Text_SVNRInfo, "InnerText", SVNR);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.AKAT011RequestFormRow.KSelect' at Center.", repo.Login.AKAT011RequestFormRow.KSelectInfo, new RecordItemIndex(9));
            repo.Login.AKAT011RequestFormRow.KSelect.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.Auswahl_Bankverbindung' at Center.", repo.Login.Auswahl_BankverbindungInfo, new RecordItemIndex(10));
            repo.Login.Auswahl_Bankverbindung.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Bankverbindung_1) on item 'Login.Auswahl_Bankverbindung'.", repo.Login.Auswahl_BankverbindungInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.Login.Auswahl_BankverbindungInfo, "InnerText", Bankverbindung_1);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
