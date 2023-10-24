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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_JUVA_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Inhalt_XML_JUVA_Header recording.
    /// </summary>
    [TestModule("479cf6e0-8dec-4f2f-ba53-101cb79a60c3", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_JUVA_Header : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Pruefung_Inhalt_XML_JUVA_Header instance = new Pruefung_Inhalt_XML_JUVA_Header();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_JUVA_Header()
        {
            XML_JUVA_VORJAHR_Header_1 = "";
            XML_JUVA_VORJAHR_Header_2 = "";
            XML_JUVA_VORJAHR_Header_3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_JUVA_Header Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_JUVA_VORJAHR_Header_1;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_VORJAHR_Header_1.
        /// </summary>
        [TestVariable("cc9aa451-beae-4d31-ba3e-2887b5281bec")]
        public string XML_JUVA_VORJAHR_Header_1
        {
            get { return _XML_JUVA_VORJAHR_Header_1; }
            set { _XML_JUVA_VORJAHR_Header_1 = value; }
        }

        string _XML_JUVA_VORJAHR_Header_2;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_VORJAHR_Header_2.
        /// </summary>
        [TestVariable("abe019ba-8d25-40c3-b714-e5265caa7a07")]
        public string XML_JUVA_VORJAHR_Header_2
        {
            get { return _XML_JUVA_VORJAHR_Header_2; }
            set { _XML_JUVA_VORJAHR_Header_2 = value; }
        }

        string _XML_JUVA_VORJAHR_Header_3;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_VORJAHR_Header_3.
        /// </summary>
        [TestVariable("6b67dacf-f998-4ed9-9361-2a6dcfe28536")]
        public string XML_JUVA_VORJAHR_Header_3
        {
            get { return _XML_JUVA_VORJAHR_Header_3; }
            set { _XML_JUVA_VORJAHR_Header_3 = value; }
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_VORJAHR_Header_1) on item 'XMLEditor_UVA_ZM3.Text15'.", repo.XMLEditor_UVA_ZM3.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM3.Text15Info, "Text", XML_JUVA_VORJAHR_Header_1, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_VORJAHR_Header_2) on item 'XMLEditor_UVA_ZM3.Text15'.", repo.XMLEditor_UVA_ZM3.Text15Info, new RecordItemIndex(1));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM3.Text15Info, "Text", XML_JUVA_VORJAHR_Header_2, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_VORJAHR_Header_3) on item 'XMLEditor_UVA_ZM3.Text15'.", repo.XMLEditor_UVA_ZM3.Text15Info, new RecordItemIndex(2));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM3.Text15Info, "Text", XML_JUVA_VORJAHR_Header_3, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
