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

namespace B_UVA_004.Recordings_Formular
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The USt_Codes_kopieren_A20_nach_NEU recording.
    /// </summary>
    [TestModule("11a3e9a1-8dc0-4bf0-bf3c-10e26b2fc707", ModuleType.Recording, 1)]
    public partial class USt_Codes_kopieren_A20_nach_NEU : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_004.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_004.B_UVA_004Repository repo = global::B_UVA_004.B_UVA_004Repository.Instance;

        static USt_Codes_kopieren_A20_nach_NEU instance = new USt_Codes_kopieren_A20_nach_NEU();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public USt_Codes_kopieren_A20_nach_NEU()
        {
            Firma_2 = "200";
            Form_Name_A20 = "UVA-Österreich 2020";
            Form_Code_A20 = "A20";
            Form_Name_NEU = "UVA-Österreich 2023";
            Form_Code_NEU = "A23";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static USt_Codes_kopieren_A20_nach_NEU Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma_2;

        /// <summary>
        /// Gets or sets the value of variable Firma_2.
        /// </summary>
        [TestVariable("a3f1129a-212d-4df6-90c1-8c2c06b9a1ee")]
        public string Firma_2
        {
            get { return _Firma_2; }
            set { _Firma_2 = value; }
        }

        string _Form_Name_A20;

        /// <summary>
        /// Gets or sets the value of variable Form_Name_A20.
        /// </summary>
        [TestVariable("b2c95171-a7c3-4507-8e9e-ec973b1a93e8")]
        public string Form_Name_A20
        {
            get { return _Form_Name_A20; }
            set { _Form_Name_A20 = value; }
        }

        string _Form_Code_A20;

        /// <summary>
        /// Gets or sets the value of variable Form_Code_A20.
        /// </summary>
        [TestVariable("77c47fc4-cae3-4888-b9fc-6c99d93aa02c")]
        public string Form_Code_A20
        {
            get { return _Form_Code_A20; }
            set { _Form_Code_A20 = value; }
        }

        string _Form_Code_NEU;

        /// <summary>
        /// Gets or sets the value of variable Form_Code_NEU.
        /// </summary>
        [TestVariable("9843002c-83f1-4f52-a40b-a5f8b00598ae")]
        public string Form_Code_NEU
        {
            get { return _Form_Code_NEU; }
            set { _Form_Code_NEU = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Form_Name_NEU.
        /// </summary>
        [TestVariable("752bca30-470b-41d7-8a74-f8b351f27f5b")]
        public string Form_Name_NEU
        {
            get { return repo.Form_Name_NEU; }
            set { repo.Form_Name_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmUVAK.FormularKopieren'.", repo.FrmUVAK.FormularKopierenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmUVAK.FormularKopierenInfo);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute ControlText to '$Form_Name_A20' on item 'FrmUVAK.CmbUvak1'.", repo.FrmUVAK.CmbUvak1Info, new RecordItemIndex(1));
            repo.FrmUVAK.CmbUvak1.Element.SetAttributeValue("ControlText", Form_Name_A20);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmUVAK.CmbUvak1'.", repo.FrmUVAK.CmbUvak1Info, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.FrmUVAK.CmbUvak1);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Form_Name_A20) on item 'FrmUVAK.CmbUvak1'.", repo.FrmUVAK.CmbUvak1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmUVAK.CmbUvak1Info, "Text", Form_Name_A20);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute ControlText to '$Form_Name_NEU' on item 'FrmUVAK.CmbUvak2'.", repo.FrmUVAK.CmbUvak2Info, new RecordItemIndex(6));
            repo.FrmUVAK.CmbUvak2.Element.SetAttributeValue("ControlText", Form_Name_NEU);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmUVAK.CmbUvak2'.", repo.FrmUVAK.CmbUvak2Info, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.FrmUVAK.CmbUvak2);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Form_Name_NEU) on item 'FrmUVAK.CmbUvak2'.", repo.FrmUVAK.CmbUvak2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmUVAK.CmbUvak2Info, "Text", Form_Name_NEU);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAK.Text' at Center.", repo.FrmUVAK.TextInfo, new RecordItemIndex(10));
            repo.FrmUVAK.Text.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Firma_2) on item 'FrmUVAK.Text'.", repo.FrmUVAK.TextInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmUVAK.TextInfo, "Text", Firma_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmUVAK.CbNurZuordnung'.", repo.FrmUVAK.CbNurZuordnungInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmUVAK.CbNurZuordnungInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (ControlText=$Form_Name_A20) on item 'FrmUVAK.CmbUvak1'.", repo.FrmUVAK.CmbUvak1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmUVAK.CmbUvak1Info, "ControlText", Form_Name_A20);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (ControlText=$Form_Name_NEU) on item 'FrmUVAK.CmbUvak2'.", repo.FrmUVAK.CmbUvak2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmUVAK.CmbUvak2Info, "ControlText", Form_Name_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Form_Code_A20) on item 'FrmUVAK.DfCode1'.", repo.FrmUVAK.DfCode1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmUVAK.DfCode1Info, "Text", Form_Code_A20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAK.PbUVAKKopieren' at Center.", repo.FrmUVAK.PbUVAKKopierenInfo, new RecordItemIndex(16));
            repo.FrmUVAK.PbUVAKKopieren.Click();
            
            // nur für Test nötig, wenn Zuordnungen bereits vorhanden
            //Report.Log(ReportLevel.Info, "Validation", "nur für Test nötig, wenn Zuordnungen bereits vorhanden\r\nValidating AttributeEqual (Text='\r\r\nZuordnungen sind bei Firma 200 in Formular A22 bereits vorhanden!\r\n\r\nDie bestehende Daten werden überschrieben!\r\n\r\nTrotzdem kopieren?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(17));
            //Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "\r\r\nZuordnungen sind bei Firma 200 in Formular A22 bereits vorhanden!\r\n\r\nDie bestehende Daten werden überschrieben!\r\n\r\nTrotzdem kopieren?");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(18));
            //repo.DlgMessageBox.Button0.Click();
            
            // Wenn Zurodnungen bereits vorhanden sind durch Tests
            Report.Log(ReportLevel.Info, "Keyboard", "Wenn Zurodnungen bereits vorhanden sind durch Tests\r\nKey sequence 'J'.", new RecordItemIndex(19));
            Keyboard.Press("J");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(20));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Kopiervorgang beendet') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Kopiervorgang beendet");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(22));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmUVAK.FormularKopieren'.", repo.FrmUVAK.FormularKopierenInfo, new RecordItemIndex(23));
            Validate.Exists(repo.FrmUVAK.FormularKopierenInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Form_Code_NEU) on item 'FrmUVAK.DfCode2'.", repo.FrmUVAK.DfCode2Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmUVAK.DfCode2Info, "Text", Form_Code_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmUVAK.FormularKopieren'.", repo.FrmUVAK.FormularKopierenInfo, new RecordItemIndex(25));
            Keyboard.PrepareFocus(repo.FrmUVAK.FormularKopieren);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
