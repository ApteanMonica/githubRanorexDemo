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

namespace Z_UHR_004.Recording_H_ANSPR
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_bestaetigen recording.
    /// </summary>
    [TestModule("8ef8835c-1218-4d30-abe9-26b101de90ac", ModuleType.Recording, 1)]
    public partial class Meldung_bestaetigen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_004.Z_UHR_004Repository repository.
        /// </summary>
        public static global::Z_UHR_004.Z_UHR_004Repository repo = global::Z_UHR_004.Z_UHR_004Repository.Instance;

        static Meldung_bestaetigen instance = new Meldung_bestaetigen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_bestaetigen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_bestaetigen Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgResult.TitleBar100ErgebnisDerAnspruchsEr'", repo.DlgResult.TitleBar100ErgebnisDerAnspruchsErInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgResult.TitleBar100ErgebnisDerAnspruchsErInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anspruchs-Ermittlung für 100/Z_UHR_004/1: Die Berechnung wurde erfolgreich beendet!') on item 'DlgResult.Meldungstext_521_511'.", repo.DlgResult.Meldungstext_521_511Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgResult.Meldungstext_521_511Info, "Text", "Anspruchs-Ermittlung für 100/Z_UHR_004/1: Die Berechnung wurde erfolgreich beendet!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgResult.PbOk' at Center.", repo.DlgResult.PbOkInfo, new RecordItemIndex(2));
            repo.DlgResult.PbOk.Click();
            
            // Ticket anlegen und nach Erledigung des Tickets ein Leerzeichen vor Text entfernen
            Report.Log(ReportLevel.Info, "Validation", "Ticket anlegen und nach Erledigung des Tickets ein Leerzeichen vor Text entfernen\r\nValidating AttributeContains (Text>'  Fehlzeitergebnisse') on item 'TblFehlzeitergebnisse.TitleBar100Fehlzeitergebnisse'.", repo.TblFehlzeitergebnisse.TitleBar100FehlzeitergebnisseInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblFehlzeitergebnisse.TitleBar100FehlzeitergebnisseInfo, "Text", "  Fehlzeitergebnisse");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFehlzeitergebnisse.PbDataAccessLoad' at Center.", repo.TblFehlzeitergebnisse.PbDataAccessLoadInfo, new RecordItemIndex(4));
            repo.TblFehlzeitergebnisse.PbDataAccessLoad.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Anspruchs-Ermittlung für 100/Z_UHR_004/1: Die Berechnung wurde erfolgreich beendet!\r\nEs waren keine Änderungen vorhanden.') on item 'DlgResult.Text'.", repo.DlgResult.TextInfo, new RecordItemIndex(5));
            //Validate.AttributeEqual(repo.DlgResult.TextInfo, "Text", "Anspruchs-Ermittlung für 100/Z_UHR_004/1: Die Berechnung wurde erfolgreich beendet!\r\nEs waren keine Änderungen vorhanden.");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
