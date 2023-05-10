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

namespace B_BUCH_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_Eingabe_Zahlung recording.
    /// </summary>
    [TestModule("42d68b07-e481-4e25-82df-5df1497c46cd", ModuleType.Recording, 1)]
    public partial class Validation_Eingabe_Zahlung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_003.B_BUCH_003Repository repository.
        /// </summary>
        public static global::B_BUCH_003.B_BUCH_003Repository repo = global::B_BUCH_003.B_BUCH_003Repository.Instance;

        static Validation_Eingabe_Zahlung instance = new Validation_Eingabe_Zahlung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_Eingabe_Zahlung()
        {
            OP_Beleg = "OP_BELEG_B_BUCH_003_1";
            Kunde = "200006";
            Beleg1 = "B_BUCH_003_1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_Eingabe_Zahlung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("c50a3959-f972-47a0-b13a-dd75edfc64fa")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
        }

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("469eca59-b055-4348-8ea3-24b2e71f3de0")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable OP_Beleg.
        /// </summary>
        [TestVariable("7cbe956b-18c6-4693-9814-d2fc4749edae")]
        public string OP_Beleg
        {
            get { return repo.OP_Beleg; }
            set { repo.OP_Beleg = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'MdiBuch.FrmZ.Beleg'.", repo.MdiBuch.FrmZ.BelegInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MdiBuch.FrmZ.BelegInfo, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='98,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfSoll'.", repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, "Text", "98,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bank 1  ') on item 'MdiBuch.FrmZ.DfZahlktoBez'.", repo.MdiBuch.FrmZ.DfZahlktoBezInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiBuch.FrmZ.DfZahlktoBezInfo, "Text", "Bank 1  ");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Kunde) on item 'MdiBuch.FrmZ.Konto'.", repo.MdiBuch.FrmZ.KontoInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.MdiBuch.FrmZ.KontoInfo, "Text", Kunde);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'KUNDE FÜR B_BUCH MIT BV') on item 'MdiBuch.FrmZ.DfAdrName'.", repo.MdiBuch.FrmZ.DfAdrNameInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.MdiBuch.FrmZ.DfAdrNameInfo, "Text", "KUNDE FÜR B_BUCH MIT BV");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$OP_Beleg) on item 'MdiBuch.frmZP_Tabelle_Buchung.ColBelegnrRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColBelegnrRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColBelegnrRow1Info, "Text", OP_Beleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='01.01.2020') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColDtbelegRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColDtbelegRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColDtbelegRow1Info, "Text", "01.01.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='31.01.2020') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColDtfaelligRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColDtfaelligRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColDtfaelligRow1Info, "Text", "31.01.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='98,00') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColNettoRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColNettoRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColNettoRow1Info, "Text", "98,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColBetragRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColBetragRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColBetragRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColArtRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColArtRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColArtRow1Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$OP_Beleg) on item 'MdiBuch.frmZP_Tabelle_Buchung.ColTextRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColTextRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColTextRow1Info, "Text", OP_Beleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColSkonto1Row1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColSkonto1Row1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColSkonto1Row1Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColSkontoBasisRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColSkontoBasisRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColSkontoBasisRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='15.01.2020') on item 'MdiBuch.frmZP_Tabelle_Buchung.ColDtSkontoRow1'.", repo.MdiBuch.frmZP_Tabelle_Buchung.ColDtSkontoRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiBuch.frmZP_Tabelle_Buchung.ColDtSkontoRow1Info, "Text", "15.01.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$OP_Beleg) on item 'MdiBuch.FrmZP.DfBelegnr_frmZP'.", repo.MdiBuch.FrmZP.DfBelegnr_frmZPInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.MdiBuch.FrmZP.DfBelegnr_frmZPInfo, "Text", OP_Beleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='98,00') on item 'MdiBuch.FrmZP.DfBetrag_frmZP'.", repo.MdiBuch.FrmZP.DfBetrag_frmZPInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.MdiBuch.FrmZP.DfBetrag_frmZPInfo, "Text", "98,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'MdiBuch.FrmZP.DfSkProz_frmZP'.", repo.MdiBuch.FrmZP.DfSkProz_frmZPInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.MdiBuch.FrmZP.DfSkProz_frmZPInfo, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'MdiBuch.FrmZP.DfSkonto_frmZP'.", repo.MdiBuch.FrmZP.DfSkonto_frmZPInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.MdiBuch.FrmZP.DfSkonto_frmZPInfo, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Ausgleich OP_BELEG_B_BUCH_003_1') on item 'MdiBuch.FrmZP.DfText1_frmZP'.", repo.MdiBuch.FrmZP.DfText1_frmZPInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.MdiBuch.FrmZP.DfText1_frmZPInfo, "Text", "Ausgleich OP_BELEG_B_BUCH_003_1");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
