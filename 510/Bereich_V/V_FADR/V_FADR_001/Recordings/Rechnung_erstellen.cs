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

namespace V_FADR_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Rechnung_erstellen recording.
    /// </summary>
    [TestModule("6d10b96a-a394-45ea-bc07-a136facbac00", ModuleType.Recording, 1)]
    public partial class Rechnung_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Rechnung_erstellen instance = new Rechnung_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Rechnung_erstellen()
        {
            Auftragsnummer = "201900005";
            Rechnungsnummer = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Rechnung_erstellen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Rechnungsnummer;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsnummer.
        /// </summary>
        [TestVariable("8107eb30-6054-42ba-8953-5373fde332b2")]
        public string Rechnungsnummer
        {
            get { return _Rechnungsnummer; }
            set { _Rechnungsnummer = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Auftragsnummer.
        /// </summary>
        [TestVariable("3f603517-740d-47df-bc01-ff6361981830")]
        public string Auftragsnummer
        {
            get { return repo.Auftragsnummer; }
            set { repo.Auftragsnummer = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.untere_Tabelle.Column0_in_Zeile_mit_Auftragsnummer' at Center.", repo.TblFadr.untere_Tabelle.Column0_in_Zeile_mit_AuftragsnummerInfo, new RecordItemIndex(0));
            repo.TblFadr.untere_Tabelle.Column0_in_Zeile_mit_Auftragsnummer.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbSpec2Fakturenerstellung' at Center.", repo.TblFadr.PbSpec2FakturenerstellungInfo, new RecordItemIndex(2));
            repo.TblFadr.PbSpec2Fakturenerstellung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsnummer' with focus on 'TblFadr.untere_Tabelle.Rechnungsnummer'.", repo.TblFadr.untere_Tabelle.RechnungsnummerInfo, new RecordItemIndex(3));
            repo.TblFadr.untere_Tabelle.Rechnungsnummer.PressKeys(Rechnungsnummer);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PageLeft' at Center.", repo.TblFadr.PageLeftInfo, new RecordItemIndex(5));
            //repo.TblFadr.PageLeft.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Rechnungsnummer) on item 'TblFadr.untere_Tabelle.Rechnungsnummer'.", repo.TblFadr.untere_Tabelle.RechnungsnummerInfo, new RecordItemIndex(6));
            Validate.AttributeRegex(repo.TblFadr.untere_Tabelle.RechnungsnummerInfo, "Text", new Regex(Rechnungsnummer));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
