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
    ///The Sichern_XML_JUVA_JAHRNEU_ausl_U recording.
    /// </summary>
    [TestModule("afda06b3-6f8b-4585-b06a-bd98de6f915b", ModuleType.Recording, 1)]
    public partial class Sichern_XML_JUVA_JAHRNEU_ausl_U : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Sichern_XML_JUVA_JAHRNEU_ausl_U instance = new Sichern_XML_JUVA_JAHRNEU_ausl_U();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Sichern_XML_JUVA_JAHRNEU_ausl_U()
        {
            XML_Inhalt_aktuell = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Sichern_XML_JUVA_JAHRNEU_ausl_U Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_Inhalt_aktuell;

        /// <summary>
        /// Gets or sets the value of variable XML_Inhalt_aktuell.
        /// </summary>
        [TestVariable("bb501e10-58cd-4ca8-9fc9-22210b0f8671")]
        public string XML_Inhalt_aktuell
        {
            get { return _XML_Inhalt_aktuell; }
            set { _XML_Inhalt_aktuell = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM' and assigning its value to variable 'XML_Inhalt_aktuell'.", repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZMInfo, new RecordItemIndex(0));
            XML_Inhalt_aktuell = repo.Editor_XML_UVA_ZM.Text15_XML_Editor_UVA_ZM.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.FileLibrary.WriteToFile(XML_Inhalt_aktuell, "c:\\temp\\xml_UST2A_JUVA_2024_ausl_U", "xml");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
