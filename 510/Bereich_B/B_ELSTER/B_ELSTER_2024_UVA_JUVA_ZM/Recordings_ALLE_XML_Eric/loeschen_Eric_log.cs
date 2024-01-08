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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_ALLE_XML_Eric
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The loeschen_Eric_log recording.
    /// </summary>
    [TestModule("a1546d34-ced4-4a9d-9f79-c067c19b39b4", ModuleType.Recording, 1)]
    public partial class loeschen_Eric_log : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static loeschen_Eric_log instance = new loeschen_Eric_log();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public loeschen_Eric_log()
        {
            Pfad = "c:\\temp";
            Eric_log_Datei = "eric.log";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static loeschen_Eric_log Instance
        {
            get { return instance; }
        }

#region Variables

        string _Pfad;

        /// <summary>
        /// Gets or sets the value of variable Pfad.
        /// </summary>
        [TestVariable("1544a1bd-7e67-4dd4-a94d-3817e47f2a00")]
        public string Pfad
        {
            get { return _Pfad; }
            set { _Pfad = value; }
        }

        string _Eric_log_Datei;

        /// <summary>
        /// Gets or sets the value of variable Eric_log_Datei.
        /// </summary>
        [TestVariable("1acc6b6d-3485-4f8b-8900-ade6de98f7bd")]
        public string Eric_log_Datei
        {
            get { return _Eric_log_Datei; }
            set { _Eric_log_Datei = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.FileLibrary.DeleteFiles(Pfad, Eric_log_Datei);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}