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

namespace AEKOOE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tagesdatum_einlesen recording.
    /// </summary>
    [TestModule("ce9b86df-a685-4b2d-a411-f4b4c1b378ca", ModuleType.Recording, 1)]
    public partial class Tagesdatum_einlesen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_001.AEKOOE_WEB_001Repository repository.
        /// </summary>
        public static global::AEKOOE_001.AEKOOE_WEB_001Repository repo = global::AEKOOE_001.AEKOOE_WEB_001Repository.Instance;

        static Tagesdatum_einlesen instance = new Tagesdatum_einlesen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tagesdatum_einlesen()
        {
            Tagesdatum = "";
            Tagesdatum_plus_7_Tage = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tagesdatum_einlesen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("71a4024f-5fff-4445-8853-0654123f3199")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_plus_7_Tage.
        /// </summary>
        [TestVariable("88cad7d4-2b03-4cb3-acd5-b3d83824356c")]
        public string Tagesdatum_plus_7_Tage
        {
            get { return repo.Tagesdatum_plus_7_Tage; }
            set { repo.Tagesdatum_plus_7_Tage = value; }
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

            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetSystemDateTimeAsString("dd.MM.yyyy");
            
            Report.Log(ReportLevel.Info, "User", Tagesdatum, new RecordItemIndex(1));
            
            Tagesdatum_plus_7_Tage = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetSystemDateTimePlus("d", ValueConverter.ArgumentFromString<int>("counter", "7"));
            
            Report.Log(ReportLevel.Info, "User", Tagesdatum_plus_7_Tage, new RecordItemIndex(3));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
