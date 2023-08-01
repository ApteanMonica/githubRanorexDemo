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

namespace K_PBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ansicht_Planungsgrundlagen_zuruecksetzen recording.
    /// </summary>
    [TestModule("a9cb8dcc-38fc-4082-957d-f1cec6b9acac", ModuleType.Recording, 1)]
    public partial class Ansicht_Planungsgrundlagen_zuruecksetzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_PBU_001.K_PBU_001Repository repository.
        /// </summary>
        public static global::K_PBU_001.K_PBU_001Repository repo = global::K_PBU_001.K_PBU_001Repository.Instance;

        static Ansicht_Planungsgrundlagen_zuruecksetzen instance = new Ansicht_Planungsgrundlagen_zuruecksetzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ansicht_Planungsgrundlagen_zuruecksetzen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ansicht_Planungsgrundlagen_zuruecksetzen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.PbAnsichtAnsicht' at Center.", repo.TblK.PbAnsichtAnsichtInfo, new RecordItemIndex(0));
            repo.TblK.PbAnsichtAnsicht.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KPBU.Planungsgrundlagen' at Center.", repo.KPBU.PlanungsgrundlagenInfo, new RecordItemIndex(1));
            repo.KPBU.Planungsgrundlagen.Click();
            
            // search timeout reduziert
            Report.Log(ReportLevel.Info, "Validation", "search timeout reduziert\r\nValidating AttributeEqual (Visible='False') on item 'TblK.FlexGrid_Tabelle.Row_1_Planungsgrundlagen.ColKsHerkRow1'.", repo.TblK.FlexGrid_Tabelle.Row_1_Planungsgrundlagen.ColKsHerkRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblK.FlexGrid_Tabelle.Row_1_Planungsgrundlagen.ColKsHerkRow1Info, "Visible", "False");
            
            // search timeout reduziert
            Report.Log(ReportLevel.Info, "Validation", "search timeout reduziert\r\nValidating AttributeEqual (Visible='False') on item 'TblK.FlexGrid_Tabelle.Row_1_Planungsgrundlagen.ColJahrmengeRow1'.", repo.TblK.FlexGrid_Tabelle.Row_1_Planungsgrundlagen.ColJahrmengeRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblK.FlexGrid_Tabelle.Row_1_Planungsgrundlagen.ColJahrmengeRow1Info, "Visible", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}