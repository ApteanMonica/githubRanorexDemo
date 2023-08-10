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

namespace N_LISTEN_BULI_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_bereits_erfolgte_Berechnung recording.
    /// </summary>
    [TestModule("62a75978-56c4-4db2-a0db-64d934683a04", ModuleType.Recording, 1)]
    public partial class Meldung_bereits_erfolgte_Berechnung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static Meldung_bereits_erfolgte_Berechnung instance = new Meldung_bereits_erfolgte_Berechnung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_bereits_erfolgte_Berechnung()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_bereits_erfolgte_Berechnung Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.AVZAuswertungen'", repo.DlgMessageBox.AVZAuswertungenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgMessageBox.AVZAuswertungenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es sind bereits berechnete Monate vorhanden! \r\n \r\nSollen diese gelöscht und neu erfaßt werden? \r\n \r\nJa\t\t= Löschen und Neu erfassen \r\nNein\t= Bereits vorhandene Buchungszeilen laden \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es sind bereits berechnete Monate vorhanden! \r\n \r\nSollen diese gelöscht und neu erfaßt werden? \r\n \r\nJa\t\t= Löschen und Neu erfassen \r\nNein\t= Bereits vorhandene Buchungszeilen laden \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmBuchungsliste.TitleBar100AVZAuswertungenBuchungs'", repo.FrmBuchungsliste.TitleBar100AVZAuswertungenBuchungsInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.FrmBuchungsliste.TitleBar100AVZAuswertungenBuchungsInfo.WaitForExists(120000);
            
            // Dieser SQL-Fehler trat nur auf der E521 der  SYSDB RANO_ENTW auf. Auf anderen DB war er bisher nicht nachvollziehbar. Schritte rauslöschen
            //Report.Log(ReportLevel.Info, "Validation", "Dieser SQL-Fehler trat nur auf der E521 der  SYSDB RANO_ENTW auf. Auf anderen DB war er bisher nicht nachvollziehbar. Schritte rauslöschen\r\nValidating AttributeEqual (Text='SQL Fehler: 156 - Falsche Syntax in der Nähe des AND-Schlüsselworts.\r\n\r\nFehlerPosition: 7 () - <CN=chGlobal>\r\n\r\nFalsche Syntax in der Nähe des AND-Schlüsselworts.\r\n') on item 'CdlgSqlFehler.Text'.", repo.CdlgSqlFehler.TextInfo, new RecordItemIndex(4));
            //Validate.AttributeEqual(repo.CdlgSqlFehler.TextInfo, "Text", "SQL Fehler: 156 - Falsche Syntax in der Nähe des AND-Schlüsselworts.\r\n\r\nFehlerPosition: 7 () - <CN=chGlobal>\r\n\r\nFalsche Syntax in der Nähe des AND-Schlüsselworts.\r\n");
            
            // Schritt rauslöschen
            //Report.Log(ReportLevel.Info, "Keyboard", "Schritt rauslöschen\r\nKey sequence 'OK' with focus on 'CdlgSqlFehler.SQLFehler'.", repo.CdlgSqlFehler.SQLFehlerInfo, new RecordItemIndex(5));
            //repo.CdlgSqlFehler.SQLFehler.PressKeys("OK");
            
            // Schritt rauslöschen
            //Report.Log(ReportLevel.Info, "Keyboard", "Schritt rauslöschen\r\nKey 'Enter' Press with focus on 'CdlgSqlFehler.SQLFehler'.", repo.CdlgSqlFehler.SQLFehlerInfo, new RecordItemIndex(6));
            //Keyboard.PrepareFocus(repo.CdlgSqlFehler.SQLFehler);
            //Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
