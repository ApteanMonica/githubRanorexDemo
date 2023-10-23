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
    ///The Pruefung_Eric_log_Tagesdatum_Tagesdatum2_UserCode recording.
    /// </summary>
    [TestModule("681c0d80-3d34-4fd5-8740-379a9600d097", ModuleType.Recording, 1)]
    public partial class Pruefung_Eric_log_Tagesdatum_Tagesdatum2_UserCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository.Instance;

        static Pruefung_Eric_log_Tagesdatum_Tagesdatum2_UserCode instance = new Pruefung_Eric_log_Tagesdatum_Tagesdatum2_UserCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Eric_log_Tagesdatum_Tagesdatum2_UserCode()
        {
            Eric_log_Inhalt_aktuell = "";
            Tagesdatum_yyyy_MM_dd = "";
            Tagesdatum2_yyyy_MM_dd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Eric_log_Tagesdatum_Tagesdatum2_UserCode Instance
        {
            get { return instance; }
        }

#region Variables

        string _Eric_log_Inhalt_aktuell;

        /// <summary>
        /// Gets or sets the value of variable Eric_log_Inhalt_aktuell.
        /// </summary>
        [TestVariable("4c846b93-aa94-4f9d-96d0-3eeca4c3a8c0")]
        public string Eric_log_Inhalt_aktuell
        {
            get { return _Eric_log_Inhalt_aktuell; }
            set { _Eric_log_Inhalt_aktuell = value; }
        }

        string _Tagesdatum_yyyy_MM_dd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_yyyy_MM_dd.
        /// </summary>
        [TestVariable("cb9591a2-eef2-430e-85ff-4f27c34e6496")]
        public string Tagesdatum_yyyy_MM_dd
        {
            get { return _Tagesdatum_yyyy_MM_dd; }
            set { _Tagesdatum_yyyy_MM_dd = value; }
        }

        string _Tagesdatum2_yyyy_MM_dd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum2_yyyy_MM_dd.
        /// </summary>
        [TestVariable("6027dddc-7c23-40e4-9866-3f33abef0782")]
        public string Tagesdatum2_yyyy_MM_dd
        {
            get { return _Tagesdatum2_yyyy_MM_dd; }
            set { _Tagesdatum2_yyyy_MM_dd = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Eric_log_Inhalt_aktuell, Tagesdatum_yyyy_MM_dd, Tagesdatum2_yyyy_MM_dd);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
