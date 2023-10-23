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
    ///The Sichern_Eric_log_ZM recording.
    /// </summary>
    [TestModule("c9619e4f-f11e-463e-ac33-818e5052b6f2", ModuleType.Recording, 1)]
    public partial class Sichern_Eric_log_ZM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_006_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_006_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_006_ZMRepository.Instance;

        static Sichern_Eric_log_ZM instance = new Sichern_Eric_log_ZM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Sichern_Eric_log_ZM()
        {
            Eric_log_Inhalt_aktuell = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Sichern_Eric_log_ZM Instance
        {
            get { return instance; }
        }

#region Variables

        string _Eric_log_Inhalt_aktuell;

        /// <summary>
        /// Gets or sets the value of variable Eric_log_Inhalt_aktuell.
        /// </summary>
        [TestVariable("12cf06a8-8bb2-4498-ad94-55028e2bf41f")]
        public string Eric_log_Inhalt_aktuell
        {
            get { return _Eric_log_Inhalt_aktuell; }
            set { _Eric_log_Inhalt_aktuell = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'EricLogEditor.Text15' and assigning its value to variable 'Eric_log_Inhalt_aktuell'.", repo.EricLogEditor.Text15Info, new RecordItemIndex(0));
            Eric_log_Inhalt_aktuell = repo.EricLogEditor.Text15.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.FileLibrary.WriteToFile(Eric_log_Inhalt_aktuell, "c:\\temp\\eric_log_zm_2023_01", "log");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
