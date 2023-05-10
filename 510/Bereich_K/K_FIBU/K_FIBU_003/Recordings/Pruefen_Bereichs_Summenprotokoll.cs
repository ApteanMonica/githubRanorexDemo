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

namespace K_FIBU_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefen_Bereichs_Summenprotokoll recording.
    /// </summary>
    [TestModule("f8bf013a-dd5b-492b-a272-36052d0d4049", ModuleType.Recording, 1)]
    public partial class Pruefen_Bereichs_Summenprotokoll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_003.K_FIBU_003Repository repository.
        /// </summary>
        public static global::K_FIBU_003.K_FIBU_003Repository repo = global::K_FIBU_003.K_FIBU_003Repository.Instance;

        static Pruefen_Bereichs_Summenprotokoll instance = new Pruefen_Bereichs_Summenprotokoll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefen_Bereichs_Summenprotokoll()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefen_Bereichs_Summenprotokoll Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblDiff.TitleBar100BereichsSummenProtokoll'", repo.TblDiff.TitleBar100BereichsSummenProtokollInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.TblDiff.TitleBar100BereichsSummenProtokollInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='[100]  Bereichs-Summen Protokoll') on item 'TblDiff.TitleBar100BereichsSummenProtokoll'.", repo.TblDiff.TitleBar100BereichsSummenProtokollInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblDiff.TitleBar100BereichsSummenProtokollInfo, "Text", "[100]  Bereichs-Summen Protokoll");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='\t100\t1\t5880\tK_FIBU_003_3\t83\t3\t-100,00\t100,00') on item 'TblDiff.FlexGrid.Row1_gesamt'.", repo.TblDiff.FlexGrid.Row1_gesamtInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblDiff.FlexGrid.Row1_gesamtInfo, "AccessibleValue", "\t100\t1\t5880\tK_FIBU_003_3\t83\t3\t-100,00\t100,00");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='\t100\t1\t9910\tK_FIBU_003_1\t81\t2\t816,65\t816,66') on item 'TblDiff.FlexGrid.Row2_gesamt'.", repo.TblDiff.FlexGrid.Row2_gesamtInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblDiff.FlexGrid.Row2_gesamtInfo, "AccessibleValue", "\t100\t1\t9910\tK_FIBU_003_1\t81\t2\t816,65\t816,66");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='\t100\t1\t9910\t\t\t\t-25,00\t') on item 'TblDiff.FlexGrid.Row3_gesamt'.", repo.TblDiff.FlexGrid.Row3_gesamtInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblDiff.FlexGrid.Row3_gesamtInfo, "AccessibleValue", "\t100\t1\t9910\t\t\t\t-25,00\t");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='\t100\t1\t9920\t\t\t\t-233,33\t') on item 'TblDiff.FlexGrid.Row4_gesamt'.", repo.TblDiff.FlexGrid.Row4_gesamtInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblDiff.FlexGrid.Row4_gesamtInfo, "AccessibleValue", "\t100\t1\t9920\t\t\t\t-233,33\t");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'TblDiff.TitleBar100BereichsSummenProtokoll'.", repo.TblDiff.TitleBar100BereichsSummenProtokollInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.TblDiff.TitleBar100BereichsSummenProtokoll);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
