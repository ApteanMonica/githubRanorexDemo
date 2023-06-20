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

namespace X_MUSTER_008.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RegEx_B1 recording.
    /// </summary>
    [TestModule("2deeb9ca-5bf5-4fe0-b16d-8392054be499", ModuleType.Recording, 1)]
    public partial class RegEx_B1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_008.X_MUSTER_008Repository repository.
        /// </summary>
        public static global::X_MUSTER_008.X_MUSTER_008Repository repo = global::X_MUSTER_008.X_MUSTER_008Repository.Instance;

        static RegEx_B1 instance = new RegEx_B1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RegEx_B1()
        {
            beleg_nr = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RegEx_B1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _beleg_nr;

        /// <summary>
        /// Gets or sets the value of variable beleg_nr.
        /// </summary>
        [TestVariable("2b4260df-f094-4122-aecb-0582f2f1e8b1")]
        public string beleg_nr
        {
            get { return _beleg_nr; }
            set { _beleg_nr = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.ColBelegnrRow1' and assigning its value to variable 'beleg_nr'.", repo.TblB.ColBelegnrRow1Info, new RecordItemIndex(0));
            beleg_nr = repo.TblB.ColBelegnrRow1.Element.GetAttributeValueText("Text");
            
            Report.Log(ReportLevel.Info, "User", beleg_nr, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'B_?(.)+[\\d]+') on item 'TblB.ColBelegnrRow1'.", repo.TblB.ColBelegnrRow1Info, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.TblB.ColBelegnrRow1Info, "Text", new Regex("B_?(.)+[\\d]+"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}