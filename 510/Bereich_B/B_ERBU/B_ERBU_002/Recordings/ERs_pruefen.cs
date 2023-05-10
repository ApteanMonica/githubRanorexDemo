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

namespace B_ERBU_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ERs_pruefen recording.
    /// </summary>
    [TestModule("876e87dc-8929-49d6-80f2-b5cdfbc1edf1", ModuleType.Recording, 1)]
    public partial class ERs_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static ERs_pruefen instance = new ERs_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ERs_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ERs_pruefen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.Tabelle.Zeile_1.Row1Column0' at Center.", repo.TblErbu.Tabelle.Zeile_1.Row1Column0Info, new RecordItemIndex(0));
            repo.TblErbu.Tabelle.Zeile_1.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}'.", new RecordItemIndex(1));
            Keyboard.Press("{LShiftKey down}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{End}'.", new RecordItemIndex(2));
            Keyboard.Press("{End}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}'.", new RecordItemIndex(3));
            Keyboard.Press("{LShiftKey up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.PbOptionenExopPruefen' at Center.", repo.TblErbu.PbOptionenExopPruefenInfo, new RecordItemIndex(4));
            repo.TblErbu.PbOptionenExopPruefen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
