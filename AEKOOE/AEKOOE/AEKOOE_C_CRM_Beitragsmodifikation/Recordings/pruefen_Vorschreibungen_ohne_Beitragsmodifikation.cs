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

namespace AEKOOE_C_CRM_Beitragsmodifikation.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The pruefen_Vorschreibungen_ohne_Beitragsmodifikation recording.
    /// </summary>
    [TestModule("f191841c-d888-412a-a8ef-315f7b4cddb5", ModuleType.Recording, 1)]
    public partial class pruefen_Vorschreibungen_ohne_Beitragsmodifikation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_C_CRM_Beitragsmodifikation.AEKOOE_C_CRM_BeitragsmodifikationRepository repository.
        /// </summary>
        public static global::AEKOOE_C_CRM_Beitragsmodifikation.AEKOOE_C_CRM_BeitragsmodifikationRepository repo = global::AEKOOE_C_CRM_Beitragsmodifikation.AEKOOE_C_CRM_BeitragsmodifikationRepository.Instance;

        static pruefen_Vorschreibungen_ohne_Beitragsmodifikation instance = new pruefen_Vorschreibungen_ohne_Beitragsmodifikation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public pruefen_Vorschreibungen_ohne_Beitragsmodifikation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static pruefen_Vorschreibungen_ohne_Beitragsmodifikation Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=34,Y=31,Width=1098,Height=350}) on item 'ShellDocObjectView.ShellDocObjectView'.", repo.ShellDocObjectView.ShellDocObjectViewInfo, new RecordItemIndex(0));
            Validate.ContainsImage(repo.ShellDocObjectView.ShellDocObjectViewInfo, ShellDocObjectView_Screenshot1, ShellDocObjectView_Screenshot1_Options);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ShellDocObjectView_Screenshot1
        { get { return repo.ShellDocObjectView.ShellDocObjectViewInfo.GetScreenshot1(new Rectangle(34, 31, 1098, 350)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ShellDocObjectView_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
