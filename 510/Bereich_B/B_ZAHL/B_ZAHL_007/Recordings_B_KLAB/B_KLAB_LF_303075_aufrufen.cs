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

namespace B_ZAHL_007.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_KLAB_LF_303075_aufrufen recording.
    /// </summary>
    [TestModule("956184f4-f6c7-4c4f-95ce-699205935842", ModuleType.Recording, 1)]
    public partial class B_KLAB_LF_303075_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_007.B_ZAHL_007Repository repository.
        /// </summary>
        public static global::B_ZAHL_007.B_ZAHL_007Repository repo = global::B_ZAHL_007.B_ZAHL_007Repository.Instance;

        static B_KLAB_LF_303075_aufrufen instance = new B_KLAB_LF_303075_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_KLAB_LF_303075_aufrufen()
        {
            LF_303075 = "303075";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_KLAB_LF_303075_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303075;

        /// <summary>
        /// Gets or sets the value of variable LF_303075.
        /// </summary>
        [TestVariable("5d5b0184-9254-4d16-90c0-1c3c749774d6")]
        public string LF_303075
        {
            get { return _LF_303075; }
            set { _LF_303075 = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'TblBuop.TitleBar100OPs303027Saldo2500'.", repo.TblBuop.TitleBar100OPs303027Saldo2500Info, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.TblBuop.TitleBar100OPs303027Saldo2500);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '' on item 'FrmKlAb.Konto'.", repo.FrmKlAb.KontoInfo, new RecordItemIndex(1));
            repo.FrmKlAb.Konto.Element.SetAttributeValue("Text", "");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LF_303075' with focus on 'FrmKlAb.Konto'.", repo.FrmKlAb.KontoInfo, new RecordItemIndex(2));
            repo.FrmKlAb.Konto.PressKeys(LF_303075);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlAb_Suchmaske.PbEdit_Suchmaske' at Center.", repo.FrmKlAb_Suchmaske.PbEdit_SuchmaskeInfo, new RecordItemIndex(4));
            repo.FrmKlAb_Suchmaske.PbEdit_Suchmaske.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKlAb.Konto'", repo.FrmKlAb.KontoInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.FrmKlAb.KontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303075) on item 'FrmKlAb.Konto'.", repo.FrmKlAb.KontoInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmKlAb.KontoInfo, "Text", LF_303075);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlAb.PbOPLaden' at Center.", repo.FrmKlAb.PbOPLadenInfo, new RecordItemIndex(7));
            repo.FrmKlAb.PbOPLaden.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblBuop.TitleBar100OPs303027Saldo2500'", repo.TblBuop.TitleBar100OPs303027Saldo2500Info, new ActionTimeout(60000), new RecordItemIndex(8));
            repo.TblBuop.TitleBar100OPs303027Saldo2500Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303075) on item 'TblBuop.TitleBar100OPs303027Saldo2500'.", repo.TblBuop.TitleBar100OPs303027Saldo2500Info, new RecordItemIndex(9));
            Validate.AttributeContains(repo.TblBuop.TitleBar100OPs303027Saldo2500Info, "Text", LF_303075);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}