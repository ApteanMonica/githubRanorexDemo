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
    ///The Einstellungen_zuruecksetzen recording.
    /// </summary>
    [TestModule("99ad8041-e987-436e-b8a7-083fb4061cea", ModuleType.Recording, 1)]
    public partial class Einstellungen_zuruecksetzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_PBU_001.K_PBU_001Repository repository.
        /// </summary>
        public static global::K_PBU_001.K_PBU_001Repository repo = global::K_PBU_001.K_PBU_001Repository.Instance;

        static Einstellungen_zuruecksetzen instance = new Einstellungen_zuruecksetzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einstellungen_zuruecksetzen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einstellungen_zuruecksetzen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.PbCommonNeu' at Center.", repo.TblK.PbCommonNeuInfo, new RecordItemIndex(0));
            repo.TblK.PbCommonNeu.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'False' on item 'TblK.CbBereich1'.", repo.TblK.CbBereich1Info, new RecordItemIndex(1));
            repo.TblK.CbBereich1.Element.SetAttributeValue("Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'TblK.CbBereich1'.", repo.TblK.CbBereich1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblK.CbBereich1Info, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'False' on item 'TblK.CbPos'.", repo.TblK.CbPosInfo, new RecordItemIndex(3));
            repo.TblK.CbPos.Element.SetAttributeValue("Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'TblK.CbPos'.", repo.TblK.CbPosInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblK.CbPosInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.RbMonat' at Center.", repo.TblK.RbMonatInfo, new RecordItemIndex(5));
            repo.TblK.RbMonat.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TblK.RbMonat'.", repo.TblK.RbMonatInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblK.RbMonatInfo, "Checked", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
