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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_ohne_dopp_Beleg_Lieferanten recording.
    /// </summary>
    [TestModule("464434d6-13d7-486d-a1fe-05a156c1175e", ModuleType.Recording, 1)]
    public partial class Pruefung_ohne_dopp_Beleg_Lieferanten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Pruefung_ohne_dopp_Beleg_Lieferanten instance = new Pruefung_ohne_dopp_Beleg_Lieferanten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_ohne_dopp_Beleg_Lieferanten()
        {
            Stapel_Herkunft = "B_EXOPV_005";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_ohne_dopp_Beleg_Lieferanten Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Stapel_Herkunft.
        /// </summary>
        [TestVariable("80147ceb-e943-46c5-a7c1-f05b59ef1cce")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_005.Column0_Stapel1' at Center.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_005.Column0_Stapel1Info, new RecordItemIndex(0));
            repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_005.Column0_Stapel1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbCommonPruefen' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbCommonPruefenInfo, new RecordItemIndex(1));
            repo.Form100ExterneBuchungenVerbuchen.PbCommonPruefen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Prüfung ohne Fehler beendet!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Prüfung ohne Fehler beendet!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
