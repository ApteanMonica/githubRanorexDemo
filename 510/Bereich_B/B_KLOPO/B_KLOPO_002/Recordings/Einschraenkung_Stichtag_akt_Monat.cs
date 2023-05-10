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

namespace B_KLOPO_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkung_Stichtag_akt_Monat recording.
    /// </summary>
    [TestModule("84a31a21-5bc7-43cc-8f80-30ab63d22853", ModuleType.Recording, 1)]
    public partial class Einschraenkung_Stichtag_akt_Monat : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLOPO_002.B_KLOPO_002Repository repository.
        /// </summary>
        public static global::B_KLOPO_002.B_KLOPO_002Repository repo = global::B_KLOPO_002.B_KLOPO_002Repository.Instance;

        static Einschraenkung_Stichtag_akt_Monat instance = new Einschraenkung_Stichtag_akt_Monat();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_Stichtag_akt_Monat()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_Stichtag_akt_Monat Instance
        {
            get { return instance; }
        }

#region Variables

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

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
