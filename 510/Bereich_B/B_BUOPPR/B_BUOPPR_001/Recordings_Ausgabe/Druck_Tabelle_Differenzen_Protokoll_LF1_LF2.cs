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

namespace B_BUOPPR_001.Recordings_Ausgabe
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Druck_Tabelle_Differenzen_Protokoll_LF1_LF2 recording.
    /// </summary>
    [TestModule("53648385-0646-40dc-a862-9892096dbf4c", ModuleType.Recording, 1)]
    public partial class Druck_Tabelle_Differenzen_Protokoll_LF1_LF2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Druck_Tabelle_Differenzen_Protokoll_LF1_LF2 instance = new Druck_Tabelle_Differenzen_Protokoll_LF1_LF2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Druck_Tabelle_Differenzen_Protokoll_LF1_LF2()
        {
            Druck_Tabelle_OP_Diff_1_LF_1 = "";
            Druck_Tabelle_OP_Diff_2_LF_1 = "";
            Druck_Tabelle_Salden_Diff_LF_1 = "";
            Druck_Tabelle_Salden_Diff_LF_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Druck_Tabelle_Differenzen_Protokoll_LF1_LF2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Druck_Tabelle_OP_Diff_1_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Druck_Tabelle_OP_Diff_1_LF_1.
        /// </summary>
        [TestVariable("122ed70e-f4e3-4544-886d-78a6b4b3f772")]
        public string Druck_Tabelle_OP_Diff_1_LF_1
        {
            get { return _Druck_Tabelle_OP_Diff_1_LF_1; }
            set { _Druck_Tabelle_OP_Diff_1_LF_1 = value; }
        }

        string _Druck_Tabelle_OP_Diff_2_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Druck_Tabelle_OP_Diff_2_LF_1.
        /// </summary>
        [TestVariable("2f56f451-4a14-4178-8d26-e23e91369edf")]
        public string Druck_Tabelle_OP_Diff_2_LF_1
        {
            get { return _Druck_Tabelle_OP_Diff_2_LF_1; }
            set { _Druck_Tabelle_OP_Diff_2_LF_1 = value; }
        }

        string _Druck_Tabelle_Salden_Diff_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Druck_Tabelle_Salden_Diff_LF_1.
        /// </summary>
        [TestVariable("d7c661db-fc7c-4be9-a8db-1377ef82f552")]
        public string Druck_Tabelle_Salden_Diff_LF_1
        {
            get { return _Druck_Tabelle_Salden_Diff_LF_1; }
            set { _Druck_Tabelle_Salden_Diff_LF_1 = value; }
        }

        string _Druck_Tabelle_Salden_Diff_LF_2;

        /// <summary>
        /// Gets or sets the value of variable Druck_Tabelle_Salden_Diff_LF_2.
        /// </summary>
        [TestVariable("8a333ec0-297b-4a1c-9732-d994a1311f5b")]
        public string Druck_Tabelle_Salden_Diff_LF_2
        {
            get { return _Druck_Tabelle_Salden_Diff_LF_2; }
            set { _Druck_Tabelle_Salden_Diff_LF_2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDrucken.PbExport' at Center.", repo.DlgDrucken.PbExportInfo, new RecordItemIndex(0));
            repo.DlgDrucken.PbExport.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Tabelle' with focus on 'DlgDrucken.PbExport'.", repo.DlgDrucken.PbExportInfo, new RecordItemIndex(1));
            repo.DlgDrucken.PbExport.PressKeys("Tabelle");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblDrucken.TitleBar100ProtokollOPSaldenpruefu'", repo.TblDrucken.TitleBar100ProtokollOPSaldenpruefuInfo, new ActionTimeout(60000), new RecordItemIndex(2));
            repo.TblDrucken.TitleBar100ProtokollOPSaldenpruefuInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Protokoll OP-Saldenprüfung') on item 'TblDrucken.TitleBar100ProtokollOPSaldenpruefu'.", repo.TblDrucken.TitleBar100ProtokollOPSaldenpruefuInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblDrucken.TitleBar100ProtokollOPSaldenpruefuInfo, "Text", "Protokoll OP-Saldenprüfung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (AccessibleValue>$Druck_Tabelle_OP_Diff_1_LF_1) on item 'TblDrucken.FlexGrid.Row1'.", repo.TblDrucken.FlexGrid.Row1Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblDrucken.FlexGrid.Row1Info, "AccessibleValue", Druck_Tabelle_OP_Diff_1_LF_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Druck_Tabelle_OP_Diff_2_LF_1) on item 'TblDrucken.FlexGrid.Row2'.", repo.TblDrucken.FlexGrid.Row2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblDrucken.FlexGrid.Row2Info, "AccessibleValue", Druck_Tabelle_OP_Diff_2_LF_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Druck_Tabelle_Salden_Diff_LF_1) on item 'TblDrucken.FlexGrid.Row3'.", repo.TblDrucken.FlexGrid.Row3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblDrucken.FlexGrid.Row3Info, "AccessibleValue", Druck_Tabelle_Salden_Diff_LF_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Druck_Tabelle_Salden_Diff_LF_2) on item 'TblDrucken.FlexGrid.Row4'.", repo.TblDrucken.FlexGrid.Row4Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblDrucken.FlexGrid.Row4Info, "AccessibleValue", Druck_Tabelle_Salden_Diff_LF_2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'TblDrucken.TitleBar100ProtokollOPSaldenpruefu'.", repo.TblDrucken.TitleBar100ProtokollOPSaldenpruefuInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.TblDrucken.TitleBar100ProtokollOPSaldenpruefu);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'DlgDrucken.TitleBar100DruckeProtokollOPSalde'.", repo.DlgDrucken.TitleBar100DruckeProtokollOPSaldeInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.DlgDrucken.TitleBar100DruckeProtokollOPSalde);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
