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
    ///The Urlaubswoche recording.
    /// </summary>
    [TestModule("c1683b66-f5c3-411a-bb59-3724cb55f148", ModuleType.Recording, 1)]
    public partial class Urlaubswoche : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_SUM_002.Z_SUM_002Repository repository.
        /// </summary>
        public static global::Z_SUM_002.Z_SUM_002Repository repo = global::Z_SUM_002.Z_SUM_002Repository.Instance;

        static Urlaubswoche instance = new Urlaubswoche();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Urlaubswoche()
        {
            Datum_Urlaubswoche = "14.02.2022";
            Zeittyp_Urlaub = "Urlaub";
            Beginn_Urlaubswoche = "08:00";
            Ende_Urlaubswoche = "16:00";
            Ist_Zeit_Urlaubswoche = "8:00";
            bew_Zeit_Urlaubswoche = "8:00";
            Sollzeit = "8:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Urlaubswoche Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_Urlaubswoche;

        /// <summary>
        /// Gets or sets the value of variable Datum_Urlaubswoche.
        /// </summary>
        [TestVariable("1a2d1e9c-a56b-4431-aff5-7d8aabd72a3e")]
        public string Datum_Urlaubswoche
        {
            get { return _Datum_Urlaubswoche; }
            set { _Datum_Urlaubswoche = value; }
        }

        string _Zeittyp_Urlaub;

        /// <summary>
        /// Gets or sets the value of variable Zeittyp_Urlaub.
        /// </summary>
        [TestVariable("776da06c-76bd-4cd3-aa21-01ddb6183edf")]
        public string Zeittyp_Urlaub
        {
            get { return _Zeittyp_Urlaub; }
            set { _Zeittyp_Urlaub = value; }
        }

        string _Beginn_Urlaubswoche;

        /// <summary>
        /// Gets or sets the value of variable Beginn_Urlaubswoche.
        /// </summary>
        [TestVariable("8bebeae6-3599-4a67-8f7e-9d35c146e78b")]
        public string Beginn_Urlaubswoche
        {
            get { return _Beginn_Urlaubswoche; }
            set { _Beginn_Urlaubswoche = value; }
        }

        string _Ende_Urlaubswoche;

        /// <summary>
        /// Gets or sets the value of variable Ende_Urlaubswoche.
        /// </summary>
        [TestVariable("a0adfbe7-cf9e-4974-ab06-a1241d39a8b6")]
        public string Ende_Urlaubswoche
        {
            get { return _Ende_Urlaubswoche; }
            set { _Ende_Urlaubswoche = value; }
        }

        string _Ist_Zeit_Urlaubswoche;

        /// <summary>
        /// Gets or sets the value of variable Ist_Zeit_Urlaubswoche.
        /// </summary>
        [TestVariable("6299c7d3-6c90-4634-aa91-cbb54088ac2f")]
        public string Ist_Zeit_Urlaubswoche
        {
            get { return _Ist_Zeit_Urlaubswoche; }
            set { _Ist_Zeit_Urlaubswoche = value; }
        }

        string _bew_Zeit_Urlaubswoche;

        /// <summary>
        /// Gets or sets the value of variable bew_Zeit_Urlaubswoche.
        /// </summary>
        [TestVariable("c990a814-63f6-4bee-8ae9-5f8d03bb5831")]
        public string bew_Zeit_Urlaubswoche
        {
            get { return _bew_Zeit_Urlaubswoche; }
            set { _bew_Zeit_Urlaubswoche = value; }
        }

        string _Sollzeit;

        /// <summary>
        /// Gets or sets the value of variable Sollzeit.
        /// </summary>
        [TestVariable("5007fae3-f7f9-4b1e-9b6c-e669ab4471df")]
        public string Sollzeit
        {
            get { return _Sollzeit; }
            set { _Sollzeit = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Urlaubswoche) on item 'FrmMain.ColKaldDatumRow25'.", repo.FrmMain.ColKaldDatumRow25Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.ColKaldDatumRow25Info, "Text", Datum_Urlaubswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zeittyp_Urlaub) on item 'FrmMain.CellTmpCol13Row25'.", repo.FrmMain.CellTmpCol13Row25Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol13Row25Info, "Text", Zeittyp_Urlaub);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beginn_Urlaubswoche) on item 'FrmMain.CellTmpCol7Row25'.", repo.FrmMain.CellTmpCol7Row25Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol7Row25Info, "Text", Beginn_Urlaubswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ende_Urlaubswoche) on item 'FrmMain.CellTmpCol8Row25'.", repo.FrmMain.CellTmpCol8Row25Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol8Row25Info, "Text", Ende_Urlaubswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ist_Zeit_Urlaubswoche) on item 'FrmMain.CellTmpCol1Row25'.", repo.FrmMain.CellTmpCol1Row25Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol1Row25Info, "Text", Ist_Zeit_Urlaubswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.CellTmpCol2Row25'.", repo.FrmMain.CellTmpCol2Row25Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol2Row25Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bew_Zeit_Urlaubswoche) on item 'FrmMain.CellTmpCol3Row25'.", repo.FrmMain.CellTmpCol3Row25Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol3Row25Info, "Text", bew_Zeit_Urlaubswoche);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Sollzeit) on item 'FrmMain.CellTmpCol4Row25'.", repo.FrmMain.CellTmpCol4Row25Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.CellTmpCol4Row25Info, "Text", Sollzeit);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
