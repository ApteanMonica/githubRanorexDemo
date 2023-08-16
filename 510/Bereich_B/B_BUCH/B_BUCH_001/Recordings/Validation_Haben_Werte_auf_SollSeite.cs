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

namespace B_BUCH_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_Haben_Werte_auf_SollSeite recording.
    /// </summary>
    [TestModule("74c85a44-4312-4dc7-8704-0b7f59ad2f4c", ModuleType.Recording, 1)]
    public partial class Validation_Haben_Werte_auf_SollSeite : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_001.B_BUCH_001Repository repository.
        /// </summary>
        public static global::B_BUCH_001.B_BUCH_001Repository repo = global::B_BUCH_001.B_BUCH_001Repository.Instance;

        static Validation_Haben_Werte_auf_SollSeite instance = new Validation_Haben_Werte_auf_SollSeite();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_Haben_Werte_auf_SollSeite()
        {
            Lieferant = "300011";
            Jahr = "2020";
            Buchungstext = "ER-Buchungs-Test_1";
            Beleg_Nr = "B_BUCH_001_1";
            Datum_Beleg = "05.01.2020";
            Datum_Fremdbeleg = "01.01.2020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_Haben_Werte_auf_SollSeite Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("6c959227-ac5c-485b-bf2f-72809cc35a22")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("b3f4d68e-4f44-46e9-b463-012b9537e365")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Buchungstext;

        /// <summary>
        /// Gets or sets the value of variable Buchungstext.
        /// </summary>
        [TestVariable("93a8c2ff-958c-415a-b4e7-e15e4c1cf1e1")]
        public string Buchungstext
        {
            get { return _Buchungstext; }
            set { _Buchungstext = value; }
        }

        string _Beleg_Nr;

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("08cce8ba-01f4-4d2b-955d-0d525c0acae5")]
        public string Beleg_Nr
        {
            get { return _Beleg_Nr; }
            set { _Beleg_Nr = value; }
        }

        string _Datum_Beleg;

        /// <summary>
        /// Gets or sets the value of variable Datum_Beleg.
        /// </summary>
        [TestVariable("63a7abe6-0c8e-4e6f-9e32-316bdf012e46")]
        public string Datum_Beleg
        {
            get { return _Datum_Beleg; }
            set { _Datum_Beleg = value; }
        }

        string _Datum_Fremdbeleg;

        /// <summary>
        /// Gets or sets the value of variable Datum_Fremdbeleg.
        /// </summary>
        [TestVariable("ca27ae13-7e12-4b89-8dc7-ad7cfcf7db8b")]
        public string Datum_Fremdbeleg
        {
            get { return _Datum_Fremdbeleg; }
            set { _Datum_Fremdbeleg = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfSoll'.", repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfHaben'.", repo.MdiBuch.Toolbar_Kopfbereich.DfHabenInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfHabenInfo, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Nr) on item 'MdiBuch.FrmU.DfBelegnr'.", repo.MdiBuch.FrmU.DfBelegnrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfBelegnrInfo, "Text", Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (WindowText=$Datum_Beleg) on item 'MdiBuch.FrmU.DfDtbeleg'.", repo.MdiBuch.FrmU.DfDtbelegInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfDtbelegInfo, "WindowText", Datum_Beleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (WindowText=$Datum_Fremdbeleg) on item 'MdiBuch.FrmU.DfDtfremdbeleg'.", repo.MdiBuch.FrmU.DfDtfremdbelegInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfDtfremdbelegInfo, "WindowText", Datum_Fremdbeleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'MdiBuch.FrmU.DfUvajahr'.", repo.MdiBuch.FrmU.DfUvajahrInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfUvajahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiBuch.FrmU.DfUvamonat'.", repo.MdiBuch.FrmU.DfUvamonatInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfUvamonatInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'MdiBuch.FrmU.DfAdrNrU'.", repo.MdiBuch.FrmU.DfAdrNrUInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfAdrNrUInfo, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'MdiBuch.tblB.ColArtRow1'.", repo.MdiBuch.tblB.ColArtRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColArtRow1Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3300') on item 'MdiBuch.tblB.ColKtoNrHabenRow1'.", repo.MdiBuch.tblB.ColKtoNrHabenRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColKtoNrHabenRow1Info, "Text", "3300");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.tblB.ColBetragRow1'.", repo.MdiBuch.tblB.ColBetragRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColBetragRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='H') on item 'MdiBuch.tblB.ColSHRow1'.", repo.MdiBuch.tblB.ColSHRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColSHRow1Info, "Text", "H");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.tblB.ColBruttoRow1'.", repo.MdiBuch.tblB.ColBruttoRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColBruttoRow1Info, "Text", "100,00");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='9.266,00') on item 'MdiBuch.tblB.ColKtoSaldoRow1'.", repo.MdiBuch.tblB.ColKtoSaldoRow1Info, new RecordItemIndex(13));
                Validate.AttributeEqual(repo.MdiBuch.tblB.ColKtoSaldoRow1Info, "Text", "9.266,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='L') on item 'MdiBuch.tblB.ColKLRow1'.", repo.MdiBuch.tblB.ColKLRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColKLRow1Info, "Text", "L");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'MdiBuch.tblB.ColAdrNrRow1'.", repo.MdiBuch.tblB.ColAdrNrRow1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColAdrNrRow1Info, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Buchungstext) on item 'MdiBuch.tblB.ColText1Row1'.", repo.MdiBuch.tblB.ColText1Row1Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColText1Row1Info, "Text", Buchungstext);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
