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

namespace B_BUCH_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_SollWerte_auf_HabenSeite recording.
    /// </summary>
    [TestModule("634c8a9d-d8f9-4a9f-8d68-938ae393b2ad", ModuleType.Recording, 1)]
    public partial class Validation_SollWerte_auf_HabenSeite : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_002.B_BUCH_002Repository repository.
        /// </summary>
        public static global::B_BUCH_002.B_BUCH_002Repository repo = global::B_BUCH_002.B_BUCH_002Repository.Instance;

        static Validation_SollWerte_auf_HabenSeite instance = new Validation_SollWerte_auf_HabenSeite();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_SollWerte_auf_HabenSeite()
        {
            Beleg1 = "B_BUCH_002_A";
            Datum_Beleg = "01.01.2020";
            Jahr = "2020";
            Kunde = "200066";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_SollWerte_auf_HabenSeite Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("c84c4274-d708-426b-9a3d-70dc1dfe6e8f")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
        }

        string _Datum_Beleg;

        /// <summary>
        /// Gets or sets the value of variable Datum_Beleg.
        /// </summary>
        [TestVariable("d8f059fe-65ea-4e90-b2a4-659a962f2a23")]
        public string Datum_Beleg
        {
            get { return _Datum_Beleg; }
            set { _Datum_Beleg = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("5b4f853e-b711-44fa-8aba-8ada5c3bf9a3")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("e7e24479-aad5-444d-9311-410320ca9aac")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfSoll'.", repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfHaben'.", repo.MdiBuch.Toolbar_Kopfbereich.DfHabenInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfHabenInfo, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'MdiBuch.FrmU.Beleg'.", repo.MdiBuch.FrmU.BelegInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.BelegInfo, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Beleg) on item 'MdiBuch.FrmU.Datum'.", repo.MdiBuch.FrmU.DatumInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DatumInfo, "Text", Datum_Beleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'MdiBuch.FrmU.DfUvajahr'.", repo.MdiBuch.FrmU.DfUvajahrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfUvajahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiBuch.FrmU.DfUvamonat'.", repo.MdiBuch.FrmU.DfUvamonatInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfUvamonatInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kunde) on item 'MdiBuch.FrmU.DfAdrNrU'.", repo.MdiBuch.FrmU.DfAdrNrUInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiBuch.FrmU.DfAdrNrUInfo, "Text", Kunde);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='H') on item 'MdiBuch.FrmS.TextSH'.", repo.MdiBuch.FrmS.TextSHInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiBuch.FrmS.TextSHInfo, "Text", "H");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'MdiBuch.tblB.ColArtRow1'.", repo.MdiBuch.tblB.ColArtRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColArtRow1Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2000') on item 'MdiBuch.tblB.ColKtoNrSollRow1'.", repo.MdiBuch.tblB.ColKtoNrSollRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColKtoNrSollRow1Info, "Text", "2000");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.tblB.ColBetragRow1'.", repo.MdiBuch.tblB.ColBetragRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColBetragRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'MdiBuch.tblB.ColSHRow1'.", repo.MdiBuch.tblB.ColSHRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColSHRow1Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'MdiBuch.tblB.ColBruttoRow1'.", repo.MdiBuch.tblB.ColBruttoRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColBruttoRow1Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='K') on item 'MdiBuch.tblB.ColKLRow1'.", repo.MdiBuch.tblB.ColKLRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColKLRow1Info, "Text", "K");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kunde) on item 'MdiBuch.tblB.ColAdrNrRow1'.", repo.MdiBuch.tblB.ColAdrNrRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColAdrNrRow1Info, "Text", Kunde);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AR-Buchungs-Test_1') on item 'MdiBuch.tblB.ColText1Row1'.", repo.MdiBuch.tblB.ColText1Row1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.MdiBuch.tblB.ColText1Row1Info, "Text", "AR-Buchungs-Test_1");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
