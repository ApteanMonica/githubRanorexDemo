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

namespace Z_Sum_003.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberpruefung_Monatssumme recording.
    /// </summary>
    [TestModule("41b4c957-f568-4ab5-8c10-52eeff600bca", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_Monatssumme : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_Sum_003.Z_SUM_001Repository repository.
        /// </summary>
        public static global::Z_Sum_003.Z_SUM_001Repository repo = global::Z_Sum_003.Z_SUM_001Repository.Instance;

        static Ueberpruefung_Monatssumme instance = new Ueberpruefung_Monatssumme();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_Monatssumme()
        {
            Ist_Zeit_Monatssumme = "156:21";
            Pause_gesamt_Monatssumme = "6:00";
            bew_Zeit_Monatssumme = "147:51";
            Sollzeit_Monatssumme = "160:00";
            Saldo_Monatssumme = "-12:09";
            nicht_bewertet_gesamt_mit_wert = "2:30";
            Summe_nicht_bew_vor_Grenze = "1:00";
            Summe_nicht_bew_nach_Grenze = "";
            Summe_Ueberstunden = "4:00";
            Summe_nicht_bew_nach_max_AZ = "1:30";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_Monatssumme Instance
        {
            get { return instance; }
        }

#region Variables

        string _Ist_Zeit_Monatssumme;

        /// <summary>
        /// Gets or sets the value of variable Ist_Zeit_Monatssumme.
        /// </summary>
        [TestVariable("b88f68ed-0036-4d6c-8438-b4f2858369d2")]
        public string Ist_Zeit_Monatssumme
        {
            get { return _Ist_Zeit_Monatssumme; }
            set { _Ist_Zeit_Monatssumme = value; }
        }

        string _Pause_gesamt_Monatssumme;

        /// <summary>
        /// Gets or sets the value of variable Pause_gesamt_Monatssumme.
        /// </summary>
        [TestVariable("c2901219-3e46-4d3b-9b49-f602bf7ec820")]
        public string Pause_gesamt_Monatssumme
        {
            get { return _Pause_gesamt_Monatssumme; }
            set { _Pause_gesamt_Monatssumme = value; }
        }

        string _bew_Zeit_Monatssumme;

        /// <summary>
        /// Gets or sets the value of variable bew_Zeit_Monatssumme.
        /// </summary>
        [TestVariable("2b9975b8-8200-47f7-96ce-3df123c99065")]
        public string bew_Zeit_Monatssumme
        {
            get { return _bew_Zeit_Monatssumme; }
            set { _bew_Zeit_Monatssumme = value; }
        }

        string _Sollzeit_Monatssumme;

        /// <summary>
        /// Gets or sets the value of variable Sollzeit_Monatssumme.
        /// </summary>
        [TestVariable("2bee9eba-73b4-41d3-b3f0-e278dcb5b85b")]
        public string Sollzeit_Monatssumme
        {
            get { return _Sollzeit_Monatssumme; }
            set { _Sollzeit_Monatssumme = value; }
        }

        string _Saldo_Monatssumme;

        /// <summary>
        /// Gets or sets the value of variable Saldo_Monatssumme.
        /// </summary>
        [TestVariable("06013713-30cc-4962-b0a7-547f76e70a4b")]
        public string Saldo_Monatssumme
        {
            get { return _Saldo_Monatssumme; }
            set { _Saldo_Monatssumme = value; }
        }

        string _nicht_bewertet_gesamt_mit_wert;

        /// <summary>
        /// Gets or sets the value of variable nicht_bewertet_gesamt_mit_wert.
        /// </summary>
        [TestVariable("f994d164-38b3-49c2-89ca-6e379f1329c3")]
        public string nicht_bewertet_gesamt_mit_wert
        {
            get { return _nicht_bewertet_gesamt_mit_wert; }
            set { _nicht_bewertet_gesamt_mit_wert = value; }
        }

        string _Summe_nicht_bew_vor_Grenze;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_vor_Grenze.
        /// </summary>
        [TestVariable("31be893f-c1dc-4515-a9ce-ac1faf454dbc")]
        public string Summe_nicht_bew_vor_Grenze
        {
            get { return _Summe_nicht_bew_vor_Grenze; }
            set { _Summe_nicht_bew_vor_Grenze = value; }
        }

        string _Summe_nicht_bew_nach_Grenze;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_nach_Grenze.
        /// </summary>
        [TestVariable("41dc406c-d094-430e-a66c-2a25bfd80c01")]
        public string Summe_nicht_bew_nach_Grenze
        {
            get { return _Summe_nicht_bew_nach_Grenze; }
            set { _Summe_nicht_bew_nach_Grenze = value; }
        }

        string _Summe_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable Summe_Ueberstunden.
        /// </summary>
        [TestVariable("241fe5f1-1cb6-4c7f-9661-6e4730a7ecc5")]
        public string Summe_Ueberstunden
        {
            get { return _Summe_Ueberstunden; }
            set { _Summe_Ueberstunden = value; }
        }

        string _Summe_nicht_bew_nach_max_AZ;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_nach_max_AZ.
        /// </summary>
        [TestVariable("edadb022-ed73-4ae5-b382-ba076da8ff90")]
        public string Summe_nicht_bew_nach_max_AZ
        {
            get { return _Summe_nicht_bew_nach_max_AZ; }
            set { _Summe_nicht_bew_nach_max_AZ = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='28.02.2022') on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.ColKaldDatumRow52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.ColKaldDatumRow52Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.ColKaldDatumRow52Info, "Text", "28.02.2022");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ist_Zeit_Monatssumme) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol1Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol1Row52Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol1Row52Info, "Text", Ist_Zeit_Monatssumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pause_gesamt_Monatssumme) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol2Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol2Row52Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol2Row52Info, "Text", Pause_gesamt_Monatssumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bew_Zeit_Monatssumme) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol3Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol3Row52Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol3Row52Info, "Text", bew_Zeit_Monatssumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit_Monatssumme) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol4Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol4Row52Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol4Row52Info, "Text", Sollzeit_Monatssumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Saldo_Monatssumme) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol5Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol5Row52Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol5Row52Info, "Text", Saldo_Monatssumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bewertet_gesamt_mit_wert) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol6Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol6Row52Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol6Row52Info, "Text", nicht_bewertet_gesamt_mit_wert);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_vor_Grenze) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol14Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol14Row52Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol14Row52Info, "Text", Summe_nicht_bew_vor_Grenze);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_vor_Grenze) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol15Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol15Row52Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol15Row52Info, "Text", Summe_nicht_bew_vor_Grenze);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_nach_max_AZ) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol16Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol16Row52Info, new RecordItemIndex(9));
            //Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol16Row52Info, "Text", Summe_nicht_bew_nach_max_AZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_Ueberstunden) on item 'FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol10Row52'.", repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol10Row52Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_52_Monatssumme.CellTmpCol10Row52Info, "Text", Summe_Ueberstunden);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
