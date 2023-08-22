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

namespace N_LISTEN_BULI_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Eingabe_Buchungsmonat recording.
    /// </summary>
    [TestModule("97dc9093-d60f-46e3-8a07-1eda6a6905f8", ModuleType.Recording, 1)]
    public partial class Eingabe_Buchungsmonat : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repo = global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository.Instance;

        static Eingabe_Buchungsmonat instance = new Eingabe_Buchungsmonat();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Eingabe_Buchungsmonat()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Eingabe_Buchungsmonat Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnfi.Steuer' at Center.", repo.FrmAnfi.SteuerInfo, new RecordItemIndex(0));
            repo.FrmAnfi.Steuer.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnfi.PbCommonBuchungsliste' at Center.", repo.FrmAnfi.PbCommonBuchungslisteInfo, new RecordItemIndex(1));
            repo.FrmAnfi.PbCommonBuchungsliste.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.AVZAuswertungen'", repo.DlgMessageBox.AVZAuswertungenInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.DlgMessageBox.AVZAuswertungenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Hinweis:\r\n\r\nBei Rücksetzung eines abgeschlossenen Buchungsmonats\r\nmüssen die bereits übergeleiteten Buchungen in der Fibu bzw. Kore\r\nmanuell gelöscht werden, um doppelte Werte zu verhindern!\r\n\r\nIn der Buchungsliste werden alle Anlagen mit Gebucht-Kz. auf\r\nNicht-Gebucht-Kz. zurückgestellt, sodaß diese wieder\r\nneu berechnet werden können.\r\n\r\nFortfahren?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Hinweis:\r\n\r\nBei Rücksetzung eines abgeschlossenen Buchungsmonats\r\nmüssen die bereits übergeleiteten Buchungen in der Fibu bzw. Kore\r\nmanuell gelöscht werden, um doppelte Werte zu verhindern!\r\n\r\nIn der Buchungsliste werden alle Anlagen mit Gebucht-Kz. auf\r\nNicht-Gebucht-Kz. zurückgestellt, sodaß diese wieder\r\nneu berechnet werden können.\r\n\r\nFortfahren?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAnfi.ColAnvabeBulimonatRow1' at Center.", repo.FrmAnfi.ColAnvabeBulimonatRow1Info, new RecordItemIndex(5));
            repo.FrmAnfi.ColAnvabeBulimonatRow1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7{Tab}' with focus on 'FrmAnfi.ColAnvabeBulimonatRow1'.", repo.FrmAnfi.ColAnvabeBulimonatRow1Info, new RecordItemIndex(6));
            repo.FrmAnfi.ColAnvabeBulimonatRow1.PressKeys("7{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAnfi.ColAnvabeBulijahrRow1' at Center.", repo.FrmAnfi.ColAnvabeBulijahrRow1Info, new RecordItemIndex(7));
            repo.FrmAnfi.ColAnvabeBulijahrRow1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2022{Tab}' with focus on 'FrmAnfi.ColAnvabeBulijahrRow1'.", repo.FrmAnfi.ColAnvabeBulijahrRow1Info, new RecordItemIndex(8));
            repo.FrmAnfi.ColAnvabeBulijahrRow1.PressKeys("2022{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnfi.PbDataAccessSave' at Center.", repo.FrmAnfi.PbDataAccessSaveInfo, new RecordItemIndex(9));
            repo.FrmAnfi.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
