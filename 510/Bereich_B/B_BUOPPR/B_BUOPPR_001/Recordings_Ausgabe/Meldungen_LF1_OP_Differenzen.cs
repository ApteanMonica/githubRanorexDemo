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
    ///The Meldungen_LF1_OP_Differenzen recording.
    /// </summary>
    [TestModule("952a851d-3dc9-4fe5-a9c3-5db450731b89", ModuleType.Recording, 1)]
    public partial class Meldungen_LF1_OP_Differenzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Meldungen_LF1_OP_Differenzen instance = new Meldungen_LF1_OP_Differenzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldungen_LF1_OP_Differenzen()
        {
            Meldung_OP_Diff_1_LF_1 = "";
            Meldung_OP_Diff_2_LF_1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldungen_LF1_OP_Differenzen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Meldung_OP_Diff_1_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Meldung_OP_Diff_1_LF_1.
        /// </summary>
        [TestVariable("0741d338-a965-4660-8002-cf5de7fd87ea")]
        public string Meldung_OP_Diff_1_LF_1
        {
            get { return _Meldung_OP_Diff_1_LF_1; }
            set { _Meldung_OP_Diff_1_LF_1 = value; }
        }

        string _Meldung_OP_Diff_2_LF_1;

        /// <summary>
        /// Gets or sets the value of variable Meldung_OP_Diff_2_LF_1.
        /// </summary>
        [TestVariable("89bc8224-0a74-4feb-b71d-b8f15bac44ed")]
        public string Meldung_OP_Diff_2_LF_1
        {
            get { return _Meldung_OP_Diff_2_LF_1; }
            set { _Meldung_OP_Diff_2_LF_1 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Meldung_OP_Diff_1_LF_1) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", Meldung_OP_Diff_1_LF_1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0_OK' at Center.", repo.DlgMessageBox.Button0_OKInfo, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0_OK.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Meldung_OP_Diff_2_LF_1) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", Meldung_OP_Diff_2_LF_1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0_OK' at Center.", repo.DlgMessageBox.Button0_OKInfo, new RecordItemIndex(5));
            repo.DlgMessageBox.Button0_OK.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
