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

namespace N_ANLA_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Hinweismeldung_GJ recording.
    /// </summary>
    [TestModule("6673b618-8151-4c38-9496-a35ffe26e574", ModuleType.Recording, 1)]
    public partial class Hinweismeldung_GJ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_004.N_ANLA_004Repository repository.
        /// </summary>
        public static global::N_ANLA_004.N_ANLA_004Repository repo = global::N_ANLA_004.N_ANLA_004Repository.Instance;

        static Hinweismeldung_GJ instance = new Hinweismeldung_GJ();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Hinweismeldung_GJ()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Hinweismeldung_GJ Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.AVZAnlagen'", repo.DlgMessageBox.AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgMessageBox.AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Buchen in einem Geschäftsjahr jünger aktuelles Geschäftsjahr nicht möglich!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Buchen in einem Geschäftsjahr jünger aktuelles Geschäftsjahr nicht möglich!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
