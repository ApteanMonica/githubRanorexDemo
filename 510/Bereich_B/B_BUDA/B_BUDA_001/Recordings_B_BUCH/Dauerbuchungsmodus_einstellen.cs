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
    ///The Dauerbuchungsmodus_einstellen recording.
    /// </summary>
    [TestModule("c7c24048-b37b-468f-86aa-3d17ff30c58f", ModuleType.Recording, 1)]
    public partial class Dauerbuchungsmodus_einstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_001.B_BUDA_001Repository repository.
        /// </summary>
        public static global::B_BUDA_001.B_BUDA_001Repository repo = global::B_BUDA_001.B_BUDA_001Repository.Instance;

        static Dauerbuchungsmodus_einstellen instance = new Dauerbuchungsmodus_einstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchungsmodus_einstellen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchungsmodus_einstellen Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'MdiBuch.FrmRG.Hauptframe_2.Beleg'", repo.MdiBuch.FrmRG.Hauptframe_2.BelegInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.MdiBuch.FrmRG.Hauptframe_2.BelegInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.FrmRG.Hauptframe_2.Beleg' at Center.", repo.MdiBuch.FrmRG.Hauptframe_2.BelegInfo, new RecordItemIndex(1));
            repo.MdiBuch.FrmRG.Hauptframe_2.Beleg.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.PbCommonCommon' at Center.", repo.MdiBuch.PbCommonCommonInfo, new RecordItemIndex(2));
            repo.MdiBuch.PbCommonCommon.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBUCH.Dauerbuchung' at Center.", repo.BBUCH.DauerbuchungInfo, new RecordItemIndex(3));
            repo.BBUCH.Dauerbuchung.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Sollen die folgenden Buchungen als Dauerbuchung erfasst werden?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Sollen die folgenden Buchungen als Dauerbuchung erfasst werden?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Dauerbuchung erfassen - Dialog') on item 'MdiBuch.TitleBar100Dialogbuchung'.", repo.MdiBuch.TitleBar100DialogbuchungInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.MdiBuch.TitleBar100DialogbuchungInfo, "Text", "Dauerbuchung erfassen - Dialog");
            
            // Neu mit Ticket NX478 erl
            Report.Log(ReportLevel.Info, "Validation", "Neu mit Ticket NX478 erl\r\nValidating AttributeEqual (Text='(Dauerbuchungsvorlage)') on item 'MdiBuch.Labeldauerbuchung'.", repo.MdiBuch.LabeldauerbuchungInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiBuch.LabeldauerbuchungInfo, "Text", "(Dauerbuchungsvorlage)");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
