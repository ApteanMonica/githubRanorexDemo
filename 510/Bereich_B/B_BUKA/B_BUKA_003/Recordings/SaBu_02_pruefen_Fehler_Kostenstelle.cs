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

namespace B_BUKA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SaBu_02_pruefen_Fehler_Kostenstelle recording.
    /// </summary>
    [TestModule("7190b2d2-2803-44c4-aebe-4bbd251c5f9c", ModuleType.Recording, 1)]
    public partial class SaBu_02_pruefen_Fehler_Kostenstelle : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_003.B_BUKA_003Repository repository.
        /// </summary>
        public static global::B_BUKA_003.B_BUKA_003Repository repo = global::B_BUKA_003.B_BUKA_003Repository.Instance;

        static SaBu_02_pruefen_Fehler_Kostenstelle instance = new SaBu_02_pruefen_Fehler_Kostenstelle();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SaBu_02_pruefen_Fehler_Kostenstelle()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SaBu_02_pruefen_Fehler_Kostenstelle Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.FlexGrid1.Row4Column0' at Center.", repo.TblBuka.FlexGrid1.Row4Column0Info, new RecordItemIndex(0));
            repo.TblBuka.FlexGrid1.Row4Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbStandard1_Pruefen' at Center.", repo.TblBuka.PbStandard1_PruefenInfo, new RecordItemIndex(1));
            repo.TblBuka.PbStandard1_Pruefen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgMessageBox'.", repo.DlgMessageBox.SelfInfo, new RecordItemIndex(2));
            Validate.Exists(repo.DlgMessageBox.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FEHLERPRÜFUNG!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "FEHLERPRÜFUNG!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
