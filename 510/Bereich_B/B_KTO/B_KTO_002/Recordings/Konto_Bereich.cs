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

namespace B_KTO_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Konto_Bereich recording.
    /// </summary>
    [TestModule("c161bd81-3a3a-43c2-8e08-ad74ea5bb954", ModuleType.Recording, 1)]
    public partial class Konto_Bereich : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTO_002.B_KTO_002Repository repository.
        /// </summary>
        public static global::B_KTO_002.B_KTO_002Repository repo = global::B_KTO_002.B_KTO_002Repository.Instance;

        static Konto_Bereich instance = new Konto_Bereich();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Konto_Bereich()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Konto_Bereich Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.PicTabs.Bereiche' at Center.", repo.FrmKto.PicTabs.BereicheInfo, new RecordItemIndex(0));
            repo.FrmKto.PicTabs.Bereiche.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.PicTabs.Kostenstelle' at Center.", repo.FrmKto.PicTabs.KostenstelleInfo, new RecordItemIndex(1));
            repo.FrmKto.PicTabs.Kostenstelle.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'P' with focus on 'FrmKto.PicTabs.Kostenstelle'.", repo.FrmKto.PicTabs.KostenstelleInfo, new RecordItemIndex(2));
            repo.FrmKto.PicTabs.Kostenstelle.EnsureVisible();
            Keyboard.Press("P");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmKto.PicTabs.Kostenstelle'.", repo.FrmKto.PicTabs.KostenstelleInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.FrmKto.PicTabs.Kostenstelle);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.PicTabs.Kostentraeger' at Center.", repo.FrmKto.PicTabs.KostentraegerInfo, new RecordItemIndex(4));
            repo.FrmKto.PicTabs.Kostentraeger.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'W' with focus on 'FrmKto.PicTabs.Kostentraeger'.", repo.FrmKto.PicTabs.KostentraegerInfo, new RecordItemIndex(5));
            repo.FrmKto.PicTabs.Kostentraeger.EnsureVisible();
            Keyboard.Press("W");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmKto.PicTabs.Kostentraeger'.", repo.FrmKto.PicTabs.KostentraegerInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.FrmKto.PicTabs.Kostentraeger);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.Speichern' at Center.", repo.FrmKto.SpeichernInfo, new RecordItemIndex(7));
            repo.FrmKto.Speichern.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='P') on item 'FrmKto.PicTabs.Kostenstelle'.", repo.FrmKto.PicTabs.KostenstelleInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmKto.PicTabs.KostenstelleInfo, "Text", "P");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='W') on item 'FrmKto.PicTabs.Kostentraeger'.", repo.FrmKto.PicTabs.KostentraegerInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmKto.PicTabs.KostentraegerInfo, "Text", "W");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
