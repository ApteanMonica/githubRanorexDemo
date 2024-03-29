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

namespace B_ELSTER_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formular_D22_auswaehlen recording.
    /// </summary>
    [TestModule("ed0d176d-fba0-4fb5-b95b-1a088b58076d", ModuleType.Recording, 1)]
    public partial class Formular_D22_auswaehlen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_005.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_005.B_ELSTER_005Repository repo = global::B_ELSTER_005.B_ELSTER_005Repository.Instance;

        static Formular_D22_auswaehlen instance = new Formular_D22_auswaehlen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formular_D22_auswaehlen()
        {
            UVA_D22_Form_Name = "UVA-Deutschland 2022 Elster";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formular_D22_auswaehlen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable UVA_D22_Form_Name.
        /// </summary>
        [TestVariable("ba20910b-d112-4934-935d-97b3ee7df73b")]
        public string UVA_D22_Form_Name
        {
            get { return repo.UVA_D22_Form_Name; }
            set { repo.UVA_D22_Form_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUVADruck.CmbUvaFBez' at Center.", repo.DlgUVADruck.CmbUvaFBezInfo, new RecordItemIndex(0));
            repo.DlgUVADruck.CmbUvaFBez.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.UVADeutschland2022Elster' at Center.", repo.List1000.UVADeutschland2022ElsterInfo, new RecordItemIndex(1));
            repo.List1000.UVADeutschland2022Elster.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_D22_Form_Name) on item 'DlgUVADruck.CmbUvaFBez'.", repo.DlgUVADruck.CmbUvaFBezInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgUVADruck.CmbUvaFBezInfo, "Text", UVA_D22_Form_Name);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'DlgUVADruck.PbElster'.", repo.DlgUVADruck.PbElsterInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgUVADruck.PbElsterInfo, "Enabled", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
