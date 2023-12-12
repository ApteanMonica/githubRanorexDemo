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

namespace B_ERBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Erfassung_ER_2 recording.
    /// </summary>
    [TestModule("9adad2be-75c9-41fa-8d8d-5a04505151d1", ModuleType.Recording, 1)]
    public partial class Erfassung_ER_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_001.B_ERBU_001Repository repository.
        /// </summary>
        public static global::B_ERBU_001.B_ERBU_001Repository repo = global::B_ERBU_001.B_ERBU_001Repository.Instance;

        static Erfassung_ER_2 instance = new Erfassung_ER_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung_ER_2()
        {
            Lieferant = "";
            Tagesdatum = "";
            Rechnungsnummer2 = "";
            Rechnungsdatum2 = "";
            Rechnungsbetrag2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung_ER_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("5698a313-9728-467f-979d-f002bd5eec9e")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("39609202-00c7-446b-a5d9-63ce4879992c")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _Rechnungsnummer2;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsnummer2.
        /// </summary>
        [TestVariable("e436581f-b8f1-4980-9246-6008d0cb65c8")]
        public string Rechnungsnummer2
        {
            get { return _Rechnungsnummer2; }
            set { _Rechnungsnummer2 = value; }
        }

        string _Rechnungsdatum2;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsdatum2.
        /// </summary>
        [TestVariable("8d5b6774-272a-45fd-9931-4d3f72e946db")]
        public string Rechnungsdatum2
        {
            get { return _Rechnungsdatum2; }
            set { _Rechnungsdatum2 = value; }
        }

        string _Rechnungsbetrag2;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsbetrag2.
        /// </summary>
        [TestVariable("3e49b504-97f1-49e2-8bcc-ae1586df0f16")]
        public string Rechnungsbetrag2
        {
            get { return _Rechnungsbetrag2; }
            set { _Rechnungsbetrag2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.FlexGrid1.ColAdrNrRow2' at Center.", repo.TblErbu.FlexGrid1.ColAdrNrRow2Info, new RecordItemIndex(0));
            repo.TblErbu.FlexGrid1.ColAdrNrRow2.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lieferant' with focus on 'TblErbu.FlexGrid1.ColAdrNrRow2'.", repo.TblErbu.FlexGrid1.ColAdrNrRow2Info, new RecordItemIndex(2));
            repo.TblErbu.FlexGrid1.ColAdrNrRow2.EnsureVisible();
            Keyboard.Press(Lieferant);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'TblErbu.FlexGrid1.ColAdrNrRow2'.", repo.TblErbu.FlexGrid1.ColAdrNrRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColAdrNrRow2Info, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblErbu.FlexGrid1.ColErbuDteingangRow2'.", repo.TblErbu.FlexGrid1.ColErbuDteingangRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColErbuDteingangRow2Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsnummer2' with focus on 'TblErbu.FlexGrid1.ColErbuRechnrRow2'.", repo.TblErbu.FlexGrid1.ColErbuRechnrRow2Info, new RecordItemIndex(8));
            repo.TblErbu.FlexGrid1.ColErbuRechnrRow2.EnsureVisible();
            Keyboard.Press(Rechnungsnummer2);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnungsnummer2) on item 'TblErbu.FlexGrid1.ColErbuRechnrRow2'.", repo.TblErbu.FlexGrid1.ColErbuRechnrRow2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColErbuRechnrRow2Info, "Text", Rechnungsnummer2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsdatum2' with focus on 'TblErbu.FlexGrid1.ColErbuDtrechRow2'.", repo.TblErbu.FlexGrid1.ColErbuDtrechRow2Info, new RecordItemIndex(12));
            repo.TblErbu.FlexGrid1.ColErbuDtrechRow2.EnsureVisible();
            Keyboard.Press(Rechnungsdatum2);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnungsdatum2) on item 'TblErbu.FlexGrid1.ColErbuDtrechRow2'.", repo.TblErbu.FlexGrid1.ColErbuDtrechRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColErbuDtrechRow2Info, "Text", Rechnungsdatum2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsbetrag2' with focus on 'TblErbu.FlexGrid1.ColErbuBetragRow2'.", repo.TblErbu.FlexGrid1.ColErbuBetragRow2Info, new RecordItemIndex(16));
            repo.TblErbu.FlexGrid1.ColErbuBetragRow2.EnsureVisible();
            Keyboard.Press(Rechnungsbetrag2);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(17));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(18));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Rechnungsbetrag2) on item 'TblErbu.FlexGrid1.ColErbuBetragRow2'.", repo.TblErbu.FlexGrid1.ColErbuBetragRow2Info, new RecordItemIndex(19));
            Validate.AttributeContains(repo.TblErbu.FlexGrid1.ColErbuBetragRow2Info, "Text", Rechnungsbetrag2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.Right' at Center.", repo.TblErbu.RightInfo, new RecordItemIndex(20));
            repo.TblErbu.Right.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.Right' at Center.", repo.TblErbu.RightInfo, new RecordItemIndex(21));
            repo.TblErbu.Right.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.Right' at Center.", repo.TblErbu.RightInfo, new RecordItemIndex(22));
            repo.TblErbu.Right.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.Right' at Center.", repo.TblErbu.RightInfo, new RecordItemIndex(23));
            repo.TblErbu.Right.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.FlexGrid1.ColErbuDtweiterRow2' at Center.", repo.TblErbu.FlexGrid1.ColErbuDtweiterRow2Info, new RecordItemIndex(24));
            repo.TblErbu.FlexGrid1.ColErbuDtweiterRow2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tagesdatum' with focus on 'TblErbu.FlexGrid1.ColErbuDtweiterRow2'.", repo.TblErbu.FlexGrid1.ColErbuDtweiterRow2Info, new RecordItemIndex(25));
            repo.TblErbu.FlexGrid1.ColErbuDtweiterRow2.EnsureVisible();
            Keyboard.Press(Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(26));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Insert' Press.", new RecordItemIndex(27));
            Keyboard.Press(System.Windows.Forms.Keys.Insert, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(28));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'TblErbu.FlexGrid1.ColErbuDtweiterRow2'.", repo.TblErbu.FlexGrid1.ColErbuDtweiterRow2Info, new RecordItemIndex(29));
            Validate.AttributeContains(repo.TblErbu.FlexGrid1.ColErbuDtweiterRow2Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'([0-9]{6})$') on item 'TblErbu.FlexGrid1.ColErbuNrRow2'.", repo.TblErbu.FlexGrid1.ColErbuNrRow2Info, new RecordItemIndex(30));
            Validate.AttributeRegex(repo.TblErbu.FlexGrid1.ColErbuNrRow2Info, "Text", new Regex("([0-9]{6})$"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
