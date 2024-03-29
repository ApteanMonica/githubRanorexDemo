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

namespace B_UVA_004.Recordings_Formular
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zuordnungen_schliessen recording.
    /// </summary>
    [TestModule("bf19700f-a876-46d6-96e9-707e83292081", ModuleType.Recording, 1)]
    public partial class Zuordnungen_schliessen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_004.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_004.B_UVA_004Repository repo = global::B_UVA_004.B_UVA_004Repository.Instance;

        static Zuordnungen_schliessen instance = new Zuordnungen_schliessen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zuordnungen_schliessen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zuordnungen_schliessen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVAZ.TitleBar200ZuordnungUStCodes'.", repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo, new RecordItemIndex(0));
            Validate.Exists(repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'DlgUVAZ.TitleBar200ZuordnungUStCodes'.", repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.DlgUVAZ.TitleBar200ZuordnungUStCodes);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
