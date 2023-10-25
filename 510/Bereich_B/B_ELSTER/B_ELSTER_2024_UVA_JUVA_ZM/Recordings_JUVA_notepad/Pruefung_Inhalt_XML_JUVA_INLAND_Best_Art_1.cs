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
    ///The Pruefung_Inhalt_XML_JUVA_INLAND_Best_Art_1 recording.
    /// </summary>
    [TestModule("c9211864-0424-4a84-8478-6abee757d397", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_JUVA_INLAND_Best_Art_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Pruefung_Inhalt_XML_JUVA_INLAND_Best_Art_1 instance = new Pruefung_Inhalt_XML_JUVA_INLAND_Best_Art_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_JUVA_INLAND_Best_Art_1()
        {
            XML_JUVA_VORJAHR_INLAND_U_Best_Art_1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_JUVA_INLAND_Best_Art_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_JUVA_VORJAHR_INLAND_U_Best_Art_1;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_VORJAHR_INLAND_U_Best_Art_1.
        /// </summary>
        [TestVariable("a4683142-d3da-434a-a7ad-3cd9c913f8b8")]
        public string XML_JUVA_VORJAHR_INLAND_U_Best_Art_1
        {
            get { return _XML_JUVA_VORJAHR_INLAND_U_Best_Art_1; }
            set { _XML_JUVA_VORJAHR_INLAND_U_Best_Art_1 = value; }
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_VORJAHR_INLAND_U_Best_Art_1) on item 'XMLEditor_UVA_ZM6.Text15'.", repo.XMLEditor_UVA_ZM6.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM6.Text15Info, "Text", XML_JUVA_VORJAHR_INLAND_U_Best_Art_1, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
