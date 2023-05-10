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

namespace B_BUDA_001.Recordings_B_BUCH
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Periode_Busy_aufrufen recording.
    /// </summary>
    [TestModule("c0fc3b57-e4e5-495d-8627-cd8bf957cfe1", ModuleType.Recording, 1)]
    public partial class Periode_Busy_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_001.B_BUDA_001Repository repository.
        /// </summary>
        public static global::B_BUDA_001.B_BUDA_001Repository repo = global::B_BUDA_001.B_BUDA_001Repository.Instance;

        static Periode_Busy_aufrufen instance = new Periode_Busy_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Periode_Busy_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Periode_Busy_aufrufen Instance
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

            // Maske Periodeneingabe
            Report.Log(ReportLevel.Info, "Validation", "Maske Periodeneingabe\r\nValidating AttributeContains (Text>'Dialogbuchung') on item 'DlgFirmaPeriode.TitleBar100Dialogbuchung'.", repo.DlgFirmaPeriode.TitleBar100DialogbuchungInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.DlgFirmaPeriode.TitleBar100DialogbuchungInfo, "Text", "Dialogbuchung");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgFirmaPeriode.DfJahrbezJ' at Center.", repo.DlgFirmaPeriode.DfJahrbezJInfo, new RecordItemIndex(1));
            repo.DlgFirmaPeriode.DfJahrbezJ.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'DlgFirmaPeriode.DfJahrbezJ'.", repo.DlgFirmaPeriode.DfJahrbezJInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.DlgFirmaPeriode.DfJahrbezJ);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2021' with focus on 'DlgFirmaPeriode.DfJahrbezJ'.", repo.DlgFirmaPeriode.DfJahrbezJInfo, new RecordItemIndex(3));
            repo.DlgFirmaPeriode.DfJahrbezJ.PressKeys("2021");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '11' with focus on 'DlgFirmaPeriode.DfPeriodeJ'.", repo.DlgFirmaPeriode.DfPeriodeJInfo, new RecordItemIndex(5));
            repo.DlgFirmaPeriode.DfPeriodeJ.PressKeys("11");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFirmaPeriode.PbOK' at Center.", repo.DlgFirmaPeriode.PbOKInfo, new RecordItemIndex(7));
            repo.DlgFirmaPeriode.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgListBox.TitleBar100AuswahllisteBuchungssymb'", repo.DlgListBox.TitleBar100AuswahllisteBuchungssymbInfo, new ActionTimeout(120000), new RecordItemIndex(8));
            repo.DlgListBox.TitleBar100AuswahllisteBuchungssymbInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Auswahlliste Buchungssymbole') on item 'DlgListBox.TitleBar100AuswahllisteBuchungssymb'.", repo.DlgListBox.TitleBar100AuswahllisteBuchungssymbInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.DlgListBox.TitleBar100AuswahllisteBuchungssymbInfo, "Text", "Auswahlliste Buchungssymbole");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.Row1Column0' at Center.", repo.DlgListBox.Row1Column0Info, new RecordItemIndex(10));
            repo.DlgListBox.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ER'.", new RecordItemIndex(11));
            Keyboard.Press("ER");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'MdiBuch.Symbol'", repo.MdiBuch.SymbolInfo, new ActionTimeout(60000), new RecordItemIndex(13));
            repo.MdiBuch.SymbolInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER') on item 'MdiBuch.Symbol'.", repo.MdiBuch.SymbolInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiBuch.SymbolInfo, "Text", "ER");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
