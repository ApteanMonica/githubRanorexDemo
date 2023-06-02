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

namespace B_ZAHL_005.Recordings_B_ZAHL
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Teilzahlung_ER051_erfassen recording.
    /// </summary>
    [TestModule("d1527718-b4a3-4558-adab-9e735f91e155", ModuleType.Recording, 1)]
    public partial class Teilzahlung_ER051_erfassen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_005.B_ZAHL_005Repository repository.
        /// </summary>
        public static global::B_ZAHL_005.B_ZAHL_005Repository repo = global::B_ZAHL_005.B_ZAHL_005Repository.Instance;

        static Teilzahlung_ER051_erfassen instance = new Teilzahlung_ER051_erfassen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Teilzahlung_ER051_erfassen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Teilzahlung_ER051_erfassen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER051 B_ZAHL_005') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColBelegRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColBelegRow3Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColBelegRow3Info, "Text", "ER051 B_ZAHL_005");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColTeilRow3' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColTeilRow3Info, new RecordItemIndex(1));
            repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColTeilRow3.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'F4' Press with focus on 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColTeilRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColTeilRow3Info, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColTeilRow3);
            Keyboard.Press(System.Windows.Forms.Keys.F4, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'DlgListBox'.", repo.DlgListBox.SelfInfo, new RecordItemIndex(3));
            repo.DlgListBox.Self.EnsureVisible();
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press with focus on 'DlgListBox'.", repo.DlgListBox.SelfInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.DlgListBox.Self);
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1200' with focus on 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColZBetragZRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColZBetragZRow3Info, new RecordItemIndex(6));
            repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColZBetragZRow3.EnsureVisible();
            Keyboard.Press("1200");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
