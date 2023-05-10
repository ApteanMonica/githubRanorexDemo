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

namespace B_KLSALD_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Jahr_Monat_aktuell_einlesen recording.
    /// </summary>
    [TestModule("33623c31-e929-408c-9cad-49d7dc7a3a5d", ModuleType.Recording, 1)]
    public partial class Jahr_Monat_aktuell_einlesen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLSALD_001.B_KLSALD_001Repository repository.
        /// </summary>
        public static global::B_KLSALD_001.B_KLSALD_001Repository repo = global::B_KLSALD_001.B_KLSALD_001Repository.Instance;

        static Jahr_Monat_aktuell_einlesen instance = new Jahr_Monat_aktuell_einlesen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Jahr_Monat_aktuell_einlesen()
        {
            Jahr_aktuell = "";
            Monat_aktuell = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Jahr_Monat_aktuell_einlesen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr_aktuell;

        /// <summary>
        /// Gets or sets the value of variable Jahr_aktuell.
        /// </summary>
        [TestVariable("cab7b16c-3d4f-4cc8-8fdd-4ab9793ee771")]
        public string Jahr_aktuell
        {
            get { return _Jahr_aktuell; }
            set { _Jahr_aktuell = value; }
        }

        string _Monat_aktuell;

        /// <summary>
        /// Gets or sets the value of variable Monat_aktuell.
        /// </summary>
        [TestVariable("b50ed0c8-9203-490d-9168-90900bc061de")]
        public string Monat_aktuell
        {
            get { return _Monat_aktuell; }
            set { _Monat_aktuell = value; }
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

            Jahr_aktuell = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("yyyy");
            
            Monat_aktuell = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("MM");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
