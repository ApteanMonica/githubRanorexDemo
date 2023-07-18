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

namespace B_EXOPV_004.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Statuskontrolle_nach_Pruefung recording.
    /// </summary>
    [TestModule("9af6b51e-9e68-4d86-9815-b395918539b3", ModuleType.Recording, 1)]
    public partial class Statuskontrolle_nach_Pruefung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Statuskontrolle_nach_Pruefung instance = new Statuskontrolle_nach_Pruefung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Statuskontrolle_nach_Pruefung()
        {
            Beleg2 = "ER_02_B_EXOPV_004";
            Beleg4 = "ER_04_B_EXOPV_004";
            Beleg5 = "ER_05_B_EXOPV_004";
            Jahr = "2018";
            Beleg1 = "ER_01_B_EXOPV_004";
            Beleg3 = "ER_03_B_EXOPV_004";
            Beleg6 = "ER_06_B_EXOPV_004";
            Periode_6_offen = "6";
            Periode_5_geschlossen = "5";
            Periode_7_geschlossen = "7";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Statuskontrolle_nach_Pruefung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg2;

        /// <summary>
        /// Gets or sets the value of variable Beleg2.
        /// </summary>
        [TestVariable("514e98df-d64e-4fb5-a098-05a618770241")]
        public string Beleg2
        {
            get { return _Beleg2; }
            set { _Beleg2 = value; }
        }

        string _Beleg4;

        /// <summary>
        /// Gets or sets the value of variable Beleg4.
        /// </summary>
        [TestVariable("c70a9809-2dd7-4790-9667-18e9251c7c70")]
        public string Beleg4
        {
            get { return _Beleg4; }
            set { _Beleg4 = value; }
        }

        string _Beleg5;

        /// <summary>
        /// Gets or sets the value of variable Beleg5.
        /// </summary>
        [TestVariable("d8543d49-9498-461c-a73b-fbb2955c45b9")]
        public string Beleg5
        {
            get { return _Beleg5; }
            set { _Beleg5 = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("493dfc45-e85b-42c0-89d0-867ba1550878")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("aa8de622-a144-4f67-a2ea-100e36965e2e")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
        }

        string _Beleg3;

        /// <summary>
        /// Gets or sets the value of variable Beleg3.
        /// </summary>
        [TestVariable("49acf57b-9bec-4f67-9640-2c454605349e")]
        public string Beleg3
        {
            get { return _Beleg3; }
            set { _Beleg3 = value; }
        }

        string _Beleg6;

        /// <summary>
        /// Gets or sets the value of variable Beleg6.
        /// </summary>
        [TestVariable("00212ea1-967b-4d0b-bcc4-f49e3f07ccb7")]
        public string Beleg6
        {
            get { return _Beleg6; }
            set { _Beleg6 = value; }
        }

        string _Periode_6_offen;

        /// <summary>
        /// Gets or sets the value of variable Periode_6_offen.
        /// </summary>
        [TestVariable("bc33c291-1bb0-44a7-ae73-0a376a8f181a")]
        public string Periode_6_offen
        {
            get { return _Periode_6_offen; }
            set { _Periode_6_offen = value; }
        }

        string _Periode_5_geschlossen;

        /// <summary>
        /// Gets or sets the value of variable Periode_5_geschlossen.
        /// </summary>
        [TestVariable("7438727d-f23f-4eb0-bb0c-5442e8d1c7bd")]
        public string Periode_5_geschlossen
        {
            get { return _Periode_5_geschlossen; }
            set { _Periode_5_geschlossen = value; }
        }

        string _Periode_7_geschlossen;

        /// <summary>
        /// Gets or sets the value of variable Periode_7_geschlossen.
        /// </summary>
        [TestVariable("861f239e-ac89-406b-9443-0381c37f5194")]
        public string Periode_7_geschlossen
        {
            get { return _Periode_7_geschlossen; }
            set { _Periode_7_geschlossen = value; }
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

            // Zeile_1
            Report.Log(ReportLevel.Info, "Section", "Zeile_1", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopBelegnrRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopBelegnrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopBelegnrRow1Info, "Text", Beleg1);
            
            // Zeile_2
            Report.Log(ReportLevel.Info, "Section", "Zeile_2", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg2) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopBelegnrRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopBelegnrRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopBelegnrRow2Info, "Text", Beleg2);
            
            // Zeile_3
            Report.Log(ReportLevel.Info, "Section", "Zeile_3", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg3) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopBelegnrRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopBelegnrRow3Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopBelegnrRow3Info, "Text", Beleg3);
            
            // Zeile_4
            Report.Log(ReportLevel.Info, "Section", "Zeile_4", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg4) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopBelegnrRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopBelegnrRow4Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopBelegnrRow4Info, "Text", Beleg4);
            
            // Zeile_5
            Report.Log(ReportLevel.Info, "Section", "Zeile_5", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg5) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopBelegnrRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopBelegnrRow5Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopBelegnrRow5Info, "Text", Beleg5);
            
            // Zeile_6
            Report.Log(ReportLevel.Info, "Section", "Zeile_6", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg6) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopBelegnrRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopBelegnrRow6Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopBelegnrRow6Info, "Text", Beleg6);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
