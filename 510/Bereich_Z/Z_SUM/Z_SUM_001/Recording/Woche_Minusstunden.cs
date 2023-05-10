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
    ///The Woche_Minusstunden recording.
    /// </summary>
    [TestModule("ac8929a2-eb49-46f0-99b7-ccc073b53217", ModuleType.Recording, 1)]
    public partial class Woche_Minusstunden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_SUM_001.Z_SUM_001Repository repository.
        /// </summary>
        public static global::Z_SUM_001.Z_SUM_001Repository repo = global::Z_SUM_001.Z_SUM_001Repository.Instance;

        static Woche_Minusstunden instance = new Woche_Minusstunden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Woche_Minusstunden()
        {
            Zeittyp = "im Hause";
            Beginn_Minuswoche = "08:16";
            Ende_Minuswoche = "16:37";
            Ist_Zeit_Minuswoche = "8:21";
            Pause = "0:30";
            bew_Zeit_Minuswoche = "7:51";
            Sollzeit = "8:00";
            Saldo_1_Minuswoche = "-0:09";
            Zeittyp_leer = "";
            bew_Zeit_Minuswoche_2 = "";
            Saldo_2_Minuswoche = "-8:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Woche_Minusstunden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Zeittyp;

        /// <summary>
        /// Gets or sets the value of variable Zeittyp.
        /// </summary>
        [TestVariable("98927c0b-067a-477d-9d37-78f5c8d9b5b5")]
        public string Zeittyp
        {
            get { return _Zeittyp; }
            set { _Zeittyp = value; }
        }

        string _Beginn_Minuswoche;

        /// <summary>
        /// Gets or sets the value of variable Beginn_Minuswoche.
        /// </summary>
        [TestVariable("35ce0b78-c452-49d7-a852-3667f80f198b")]
        public string Beginn_Minuswoche
        {
            get { return _Beginn_Minuswoche; }
            set { _Beginn_Minuswoche = value; }
        }

        string _Ende_Minuswoche;

        /// <summary>
        /// Gets or sets the value of variable Ende_Minuswoche.
        /// </summary>
        [TestVariable("69a6f298-35f7-490f-9393-27662ebc1ebc")]
        public string Ende_Minuswoche
        {
            get { return _Ende_Minuswoche; }
            set { _Ende_Minuswoche = value; }
        }

        string _Ist_Zeit_Minuswoche;

        /// <summary>
        /// Gets or sets the value of variable Ist_Zeit_Minuswoche.
        /// </summary>
        [TestVariable("1fb0a61b-d368-4220-b01a-365d9981a672")]
        public string Ist_Zeit_Minuswoche
        {
            get { return _Ist_Zeit_Minuswoche; }
            set { _Ist_Zeit_Minuswoche = value; }
        }

        string _Pause;

        /// <summary>
        /// Gets or sets the value of variable Pause.
        /// </summary>
        [TestVariable("2e2258d6-2a19-46eb-83c4-8cffdb34cac8")]
        public string Pause
        {
            get { return _Pause; }
            set { _Pause = value; }
        }

        string _bew_Zeit_Minuswoche;

        /// <summary>
        /// Gets or sets the value of variable bew_Zeit_Minuswoche.
        /// </summary>
        [TestVariable("e51b78dd-0685-4272-98f3-f7d393160f1b")]
        public string bew_Zeit_Minuswoche
        {
            get { return _bew_Zeit_Minuswoche; }
            set { _bew_Zeit_Minuswoche = value; }
        }

        string _Sollzeit;

        /// <summary>
        /// Gets or sets the value of variable Sollzeit.
        /// </summary>
        [TestVariable("85b63f94-4348-40f6-a6d5-d572621a6f66")]
        public string Sollzeit
        {
            get { return _Sollzeit; }
            set { _Sollzeit = value; }
        }

        string _Saldo_1_Minuswoche;

        /// <summary>
        /// Gets or sets the value of variable Saldo_1_Minuswoche.
        /// </summary>
        [TestVariable("0a697fef-8d7e-4922-b780-7804ed2e5182")]
        public string Saldo_1_Minuswoche
        {
            get { return _Saldo_1_Minuswoche; }
            set { _Saldo_1_Minuswoche = value; }
        }

        string _Zeittyp_leer;

        /// <summary>
        /// Gets or sets the value of variable Zeittyp_leer.
        /// </summary>
        [TestVariable("d8948f11-1a19-4579-b353-7850b4c19c85")]
        public string Zeittyp_leer
        {
            get { return _Zeittyp_leer; }
            set { _Zeittyp_leer = value; }
        }

        string _bew_Zeit_Minuswoche_2;

        /// <summary>
        /// Gets or sets the value of variable bew_Zeit_Minuswoche_2.
        /// </summary>
        [TestVariable("cb6cfdc7-fcbd-4f17-98dc-10976c5fa7f3")]
        public string bew_Zeit_Minuswoche_2
        {
            get { return _bew_Zeit_Minuswoche_2; }
            set { _bew_Zeit_Minuswoche_2 = value; }
        }

        string _Saldo_2_Minuswoche;

        /// <summary>
        /// Gets or sets the value of variable Saldo_2_Minuswoche.
        /// </summary>
        [TestVariable("7228be12-1eca-45cd-8c21-ccc0ebd17cac")]
        public string Saldo_2_Minuswoche
        {
            get { return _Saldo_2_Minuswoche; }
            set { _Saldo_2_Minuswoche = value; }
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

            // Mi
            Report.Log(ReportLevel.Info, "Section", "Mi", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='23.02.2022') on item 'FrmMain.Flexgrid_Tabelle.Row_42.ColKaldDatumRow42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.ColKaldDatumRow42Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.ColKaldDatumRow42Info, "Text", "23.02.2022");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zeittyp) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol13Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol13Row42Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol13Row42Info, "Text", Zeittyp);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beginn_Minuswoche) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol7Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol7Row42Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol7Row42Info, "Text", Beginn_Minuswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ende_Minuswoche) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol8Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol8Row42Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol8Row42Info, "Text", Ende_Minuswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ist_Zeit_Minuswoche) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol1Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol1Row42Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol1Row42Info, "Text", Ist_Zeit_Minuswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pause) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol2Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol2Row42Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol2Row42Info, "Text", Pause);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bew_Zeit_Minuswoche) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol3Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol3Row42Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol3Row42Info, "Text", bew_Zeit_Minuswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol4Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol4Row42Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol4Row42Info, "Text", Sollzeit);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Saldo_1_Minuswoche) on item 'FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol5Row42'.", repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol5Row42Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.Row_42.CellTmpCol5Row42Info, "Text", Saldo_1_Minuswoche);
            
            // Do
            Report.Log(ReportLevel.Info, "Section", "Do", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='24.02.2022') on item 'FrmMain.Flexgrid_Tabelle.ColKaldDatumRow44'.", repo.FrmMain.Flexgrid_Tabelle.ColKaldDatumRow44Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.ColKaldDatumRow44Info, "Text", "24.02.2022");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zeittyp_leer) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol13Row44'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol13Row44Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol13Row44Info, "Text", Zeittyp_leer);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bew_Zeit_Minuswoche_2) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol3Row44'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol3Row44Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol3Row44Info, "Text", bew_Zeit_Minuswoche_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol4Row44'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol4Row44Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol4Row44Info, "Text", Sollzeit);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Saldo_2_Minuswoche) on item 'FrmMain.Flexgrid_Tabelle.CellTmpCol5Row44'.", repo.FrmMain.Flexgrid_Tabelle.CellTmpCol5Row44Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmMain.Flexgrid_Tabelle.CellTmpCol5Row44Info, "Text", Saldo_2_Minuswoche);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
