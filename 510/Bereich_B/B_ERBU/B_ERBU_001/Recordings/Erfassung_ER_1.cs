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
    ///The Erfassung_ER_1 recording.
    /// </summary>
    [TestModule("f0ff5841-cde5-487e-a424-1dafdff4b1ff", ModuleType.Recording, 1)]
    public partial class Erfassung_ER_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_001.B_ERBU_001Repository repository.
        /// </summary>
        public static global::B_ERBU_001.B_ERBU_001Repository repo = global::B_ERBU_001.B_ERBU_001Repository.Instance;

        static Erfassung_ER_1 instance = new Erfassung_ER_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung_ER_1()
        {
            Lieferant = "";
            Tagesdatum = "";
            Rechnungsnummer1 = "";
            Rechnungsdatum1 = "";
            Rechnungsbetrag1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung_ER_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("fefa3831-8e09-4718-bab3-2c928c66bc39")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("cb23b5dc-92b3-45e3-b902-c0e7246a8524")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _Rechnungsnummer1;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsnummer1.
        /// </summary>
        [TestVariable("6c70a960-f5a7-474e-bf41-24f3c627f780")]
        public string Rechnungsnummer1
        {
            get { return _Rechnungsnummer1; }
            set { _Rechnungsnummer1 = value; }
        }

        string _Rechnungsdatum1;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsdatum1.
        /// </summary>
        [TestVariable("5466fd64-a5a2-42b0-9e2f-b25678720407")]
        public string Rechnungsdatum1
        {
            get { return _Rechnungsdatum1; }
            set { _Rechnungsdatum1 = value; }
        }

        string _Rechnungsbetrag1;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsbetrag1.
        /// </summary>
        [TestVariable("6aa7d0f4-0de7-48b1-b7dd-ddb0aa1bc762")]
        public string Rechnungsbetrag1
        {
            get { return _Rechnungsbetrag1; }
            set { _Rechnungsbetrag1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.FlexGrid' at Center.", repo.TblErbu.FlexGridInfo, new RecordItemIndex(0));
            repo.TblErbu.FlexGrid.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Insert' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Insert, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.FlexGrid1.ColAdrNrRow1' at Center.", repo.TblErbu.FlexGrid1.ColAdrNrRow1Info, new RecordItemIndex(2));
            repo.TblErbu.FlexGrid1.ColAdrNrRow1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lieferant' with focus on 'TblErbu.FlexGrid1.ColAdrNrRow1'.", repo.TblErbu.FlexGrid1.ColAdrNrRow1Info, new RecordItemIndex(3));
            repo.TblErbu.FlexGrid1.ColAdrNrRow1.EnsureVisible();
            Keyboard.Press(Lieferant);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'TblErbu.FlexGrid1.ColAdrNrRow1'.", repo.TblErbu.FlexGrid1.ColAdrNrRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColAdrNrRow1Info, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblErbu.FlexGrid1.ColErbuDteingangRow1'.", repo.TblErbu.FlexGrid1.ColErbuDteingangRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColErbuDteingangRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsnummer1' with focus on 'TblErbu.FlexGrid1.ColErbuRechnrRow1'.", repo.TblErbu.FlexGrid1.ColErbuRechnrRow1Info, new RecordItemIndex(7));
            repo.TblErbu.FlexGrid1.ColErbuRechnrRow1.EnsureVisible();
            Keyboard.Press(Rechnungsnummer1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnungsnummer1) on item 'TblErbu.FlexGrid1.ColErbuRechnrRow1'.", repo.TblErbu.FlexGrid1.ColErbuRechnrRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColErbuRechnrRow1Info, "Text", Rechnungsnummer1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsdatum1' with focus on 'TblErbu.FlexGrid1.ColErbuDtrechRow1'.", repo.TblErbu.FlexGrid1.ColErbuDtrechRow1Info, new RecordItemIndex(10));
            repo.TblErbu.FlexGrid1.ColErbuDtrechRow1.EnsureVisible();
            Keyboard.Press(Rechnungsdatum1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnungsdatum1) on item 'TblErbu.FlexGrid1.ColErbuDtrechRow1'.", repo.TblErbu.FlexGrid1.ColErbuDtrechRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblErbu.FlexGrid1.ColErbuDtrechRow1Info, "Text", Rechnungsdatum1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsbetrag1' with focus on 'TblErbu.FlexGrid1.ColErbuBetragRow1'.", repo.TblErbu.FlexGrid1.ColErbuBetragRow1Info, new RecordItemIndex(13));
            repo.TblErbu.FlexGrid1.ColErbuBetragRow1.EnsureVisible();
            Keyboard.Press(Rechnungsbetrag1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Insert' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Insert, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (AccessibleValue~$Rechnungsbetrag1) on item 'TblErbu.FlexGrid1.ColErbuBetragRow1'.", repo.TblErbu.FlexGrid1.ColErbuBetragRow1Info, new RecordItemIndex(15));
            Validate.AttributeRegex(repo.TblErbu.FlexGrid1.ColErbuBetragRow1Info, "AccessibleValue", new Regex(Rechnungsbetrag1));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'([0-9]{6})$') on item 'TblErbu.FlexGrid1.ColErbuNrRow1'.", repo.TblErbu.FlexGrid1.ColErbuNrRow1Info, new RecordItemIndex(16));
            Validate.AttributeRegex(repo.TblErbu.FlexGrid1.ColErbuNrRow1Info, "Text", new Regex("([0-9]{6})$"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
