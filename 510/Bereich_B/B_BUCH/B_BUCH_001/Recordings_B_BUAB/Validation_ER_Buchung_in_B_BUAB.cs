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

namespace B_BUCH_001.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_ER_Buchung_in_B_BUAB recording.
    /// </summary>
    [TestModule("b49cdb4c-90f6-4113-a0ea-fd6f0818f92d", ModuleType.Recording, 1)]
    public partial class Validation_ER_Buchung_in_B_BUAB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_001.B_BUCH_001Repository repository.
        /// </summary>
        public static global::B_BUCH_001.B_BUCH_001Repository repo = global::B_BUCH_001.B_BUCH_001Repository.Instance;

        static Validation_ER_Buchung_in_B_BUAB instance = new Validation_ER_Buchung_in_B_BUAB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_ER_Buchung_in_B_BUAB()
        {
            Buchungstext = "ER-Buchungs-Test_1";
            Beleg_Nr = "B_BUCH_001_1";
            Datum_Beleg = "05.01.2020";
            Lieferant = "300011";
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_ER_Buchung_in_B_BUAB Instance
        {
            get { return instance; }
        }

#region Variables

        string _Buchungstext;

        /// <summary>
        /// Gets or sets the value of variable Buchungstext.
        /// </summary>
        [TestVariable("7b4e1f84-bc5d-42d7-b8d8-68ca46944ca2")]
        public string Buchungstext
        {
            get { return _Buchungstext; }
            set { _Buchungstext = value; }
        }

        string _Beleg_Nr;

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("565612f0-36b3-4673-9856-ee76ea944275")]
        public string Beleg_Nr
        {
            get { return _Beleg_Nr; }
            set { _Beleg_Nr = value; }
        }

        string _Datum_Beleg;

        /// <summary>
        /// Gets or sets the value of variable Datum_Beleg.
        /// </summary>
        [TestVariable("a43cdf56-d4dd-42ab-9c09-3b4f643c99b1")]
        public string Datum_Beleg
        {
            get { return _Datum_Beleg; }
            set { _Datum_Beleg = value; }
        }

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("e683663b-d619-466a-9c12-024c00b185f9")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("55a6d985-1b92-4078-8d18-ff4f5d05cdce")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'TblB_b_buab.FlexGrid_b_buab.ColDtAendgRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColDtAendgRow1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblB_b_buab.FlexGrid_b_buab.ColDtAendgRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Nr) on item 'TblB_b_buab.FlexGrid_b_buab.ColBelegnrRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColBelegnrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColBelegnrRow1Info, "Text", Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Buchungstext) on item 'TblB_b_buab.FlexGrid_b_buab.ColText1Row1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColText1Row1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColText1Row1Info, "Text", Buchungstext);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Beleg) on item 'TblB_b_buab.FlexGrid_b_buab.ColDatumRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColDatumRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColDatumRow1Info, "Text", Datum_Beleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='01.2020') on item 'TblB_b_buab.FlexGrid_b_buab.ColJahrPeriRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColJahrPeriRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColJahrPeriRow1Info, "Text", "01.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3300') on item 'TblB_b_buab.FlexGrid_b_buab.ColKtoNrRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColKtoNrRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColKtoNrRow1Info, "Text", "3300");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER') on item 'TblB_b_buab.FlexGrid_b_buab.ColBusyRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColBusyRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColBusyRow1Info, "Text", "ER");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'TblB_b_buab.FlexGrid_b_buab.ColArtRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColArtRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColArtRow1Info, "Text", "R");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='*') on item 'TblB_b_buab.FlexGrid_b_buab.ColGKtoNrRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColGKtoNrRow1Info, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColGKtoNrRow1Info, "Text", "*", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'TblB_b_buab.FlexGrid_b_buab.ColAdrNrRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColAdrNrRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColAdrNrRow1Info, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'TblB_b_buab.FlexGrid_b_buab.ColBetragRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColBetragRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColBetragRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='H') on item 'TblB_b_buab.FlexGrid_b_buab.ColSHRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColSHRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColSHRow1Info, "Text", "H");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'TblB_b_buab.FlexGrid_b_buab.ColBruttoRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColBruttoRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColBruttoRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2020-1') on item 'TblB_b_buab.FlexGrid_b_buab.ColUvaRow1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColUvaRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColUvaRow1Info, "Text", "2020-1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'TblB_b_buab.FlexGrid_b_buab.ColCd1Row1'.", repo.TblB_b_buab.FlexGrid_b_buab.ColCd1Row1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColCd1Row1Info, "Text", "20");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}