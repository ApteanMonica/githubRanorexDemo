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

namespace B_BUCH_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Jahr_Periode_eingaben recording.
    /// </summary>
    [TestModule("c46fbe59-d80e-418e-a7e8-b14280851789", ModuleType.Recording, 1)]
    public partial class Jahr_Periode_eingaben : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_006.B_BUCH_006Repository repository.
        /// </summary>
        public static global::B_BUCH_006.B_BUCH_006Repository repo = global::B_BUCH_006.B_BUCH_006Repository.Instance;

        static Jahr_Periode_eingaben instance = new Jahr_Periode_eingaben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Jahr_Periode_eingaben()
        {
            jahr = "2023";
            periode = "03";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Jahr_Periode_eingaben Instance
        {
            get { return instance; }
        }

#region Variables

        string _jahr;

        /// <summary>
        /// Gets or sets the value of variable jahr.
        /// </summary>
        [TestVariable("7dcec018-46e6-4951-81d0-728e178eacd7")]
        public string jahr
        {
            get { return _jahr; }
            set { _jahr = value; }
        }

        string _periode;

        /// <summary>
        /// Gets or sets the value of variable periode.
        /// </summary>
        [TestVariable("27bc2123-683b-4cbe-a05d-ff8fe5282092")]
        public string periode
        {
            get { return _periode; }
            set { _periode = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgFirmaPeriode.DfJahrbezJ' at Center.", repo.DlgFirmaPeriode.DfJahrbezJInfo, new RecordItemIndex(0));
            repo.DlgFirmaPeriode.DfJahrbezJ.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$jahr' with focus on 'DlgFirmaPeriode.DfJahrbezJ'.", repo.DlgFirmaPeriode.DfJahrbezJInfo, new RecordItemIndex(1));
            repo.DlgFirmaPeriode.DfJahrbezJ.PressKeys(jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(2));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$periode' with focus on 'DlgFirmaPeriode.Monat'.", repo.DlgFirmaPeriode.MonatInfo, new RecordItemIndex(3));
            repo.DlgFirmaPeriode.Monat.EnsureVisible();
            Keyboard.Press(periode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFirmaPeriode.PbOK' at Center.", repo.DlgFirmaPeriode.PbOKInfo, new RecordItemIndex(5));
            repo.DlgFirmaPeriode.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.Row6Column0' at Center.", repo.DlgListBox.Row6Column0Info, new RecordItemIndex(6));
            repo.DlgListBox.Row6Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.PbOk' at Center.", repo.DlgListBox.PbOkInfo, new RecordItemIndex(7));
            repo.DlgListBox.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
