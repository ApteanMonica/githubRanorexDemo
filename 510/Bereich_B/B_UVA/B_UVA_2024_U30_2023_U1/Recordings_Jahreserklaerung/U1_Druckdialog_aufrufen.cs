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

namespace B_UVA_2024_U30_2023_U1.Recordings_Jahreserklaerung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The U1_Druckdialog_aufrufen recording.
    /// </summary>
    [TestModule("40ad7d0d-943e-444f-be24-b05558dafb3b", ModuleType.Recording, 1)]
    public partial class U1_Druckdialog_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository.Instance;

        static U1_Druckdialog_aufrufen instance = new U1_Druckdialog_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public U1_Druckdialog_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static U1_Druckdialog_aufrufen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUVADruck.PbDruck' at Center.", repo.DlgUVADruck.PbDruckInfo, new RecordItemIndex(0));
            repo.DlgUVADruck.PbDruck.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgDrucken.TitleBar200DruckeUVAFormular'.", repo.DlgDrucken.TitleBar200DruckeUVAFormularInfo, new RecordItemIndex(1));
            Validate.Exists(repo.DlgDrucken.TitleBar200DruckeUVAFormularInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
