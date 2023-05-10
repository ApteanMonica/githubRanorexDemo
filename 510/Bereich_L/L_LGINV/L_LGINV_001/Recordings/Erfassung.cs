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

namespace L_LGINV_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Erfassung recording.
    /// </summary>
    [TestModule("8deb4642-1925-41ac-84b2-9589e3ff77dd", ModuleType.Recording, 1)]
    public partial class Erfassung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_LGINV_001.L_LGINV_001Repository repository.
        /// </summary>
        public static global::L_LGINV_001.L_LGINV_001Repository repo = global::L_LGINV_001.L_LGINV_001Repository.Instance;

        static Erfassung instance = new Erfassung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Erfassung()
        {
            Inventur_Nr = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Erfassung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Inventur_Nr;

        /// <summary>
        /// Gets or sets the value of variable Inventur_Nr.
        /// </summary>
        [TestVariable("b411783c-e6a0-4a19-bfb2-909f6057d5ea")]
        public string Inventur_Nr
        {
            get { return _Inventur_Nr; }
            set { _Inventur_Nr = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotEqual (Text!='0') on item 'MdiLginv.ZaehlungBeendet'.", repo.MdiLginv.ZaehlungBeendetInfo, new RecordItemIndex(0));
            Validate.AttributeNotEqual(repo.MdiLginv.ZaehlungBeendetInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLginv.PbCommonErfassung' at Center.", repo.MdiLginv.PbCommonErfassungInfo, new RecordItemIndex(1));
            repo.MdiLginv.PbCommonErfassung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Inventur_Nr' with focus on 'TblErfassung.InventurNr'.", repo.TblErfassung.InventurNrInfo, new RecordItemIndex(2));
            repo.TblErfassung.InventurNr.EnsureVisible();
            Keyboard.Press(Inventur_Nr);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.RibbonBar.PbDataAccessLoad' at Center.", repo.TblErfassung.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(3));
            repo.TblErfassung.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.RibbonBar.PbDataAccessSave' at Center.", repo.TblErfassung.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(4));
            repo.TblErfassung.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row1' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row1Info, new RecordItemIndex(5));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad0}' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(6));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("{NumPad1}{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row2' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row2Info, new RecordItemIndex(7));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad6}' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(8));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("{NumPad6}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row3' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row3Info, new RecordItemIndex(9));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row3.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(10));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row4' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row4Info, new RecordItemIndex(11));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row4.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(12));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row5' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row5Info, new RecordItemIndex(13));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row5.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(14));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row6' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row6Info, new RecordItemIndex(15));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row6.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(16));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row7' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row7Info, new RecordItemIndex(17));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row7.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad4}' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(18));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("{NumPad4}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.FlexGrid.ColLgpbIerfass1Row8' at Center.", repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row8Info, new RecordItemIndex(19));
            repo.TblErfassung.FlexGrid.ColLgpbIerfass1Row8.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad2}' with focus on 'TblErfassung'.", repo.TblErfassung.SelfInfo, new RecordItemIndex(20));
            repo.TblErfassung.Self.EnsureVisible();
            Keyboard.Press("{NumPad2}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErfassung.RibbonBar.PbDataAccessSave' at Center.", repo.TblErfassung.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(21));
            repo.TblErfassung.RibbonBar.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
