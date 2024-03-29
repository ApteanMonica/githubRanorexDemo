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

namespace B_BUKA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Grundeinstellungen recording.
    /// </summary>
    [TestModule("4911d55b-1ae9-4bc0-9189-bd86d15e2b58", ModuleType.Recording, 1)]
    public partial class Grundeinstellungen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_003.B_BUKA_003Repository repository.
        /// </summary>
        public static global::B_BUKA_003.B_BUKA_003Repository repo = global::B_BUKA_003.B_BUKA_003Repository.Instance;

        static Grundeinstellungen instance = new Grundeinstellungen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Grundeinstellungen()
        {
            Kassa = "2703";
            Datum_von = "01.12.2019";
            Datum_bis = "31.12.2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Grundeinstellungen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kassa;

        /// <summary>
        /// Gets or sets the value of variable Kassa.
        /// </summary>
        [TestVariable("c198da68-4620-4b5f-97e6-b0b9199e5b6b")]
        public string Kassa
        {
            get { return _Kassa; }
            set { _Kassa = value; }
        }

        string _Datum_von;

        /// <summary>
        /// Gets or sets the value of variable Datum_von.
        /// </summary>
        [TestVariable("50016e14-434e-4aed-a294-af9179a64473")]
        public string Datum_von
        {
            get { return _Datum_von; }
            set { _Datum_von = value; }
        }

        string _Datum_bis;

        /// <summary>
        /// Gets or sets the value of variable Datum_bis.
        /// </summary>
        [TestVariable("6698bc68-4d4d-4cc3-a66b-acd46c7a856e")]
        public string Datum_bis
        {
            get { return _Datum_bis; }
            set { _Datum_bis = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbDataAccessNew' at Center.", repo.TblBuka.PbDataAccessNewInfo, new RecordItemIndex(0));
            repo.TblBuka.PbDataAccessNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kassa' with focus on 'TblBuka.ToolBar.Zahlkonto'.", repo.TblBuka.ToolBar.ZahlkontoInfo, new RecordItemIndex(1));
            repo.TblBuka.ToolBar.Zahlkonto.PressKeys(Kassa);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_von' with focus on 'TblBuka.ToolBar.DfDatumVon'.", repo.TblBuka.ToolBar.DfDatumVonInfo, new RecordItemIndex(3));
            repo.TblBuka.ToolBar.DfDatumVon.PressKeys(Datum_von);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbDataAccessLoad' at Center.", repo.TblBuka.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.TblBuka.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kassa) on item 'TblBuka.ToolBar.Zahlkonto'.", repo.TblBuka.ToolBar.ZahlkontoInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.ZahlkontoInfo, "Text", Kassa);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_von) on item 'TblBuka.ToolBar.DfDatumVon'.", repo.TblBuka.ToolBar.DfDatumVonInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.DfDatumVonInfo, "Text", Datum_von);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_bis) on item 'TblBuka.ToolBar.DfDatumBis'.", repo.TblBuka.ToolBar.DfDatumBisInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.DfDatumBisInfo, "Text", Datum_bis);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TblBuka.ToolBar.CbAnzeigeBereiche'.", repo.TblBuka.ToolBar.CbAnzeigeBereicheInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.CbAnzeigeBereicheInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TblBuka.ToolBar.CbKL'.", repo.TblBuka.ToolBar.CbKLInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.CbKLInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'K/L') on item 'TblBuka.FlexGrid1.ColBukaKlRow0_Spaltenueberschrift'.", repo.TblBuka.FlexGrid1.ColBukaKlRow0_SpaltenueberschriftInfo, new RecordItemIndex(11));
            Validate.AttributeContains(repo.TblBuka.FlexGrid1.ColBukaKlRow0_SpaltenueberschriftInfo, "Text", "K/L");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Saldovortrag') on item 'TblBuka.FlexGrid1.ColTextRow1'.", repo.TblBuka.FlexGrid1.ColTextRow1Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.TblBuka.FlexGrid1.ColTextRow1Info, "Text", "Saldovortrag");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
