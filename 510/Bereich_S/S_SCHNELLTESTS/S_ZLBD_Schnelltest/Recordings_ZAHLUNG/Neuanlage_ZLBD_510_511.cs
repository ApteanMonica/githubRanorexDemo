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

namespace S_ZLBD_Schnelltest.Recordings_ZAHLUNG
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neuanlage_ZLBD_510_511 recording.
    /// </summary>
    [TestModule("a865a70a-3335-461e-9f5d-28a74d59ac79", ModuleType.Recording, 1)]
    public partial class Neuanlage_ZLBD_510_511 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ZLBD_Schnelltest.S_ZLBD_SchnelltestRepository repository.
        /// </summary>
        public static global::S_ZLBD_Schnelltest.S_ZLBD_SchnelltestRepository repo = global::S_ZLBD_Schnelltest.S_ZLBD_SchnelltestRepository.Instance;

        static Neuanlage_ZLBD_510_511 instance = new Neuanlage_ZLBD_510_511();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_ZLBD_510_511()
        {
            ZLBD_CD_NEU = "TST";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_ZLBD_510_511 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ZLBD_CD_NEU.
        /// </summary>
        [TestVariable("41f0a088-afd3-4526-a1a1-07e3c2ca7018")]
        public string ZLBD_CD_NEU
        {
            get { return repo.ZLBD_CD_NEU; }
            set { repo.ZLBD_CD_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZlbd.Maximieren' at Center.", repo.TblZlbd.MaximierenInfo, new RecordItemIndex(0));
            repo.TblZlbd.Maximieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'TblZlbd.FlexGrid' at Center.", repo.TblZlbd.FlexGridInfo, new RecordItemIndex(1));
            repo.TblZlbd.FlexGrid.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SZLBD.ZeileEinfuegen'", repo.SZLBD.ZeileEinfuegenInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SZLBD.ZeileEinfuegenInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SZLBD.ZeileEinfuegen' at Center.", repo.SZLBD.ZeileEinfuegenInfo, new RecordItemIndex(3));
            repo.SZLBD.ZeileEinfuegen.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ZLBD_CD_NEU'.", new RecordItemIndex(4));
            Keyboard.Press(ZLBD_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ZLBD_CD_NEU) on item 'TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEU'.", repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEUInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEUInfo, "Text", ZLBD_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7'.", new RecordItemIndex(7));
            Keyboard.Press("7");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3,00'.", new RecordItemIndex(9));
            Keyboard.Press("3,00");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20'.", new RecordItemIndex(13));
            Keyboard.Press("20");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7 Tage 3%, 20 Tage netto'.", new RecordItemIndex(15));
            Keyboard.Press("7 Tage 3%, 20 Tage netto");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(16));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
