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

namespace Z_UHR_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UEberpruefung_Erfassung_Urlaub_MA_02 recording.
    /// </summary>
    [TestModule("31d47142-487c-4d51-987e-ecbd71f2c2a6", ModuleType.Recording, 1)]
    public partial class UEberpruefung_Erfassung_Urlaub_MA_02 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_002.Z_UHR_002Repository repository.
        /// </summary>
        public static global::Z_UHR_002.Z_UHR_002Repository repo = global::Z_UHR_002.Z_UHR_002Repository.Instance;

        static UEberpruefung_Erfassung_Urlaub_MA_02 instance = new UEberpruefung_Erfassung_Urlaub_MA_02();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UEberpruefung_Erfassung_Urlaub_MA_02()
        {
            Tagesdatum_plus_3 = "";
            Status_n_G = "nicht Genehmigt";
            Tagesteil_2_Tageshaelfte = "nur 2. Tageshälfte";
            Personalnr_MA_02 = "UHR_002_C";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UEberpruefung_Erfassung_Urlaub_MA_02 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum_plus_3;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_plus_3.
        /// </summary>
        [TestVariable("a1ed0f43-203e-41df-b63b-cdf3f57f5691")]
        public string Tagesdatum_plus_3
        {
            get { return _Tagesdatum_plus_3; }
            set { _Tagesdatum_plus_3 = value; }
        }

        string _Tagesteil_2_Tageshaelfte;

        /// <summary>
        /// Gets or sets the value of variable Tagesteil_2_Tageshaelfte.
        /// </summary>
        [TestVariable("dca8868e-a4f3-4c15-9569-03dbbae81df8")]
        public string Tagesteil_2_Tageshaelfte
        {
            get { return _Tagesteil_2_Tageshaelfte; }
            set { _Tagesteil_2_Tageshaelfte = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Personalnr_MA_02.
        /// </summary>
        [TestVariable("b802aff6-f4de-47d9-bd66-dee56274e0fa")]
        public string Personalnr_MA_02
        {
            get { return repo.Personalnr_MA_02; }
            set { repo.Personalnr_MA_02 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Status_n_G.
        /// </summary>
        [TestVariable("3a9dec42-27e4-45fc-83ba-3088b2955c65")]
        public string Status_n_G
        {
            get { return repo.Status_n_G; }
            set { repo.Status_n_G = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Zeitsystem \"Stechuhr\"') on item 'FrmUhr.TitleBar100ZeitsystemStechuhr'.", repo.FrmUhr.TitleBar100ZeitsystemStechuhrInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.FrmUhr.TitleBar100ZeitsystemStechuhrInfo, "Text", "Zeitsystem \"Stechuhr\"");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum_plus_3) on item 'FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrDtbeginn'.", repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrDtbeginnInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrDtbeginnInfo, "Text", Tagesdatum_plus_3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesteil_2_Tageshaelfte) on item 'FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrTagtVonBez'.", repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrTagtVonBezInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrTagtVonBezInfo, "Text", Tagesteil_2_Tageshaelfte);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum_plus_3) on item 'FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrDtende'.", repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrDtendeInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrDtendeInfo, "Text", Tagesdatum_plus_3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Personalnr_MA_02) on item 'FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColPersNr'.", repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColPersNrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColPersNrInfo, "Text", Personalnr_MA_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_n_G) on item 'FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrGenstatusBez'.", repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrGenstatusBezInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmUhr.Tabelle_rechts_mit_Variable_Mitarbeiter_02.ColUhrGenstatusBezInfo, "Text", Status_n_G);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}