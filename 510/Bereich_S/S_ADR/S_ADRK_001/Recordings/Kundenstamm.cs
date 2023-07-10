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

namespace S_ADRK_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kundenstamm recording.
    /// </summary>
    [TestModule("7a62f63b-284a-4405-bca5-3377f4984993", ModuleType.Recording, 1)]
    public partial class Kundenstamm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADRK_001.S_ADRK_001Repository repository.
        /// </summary>
        public static global::S_ADRK_001.S_ADRK_001Repository repo = global::S_ADRK_001.S_ADRK_001Repository.Instance;

        static Kundenstamm instance = new Kundenstamm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kundenstamm()
        {
            Aptean_Austria = "\r\nAptean Austria GmbH\r\nDorfstraße 67\nAT-5101 Bergheim\r\n\r\nMöchten Sie als gültige UID übernehmen?\r\n";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kundenstamm Instance
        {
            get { return instance; }
        }

#region Variables

        string _Aptean_Austria;

        /// <summary>
        /// Gets or sets the value of variable Aptean_Austria.
        /// </summary>
        [TestVariable("4f127bbc-eddf-499f-91b9-f1799323cadd")]
        public string Aptean_Austria
        {
            get { return _Aptean_Austria; }
            set { _Aptean_Austria = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.TpAllgemein.DfZlbdCd' at Center.", repo.FrmAdr.TpAllgemein.DfZlbdCdInfo, new RecordItemIndex(0));
            repo.FrmAdr.TpAllgemein.DfZlbdCd.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '030{Tab}' with focus on 'FrmAdr.TpAllgemein.DfZlbdCd'.", repo.FrmAdr.TpAllgemein.DfZlbdCdInfo, new RecordItemIndex(1));
            repo.FrmAdr.TpAllgemein.DfZlbdCd.PressKeys("030{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='030') on item 'FrmAdr.TpAllgemein.DfZlbdCd'.", repo.FrmAdr.TpAllgemein.DfZlbdCdInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmAdr.TpAllgemein.DfZlbdCdInfo, "Text", "030");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.TpAllgemein.Zahlungsart' at Center.", repo.FrmAdr.TpAllgemein.ZahlungsartInfo, new RecordItemIndex(3));
            repo.FrmAdr.TpAllgemein.Zahlungsart.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'S{Tab}' with focus on 'FrmAdr.TpAllgemein.Zahlungsart'.", repo.FrmAdr.TpAllgemein.ZahlungsartInfo, new RecordItemIndex(4));
            repo.FrmAdr.TpAllgemein.Zahlungsart.PressKeys("S{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'FrmAdr.TpAllgemein.Zahlungsart'.", repo.FrmAdr.TpAllgemein.ZahlungsartInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmAdr.TpAllgemein.ZahlungsartInfo, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.TpAllgemein.Text' at Center.", repo.FrmAdr.TpAllgemein.TextInfo, new RecordItemIndex(6));
            repo.FrmAdr.TpAllgemein.Text.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'U75601939{Tab down}' with focus on 'FrmAdr.TpAllgemein.Text'.", repo.FrmAdr.TpAllgemein.TextInfo, new RecordItemIndex(7));
            repo.FrmAdr.TpAllgemein.Text.PressKeys("U75601939{Tab down}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Aptean_Austria) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", Aptean_Austria);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Bestaetigung_Fehlermeldung' at Center.", repo.DlgMessageBox.Bestaetigung_FehlermeldungInfo, new RecordItemIndex(9));
            repo.DlgMessageBox.Bestaetigung_Fehlermeldung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.TpAllgemein.VID' at Center.", repo.FrmAdr.TpAllgemein.VIDInfo, new RecordItemIndex(10));
            repo.FrmAdr.TpAllgemein.VID.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100{Tab}' with focus on 'FrmAdr.TpAllgemein.VID'.", repo.FrmAdr.TpAllgemein.VIDInfo, new RecordItemIndex(11));
            repo.FrmAdr.TpAllgemein.VID.PressKeys("100{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'FrmAdr.TpAllgemein.VID'.", repo.FrmAdr.TpAllgemein.VIDInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmAdr.TpAllgemein.VIDInfo, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.ClientArea.TabPageWaWi' at Center.", repo.FrmAdr.ClientArea.TabPageWaWiInfo, new RecordItemIndex(13));
            repo.FrmAdr.ClientArea.TabPageWaWi.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Versandbed' at Center.", repo.FrmAdr.VersandbedInfo, new RecordItemIndex(14));
            repo.FrmAdr.Versandbed.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'SPE{Tab}' with focus on 'FrmAdr.Versandbed'.", repo.FrmAdr.VersandbedInfo, new RecordItemIndex(15));
            repo.FrmAdr.Versandbed.PressKeys("SPE{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='SPE') on item 'FrmAdr.Versandbed'.", repo.FrmAdr.VersandbedInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmAdr.VersandbedInfo, "Text", "SPE");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.ClientArea.Notizbuch' at Center.", repo.FrmAdr.ClientArea.NotizbuchInfo, new RecordItemIndex(17));
            repo.FrmAdr.ClientArea.Notizbuch.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.ClientArea.SplitterPanel' at Center.", repo.FrmAdr.ClientArea.SplitterPanelInfo, new RecordItemIndex(18));
            repo.FrmAdr.ClientArea.SplitterPanel.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QS Test Ranorex' with focus on 'FrmAdr.ClientArea.SplitterPanel'.", repo.FrmAdr.ClientArea.SplitterPanelInfo, new RecordItemIndex(19));
            repo.FrmAdr.ClientArea.SplitterPanel.PressKeys("QS Test Ranorex");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='QS Test Ranorex') on item 'FrmAdr.ClientArea.SplitterPanel'.", repo.FrmAdr.ClientArea.SplitterPanelInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmAdr.ClientArea.SplitterPanelInfo, "Text", "QS Test Ranorex");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
