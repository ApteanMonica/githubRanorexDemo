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

namespace B_UVA_2024_U30_2023_U1.Recordings_Jahreserklaerung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The U1_2017_1_3_XML_ausgeben recording.
    /// </summary>
    [TestModule("ad772073-aff6-4492-8757-196badd43bce", ModuleType.Recording, 1)]
    public partial class U1_2017_1_3_XML_ausgeben : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository.Instance;

        static U1_2017_1_3_XML_ausgeben instance = new U1_2017_1_3_XML_ausgeben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public U1_2017_1_3_XML_ausgeben()
        {
            UVA_Jahr_2017 = "2017";
            UVA_Monat_1 = "1";
            UVA_Monat_3 = "3";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static U1_2017_1_3_XML_ausgeben Instance
        {
            get { return instance; }
        }

#region Variables

        string _UVA_Jahr_2017;

        /// <summary>
        /// Gets or sets the value of variable UVA_Jahr_2017.
        /// </summary>
        [TestVariable("2920fe7b-8361-4b0e-b604-01fd80636a30")]
        public string UVA_Jahr_2017
        {
            get { return _UVA_Jahr_2017; }
            set { _UVA_Jahr_2017 = value; }
        }

        string _UVA_Monat_1;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_1.
        /// </summary>
        [TestVariable("b8d1b933-a007-4c84-968c-39be06a433a1")]
        public string UVA_Monat_1
        {
            get { return _UVA_Monat_1; }
            set { _UVA_Monat_1 = value; }
        }

        string _UVA_Monat_3;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_3.
        /// </summary>
        [TestVariable("1a5f0e60-1fc4-4223-9db8-7b40b4bac548")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Druck UVA-Werte') on item 'DlgUVADruck.TitleBar200DruckUVAWerte'.", repo.DlgUVADruck.TitleBar200DruckUVAWerteInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.DlgUVADruck.TitleBar200DruckUVAWerteInfo, "Text", "Druck UVA-Werte");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVADruck.TabPageJahreserklaerung'.", repo.DlgUVADruck.TabPageJahreserklaerungInfo, new RecordItemIndex(1));
            Validate.Exists(repo.DlgUVADruck.TabPageJahreserklaerungInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'DlgUVADruck.TpJahreserklaerung.UmsatzsteuererklaerungFuerJahr'.", repo.DlgUVADruck.TpJahreserklaerung.UmsatzsteuererklaerungFuerJahrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgUVADruck.TpJahreserklaerung.UmsatzsteuererklaerungFuerJahrInfo, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'DlgUVADruck.TpJahreserklaerung.JahrMonatVom'.", repo.DlgUVADruck.TpJahreserklaerung.JahrMonatVomInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgUVADruck.TpJahreserklaerung.JahrMonatVomInfo, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'DlgUVADruck.TpJahreserklaerung.Text1'.", repo.DlgUVADruck.TpJahreserklaerung.Text1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgUVADruck.TpJahreserklaerung.Text1Info, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_1) on item 'DlgUVADruck.TpJahreserklaerung.Text'.", repo.DlgUVADruck.TpJahreserklaerung.TextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgUVADruck.TpJahreserklaerung.TextInfo, "Text", UVA_Monat_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_3) on item 'DlgUVADruck.TpJahreserklaerung.Text2'.", repo.DlgUVADruck.TpJahreserklaerung.Text2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgUVADruck.TpJahreserklaerung.Text2Info, "Text", UVA_Monat_3);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUVADruck.PbXML' at Center.", repo.DlgUVADruck.PbXMLInfo, new RecordItemIndex(7));
            repo.DlgUVADruck.PbXML.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='XML-Ausgabe in Datei 'C:\\TEMP\\UVA.XML' durchführen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "XML-Ausgabe in Datei 'C:\\TEMP\\UVA.XML' durchführen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='XML - Ausgabe in Datei 'C:\\TEMP\\UVA.XML' beendet!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "XML - Ausgabe in Datei 'C:\\TEMP\\UVA.XML' beendet!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}