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
    ///The Stapel_verbuchen_starten recording.
    /// </summary>
    [TestModule("6947c70b-e722-4f7f-84e2-779ce7b41a9c", ModuleType.Recording, 1)]
    public partial class Stapel_verbuchen_starten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Stapel_verbuchen_starten instance = new Stapel_verbuchen_starten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stapel_verbuchen_starten()
        {
            Fehlerprotokoll_Verbuchung = "c:\\temp\\Fehlerprotokoll_b_exopv_004_verbuch.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stapel_verbuchen_starten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Fehlerprotokoll_Verbuchung;

        /// <summary>
        /// Gets or sets the value of variable Fehlerprotokoll_Verbuchung.
        /// </summary>
        [TestVariable("66cddfda-58b0-49f7-af73-f6b2674b1053")]
        public string Fehlerprotokoll_Verbuchung
        {
            get { return _Fehlerprotokoll_Verbuchung; }
            set { _Fehlerprotokoll_Verbuchung = value; }
        }

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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '' on item 'Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll'.", repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_PruefprotokollInfo, new RecordItemIndex(0));
            repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll.Element.SetAttributeValue("AccessibleValue", "");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(1));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Fehlerprotokoll_Verbuchung' with focus on 'Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll'.", repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_PruefprotokollInfo, new RecordItemIndex(2));
            repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll.PressKeys(Fehlerprotokoll_Verbuchung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbCommonLaden' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbCommonLadenInfo, new RecordItemIndex(4));
            repo.Form100ExterneBuchungenVerbuchen.PbCommonLaden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_Stapel'.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_StapelInfo, new RecordItemIndex(5));
            Validate.Exists(repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_StapelInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_Stapel' at Center.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_StapelInfo, new RecordItemIndex(6));
            repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_004.Column0_Stapel.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbCommonVerbuchen' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbCommonVerbuchenInfo, new RecordItemIndex(7));
            repo.Form100ExterneBuchungenVerbuchen.PbCommonVerbuchen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
