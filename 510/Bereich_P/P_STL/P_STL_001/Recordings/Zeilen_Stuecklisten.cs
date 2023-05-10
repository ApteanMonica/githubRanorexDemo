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

namespace P_STL_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zeilen_Stuecklisten recording.
    /// </summary>
    [TestModule("26254088-6815-4d10-9520-95042acdb310", ModuleType.Recording, 1)]
    public partial class Zeilen_Stuecklisten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::P_STL_001.P_STL_001Repository repository.
        /// </summary>
        public static global::P_STL_001.P_STL_001Repository repo = global::P_STL_001.P_STL_001Repository.Instance;

        static Zeilen_Stuecklisten instance = new Zeilen_Stuecklisten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zeilen_Stuecklisten()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zeilen_Stuecklisten Instance
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmStueckliste.FlexGrid' at Center.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(0));
            repo.FrmStueckliste.FlexGrid.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}{Tab}{Tab}' with focus on 'FrmStueckliste.FlexGrid'.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(1));
            repo.FrmStueckliste.FlexGrid.PressKeys("{Insert}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100018{Tab}{Tab}' with focus on 'FrmStueckliste.FlexGrid1.Zeilen_Stueckliste'.", repo.FrmStueckliste.FlexGrid1.Zeilen_StuecklisteInfo, new RecordItemIndex(2));
            repo.FrmStueckliste.FlexGrid1.Zeilen_Stueckliste.EnsureVisible();
            Keyboard.Press("100018{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100018') on item 'FrmStueckliste.FlexGrid1.Zeilen_Stueckliste'.", repo.FrmStueckliste.FlexGrid1.Zeilen_StuecklisteInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmStueckliste.FlexGrid1.Zeilen_StuecklisteInfo, "Text", "100018");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmStueckliste.Artikel' at Center.", repo.FrmStueckliste.ArtikelInfo, new RecordItemIndex(4));
            repo.FrmStueckliste.Artikel.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2{Tab}' with focus on 'FrmStueckliste.FlexGrid'.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(5));
            repo.FrmStueckliste.FlexGrid.PressKeys("2{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmStueckliste.PbCommonSave' at Center.", repo.FrmStueckliste.PbCommonSaveInfo, new RecordItemIndex(6));
            repo.FrmStueckliste.PbCommonSave.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmStueckliste.FlexGrid' at Center.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(7));
            repo.FrmStueckliste.FlexGrid.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}{Tab}{Tab}' with focus on 'FrmStueckliste.FlexGrid'.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(8));
            repo.FrmStueckliste.FlexGrid.EnsureVisible();
            Keyboard.Press("{Insert}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100017{Tab}{Tab}' with focus on 'FrmStueckliste.FlexGrid1.Position2'.", repo.FrmStueckliste.FlexGrid1.Position2Info, new RecordItemIndex(9));
            repo.FrmStueckliste.FlexGrid1.Position2.EnsureVisible();
            Keyboard.Press("100017{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100017') on item 'FrmStueckliste.FlexGrid1.Position2'.", repo.FrmStueckliste.FlexGrid1.Position2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmStueckliste.FlexGrid1.Position2Info, "Text", "100017");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'FrmStueckliste.FlexGrid'.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(11));
            repo.FrmStueckliste.FlexGrid.EnsureVisible();
            Keyboard.Press("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}{Tab}{Tab}' with focus on 'FrmStueckliste.FlexGrid'.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(12));
            repo.FrmStueckliste.FlexGrid.EnsureVisible();
            Keyboard.Press("{Insert}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100015{Tab}{Tab}' with focus on 'FrmStueckliste.FlexGrid1.Position_3'.", repo.FrmStueckliste.FlexGrid1.Position_3Info, new RecordItemIndex(13));
            repo.FrmStueckliste.FlexGrid1.Position_3.EnsureVisible();
            Keyboard.Press("100015{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100015') on item 'FrmStueckliste.FlexGrid1.Position_3'.", repo.FrmStueckliste.FlexGrid1.Position_3Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmStueckliste.FlexGrid1.Position_3Info, "Text", "100015");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Tab}' with focus on 'FrmStueckliste.FlexGrid'.", repo.FrmStueckliste.FlexGridInfo, new RecordItemIndex(15));
            repo.FrmStueckliste.FlexGrid.EnsureVisible();
            Keyboard.Press("1{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmStueckliste.PbCommonSave' at Center.", repo.FrmStueckliste.PbCommonSaveInfo, new RecordItemIndex(16));
            repo.FrmStueckliste.PbCommonSave.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
