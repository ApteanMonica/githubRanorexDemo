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

namespace E_FIBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UEberleitung recording.
    /// </summary>
    [TestModule("ce55703d-c0c8-442a-b318-d6ae8aa634ec", ModuleType.Recording, 1)]
    public partial class UEberleitung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_FIBU_001.E_FIBU_001Repository repository.
        /// </summary>
        public static global::E_FIBU_001.E_FIBU_001Repository repo = global::E_FIBU_001.E_FIBU_001Repository.Instance;

        static UEberleitung instance = new UEberleitung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UEberleitung()
        {
            Rechnung = "301900003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UEberleitung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Rechnung;

        /// <summary>
        /// Gets or sets the value of variable Rechnung.
        /// </summary>
        [TestVariable("353eedf2-ce8e-4d0e-a8c8-2156fd65f9b1")]
        public string Rechnung
        {
            get { return _Rechnung; }
            set { _Rechnung = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Rechnung' on item 'TblFibu.RechNrVon'.", repo.TblFibu.RechNrVonInfo, new RecordItemIndex(0));
            repo.TblFibu.RechNrVon.Element.SetAttributeValue("AccessibleValue", Rechnung);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'TblFibu.RechNrVon'.", repo.TblFibu.RechNrVonInfo, new RecordItemIndex(1));
            repo.TblFibu.RechNrVon.Focus();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.PbOk' at Center.", repo.DlgListBox.PbOkInfo, new RecordItemIndex(3));
            repo.DlgListBox.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Rechnung' on item 'TblFibu.RechNrBis'.", repo.TblFibu.RechNrBisInfo, new RecordItemIndex(4));
            repo.TblFibu.RechNrBis.Element.SetAttributeValue("AccessibleValue", Rechnung);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'TblFibu.RechNrBis'.", repo.TblFibu.RechNrBisInfo, new RecordItemIndex(5));
            repo.TblFibu.RechNrBis.Focus();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFibu.PbDataAccessLoad' at Center.", repo.TblFibu.PbDataAccessLoadInfo, new RecordItemIndex(7));
            repo.TblFibu.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFibu.CbProtokoll' at Center.", repo.TblFibu.CbProtokollInfo, new RecordItemIndex(8));
            repo.TblFibu.CbProtokoll.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'TblFibu.CbProtokoll'.", repo.TblFibu.CbProtokollInfo, new RecordItemIndex(9));
            repo.TblFibu.CbProtokoll.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TblFibu.CbProtokoll'.", repo.TblFibu.CbProtokollInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblFibu.CbProtokollInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Rechnung) on item 'TblFibu.ColRechNrRow1'.", repo.TblFibu.ColRechNrRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblFibu.ColRechNrRow1Info, "AccessibleValue", Rechnung);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFibu.PbCommonUeberleitung' at Center.", repo.TblFibu.PbCommonUeberleitungInfo, new RecordItemIndex(12));
            repo.TblFibu.PbCommonUeberleitung.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
