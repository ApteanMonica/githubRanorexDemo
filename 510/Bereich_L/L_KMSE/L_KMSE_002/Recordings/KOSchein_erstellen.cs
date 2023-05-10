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

namespace L_KMSE_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The KOSchein_erstellen recording.
    /// </summary>
    [TestModule("51582ca1-0e63-4e12-bc79-cb2b4d9772ae", ModuleType.Recording, 1)]
    public partial class KOSchein_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_KMSE_002.L_KMSE_002Repository repository.
        /// </summary>
        public static global::L_KMSE_002.L_KMSE_002Repository repo = global::L_KMSE_002.L_KMSE_002Repository.Instance;

        static KOSchein_erstellen instance = new KOSchein_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KOSchein_erstellen()
        {
            KoSchein = "KO21/00009";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KOSchein_erstellen Instance
        {
            get { return instance; }
        }

#region Variables

        string _KoSchein;

        /// <summary>
        /// Gets or sets the value of variable KoSchein.
        /// </summary>
        [TestVariable("d8736474-06d6-499a-a82f-7ffa73953280")]
        public string KoSchein
        {
            get { return _KoSchein; }
            set { _KoSchein = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblKmse.ToolBar.LagerVon' at Center.", repo.TblKmse.ToolBar.LagerVonInfo, new RecordItemIndex(0));
            repo.TblKmse.ToolBar.LagerVon.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'TblKmse.ToolBar.LagerVon'.", repo.TblKmse.ToolBar.LagerVonInfo, new RecordItemIndex(1));
            repo.TblKmse.ToolBar.LagerVon.PressKeys("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblKmse.ToolBar.Lagerbis' at Center.", repo.TblKmse.ToolBar.LagerbisInfo, new RecordItemIndex(2));
            repo.TblKmse.ToolBar.Lagerbis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'TblKmse.ToolBar.Lagerbis'.", repo.TblKmse.ToolBar.LagerbisInfo, new RecordItemIndex(3));
            repo.TblKmse.ToolBar.Lagerbis.PressKeys("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.Laden' at Center.", repo.TblKmse.LadenInfo, new RecordItemIndex(4));
            repo.TblKmse.Laden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Lagerangabe fehlt!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Lagerangabe fehlt!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.OK_Fehlermeldung' at Center.", repo.DlgMessageBox.OK_FehlermeldungInfo, new RecordItemIndex(6));
            repo.DlgMessageBox.OK_Fehlermeldung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.ToolBar.LagerVon' at Center.", repo.TblKmse.ToolBar.LagerVonInfo, new RecordItemIndex(7));
            repo.TblKmse.ToolBar.LagerVon.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100{Tab}' with focus on 'TblKmse.ToolBar.LagerVon'.", repo.TblKmse.ToolBar.LagerVonInfo, new RecordItemIndex(8));
            repo.TblKmse.ToolBar.LagerVon.PressKeys("100{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'TblKmse.ToolBar.LagerVon'.", repo.TblKmse.ToolBar.LagerVonInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblKmse.ToolBar.LagerVonInfo, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.ToolBar.Aufk_Nr' at Center.", repo.TblKmse.ToolBar.Aufk_NrInfo, new RecordItemIndex(10));
            repo.TblKmse.ToolBar.Aufk_Nr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'A21/00003' with focus on 'TblKmse.ToolBar.Aufk_Nr'.", repo.TblKmse.ToolBar.Aufk_NrInfo, new RecordItemIndex(11));
            repo.TblKmse.ToolBar.Aufk_Nr.PressKeys("A21/00003");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.Laden' at Center.", repo.TblKmse.LadenInfo, new RecordItemIndex(12));
            repo.TblKmse.Laden.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKmse.PbCommonKsErstellen' at Center.", repo.TblKmse.PbCommonKsErstellenInfo, new RecordItemIndex(13));
            repo.TblKmse.PbCommonKsErstellen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'KO([0-9]{2})[\\/]([0-9]{5})$') on item 'TblKmse.ColKmskNrRow1'.", repo.TblKmse.ColKmskNrRow1Info, new RecordItemIndex(14));
            Validate.AttributeRegex(repo.TblKmse.ColKmskNrRow1Info, "Text", new Regex("KO([0-9]{2})[\\/]([0-9]{5})$"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
