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
    ///The Beleg recording.
    /// </summary>
    [TestModule("150f999d-684c-4781-9947-bcea9d5c09cf", ModuleType.Recording, 1)]
    public partial class Beleg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_008.X_MUSTER_008Repository repository.
        /// </summary>
        public static global::X_MUSTER_008.X_MUSTER_008Repository repo = global::X_MUSTER_008.X_MUSTER_008Repository.Instance;

        static Beleg instance = new Beleg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Beleg()
        {
            busy = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Beleg Instance
        {
            get { return instance; }
        }

#region Variables

        string _busy;

        /// <summary>
        /// Gets or sets the value of variable busy.
        /// </summary>
        [TestVariable("1c5220b2-ef2d-4d8d-bfe5-30c9b5298d92")]
        public string busy
        {
            get { return _busy; }
            set { _busy = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.ColBusyRow1' and assigning its value to variable 'busy'.", repo.TblB.ColBusyRow1Info, new RecordItemIndex(0));
            busy = repo.TblB.ColBusyRow1.Element.GetAttributeValueText("Text");
            
            Report.Log(ReportLevel.Info, "User", busy, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
