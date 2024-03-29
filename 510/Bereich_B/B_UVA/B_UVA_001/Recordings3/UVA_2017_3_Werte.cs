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

namespace B_UVA_001.Recordings3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_2017_3_Werte recording.
    /// </summary>
    [TestModule("03991de5-5b82-4698-a12d-c6038ee4e7bf", ModuleType.Recording, 1)]
    public partial class UVA_2017_3_Werte : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_001.B_UVA_001Repository repository.
        /// </summary>
        public static global::B_UVA_001.B_UVA_001Repository repo = global::B_UVA_001.B_UVA_001Repository.Instance;

        static UVA_2017_3_Werte instance = new UVA_2017_3_Werte();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_2017_3_Werte()
        {
            UVA_Jahr_2017 = "2017";
            UVA_Monat_3 = "3";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_2017_3_Werte Instance
        {
            get { return instance; }
        }

#region Variables

        string _UVA_Jahr_2017;

        /// <summary>
        /// Gets or sets the value of variable UVA_Jahr_2017.
        /// </summary>
        [TestVariable("bc28d5f4-8c85-4d4d-85ea-c8c4b1af38f7")]
        public string UVA_Jahr_2017
        {
            get { return _UVA_Jahr_2017; }
            set { _UVA_Jahr_2017 = value; }
        }

        string _UVA_Monat_3;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_3.
        /// </summary>
        [TestVariable("67c0dd13-8402-4b20-ad6b-f4fb90a3f292")]
        public string UVA_Monat_3
        {
            get { return _UVA_Monat_3; }
            set { _UVA_Monat_3 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmUVAW.TitleBar100UVAWerte'.", repo.FrmUVAW.TitleBar100UVAWerteInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmUVAW.TitleBar100UVAWerteInfo);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$UVA_Jahr_2017' on item 'FrmUVAW._UVA_Jahr_'.", repo.FrmUVAW._UVA_Jahr_Info, new RecordItemIndex(1));
            repo.FrmUVAW._UVA_Jahr_.Element.SetAttributeValue("Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$UVA_Monat_3' on item 'FrmUVAW._UVA_Monat_'.", repo.FrmUVAW._UVA_Monat_Info, new RecordItemIndex(2));
            repo.FrmUVAW._UVA_Monat_.Element.SetAttributeValue("Text", UVA_Monat_3);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmUVAW._UVA_Monat_'.", repo.FrmUVAW._UVA_Monat_Info, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.FrmUVAW._UVA_Monat_);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'FrmUVAW._UVA_Jahr_'.", repo.FrmUVAW._UVA_Jahr_Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmUVAW._UVA_Jahr_Info, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_3) on item 'FrmUVAW._UVA_Monat_'.", repo.FrmUVAW._UVA_Monat_Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmUVAW._UVA_Monat_Info, "Text", UVA_Monat_3);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAW.PbCommonRechnen' at Center.", repo.FrmUVAW.PbCommonRechnenInfo, new RecordItemIndex(7));
            repo.FrmUVAW.PbCommonRechnen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'UVA-Werte berechnen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "UVA-Werte berechnen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Für dieses Jahr/Periode wurde bereits eine\r\nErmittlung der UVA-Werte durchgeführt!\r\n\r\nSollen diese Werte gelöscht und neu ermittelt werden?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Für dieses Jahr/Periode wurde bereits eine\r\nErmittlung der UVA-Werte durchgeführt!\r\n\r\nSollen diese Werte gelöscht und neu ermittelt werden?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'FrmUVAW._UVA_Jahr_'.", repo.FrmUVAW._UVA_Jahr_Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmUVAW._UVA_Jahr_Info, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_3) on item 'FrmUVAW._UVA_Monat_'.", repo.FrmUVAW._UVA_Monat_Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmUVAW._UVA_Monat_Info, "Text", UVA_Monat_3);
            
            // 1. Zeile als Stichprobe überprüfen
            Report.Log(ReportLevel.Info, "Validation", "1. Zeile als Stichprobe überprüfen\r\nValidating AttributeEqual (Text='\t\t200\t*\tE10\tEWSt 10% KZ073/KZ065 (KZ070)\tE\t1.000,00\t10,00\t100,00\t2017\t3\t0,00\t100,00\t0\t\tE10\t') on item 'FrmUVAW.FlexGrid_UVA_Werte_Row1'.", repo.FrmUVAW.FlexGrid_UVA_Werte_Row1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmUVAW.FlexGrid_UVA_Werte_Row1Info, "Text", "\t\t200\t*\tE10\tEWSt 10% KZ073/KZ065 (KZ070)\tE\t1.000,00\t10,00\t100,00\t2017\t3\t0,00\t100,00\t0\t\tE10\t");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='120,08') on item 'FrmUVAW.ColUvawBasisRow0'.", repo.FrmUVAW.ColUvawBasisRow0Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmUVAW.ColUvawBasisRow0Info, "Text", "120,08");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='140,82') on item 'FrmUVAW.ColUvawSteuerRow0'.", repo.FrmUVAW.ColUvawSteuerRow0Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmUVAW.ColUvawSteuerRow0Info, "Text", "140,82");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
