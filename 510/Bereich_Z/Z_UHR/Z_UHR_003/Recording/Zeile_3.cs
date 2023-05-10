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

namespace Z_UHR_003.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zeile_3 recording.
    /// </summary>
    [TestModule("9dfc7842-d7c3-4cf1-af70-1a665abb9ecc", ModuleType.Recording, 1)]
    public partial class Zeile_3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_003.Z_UHR_003Repository repository.
        /// </summary>
        public static global::Z_UHR_003.Z_UHR_003Repository repo = global::Z_UHR_003.Z_UHR_003Repository.Instance;

        static Zeile_3 instance = new Zeile_3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zeile_3()
        {
            Datum = "01.07.2022";
            Uhrzeit_Beginn_Pause = "13:00";
            Uhrzeit_Ende_Pause = "13:30";
            Zeittyp_Pause = "Pause: ";
            Pause_01 = " 00:30";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zeile_3 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum;

        /// <summary>
        /// Gets or sets the value of variable Datum.
        /// </summary>
        [TestVariable("a9988241-2a4b-46b4-b3a7-f10a60e6e47c")]
        public string Datum
        {
            get { return _Datum; }
            set { _Datum = value; }
        }

        string _Uhrzeit_Beginn_Pause;

        /// <summary>
        /// Gets or sets the value of variable Uhrzeit_Beginn_Pause.
        /// </summary>
        [TestVariable("77b8eb20-cbf4-4b7c-a1e4-f186ebb89f97")]
        public string Uhrzeit_Beginn_Pause
        {
            get { return _Uhrzeit_Beginn_Pause; }
            set { _Uhrzeit_Beginn_Pause = value; }
        }

        string _Uhrzeit_Ende_Pause;

        /// <summary>
        /// Gets or sets the value of variable Uhrzeit_Ende_Pause.
        /// </summary>
        [TestVariable("2b11fb7f-8232-4b93-b070-409e9e497140")]
        public string Uhrzeit_Ende_Pause
        {
            get { return _Uhrzeit_Ende_Pause; }
            set { _Uhrzeit_Ende_Pause = value; }
        }

        string _Zeittyp_Pause;

        /// <summary>
        /// Gets or sets the value of variable Zeittyp_Pause.
        /// </summary>
        [TestVariable("d9a981f4-29a8-43c6-b3ff-10c40e271547")]
        public string Zeittyp_Pause
        {
            get { return _Zeittyp_Pause; }
            set { _Zeittyp_Pause = value; }
        }

        string _Pause_01;

        /// <summary>
        /// Gets or sets the value of variable Pause_01.
        /// </summary>
        [TestVariable("6daa4853-e1ec-4a5f-84ab-4b4859775361")]
        public string Pause_01
        {
            get { return _Pause_01; }
            set { _Pause_01 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Fr') on item 'Form100ZeitsystemStechuhrAuswert.Zeile_3.ColTagRow3'.", repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColTagRow3Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColTagRow3Info, "Text", "Fr");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum) on item 'Form100ZeitsystemStechuhrAuswert.Zeile_3.ColDatumRow3'.", repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColDatumRow3Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColDatumRow3Info, "Text", Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Uhrzeit_Beginn_Pause) on item 'Form100ZeitsystemStechuhrAuswert.Zeile_3.ColUhrDtbeginnRow3'.", repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColUhrDtbeginnRow3Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColUhrDtbeginnRow3Info, "Text", Uhrzeit_Beginn_Pause);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Uhrzeit_Ende_Pause) on item 'Form100ZeitsystemStechuhrAuswert.Zeile_3.ColUhrDtendeRow3'.", repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColUhrDtendeRow3Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColUhrDtendeRow3Info, "Text", Uhrzeit_Ende_Pause);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pause_01) on item 'Form100ZeitsystemStechuhrAuswert.Zeile_3.ColPausenRow3'.", repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColPausenRow3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColPausenRow3Info, "Text", Pause_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zeittyp_Pause) on item 'Form100ZeitsystemStechuhrAuswert.Zeile_3.ColTextRow3'.", repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColTextRow3Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Form100ZeitsystemStechuhrAuswert.Zeile_3.ColTextRow3Info, "Text", Zeittyp_Pause);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
