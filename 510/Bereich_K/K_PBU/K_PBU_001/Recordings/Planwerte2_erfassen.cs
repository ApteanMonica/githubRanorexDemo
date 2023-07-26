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
    ///The Planwerte2_erfassen recording.
    /// </summary>
    [TestModule("57cf5b28-96e5-4b7a-8657-a6c81b63de29", ModuleType.Recording, 1)]
    public partial class Planwerte2_erfassen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_PBU_001.K_PBU_001Repository repository.
        /// </summary>
        public static global::K_PBU_001.K_PBU_001Repository repo = global::K_PBU_001.K_PBU_001Repository.Instance;

        static Planwerte2_erfassen instance = new Planwerte2_erfassen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Planwerte2_erfassen()
        {
            Konto2 = "0100";
            Kostentraeger2 = "200";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Planwerte2_erfassen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Konto2;

        /// <summary>
        /// Gets or sets the value of variable Konto2.
        /// </summary>
        [TestVariable("f83b68da-1548-4838-a77d-7d86a8e37a2f")]
        public string Konto2
        {
            get { return _Konto2; }
            set { _Konto2 = value; }
        }

        string _Kostentraeger2;

        /// <summary>
        /// Gets or sets the value of variable Kostentraeger2.
        /// </summary>
        [TestVariable("9f7c30c4-06ea-4c0a-a3fc-747744c0ad08")]
        public string Kostentraeger2
        {
            get { return _Kostentraeger2; }
            set { _Kostentraeger2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'TblK.FlexGrid.Row_1.Row1Column0' at Center.", repo.TblK.FlexGrid.Row_1.Row1Column0Info, new RecordItemIndex(0));
            repo.TblK.FlexGrid.Row_1.Row1Column0.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KPBU.ZeileEinfuegen' at Center.", repo.KPBU.ZeileEinfuegenInfo, new RecordItemIndex(1));
            repo.KPBU.ZeileEinfuegen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblK.FlexGrid.Row_2.Row2'", repo.TblK.FlexGrid.Row_2.Row2Info, new ActionTimeout(60000), new RecordItemIndex(2));
            repo.TblK.FlexGrid.Row_2.Row2Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.FlexGrid.Row_2.ColKtoNrRow2' at Center.", repo.TblK.FlexGrid.Row_2.ColKtoNrRow2Info, new RecordItemIndex(3));
            repo.TblK.FlexGrid.Row_2.ColKtoNrRow2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Konto2' with focus on 'TblK.FlexGrid.Row_2.ColKtoNrRow2'.", repo.TblK.FlexGrid.Row_2.ColKtoNrRow2Info, new RecordItemIndex(4));
            repo.TblK.FlexGrid.Row_2.ColKtoNrRow2.PressKeys(Konto2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kostentraeger2' with focus on 'TblK.FlexGrid.Row_2.ColKs2NrRow2'.", repo.TblK.FlexGrid.Row_2.ColKs2NrRow2Info, new RecordItemIndex(6));
            repo.TblK.FlexGrid.Row_2.ColKs2NrRow2.PressKeys(Kostentraeger2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}