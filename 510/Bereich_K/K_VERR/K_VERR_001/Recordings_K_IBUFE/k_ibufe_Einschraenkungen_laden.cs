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

namespace K_VERR_001.Recordings_K_IBUFE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The k_ibufe_Einschraenkungen_laden recording.
    /// </summary>
    [TestModule("98b3ba54-fc18-4e51-84f4-b5bfac5ada2f", ModuleType.Recording, 1)]
    public partial class k_ibufe_Einschraenkungen_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERR_001.K_VERR_001Repository repository.
        /// </summary>
        public static global::K_VERR_001.K_VERR_001Repository repo = global::K_VERR_001.K_VERR_001Repository.Instance;

        static k_ibufe_Einschraenkungen_laden instance = new k_ibufe_Einschraenkungen_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public k_ibufe_Einschraenkungen_laden()
        {
            Jahr = "2020";
            Periode = "6";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static k_ibufe_Einschraenkungen_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("b49334fc-c3f3-4920-a8e2-622ac8b2194d")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Periode;

        /// <summary>
        /// Gets or sets the value of variable Periode.
        /// </summary>
        [TestVariable("c01406ed-8dec-4c5a-939b-370769d34897")]
        public string Periode
        {
            get { return _Periode; }
            set { _Periode = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.ToolBar.Planvariante'.", repo.TblIbufe.ToolBar.PlanvarianteInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.PlanvarianteInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblIbufe.ToolBar.Jahr_von' at Center.", repo.TblIbufe.ToolBar.Jahr_vonInfo, new RecordItemIndex(1));
            repo.TblIbufe.ToolBar.Jahr_von.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblIbufe.ToolBar.Jahr_von'.", repo.TblIbufe.ToolBar.Jahr_vonInfo, new RecordItemIndex(2));
            repo.TblIbufe.ToolBar.Jahr_von.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periode' with focus on 'TblIbufe.ToolBar.Periode_von'.", repo.TblIbufe.ToolBar.Periode_vonInfo, new RecordItemIndex(4));
            repo.TblIbufe.ToolBar.Periode_von.PressKeys(Periode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblIbufe.ToolBar.Jahr_bis'.", repo.TblIbufe.ToolBar.Jahr_bisInfo, new RecordItemIndex(6));
            //repo.TblIbufe.ToolBar.Jahr_bis.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periode' with focus on 'TblIbufe.ToolBar.Periode_bis_530_510_accessiblerole'.", repo.TblIbufe.ToolBar.Periode_bis_530_510_accessibleroleInfo, new RecordItemIndex(8));
            repo.TblIbufe.ToolBar.Periode_bis_530_510_accessiblerole.PressKeys(Periode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.ToolBar.Planvariante'.", repo.TblIbufe.ToolBar.PlanvarianteInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.PlanvarianteInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'TblIbufe.ToolBar.Jahr_von'.", repo.TblIbufe.ToolBar.Jahr_vonInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Jahr_vonInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'TblIbufe.ToolBar.Jahr_bis'.", repo.TblIbufe.ToolBar.Jahr_bisInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Jahr_bisInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode) on item 'TblIbufe.ToolBar.Periode_von'.", repo.TblIbufe.ToolBar.Periode_vonInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Periode_vonInfo, "Text", Periode);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode) on item 'TblIbufe.ToolBar.Periode_bis_530_510_accessiblerole'.", repo.TblIbufe.ToolBar.Periode_bis_530_510_accessibleroleInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblIbufe.ToolBar.Periode_bis_530_510_accessibleroleInfo, "Text", Periode);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblIbufe.PbDataAccessLaden' at Center.", repo.TblIbufe.PbDataAccessLadenInfo, new RecordItemIndex(15));
            repo.TblIbufe.PbDataAccessLaden.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblIbufe.Row1'", repo.TblIbufe.Row1Info, new ActionTimeout(60000), new RecordItemIndex(16));
            repo.TblIbufe.Row1Info.WaitForExists(60000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
