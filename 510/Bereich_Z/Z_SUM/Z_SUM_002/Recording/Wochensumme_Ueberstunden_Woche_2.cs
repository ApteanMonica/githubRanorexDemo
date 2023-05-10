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

namespace Z_SUM_002.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Wochensumme_Ueberstunden_Woche_2 recording.
    /// </summary>
    [TestModule("a1eeaef4-17cb-4663-a6ee-9daa02aa3536", ModuleType.Recording, 1)]
    public partial class Wochensumme_Ueberstunden_Woche_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_SUM_002.Z_SUM_002Repository repository.
        /// </summary>
        public static global::Z_SUM_002.Z_SUM_002Repository repo = global::Z_SUM_002.Z_SUM_002Repository.Instance;

        static Wochensumme_Ueberstunden_Woche_2 instance = new Wochensumme_Ueberstunden_Woche_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Wochensumme_Ueberstunden_Woche_2()
        {
            Datum_Wochensumme_UEberstundenw = "13.02.2022";
            Ist_Zeit_Summe_Ueberstundenwoche = "49:00";
            Pause_WS = "2:30";
            Summe_bew_Zeit_2 = "44:00";
            Sollzeit_Wochensumme = "40:00";
            Saldo_Summe_Woche_2 = "4:00";
            nicht_bewertet_gesamt_mit_wert = "2:30";
            Summe_nicht_bew_vor_Grenze = "1:00";
            Summe_nicht_bew_nach_max_AZ = "1:30";
            Summe_Ueberstunden = "4:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Wochensumme_Ueberstunden_Woche_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_Wochensumme_UEberstundenw;

        /// <summary>
        /// Gets or sets the value of variable Datum_Wochensumme_UEberstundenw.
        /// </summary>
        [TestVariable("308d3fd3-8cfd-4091-b5f0-d2e8921b416e")]
        public string Datum_Wochensumme_UEberstundenw
        {
            get { return _Datum_Wochensumme_UEberstundenw; }
            set { _Datum_Wochensumme_UEberstundenw = value; }
        }

        string _Ist_Zeit_Summe_Ueberstundenwoche;

        /// <summary>
        /// Gets or sets the value of variable Ist_Zeit_Summe_Ueberstundenwoche.
        /// </summary>
        [TestVariable("1dd6062c-8dd1-49ed-ac0c-01dd6925134c")]
        public string Ist_Zeit_Summe_Ueberstundenwoche
        {
            get { return _Ist_Zeit_Summe_Ueberstundenwoche; }
            set { _Ist_Zeit_Summe_Ueberstundenwoche = value; }
        }

        string _Pause_WS;

        /// <summary>
        /// Gets or sets the value of variable Pause_WS.
        /// </summary>
        [TestVariable("9a5b7202-fe9a-4122-9a48-261bfe0a6f6f")]
        public string Pause_WS
        {
            get { return _Pause_WS; }
            set { _Pause_WS = value; }
        }

        string _Summe_bew_Zeit_2;

        /// <summary>
        /// Gets or sets the value of variable Summe_bew_Zeit_2.
        /// </summary>
        [TestVariable("0dd48333-d78b-4c7d-b16a-df8d9648cf42")]
        public string Summe_bew_Zeit_2
        {
            get { return _Summe_bew_Zeit_2; }
            set { _Summe_bew_Zeit_2 = value; }
        }

        string _Sollzeit_Wochensumme;

        /// <summary>
        /// Gets or sets the value of variable Sollzeit_Wochensumme.
        /// </summary>
        [TestVariable("c43c3ea1-70b0-48e9-a4ff-6e42a899aae4")]
        public string Sollzeit_Wochensumme
        {
            get { return _Sollzeit_Wochensumme; }
            set { _Sollzeit_Wochensumme = value; }
        }

        string _Saldo_Summe_Woche_2;

        /// <summary>
        /// Gets or sets the value of variable Saldo_Summe_Woche_2.
        /// </summary>
        [TestVariable("64c977e5-7de4-40cc-9e21-9e5aa9642fa7")]
        public string Saldo_Summe_Woche_2
        {
            get { return _Saldo_Summe_Woche_2; }
            set { _Saldo_Summe_Woche_2 = value; }
        }

        string _nicht_bewertet_gesamt_mit_wert;

        /// <summary>
        /// Gets or sets the value of variable nicht_bewertet_gesamt_mit_wert.
        /// </summary>
        [TestVariable("cc230f01-fe5b-4944-9cbe-c4ab291518f2")]
        public string nicht_bewertet_gesamt_mit_wert
        {
            get { return _nicht_bewertet_gesamt_mit_wert; }
            set { _nicht_bewertet_gesamt_mit_wert = value; }
        }

        string _Summe_nicht_bew_vor_Grenze;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_vor_Grenze.
        /// </summary>
        [TestVariable("97b8cadf-4c94-4aaa-95e2-26b63dbe31ae")]
        public string Summe_nicht_bew_vor_Grenze
        {
            get { return _Summe_nicht_bew_vor_Grenze; }
            set { _Summe_nicht_bew_vor_Grenze = value; }
        }

        string _Summe_nicht_bew_nach_max_AZ;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_nach_max_AZ.
        /// </summary>
        [TestVariable("20ed1e98-193a-4289-b83e-9924e9eb75a2")]
        public string Summe_nicht_bew_nach_max_AZ
        {
            get { return _Summe_nicht_bew_nach_max_AZ; }
            set { _Summe_nicht_bew_nach_max_AZ = value; }
        }

        string _Summe_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable Summe_Ueberstunden.
        /// </summary>
        [TestVariable("c459ce4e-7297-4a9e-b1a8-3c300935de7c")]
        public string Summe_Ueberstunden
        {
            get { return _Summe_Ueberstunden; }
            set { _Summe_Ueberstunden = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Wochensumme_UEberstundenw) on item 'FrmMain.ColKaldDatumRow24'.", repo.FrmMain.ColKaldDatumRow24Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.ColKaldDatumRow24Info, "Text", Datum_Wochensumme_UEberstundenw);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ist_Zeit_Summe_Ueberstundenwoche) on item 'FrmMain.CellTmpCol1Row24'.", repo.FrmMain.CellTmpCol1Row24Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol1Row24Info, "Text", Ist_Zeit_Summe_Ueberstundenwoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pause_WS) on item 'FrmMain.CellTmpCol2Row24'.", repo.FrmMain.CellTmpCol2Row24Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol2Row24Info, "Text", Pause_WS);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_bew_Zeit_2) on item 'FrmMain.CellTmpCol3Row24'.", repo.FrmMain.CellTmpCol3Row24Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol3Row24Info, "Text", Summe_bew_Zeit_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit_Wochensumme) on item 'FrmMain.CellTmpCol4Row24'.", repo.FrmMain.CellTmpCol4Row24Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol4Row24Info, "Text", Sollzeit_Wochensumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Saldo_Summe_Woche_2) on item 'FrmMain.CellTmpCol5Row24'.", repo.FrmMain.CellTmpCol5Row24Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol5Row24Info, "Text", Saldo_Summe_Woche_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bewertet_gesamt_mit_wert) on item 'FrmMain.CellTmpCol6Row24'.", repo.FrmMain.CellTmpCol6Row24Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol6Row24Info, "Text", nicht_bewertet_gesamt_mit_wert);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_vor_Grenze) on item 'FrmMain.CellTmpCol14Row24'.", repo.FrmMain.CellTmpCol14Row24Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol14Row24Info, "Text", Summe_nicht_bew_vor_Grenze);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_vor_Grenze) on item 'FrmMain.CellTmpCol15Row24'.", repo.FrmMain.CellTmpCol15Row24Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol15Row24Info, "Text", Summe_nicht_bew_vor_Grenze);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_nach_max_AZ) on item 'FrmMain.CellTmpCol16Row24'.", repo.FrmMain.CellTmpCol16Row24Info, new RecordItemIndex(9));
            //Validate.AttributeEqual(repo.FrmMain.CellTmpCol16Row24Info, "Text", Summe_nicht_bew_nach_max_AZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_Ueberstunden) on item 'FrmMain.CellTmpCol10Row24'.", repo.FrmMain.CellTmpCol10Row24Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol10Row24Info, "Text", Summe_Ueberstunden);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
