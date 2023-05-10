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

namespace Z_PROJ_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Phasen_loeschen_nicht_erlaubt recording.
    /// </summary>
    [TestModule("63e96075-041e-4ee6-9bec-269292ab57a3", ModuleType.Recording, 1)]
    public partial class Phasen_loeschen_nicht_erlaubt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_005.Z_PROJ_005Repository repository.
        /// </summary>
        public static global::Z_PROJ_005.Z_PROJ_005Repository repo = global::Z_PROJ_005.Z_PROJ_005Repository.Instance;

        static Phasen_loeschen_nicht_erlaubt instance = new Phasen_loeschen_nicht_erlaubt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Phasen_loeschen_nicht_erlaubt()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Phasen_loeschen_nicht_erlaubt Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1.Row1Column0' at Center.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1.Row1Column0Info, new RecordItemIndex(0));
            repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1.Row1Column0'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1.Row1Column0Info, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1.Row1Column0);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbDataAccessSave' at Center.", repo.FrmTabProjekt.PbDataAccessSaveInfo, new RecordItemIndex(2));
            repo.FrmTabProjekt.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Projekt kann ohne Phaseneintrag nicht gespeichert werden!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Projekt kann ohne Phaseneintrag nicht gespeichert werden!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbDataAccessReload' at Center.", repo.FrmTabProjekt.PbDataAccessReloadInfo, new RecordItemIndex(5));
            repo.FrmTabProjekt.PbDataAccessReload.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbNavigationBack' at Center.", repo.FrmTabProjekt.PbNavigationBackInfo, new RecordItemIndex(6));
            repo.FrmTabProjekt.PbNavigationBack.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
