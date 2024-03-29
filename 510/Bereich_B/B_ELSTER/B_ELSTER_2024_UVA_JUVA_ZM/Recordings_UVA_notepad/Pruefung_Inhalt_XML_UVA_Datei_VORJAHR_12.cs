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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_UVA_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Inhalt_XML_UVA_Datei_VORJAHR_12 recording.
    /// </summary>
    [TestModule("f8e3a775-907b-4cab-996f-e884905146f3", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_UVA_Datei_VORJAHR_12 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Pruefung_Inhalt_XML_UVA_Datei_VORJAHR_12 instance = new Pruefung_Inhalt_XML_UVA_Datei_VORJAHR_12();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_UVA_Datei_VORJAHR_12()
        {
            XML_UVA_VERSION_VORJAHR = "";
            XML_UVA_Teil_1 = "";
            XML_UVA_Teil_2 = "";
            XML_UVA_Teil_3 = "";
            XML_UVA_Teil_4 = "";
            VORJAHR = "";
            XML_UVA_Teil_5 = "";
            XML_UVA_Monat_12 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_UVA_Datei_VORJAHR_12 Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_UVA_VERSION_VORJAHR;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_VERSION_VORJAHR.
        /// </summary>
        [TestVariable("e6c9043d-8787-4048-8c72-ccbaabc41774")]
        public string XML_UVA_VERSION_VORJAHR
        {
            get { return _XML_UVA_VERSION_VORJAHR; }
            set { _XML_UVA_VERSION_VORJAHR = value; }
        }

        string _XML_UVA_Teil_1;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Teil_1.
        /// </summary>
        [TestVariable("68fefb4b-664b-46c4-8cae-c8021049aa35")]
        public string XML_UVA_Teil_1
        {
            get { return _XML_UVA_Teil_1; }
            set { _XML_UVA_Teil_1 = value; }
        }

        string _XML_UVA_Teil_2;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Teil_2.
        /// </summary>
        [TestVariable("8bf93dbf-cb59-47a3-9ca0-20221841353e")]
        public string XML_UVA_Teil_2
        {
            get { return _XML_UVA_Teil_2; }
            set { _XML_UVA_Teil_2 = value; }
        }

        string _XML_UVA_Teil_3;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Teil_3.
        /// </summary>
        [TestVariable("45b43b74-7ba4-47c7-ae5b-c9137d617389")]
        public string XML_UVA_Teil_3
        {
            get { return _XML_UVA_Teil_3; }
            set { _XML_UVA_Teil_3 = value; }
        }

        string _XML_UVA_Teil_4;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Teil_4.
        /// </summary>
        [TestVariable("926425bc-afac-429d-809e-5f51b213edaa")]
        public string XML_UVA_Teil_4
        {
            get { return _XML_UVA_Teil_4; }
            set { _XML_UVA_Teil_4 = value; }
        }

        string _VORJAHR;

        /// <summary>
        /// Gets or sets the value of variable VORJAHR.
        /// </summary>
        [TestVariable("b6fa4e3c-558f-4c25-b035-15e45b9e5624")]
        public string VORJAHR
        {
            get { return _VORJAHR; }
            set { _VORJAHR = value; }
        }

        string _XML_UVA_Teil_5;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Teil_5.
        /// </summary>
        [TestVariable("fd96c99a-ca6e-4ae8-b9d1-0602886cc226")]
        public string XML_UVA_Teil_5
        {
            get { return _XML_UVA_Teil_5; }
            set { _XML_UVA_Teil_5 = value; }
        }

        string _XML_UVA_Monat_12;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Monat_12.
        /// </summary>
        [TestVariable("fc1f1919-99d0-42f8-9df3-f1ff4632e37f")]
        public string XML_UVA_Monat_12
        {
            get { return _XML_UVA_Monat_12; }
            set { _XML_UVA_Monat_12 = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_Teil_1) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(0));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_Teil_1, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_Teil_2) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(1));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_Teil_2, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_Teil_3) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(2));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_Teil_3, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_VERSION_VORJAHR) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(3));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_VERSION_VORJAHR, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_Teil_4) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(4));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_Teil_4, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$VORJAHR) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(5));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", VORJAHR, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_Monat_12) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(6));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_Monat_12, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_Teil_5) on item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(7));
                Validate.AttributeContains(repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, "Text", XML_UVA_Teil_5, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
