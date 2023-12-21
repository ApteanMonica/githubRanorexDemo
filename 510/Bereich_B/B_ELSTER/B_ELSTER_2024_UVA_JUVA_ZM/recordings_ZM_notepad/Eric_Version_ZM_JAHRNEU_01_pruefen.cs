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
    ///The Eric_Version_ZM_JAHRNEU_01_pruefen recording.
    /// </summary>
    [TestModule("27453a92-84f3-4162-b4b3-a239cb3d3bc7", ModuleType.Recording, 1)]
    public partial class Eric_Version_ZM_JAHRNEU_01_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Eric_Version_ZM_JAHRNEU_01_pruefen instance = new Eric_Version_ZM_JAHRNEU_01_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Eric_Version_ZM_JAHRNEU_01_pruefen()
        {
            Eric_ZM_JAHRNEU_01_39_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Eric_Version_ZM_JAHRNEU_01_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Eric_ZM_JAHRNEU_01_39_2;

        /// <summary>
        /// Gets or sets the value of variable Eric_ZM_JAHRNEU_01_39_2.
        /// </summary>
        [TestVariable("0018eb0b-531f-4dbe-98f3-f02e5d459375")]
        public string Eric_ZM_JAHRNEU_01_39_2
        {
            get { return _Eric_ZM_JAHRNEU_01_39_2; }
            set { _Eric_ZM_JAHRNEU_01_39_2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Eric_ZM_JAHRNEU_01_39_2) on item 'EricLogEditor.Text15'.", repo.EricLogEditor.Text15Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.EricLogEditor.Text15Info, "Text", Eric_ZM_JAHRNEU_01_39_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
