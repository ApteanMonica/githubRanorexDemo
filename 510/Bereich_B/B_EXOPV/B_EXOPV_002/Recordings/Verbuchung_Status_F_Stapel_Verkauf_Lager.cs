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

namespace B_EXOPV_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Stapel recording.
    /// </summary>
    [TestModule("f996d5e9-02ae-4bcf-8da7-7b6672819014", ModuleType.Recording, 1)]
    public partial class Verbuchung_Status_F_Stapel_Verkauf_Lager : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_002.B_EXOPV_002Repository repository.
        /// </summary>
        public static global::B_EXOPV_002.B_EXOPV_002Repository repo = global::B_EXOPV_002.B_EXOPV_002Repository.Instance;

        static Verbuchung_Status_F_Stapel_Verkauf_Lager instance = new Verbuchung_Status_F_Stapel_Verkauf_Lager();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchung_Status_F_Stapel_Verkauf_Lager()
        {
            Protokolldatei_C = "c:\\temp\\Fehlerprotokoll_b_exopv_002_C.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchung_Status_F_Stapel_Verkauf_Lager Instance
        {
            get { return instance; }
        }

#region Variables

        string _Protokolldatei_C;

        /// <summary>
        /// Gets or sets the value of variable Protokolldatei_C.
        /// </summary>
        [TestVariable("69d349c8-8761-42db-b9e6-7a291bd29e16")]
        public string Protokolldatei_C
        {
            get { return _Protokolldatei_C; }
            set { _Protokolldatei_C = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Stapel1_Verkauf_Datum.
        /// </summary>
        [TestVariable("b0c271b0-02dc-478d-97d5-2ed654cbc40a")]
        public string Stapel1_Verkauf_Datum
        {
            get { return repo.Stapel1_Verkauf_Datum; }
            set { repo.Stapel1_Verkauf_Datum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Stapel2_Lager_Datum.
        /// </summary>
        [TestVariable("71ec8ecc-809e-47cc-9648-8bc026ba53bf")]
        public string Stapel2_Lager_Datum
        {
            get { return repo.Stapel2_Lager_Datum; }
            set { repo.Stapel2_Lager_Datum = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Form100ExterneBuchungenVerbuchen.TitleBar100ExterneBuchungenVerbuche'.", repo.Form100ExterneBuchungenVerbuchen.TitleBar100ExterneBuchungenVerbucheInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Form100ExterneBuchungenVerbuchen.TitleBar100ExterneBuchungenVerbucheInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbCommonLaden' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbCommonLadenInfo, new RecordItemIndex(1));
            repo.Form100ExterneBuchungenVerbuchen.PbCommonLaden.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Protokolldatei_C' on item 'Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll'.", repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_PruefprotokollInfo, new RecordItemIndex(2));
            repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll.Element.SetAttributeValue("AccessibleValue", Protokolldatei_C);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen_mit_Variablen_Stapel1_Verkauf_Stapel2_Lager.Zeile_mit_Stapel1_Verkauf_16012020.Column0_Stapel1' at Center.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen_mit_Variablen_Stapel1_Verkauf_Stapel2_Lager.Zeile_mit_Stapel1_Verkauf_16012020.Column0_Stapel1Info, new RecordItemIndex(3));
            repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen_mit_Variablen_Stapel1_Verkauf_Stapel2_Lager.Zeile_mit_Stapel1_Verkauf_16012020.Column0_Stapel1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}'.", new RecordItemIndex(4));
            Keyboard.Press("{LControlKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen_mit_Variablen_Stapel1_Verkauf_Stapel2_Lager.Zeile_mit_Stapel2_Lager_18012020.Column0_Stapel2' at Center.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen_mit_Variablen_Stapel1_Verkauf_Stapel2_Lager.Zeile_mit_Stapel2_Lager_18012020.Column0_Stapel2Info, new RecordItemIndex(5));
            repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen_mit_Variablen_Stapel1_Verkauf_Stapel2_Lager.Zeile_mit_Stapel2_Lager_18012020.Column0_Stapel2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(6));
            Keyboard.Press("{LControlKey up}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbCommonVerbuchen' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbCommonVerbuchenInfo, new RecordItemIndex(8));
            repo.Form100ExterneBuchungenVerbuchen.PbCommonVerbuchen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
