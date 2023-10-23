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
    ///The Oeffnen_notepad_XML_Datei recording.
    /// </summary>
    [TestModule("86383f54-919d-42f4-a0a5-75cf61184fe3", ModuleType.Recording, 1)]
    public partial class Oeffnen_notepad_XML_Datei : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository.Instance;

        static Oeffnen_notepad_XML_Datei instance = new Oeffnen_notepad_XML_Datei();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Oeffnen_notepad_XML_Datei()
        {
            Programm_2 = "notepad.exe";
            XML_UVA_Pfad_Datei = "C:\\temp\\STADUEV.XML";
            XML_UVA_Datei = "STADUEV.XML";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Oeffnen_notepad_XML_Datei Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm_2;

        /// <summary>
        /// Gets or sets the value of variable Programm_2.
        /// </summary>
        [TestVariable("6638446f-c51a-456d-92ba-02636d7bb748")]
        public string Programm_2
        {
            get { return _Programm_2; }
            set { _Programm_2 = value; }
        }

        string _XML_UVA_Pfad_Datei;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Pfad_Datei.
        /// </summary>
        [TestVariable("45c635e3-2140-4abe-a2a5-4bec112023be")]
        public string XML_UVA_Pfad_Datei
        {
            get { return _XML_UVA_Pfad_Datei; }
            set { _XML_UVA_Pfad_Datei = value; }
        }

        string _XML_UVA_Datei;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_Datei.
        /// </summary>
        [TestVariable("9a617ced-bff6-497b-9ff6-f6654650da33")]
        public string XML_UVA_Datei
        {
            get { return _XML_UVA_Datei; }
            set { _XML_UVA_Datei = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $XML_UVA_Pfad_Datei with arguments from variable $Programm_2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(XML_UVA_Pfad_Datei, Programm_2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'XMLEditor_UVA_ZM.XMLEditor'", repo.XMLEditor_UVA_ZM.XMLEditorInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.XMLEditor_UVA_ZM.XMLEditorInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$XML_UVA_Datei) on item 'XMLEditor_UVA_ZM.XMLEditor'.", repo.XMLEditor_UVA_ZM.XMLEditorInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.XMLEditor_UVA_ZM.XMLEditorInfo, "Text", XML_UVA_Datei);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
