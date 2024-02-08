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

namespace B_UVA_2024_U30_2023_U1.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_Notepad recording.
    /// </summary>
    [TestModule("6544749e-0cc1-45ae-aa4f-f4b757d8efa1", ModuleType.Recording, 1)]
    public partial class Close_Notepad : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository.Instance;

        static Close_Notepad instance = new Close_Notepad();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_Notepad()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_Notepad Instance
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

            // Hat Fehler gebracht, dh Schließen mit Alt+F4
            Report.Log(ReportLevel.Info, "Application", "Hat Fehler gebracht, dh Schließen mit Alt+F4\r\nClosing application containing item 'UVAXMLEditor'.", repo.UVAXMLEditor.SelfInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.UVAXMLEditor.Self, 1);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
