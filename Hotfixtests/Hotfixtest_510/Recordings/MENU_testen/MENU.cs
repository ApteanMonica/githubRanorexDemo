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

namespace Hotfixtest_510.Recordings.MENU_testen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MENU recording.
    /// </summary>
    [TestModule("fd56f51b-7409-40a8-9af5-369949c4bb16", ModuleType.Recording, 1)]
    public partial class MENU : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Hotfixtest_510.Hotfixtest_510Repository repository.
        /// </summary>
        public static global::Hotfixtest_510.Hotfixtest_510Repository repo = global::Hotfixtest_510.Hotfixtest_510Repository.Instance;

        static MENU instance = new MENU();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MENU()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MENU Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormWorkplace1.Ausfuehrdialog' at Center.", repo.FormWorkplace1.AusfuehrdialogInfo, new RecordItemIndex(0));
            repo.FormWorkplace1.Ausfuehrdialog.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+R' Press with focus on 'FormWorkplace1.Ausfuehrdialog'.", repo.FormWorkplace1.AusfuehrdialogInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FormWorkplace1.Ausfuehrdialog);
            Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Programm.Text1001' at Center.", repo.Programm.Text1001Info, new RecordItemIndex(2));
            repo.Programm.Text1001.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '@E_BSK' with focus on 'Programm.Text1001'.", repo.Programm.Text1001Info, new RecordItemIndex(3));
            repo.Programm.Text1001.EnsureVisible();
            Keyboard.Press("@E_BSK");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(4));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'Form100RSREFDBRs2Version.Bestellungen'", repo.Form100RSREFDBRs2Version.BestellungenInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.Form100RSREFDBRs2Version.BestellungenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Form100RSREFDBRs2Version.Bestellungen'.", repo.Form100RSREFDBRs2Version.BestellungenInfo, new RecordItemIndex(6));
            Validate.Exists(repo.Form100RSREFDBRs2Version.BestellungenInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+R' Press with focus on 'FormWorkplace1.Ausfuehrdialog'.", repo.FormWorkplace1.AusfuehrdialogInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.FormWorkplace1.Ausfuehrdialog);
            Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Programm.Text1001' at Center.", repo.Programm.Text1001Info, new RecordItemIndex(8));
            repo.Programm.Text1001.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '@B_KTO' with focus on 'Programm.Text1001'.", repo.Programm.Text1001Info, new RecordItemIndex(9));
            repo.Programm.Text1001.EnsureVisible();
            Keyboard.Press("@B_KTO");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(10));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'Form100RSREFDBRs2Version.Sachkonten'", repo.Form100RSREFDBRs2Version.SachkontenInfo, new ActionTimeout(60000), new RecordItemIndex(11));
            repo.Form100RSREFDBRs2Version.SachkontenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Form100RSREFDBRs2Version.Sachkonten'.", repo.Form100RSREFDBRs2Version.SachkontenInfo, new RecordItemIndex(12));
            Validate.Exists(repo.Form100RSREFDBRs2Version.SachkontenInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
