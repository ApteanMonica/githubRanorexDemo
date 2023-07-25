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

namespace B_EXOPV_004.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stapel_verbucht_pruefen recording.
    /// </summary>
    [TestModule("a853b09e-6b86-47f1-add3-06d5780bd494", ModuleType.Recording, 1)]
    public partial class Stapel_verbucht_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Stapel_verbucht_pruefen instance = new Stapel_verbucht_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stapel_verbucht_pruefen()
        {
            Stapel_Herkunft = "B_EXOPV_004";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stapel_verbucht_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Stapel_Herkunft.
        /// </summary>
        [TestVariable("f49cbd79-1eb3-44bb-944f-1aacebbc6e29")]
        public string Stapel_Herkunft
        {
            get { return repo.Stapel_Herkunft; }
            set { repo.Stapel_Herkunft = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Stapel_Herkunft) on item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_Stapel'.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_StapelInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_StapelInfo, "Text", Stapel_Herkunft);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='6') on item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPCount_Stapel'.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPCount_StapelInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPCount_StapelInfo, "Text", "6");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4') on item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPVerbucht_Stapel'.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPVerbucht_StapelInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPVerbucht_StapelInfo, "Text", "4");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='21.000,00') on item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPBetragB_Stapel'.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPBetragB_StapelInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPBetragB_StapelInfo, "Text", "21.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='16.800,00') on item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPBetrag_Stapel'.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPBetrag_StapelInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.ColOPBetrag_StapelInfo, "Text", "16.800,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}