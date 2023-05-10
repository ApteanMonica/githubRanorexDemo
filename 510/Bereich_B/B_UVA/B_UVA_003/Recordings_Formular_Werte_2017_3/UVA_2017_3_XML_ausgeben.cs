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

namespace B_UVA_003.Recordings_Formular_Werte_2017_3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_2017_3_XML_ausgeben recording.
    /// </summary>
    [TestModule("05443891-082a-4040-a987-423dc65abd3d", ModuleType.Recording, 1)]
    public partial class UVA_2017_3_XML_ausgeben : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_003.B_UVA_003Repository repository.
        /// </summary>
        public static global::B_UVA_003.B_UVA_003Repository repo = global::B_UVA_003.B_UVA_003Repository.Instance;

        static UVA_2017_3_XML_ausgeben instance = new UVA_2017_3_XML_ausgeben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_2017_3_XML_ausgeben()
        {
            UVA_Jahr_2017 = "2017";
            UVA_Monat_3 = "3";
            UVA_A21_Form_Name = "UVA-Österreich 2021";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_2017_3_XML_ausgeben Instance
        {
            get { return instance; }
        }

#region Variables

        string _UVA_Jahr_2017;

        /// <summary>
        /// Gets or sets the value of variable UVA_Jahr_2017.
        /// </summary>
        [TestVariable("049b4798-e6a3-4a2c-8e25-d1da80774252")]
        public string UVA_Jahr_2017
        {
            get { return _UVA_Jahr_2017; }
            set { _UVA_Jahr_2017 = value; }
        }

        string _UVA_Monat_3;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_3.
        /// </summary>
        [TestVariable("43b21ade-1a4d-4e0c-9a68-8716af656f40")]
        public string UVA_Monat_3
        {
            get { return _UVA_Monat_3; }
            set { _UVA_Monat_3 = value; }
        }

        string _UVA_A21_Form_Name;

        /// <summary>
        /// Gets or sets the value of variable UVA_A21_Form_Name.
        /// </summary>
        [TestVariable("9204beb8-96b9-4a1e-b48f-5b17165a2640")]
        public string UVA_A21_Form_Name
        {
            get { return _UVA_A21_Form_Name; }
            set { _UVA_A21_Form_Name = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVon'.", repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVonInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVonInfo, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_3) on item 'DlgUVADruck.TpFormular.Text'.", repo.DlgUVADruck.TpFormular.TextInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.TextInfo, "Text", UVA_Monat_3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_A21_Form_Name) on item 'DlgUVADruck.TpFormular.CmbUvaFBez'.", repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, "Text", UVA_A21_Form_Name);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUVADruck.PbXML' at Center.", repo.DlgUVADruck.PbXMLInfo, new RecordItemIndex(4));
            repo.DlgUVADruck.PbXML.Click();
            
            // Prüfung Meldung ohne Zeitraum
            Report.Log(ReportLevel.Info, "Validation", "Prüfung Meldung ohne Zeitraum\r\nValidating AttributeContains (Text>$UVA_Jahr_2017) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UVA_Monat_3) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", UVA_Monat_3);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'XML - Ausgabe in Datei 'C:\\TEMP\\UVA.XML' beendet!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "XML - Ausgabe in Datei 'C:\\TEMP\\UVA.XML' beendet!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
