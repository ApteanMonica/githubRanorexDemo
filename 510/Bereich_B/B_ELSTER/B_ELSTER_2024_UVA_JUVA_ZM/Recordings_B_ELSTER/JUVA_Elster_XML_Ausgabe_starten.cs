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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_B_ELSTER
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The JUVA_Elster_XML_Ausgabe_starten recording.
    /// </summary>
    [TestModule("c77fa497-c408-4bff-aa81-9f4abd3e62cb", ModuleType.Recording, 1)]
    public partial class JUVA_Elster_XML_Ausgabe_starten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static JUVA_Elster_XML_Ausgabe_starten instance = new JUVA_Elster_XML_Ausgabe_starten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public JUVA_Elster_XML_Ausgabe_starten()
        {
            Firma = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static JUVA_Elster_XML_Ausgabe_starten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("af8e8dd5-b96d-4a1c-8f8a-643ddee000bb")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgElster.TitleBar300ElsterXML'", repo.DlgElster.TitleBar300ElsterXMLInfo, new ActionTimeout(180000), new RecordItemIndex(0));
            repo.DlgElster.TitleBar300ElsterXMLInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'JahresUVA') on item 'DlgElster.TitleBar300ElsterXML'.", repo.DlgElster.TitleBar300ElsterXMLInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgElster.TitleBar300ElsterXMLInfo, "Text", "JahresUVA");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'DlgElster.TitleBar300ElsterXML'.", repo.DlgElster.TitleBar300ElsterXMLInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgElster.TitleBar300ElsterXMLInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'DlgElster.DieSteuerWurdeNachVereinbartenEntg'.", repo.DlgElster.DieSteuerWurdeNachVereinbartenEntgInfo, new RecordItemIndex(3));
            repo.DlgElster.DieSteuerWurdeNachVereinbartenEntg.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'DlgElster.DieSteuerWurdeNachVereinbartenEntg'.", repo.DlgElster.DieSteuerWurdeNachVereinbartenEntgInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgElster.DieSteuerWurdeNachVereinbartenEntgInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElster.PbJa' at Center.", repo.DlgElster.PbJaInfo, new RecordItemIndex(6));
            repo.DlgElster.PbJa.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
