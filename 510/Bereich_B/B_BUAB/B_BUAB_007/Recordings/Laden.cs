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

namespace B_BUAB_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Laden recording.
    /// </summary>
    [TestModule("39706084-eeb1-4e57-86eb-03558da18b5e", ModuleType.Recording, 1)]
    public partial class Laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_007.B_BUAB_007Repository repository.
        /// </summary>
        public static global::B_BUAB_007.B_BUAB_007Repository repo = global::B_BUAB_007.B_BUAB_007Repository.Instance;

        static Laden instance = new Laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Laden()
        {
            beleg_laden = "BA_2030003_2022";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _beleg_laden;

        /// <summary>
        /// Gets or sets the value of variable beleg_laden.
        /// </summary>
        [TestVariable("53353a33-30c1-4d8b-ad82-faa7daf86f85")]
        public string beleg_laden
        {
            get { return _beleg_laden; }
            set { _beleg_laden = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB1.PbStandardNew' at Center.", repo.TblB1.PbStandardNewInfo, new RecordItemIndex(0));
            repo.TblB1.PbStandardNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$beleg_laden' with focus on 'TblB.Beleg'.", repo.TblB.BelegInfo, new RecordItemIndex(1));
            repo.TblB.Beleg.PressKeys(beleg_laden);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbDataAccessLoad' at Center.", repo.TblB.PbDataAccessLoadInfo, new RecordItemIndex(2));
            repo.TblB.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'TblB.ColBelegnrRow11'", repo.TblB.ColBelegnrRow11Info, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.TblB.ColBelegnrRow11Info.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$beleg_laden) on item 'TblB.ColBelegnrRow11'.", repo.TblB.ColBelegnrRow11Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblB.ColBelegnrRow11Info, "Text", beleg_laden);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
