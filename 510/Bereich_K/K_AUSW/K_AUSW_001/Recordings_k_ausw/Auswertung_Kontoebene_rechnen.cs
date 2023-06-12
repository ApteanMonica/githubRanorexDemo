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

namespace K_AUSW_001.Recordings_k_ausw
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Auswertung_Kontoebene_rechnen recording.
    /// </summary>
    [TestModule("bfefd8ff-6535-47c3-82cb-a4d080ef47fd", ModuleType.Recording, 1)]
    public partial class Auswertung_Kontoebene_rechnen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_AUSW_001.K_AUSW_001Repository repository.
        /// </summary>
        public static global::K_AUSW_001.K_AUSW_001Repository repo = global::K_AUSW_001.K_AUSW_001Repository.Instance;

        static Auswertung_Kontoebene_rechnen instance = new Auswertung_Kontoebene_rechnen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Auswertung_Kontoebene_rechnen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Auswertung_Kontoebene_rechnen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.FlexGrid_TblAtbz.Row1Column0' at Center.", repo.FrmMain.FlexGrid_TblAtbz.Row1Column0Info, new RecordItemIndex(0));
            repo.FrmMain.FlexGrid_TblAtbz.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(1));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbToolBarItemsRechnen' at Center.", repo.FrmMain.PbToolBarItemsRechnenInfo, new RecordItemIndex(2));
            repo.FrmMain.PbToolBarItemsRechnen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(180000), new RecordItemIndex(3));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Nur markierte Formulare rechnen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Nur markierte Formulare rechnen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(5));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'TblAnzeige.TitleBar100GuVSec231UGBStand2016'", repo.TblAnzeige.TitleBar100GuVSec231UGBStand2016Info, new ActionTimeout(300000), new RecordItemIndex(6));
            repo.TblAnzeige.TitleBar100GuVSec231UGBStand2016Info.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to not exist. Associated repository item: 'FrmProgress'", repo.FrmProgress.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(7));
            repo.FrmProgress.SelfInfo.WaitForNotExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
