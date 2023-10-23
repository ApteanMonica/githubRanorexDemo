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

namespace B_ELSTER_2024_UVA_JUVA_ZM.recordings_ZM_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Sichern_XML_ZM_JAHRNEU_01 recording.
    /// </summary>
    [TestModule("f721d957-20ea-40a9-8aa4-7ed6fa875bd7", ModuleType.Recording, 1)]
    public partial class Sichern_XML_ZM_JAHRNEU_01 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_006_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_006_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_006_ZMRepository.Instance;

        static Sichern_XML_ZM_JAHRNEU_01 instance = new Sichern_XML_ZM_JAHRNEU_01();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Sichern_XML_ZM_JAHRNEU_01()
        {
            XML_Inhalt_aktuell = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Sichern_XML_ZM_JAHRNEU_01 Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_Inhalt_aktuell;

        /// <summary>
        /// Gets or sets the value of variable XML_Inhalt_aktuell.
        /// </summary>
        [TestVariable("528fbc53-e483-4de1-87d9-394461725ea9")]
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'XMLEditor_UVA_ZM.Text15' and assigning its value to variable 'XML_Inhalt_aktuell'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(0));
            XML_Inhalt_aktuell = repo.XMLEditor_UVA_ZM.Text15.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.FileLibrary.WriteToFile(XML_Inhalt_aktuell, "c:\\temp\\ZMDO_JAHRNEU_01", "xml");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
