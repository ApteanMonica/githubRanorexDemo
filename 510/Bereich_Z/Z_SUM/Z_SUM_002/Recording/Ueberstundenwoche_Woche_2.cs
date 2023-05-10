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
    ///The Ueberstundenwoche_Woche_2 recording.
    /// </summary>
    [TestModule("8ac4afee-eba4-4a09-96d8-3d013bcc9fdd", ModuleType.Recording, 1)]
    public partial class Ueberstundenwoche_Woche_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_SUM_002.Z_SUM_002Repository repository.
        /// </summary>
        public static global::Z_SUM_002.Z_SUM_002Repository repo = global::Z_SUM_002.Z_SUM_002Repository.Instance;

        static Ueberstundenwoche_Woche_2 instance = new Ueberstundenwoche_Woche_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberstundenwoche_Woche_2()
        {
            Datum_Woche_2 = "08.02.2022";
            Zeittyp = "im Hause";
            Beginn_Ueberstunden = "05:00";
            Ende_Ueberstunden = "20:00";
            Ist_Zeit_Ueberstunden = "15:00";
            Pause = "0:30";
            bew_Zeit_Ueberstunden = "12:00";
            Sollzeit = "8:00";
            nicht_bew_gesamt_Ueberstundenwoche = "2:30";
            nicht_bew_ausserhalb_Grenze = "1:00";
            nicht_bew_nach_max_AZ = "1:30";
            Ueberstunde_Ueberstundenwoche = "4:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberstundenwoche_Woche_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_Woche_2;

        /// <summary>
        /// Gets or sets the value of variable Datum_Woche_2.
        /// </summary>
        [TestVariable("107e228c-165c-4ef0-93f4-9a0fb18f5b5b")]
        public string Datum_Woche_2
        {
            get { return _Datum_Woche_2; }
            set { _Datum_Woche_2 = value; }
        }

        string _Zeittyp;

        /// <summary>
        /// Gets or sets the value of variable Zeittyp.
        /// </summary>
        [TestVariable("dd95445d-99c1-4d61-880e-83ee4092d504")]
        public string Zeittyp
        {
            get { return _Zeittyp; }
            set { _Zeittyp = value; }
        }

        string _Beginn_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable Beginn_Ueberstunden.
        /// </summary>
        [TestVariable("55db6bc7-1267-4e44-a667-014ca2d4c048")]
        public string Beginn_Ueberstunden
        {
            get { return _Beginn_Ueberstunden; }
            set { _Beginn_Ueberstunden = value; }
        }

        string _Ende_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable Ende_Ueberstunden.
        /// </summary>
        [TestVariable("5c228bfb-7089-41e3-82c8-d6b33ae4e2ff")]
        public string Ende_Ueberstunden
        {
            get { return _Ende_Ueberstunden; }
            set { _Ende_Ueberstunden = value; }
        }

        string _Ist_Zeit_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable Ist_Zeit_Ueberstunden.
        /// </summary>
        [TestVariable("18cfc75a-d84a-4e42-9fca-c64bae64a282")]
        public string Ist_Zeit_Ueberstunden
        {
            get { return _Ist_Zeit_Ueberstunden; }
            set { _Ist_Zeit_Ueberstunden = value; }
        }

        string _Pause;

        /// <summary>
        /// Gets or sets the value of variable Pause.
        /// </summary>
        [TestVariable("ef808fb0-ff9a-4cc8-8f91-0583cdcae484")]
        public string Pause
        {
            get { return _Pause; }
            set { _Pause = value; }
        }

        string _bew_Zeit_Ueberstunden;

        /// <summary>
        /// Gets or sets the value of variable bew_Zeit_Ueberstunden.
        /// </summary>
        [TestVariable("63a75f85-2ec3-40e9-8b03-6424ccdacb97")]
        public string bew_Zeit_Ueberstunden
        {
            get { return _bew_Zeit_Ueberstunden; }
            set { _bew_Zeit_Ueberstunden = value; }
        }

        string _Sollzeit;

        /// <summary>
        /// Gets or sets the value of variable Sollzeit.
        /// </summary>
        [TestVariable("70ae20e1-a665-4e0b-b9d4-d4f7529580a7")]
        public string Sollzeit
        {
            get { return _Sollzeit; }
            set { _Sollzeit = value; }
        }

        string _nicht_bew_gesamt_Ueberstundenwoche;

        /// <summary>
        /// Gets or sets the value of variable nicht_bew_gesamt_Ueberstundenwoche.
        /// </summary>
        [TestVariable("7ad5356b-524c-4226-9a09-f2abba317d80")]
        public string nicht_bew_gesamt_Ueberstundenwoche
        {
            get { return _nicht_bew_gesamt_Ueberstundenwoche; }
            set { _nicht_bew_gesamt_Ueberstundenwoche = value; }
        }

        string _nicht_bew_ausserhalb_Grenze;

        /// <summary>
        /// Gets or sets the value of variable nicht_bew_ausserhalb_Grenze.
        /// </summary>
        [TestVariable("05a40f84-e97f-4a42-a67b-2b2153b184c8")]
        public string nicht_bew_ausserhalb_Grenze
        {
            get { return _nicht_bew_ausserhalb_Grenze; }
            set { _nicht_bew_ausserhalb_Grenze = value; }
        }

        string _nicht_bew_nach_max_AZ;

        /// <summary>
        /// Gets or sets the value of variable nicht_bew_nach_max_AZ.
        /// </summary>
        [TestVariable("f2878878-556b-482a-861b-dd12d45cdd0b")]
        public string nicht_bew_nach_max_AZ
        {
            get { return _nicht_bew_nach_max_AZ; }
            set { _nicht_bew_nach_max_AZ = value; }
        }

        string _Ueberstunde_Ueberstundenwoche;

        /// <summary>
        /// Gets or sets the value of variable Ueberstunde_Ueberstundenwoche.
        /// </summary>
        [TestVariable("2d554cec-c18b-479e-8b78-3053ad5a4184")]
        public string Ueberstunde_Ueberstundenwoche
        {
            get { return _Ueberstunde_Ueberstundenwoche; }
            set { _Ueberstunde_Ueberstundenwoche = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Woche_2) on item 'FrmMain.ColKaldDatumRow14'.", repo.FrmMain.ColKaldDatumRow14Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.ColKaldDatumRow14Info, "Text", Datum_Woche_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zeittyp) on item 'FrmMain.CellTmpCol13Row14'.", repo.FrmMain.CellTmpCol13Row14Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol13Row14Info, "Text", Zeittyp);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beginn_Ueberstunden) on item 'FrmMain.CellTmpCol7Row14'.", repo.FrmMain.CellTmpCol7Row14Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol7Row14Info, "Text", Beginn_Ueberstunden);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ende_Ueberstunden) on item 'FrmMain.CellTmpCol8Row14'.", repo.FrmMain.CellTmpCol8Row14Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol8Row14Info, "Text", Ende_Ueberstunden);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ist_Zeit_Ueberstunden) on item 'FrmMain.CellTmpCol1Row14'.", repo.FrmMain.CellTmpCol1Row14Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol1Row14Info, "Text", Ist_Zeit_Ueberstunden);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pause) on item 'FrmMain.CellTmpCol2Row14'.", repo.FrmMain.CellTmpCol2Row14Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol2Row14Info, "Text", Pause);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bew_Zeit_Ueberstunden) on item 'FrmMain.CellTmpCol3Row14'.", repo.FrmMain.CellTmpCol3Row14Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol3Row14Info, "Text", bew_Zeit_Ueberstunden);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit) on item 'FrmMain.CellTmpCol4Row14'.", repo.FrmMain.CellTmpCol4Row14Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol4Row14Info, "Text", Sollzeit);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4:00') on item 'FrmMain.CellTmpCol5Row14'.", repo.FrmMain.CellTmpCol5Row14Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol5Row14Info, "Text", "4:00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bew_gesamt_Ueberstundenwoche) on item 'FrmMain.CellTmpCol6Row14'.", repo.FrmMain.CellTmpCol6Row14Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol6Row14Info, "Text", nicht_bew_gesamt_Ueberstundenwoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bew_ausserhalb_Grenze) on item 'FrmMain.CellTmpCol14Row14'.", repo.FrmMain.CellTmpCol14Row14Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol14Row14Info, "Text", nicht_bew_ausserhalb_Grenze);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bew_ausserhalb_Grenze) on item 'FrmMain.CellTmpCol15Row14'.", repo.FrmMain.CellTmpCol15Row14Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol15Row14Info, "Text", nicht_bew_ausserhalb_Grenze);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$nicht_bew_nach_max_AZ) on item 'FrmMain.CellTmpCol16Row14'.", repo.FrmMain.CellTmpCol16Row14Info, new RecordItemIndex(12));
            //Validate.AttributeEqual(repo.FrmMain.CellTmpCol16Row14Info, "Text", nicht_bew_nach_max_AZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ueberstunde_Ueberstundenwoche) on item 'FrmMain.CellTmpCol10Row14'.", repo.FrmMain.CellTmpCol10Row14Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol10Row14Info, "Text", Ueberstunde_Ueberstundenwoche);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
