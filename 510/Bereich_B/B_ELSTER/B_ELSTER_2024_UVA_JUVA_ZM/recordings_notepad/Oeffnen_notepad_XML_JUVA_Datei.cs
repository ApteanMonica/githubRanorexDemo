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

namespace B_ELSTER_005.Recordings_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Oeffnen_notepad_XML_JUVA_Datei recording.
    /// </summary>
    [TestModule("1704911f-2933-4c2a-9851-c329ef8b02dc", ModuleType.Recording, 1)]
    public partial class Oeffnen_notepad_XML_JUVA_Datei : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_005.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_005.B_ELSTER_005Repository repo = global::B_ELSTER_005.B_ELSTER_005Repository.Instance;

        static Oeffnen_notepad_XML_JUVA_Datei instance = new Oeffnen_notepad_XML_JUVA_Datei();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Oeffnen_notepad_XML_JUVA_Datei()
        {
            Programm_2 = "notepad.exe";
            XML_JUVA_Pfad_Datei = "C:\\temp\\UST2A.XML";
            XML_JUVA_Datei = "UST2A.XML";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Oeffnen_notepad_XML_JUVA_Datei Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm_2;

        /// <summary>
        /// Gets or sets the value of variable Programm_2.
        /// </summary>
        [TestVariable("12c77e58-fd94-445b-b2f3-0d082be2e2d7")]
        public string Programm_2
        {
            get { return _Programm_2; }
            set { _Programm_2 = value; }
        }

        string _XML_JUVA_Pfad_Datei;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_Pfad_Datei.
        /// </summary>
        [TestVariable("6b39e6f7-0c5c-4f51-bf8c-4a8a7fc78df5")]
        public string XML_JUVA_Pfad_Datei
        {
            get { return _XML_JUVA_Pfad_Datei; }
            set { _XML_JUVA_Pfad_Datei = value; }
        }

        string _XML_JUVA_Datei;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_Datei.
        /// </summary>
        [TestVariable("cb2cadc8-e3c2-4d09-b69f-4f7a8e357735")]
        public string XML_JUVA_Datei
        {
            get { return _XML_JUVA_Datei; }
            set { _XML_JUVA_Datei = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $XML_JUVA_Pfad_Datei with arguments from variable $Programm_2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(XML_JUVA_Pfad_Datei, Programm_2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'XMLEditor_UVA_ZM.XMLEditor'", repo.XMLEditor_UVA_ZM.XMLEditorInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.XMLEditor_UVA_ZM.XMLEditorInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$XML_JUVA_Datei) on item 'XMLEditor_UVA_ZM.XMLEditor'.", repo.XMLEditor_UVA_ZM.XMLEditorInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.XMLEditor_UVA_ZM.XMLEditorInfo, "Text", XML_JUVA_Datei);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
