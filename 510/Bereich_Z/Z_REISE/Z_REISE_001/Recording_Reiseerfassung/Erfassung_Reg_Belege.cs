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

namespace Z_REISE_001.Recording_Reiseerfassung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Erfassung_Reg_Belege recording.
    /// </summary>
    [TestModule("fe9a882d-183d-4c20-b4c8-6fd2d7bf52b2", ModuleType.Recording, 1)]
    public partial class Erfassung_Reg_Belege : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_REISE_001.Z_REISE_001Repository repository.
        /// </summary>
        public static global::Z_REISE_001.Z_REISE_001Repository repo = global::Z_REISE_001.Z_REISE_001Repository.Instance;

        static Erfassung_Reg_Belege instance = new Erfassung_Reg_Belege();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung_Reg_Belege()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung_Reg_Belege Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRk.Belege' at Center.", repo.FormRk.BelegeInfo, new RecordItemIndex(0));
            repo.FormRk.Belege.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName='Belege') on item 'FormRk.Belege'.", repo.FormRk.BelegeInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FormRk.BelegeInfo, "AccessibleName", "Belege");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormRk.FlexGrid2' at Center.", repo.FormRk.FlexGrid2Info, new RecordItemIndex(2));
            repo.FormRk.FlexGrid2.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Return}'.", new RecordItemIndex(3));
            Keyboard.Press("{Down}{Return}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormRk.TpBelege.Text' at Center.", repo.FormRk.TpBelege.TextInfo, new RecordItemIndex(4));
            repo.FormRk.TpBelege.Text.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20.04.2022' with focus on 'FormRk.TpBelege.Text'.", repo.FormRk.TpBelege.TextInfo, new RecordItemIndex(5));
            repo.FormRk.TpBelege.Text.PressKeys("20.04.2022");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Tab}' with focus on 'FormRk.TpBelege.DfRbelaCd'.", repo.FormRk.TpBelege.DfRbelaCdInfo, new RecordItemIndex(6));
            repo.FormRk.TpBelege.DfRbelaCd.PressKeys("1{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'B1{Tab}' with focus on 'FormRk.TpBelege.DfRbelNummer'.", repo.FormRk.TpBelege.DfRbelNummerInfo, new RecordItemIndex(7));
            repo.FormRk.TpBelege.DfRbelNummer.PressKeys("B1{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormRk.TpBelege.BelegDatum' at Center.", repo.FormRk.TpBelege.BelegDatumInfo, new RecordItemIndex(8));
            repo.FormRk.TpBelege.BelegDatum.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20.04.2022{Tab}' with focus on 'FormRk.TpBelege.BelegDatum'.", repo.FormRk.TpBelege.BelegDatumInfo, new RecordItemIndex(9));
            repo.FormRk.TpBelege.BelegDatum.PressKeys("20.04.2022{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '15{Tab}' with focus on 'FormRk.TpBelege.DfRbelFremdbrutto'.", repo.FormRk.TpBelege.DfRbelFremdbruttoInfo, new RecordItemIndex(10));
            repo.FormRk.TpBelege.DfRbelFremdbrutto.PressKeys("15{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'EUR{Tab}' with focus on 'FormRk.TpBelege.DfRbelBrutto'.", repo.FormRk.TpBelege.DfRbelBruttoInfo, new RecordItemIndex(11));
            repo.FormRk.TpBelege.DfRbelBrutto.PressKeys("EUR{Tab}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
