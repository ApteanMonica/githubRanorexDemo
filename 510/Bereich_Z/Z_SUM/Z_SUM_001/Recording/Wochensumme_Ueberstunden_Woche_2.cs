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

namespace Z_SUM_001.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Wochensumme_Ueberstunden_Woche_2 recording.
    /// </summary>
    [TestModule("d17fbb82-5bbc-40cc-9aad-40afb5720e6c", ModuleType.Recording, 1)]
    public partial class Wochensumme_Ueberstunden_Woche_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_SUM_001.Z_SUM_001Repository repository.
        /// </summary>
        public static global::Z_SUM_001.Z_SUM_001Repository repo = global::Z_SUM_001.Z_SUM_001Repository.Instance;

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
            Summe_nicht_bew_nach_Grenze = "";
            Summe_nicht_bew_nach_max_AZ = "1:30";
            Summe_Ueberstunden = "4:00";
            nicht_bew_ausserhalb_Grenze_leer = "";
            nicht_bew_ausserhalb_Grenze = "1:00";
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
        [TestVariable("33c2281a-fe57-46c3-a1e7-6ecab01005de")]
        public string Datum_Wochensumme_UEberstundenw
        {
            get { return _Datum_Wochensumme_UEberstundenw; }
            set { _Datum_Wochensumme_UEberstundenw = value; }
        }

        string _Ist_Zeit_Summe_Ueberstundenwoche;

        /// <summary>
        /// Gets or sets the value of variable Ist_Zeit_Summe_Ueberstundenwoche.
        /// </summary>
        [TestVariable("9bc2b7d3-c1e4-4ef1-b0cb-f37a8b149091")]
        public string Ist_Zeit_Summe_Ueberstundenwoche
        {
            get { return _Ist_Zeit_Summe_Ueberstundenwoche; }
            set { _Ist_Zeit_Summe_Ueberstundenwoche = value; }
        }

        string _Pause_WS;

        /// <summary>
        /// Gets or sets the value of variable Pause_WS.
        /// </summary>
        [TestVariable("82de17dd-ce6d-4b72-a7ee-4ffcc52bb159")]
        public string Pause_WS
        {
            get { return _Pause_WS; }
            set { _Pause_WS = value; }
        }

        string _Summe_bew_Zeit_2;

        /// <summary>
        /// Gets or sets the value of variable Summe_bew_Zeit_2.
        /// </summary>
        [TestVariable("5f7862e9-5a7c-4017-916d-95e3e02d5c46")]
        public string Summe_bew_Zeit_2
        {
            get { return _Summe_bew_Zeit_2; }
            set { _Summe_bew_Zeit_2 = value; }
        }

        string _Sollzeit_Wochensumme;

        /// <summary>
        /// Gets or sets the value of variable Sollzeit_Wochensumme.
        /// </summary>
        [TestVariable("12e78de0-4368-4fcf-9f53-aaba891138c2")]
        public string Sollzeit_Wochensumme
        {
            get { return _Sollzeit_Wochensumme; }
            set { _Sollzeit_Wochensumme = value; }
        }

        string _Saldo_Summe_Woche_2;

        /// <summary>
        /// Gets or sets the value of variable Saldo_Summe_Woche_2.
        /// </summary>
        [TestVariable("f4a7ad29-d748-40d5-b0f3-46eb9f6d349a")]
        public string Saldo_Summe_Woche_2
        {
            get { return _Saldo_Summe_Woche_2; }
            set { _Saldo_Summe_Woche_2 = value; }
        }

        string _nicht_bewertet_gesamt_mit_wert;

        /// <summary>
        /// Gets or sets the value of variable nicht_bewertet_gesamt_mit_wert.
        /// </summary>
        [TestVariable("702615f9-0187-4520-b6dc-b0c12a0afdc8")]
        public string nicht_bewertet_gesamt_mit_wert
        {
            get { return _nicht_bewertet_gesamt_mit_wert; }
            set { _nicht_bewertet_gesamt_mit_wert = value; }
        }

        string _Summe_nicht_bew_vor_Grenze;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_vor_Grenze.
        /// </summary>
        [TestVariable("19429f91-1502-42ea-8fad-8818b3317ec8")]
        public string Summe_nicht_bew_vor_Grenze
        {
            get { return _Summe_nicht_bew_vor_Grenze; }
            set { _Summe_nicht_bew_vor_Grenze = value; }
        }

        string _Summe_nicht_bew_nach_Grenze;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_nach_Grenze.
        /// </summary>
        [TestVariable("a1b43ff0-51d9-4425-ae67-e66c106c6c1d")]
        public string Summe_nicht_bew_nach_Grenze
        {
            get { return _Summe_nicht_bew_nach_Grenze; }
            set { _Summe_nicht_bew_nach_Grenze = value; }
        }

        string _Summe_nicht_bew_nach_max_AZ;

        /// <summary>
        /// Gets or sets the value of variable Summe_nicht_bew_nach_max_AZ.
        /// </summary>
        [TestVariable("00f16718-22cb-4d01-95d1-f2e2f11fd92a")]
        public string Summe_nicht_bew_nach_max_AZ
        {
            get { return _Summe_nicht_bew_nach_max_AZ; }
            set { _Summe_nicht_bew_nach_max_AZ = value; }
        }

        string _Summe_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable Summe_Ueberstunden.
        /// </summary>
        [TestVariable("b9d49100-abe1-431d-a598-94115bc6b367")]
        public string Summe_Ueberstunden
        {
            get { return _Summe_Ueberstunden; }
            set { _Summe_Ueberstunden = value; }
        }

        string _nicht_bew_ausserhalb_Grenze_leer;

        /// <summary>
        /// Gets or sets the value of variable nicht_bew_ausserhalb_Grenze_leer.
        /// </summary>
        [TestVariable("8c28d84e-f9c2-4767-9faf-88a95a12ac70")]
        public string nicht_bew_ausserhalb_Grenze_leer
        {
            get { return _nicht_bew_ausserhalb_Grenze_leer; }
            set { _nicht_bew_ausserhalb_Grenze_leer = value; }
        }

        string _nicht_bew_ausserhalb_Grenze;

        /// <summary>
        /// Gets or sets the value of variable nicht_bew_ausserhalb_Grenze.
        /// </summary>
        [TestVariable("362368c3-7f2f-466f-a999-06f300157328")]
        public string nicht_bew_ausserhalb_Grenze
        {
            get { return _nicht_bew_ausserhalb_Grenze; }
            set { _nicht_bew_ausserhalb_Grenze = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Wochensumme_UEberstundenw) on item 'FrmMain.Flexgrid_Tabelle.ColKaldDatumRow24'.", repo.FrmMain.Flexgrid_Tabelle.ColKaldDatumRow24Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.ColKaldDatumRow24Info, "Text", Datum_Wochensumme_UEberstundenw);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ist_Zeit_Summe_Ueberstundenwoche) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol1Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol1Row24Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol1Row24Info, "Text", Ist_Zeit_Summe_Ueberstundenwoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pause_WS) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol2Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol2Row24Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol2Row24Info, "Text", Pause_WS);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_bew_Zeit_2) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol3Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol3Row24Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol3Row24Info, "Text", Summe_bew_Zeit_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit_Wochensumme) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol4Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol4Row24Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol4Row24Info, "Text", Sollzeit_Wochensumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Saldo_Summe_Woche_2) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol5Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol5Row24Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol5Row24Info, "Text", Saldo_Summe_Woche_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bewertet_gesamt_mit_wert) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol6Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol6Row24Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol6Row24Info, "Text", nicht_bewertet_gesamt_mit_wert);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bew_ausserhalb_Grenze) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol14Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol14Row24Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol14Row24Info, "Text", nicht_bew_ausserhalb_Grenze);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol15Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol15Row24Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol15Row24Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_nicht_bew_nach_max_AZ) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol16Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol16Row24Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol16Row24Info, "Text", Summe_nicht_bew_nach_max_AZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Summe_Ueberstunden) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol10Row24'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol10Row24Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol10Row24Info, "Text", Summe_Ueberstunden);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
