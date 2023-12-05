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

namespace K_PBU_001.Recordings_k_ibufe
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The K_IBUFE_Einschraenkungen_laden recording.
    /// </summary>
    [TestModule("fe247126-65bc-45a1-97b7-0cb7ee7a4ad1", ModuleType.Recording, 1)]
    public partial class K_IBUFE_Einschraenkungen_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_PBU_001.K_PBU_001Repository repository.
        /// </summary>
        public static global::K_PBU_001.K_PBU_001Repository repo = global::K_PBU_001.K_PBU_001Repository.Instance;

        static K_IBUFE_Einschraenkungen_laden instance = new K_IBUFE_Einschraenkungen_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K_IBUFE_Einschraenkungen_laden()
        {
            Jahr = "2022";
            Kostenstelle = "10";
            Kostenstelle2 = "20";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K_IBUFE_Einschraenkungen_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("6aff4b2e-f45e-4b92-9722-a06c9cb76a2e")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Kostenstelle;

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle.
        /// </summary>
        [TestVariable("6af85598-fa3f-4e27-ac13-c170368d29b6")]
        public string Kostenstelle
        {
            get { return _Kostenstelle; }
            set { _Kostenstelle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle2.
        /// </summary>
        [TestVariable("85e64b91-cf3e-4f7a-93de-4e2075b81261")]
        public string Kostenstelle2
        {
            get { return repo.Kostenstelle2; }
            set { repo.Kostenstelle2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblIbufe.PbDataAccessNeu' at Center.", repo.TblIbufe.PbDataAccessNeuInfo, new RecordItemIndex(0));
            repo.TblIbufe.PbDataAccessNeu.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblIbufe.ToolBar.Planvariante' at Center.", repo.TblIbufe.ToolBar.PlanvarianteInfo, new RecordItemIndex(1));
            repo.TblIbufe.ToolBar.Planvariante.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'TblIbufe.ToolBar.Planvariante'.", repo.TblIbufe.ToolBar.PlanvarianteInfo, new RecordItemIndex(3));
            repo.TblIbufe.ToolBar.Planvariante.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblIbufe.ToolBar.Planvariante'.", repo.TblIbufe.ToolBar.PlanvarianteInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.PlanvarianteInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblIbufe.ToolBar.Periode_von' at Center.", repo.TblIbufe.ToolBar.Periode_vonInfo, new RecordItemIndex(6));
            repo.TblIbufe.ToolBar.Periode_von.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblIbufe.ToolBar.Jahr_von'.", repo.TblIbufe.ToolBar.Jahr_vonInfo, new RecordItemIndex(7));
            repo.TblIbufe.ToolBar.Jahr_von.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'TblIbufe.ToolBar.Periode_von'.", repo.TblIbufe.ToolBar.Periode_vonInfo, new RecordItemIndex(9));
            repo.TblIbufe.ToolBar.Periode_von.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblIbufe.ToolBar.Jahr_bis'.", repo.TblIbufe.ToolBar.Jahr_bisInfo, new RecordItemIndex(11));
            repo.TblIbufe.ToolBar.Jahr_bis.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12' with focus on 'TblIbufe.ToolBar.Periode_bis'.", repo.TblIbufe.ToolBar.Periode_bisInfo, new RecordItemIndex(13));
            repo.TblIbufe.ToolBar.Periode_bis.PressKeys("12");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblIbufe.ToolBar.Kostenstelle_von_510_530_accessiblerole' at Center.", repo.TblIbufe.ToolBar.Kostenstelle_von_510_530_accessibleroleInfo, new RecordItemIndex(15));
            repo.TblIbufe.ToolBar.Kostenstelle_von_510_530_accessiblerole.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kostenstelle' with focus on 'TblIbufe.ToolBar.Kostenstelle_von_510_530_accessiblerole'.", repo.TblIbufe.ToolBar.Kostenstelle_von_510_530_accessibleroleInfo, new RecordItemIndex(16));
            repo.TblIbufe.ToolBar.Kostenstelle_von_510_530_accessiblerole.PressKeys(Kostenstelle);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kostenstelle2' with focus on 'TblIbufe.ToolBar.Kostenstellen_bis'.", repo.TblIbufe.ToolBar.Kostenstellen_bisInfo, new RecordItemIndex(18));
            repo.TblIbufe.ToolBar.Kostenstellen_bis.PressKeys(Kostenstelle2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblIbufe.ToolBar.Planvariante'.", repo.TblIbufe.ToolBar.PlanvarianteInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.PlanvarianteInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Budget') on item 'TblIbufe.ToolBar.DfPlvBez'.", repo.TblIbufe.ToolBar.DfPlvBezInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.DfPlvBezInfo, "Text", "Budget");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'TblIbufe.ToolBar.Jahr_von'.", repo.TblIbufe.ToolBar.Jahr_vonInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Jahr_vonInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'TblIbufe.ToolBar.Jahr_bis'.", repo.TblIbufe.ToolBar.Jahr_bisInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Jahr_bisInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblIbufe.ToolBar.Periode_von'.", repo.TblIbufe.ToolBar.Periode_vonInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Periode_vonInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='12') on item 'TblIbufe.ToolBar.Periode_bis'.", repo.TblIbufe.ToolBar.Periode_bisInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Periode_bisInfo, "Text", "12");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kostenstelle) on item 'TblIbufe.ToolBar.Kostenstelle_von_510_530_accessiblerole'.", repo.TblIbufe.ToolBar.Kostenstelle_von_510_530_accessibleroleInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Kostenstelle_von_510_530_accessibleroleInfo, "Text", Kostenstelle);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kostenstelle2) on item 'TblIbufe.ToolBar.Kostenstellen_bis'.", repo.TblIbufe.ToolBar.Kostenstellen_bisInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Kostenstellen_bisInfo, "Text", Kostenstelle2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblIbufe.PbDataAccessLaden' at Center.", repo.TblIbufe.PbDataAccessLadenInfo, new RecordItemIndex(28));
            repo.TblIbufe.PbDataAccessLaden.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblIbufe.Row1'", repo.TblIbufe.Row1Info, new ActionTimeout(60000), new RecordItemIndex(29));
            repo.TblIbufe.Row1Info.WaitForExists(60000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
