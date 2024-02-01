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
        /// Holds an instance of the global::AEKOOE_001.AEKOOE_WEB_001Repository repository.
        /// </summary>
        public static global::AEKOOE_001.AEKOOE_WEB_001Repository repo = global::AEKOOE_001.AEKOOE_WEB_001Repository.Instance;

        static Daten_eingeben instance = new Daten_eingeben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Daten_eingeben()
        {
            Diagnose = "Testdiagnose zum Krankengeld";
            Tagesdatum = "";
            Tagesdatum_plus_7_Tage = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Daten_eingeben Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Diagnose.
        /// </summary>
        [TestVariable("a438f4cc-cc00-44e9-abf0-2e5c71a5523b")]
        public string Diagnose
        {
            get { return repo.Diagnose; }
            set { repo.Diagnose = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("0b20a6c3-01c6-478d-a42a-cd1605d0f3be")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_plus_7_Tage.
        /// </summary>
        [TestVariable("28992d41-1fc0-4116-9977-6040fb52a494")]
        public string Tagesdatum_plus_7_Tage
        {
            get { return repo.Tagesdatum_plus_7_Tage; }
            set { repo.Tagesdatum_plus_7_Tage = value; }
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

            //Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetSystemDateTimeAsString("dd.MM.yyyy");
            
            //Report.Log(ReportLevel.Info, "User", Tagesdatum, new RecordItemIndex(1));
            
            //Tagesdatum_plus_7_Tage = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetSystemDateTimePlus("d", ValueConverter.ArgumentFromString<int>("counter", "7"));
            
            //Report.Log(ReportLevel.Info, "User", Tagesdatum_plus_7_Tage, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.AntragAufKrankengeld'", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.AntragAufKrankengeldInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.AntragAufKrankengeldInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "User", Tagesdatum, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Antrag auf Krankengeld') on item 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.AntragAufKrankengeld'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.AntragAufKrankengeldInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.AntragAufKrankengeldInfo, "InnerText", "Antrag auf Krankengeld");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tagesdatum' with focus on 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Text_Berufsunfaehigkeit_ab'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Text_Berufsunfaehigkeit_abInfo, new RecordItemIndex(7));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Text_Berufsunfaehigkeit_ab.PressKeys(Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "User", Tagesdatum_plus_7_Tage, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tagesdatum_plus_7_Tage' with focus on 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Text_Berufsunfaehigkeit_bis'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Text_Berufsunfaehigkeit_bisInfo, new RecordItemIndex(10));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Text_Berufsunfaehigkeit_bis.PressKeys(Tagesdatum_plus_7_Tage);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Bankverbindung' at Center.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_BankverbindungInfo, new RecordItemIndex(12));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Bankverbindung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Tab}'.", new RecordItemIndex(13));
            Keyboard.Press("{Down}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Diagnose' with focus on 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.False_Eingabe_Diagnose'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.False_Eingabe_DiagnoseInfo, new RecordItemIndex(15));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.False_Eingabe_Diagnose.PressKeys(Diagnose);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.False_Eingabe_Diagnose'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.False_Eingabe_DiagnoseInfo, new RecordItemIndex(16));
            Keyboard.PrepareFocus(repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.False_Eingabe_Diagnose);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Aufenthaltsort' at Center.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_AufenthaltsortInfo, new RecordItemIndex(17));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Aufenthaltsort.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Down' Press with focus on 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Aufenthaltsort'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_AufenthaltsortInfo, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Aufenthaltsort);
            Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press with focus on 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Aufenthaltsort'.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_AufenthaltsortInfo, new RecordItemIndex(19));
            Keyboard.PrepareFocus(repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.KInput_Aufenthaltsort);
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Checkbox_Fremdverschulden' at Center.", repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Checkbox_FremdverschuldenInfo, new RecordItemIndex(20));
            repo.Login.AKAT011RequestFormRow__Tabelle_rechts_neuer_Antrag.Checkbox_Fremdverschulden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}