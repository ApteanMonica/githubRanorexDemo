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

namespace V_AUF_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Beleg_abschliessen recording.
    /// </summary>
    [TestModule("534a9e50-551a-4fe0-93e0-967df74f57d8", ModuleType.Recording, 1)]
    public partial class Beleg_abschliessen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_AUF_003.V_AUF_003Repository repository.
        /// </summary>
        public static global::V_AUF_003.V_AUF_003Repository repo = global::V_AUF_003.V_AUF_003Repository.Instance;

        static Beleg_abschliessen instance = new Beleg_abschliessen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Beleg_abschliessen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Beleg_abschliessen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Beleg_abschliessen_.Beleg_abschliessen_ReKorr' at Center.", repo.Beleg_abschliessen_.Beleg_abschliessen_ReKorrInfo, new RecordItemIndex(0));
            repo.Beleg_abschliessen_.Beleg_abschliessen_ReKorr.Click();
            
            // BAR: Wait for erhöht von 2 auf 3 Minuten
            Report.Log(ReportLevel.Info, "Wait", "BAR: Wait for erhöht von 2 auf 3 Minuten\r\nWaiting 5m to exist. Associated repository item: 'TblFadr.TitleBar100Rechnungskorrektur'", repo.TblFadr.TitleBar100RechnungskorrekturInfo, new ActionTimeout(300000), new RecordItemIndex(1));
            repo.TblFadr.TitleBar100RechnungskorrekturInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'Rechnungskorrektur') on item 'TblFadr.TitleBar100Rechnungskorrektur'.", repo.TblFadr.TitleBar100RechnungskorrekturInfo, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.TblFadr.TitleBar100RechnungskorrekturInfo, "Text", new Regex("Rechnungskorrektur"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.TitleBar100Rechnungskorrektur' at Center.", repo.TblFadr.TitleBar100RechnungskorrekturInfo, new RecordItemIndex(3));
            repo.TblFadr.TitleBar100Rechnungskorrektur.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R21/00003') on item 'TblFadr.ColRechNrRow1'.", repo.TblFadr.ColRechNrRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblFadr.ColRechNrRow1Info, "Text", "R21/00003");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
