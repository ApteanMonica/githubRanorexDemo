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

namespace E_LIST_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Firmenwechsel recording.
    /// </summary>
    [TestModule("0ac64352-cd19-44ce-8fa6-8a0805677bbe", ModuleType.Recording, 1)]
    public partial class Firmenwechsel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LIST_003.E_LIST_003Repository repository.
        /// </summary>
        public static global::E_LIST_003.E_LIST_003Repository repo = global::E_LIST_003.E_LIST_003Repository.Instance;

        static Firmenwechsel instance = new Firmenwechsel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Firmenwechsel()
        {
            Firma = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Firmenwechsel Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("3a8dbb57-b5e8-4d97-bf52-67a633320bd4")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblRechList.PbCommonFirmenwechsel' at Center.", repo.TblRechList.PbCommonFirmenwechselInfo, new RecordItemIndex(0));
            repo.TblRechList.PbCommonFirmenwechsel.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Firmenwechsel.Firma' at Center.", repo.Firmenwechsel.FirmaInfo, new RecordItemIndex(1));
            repo.Firmenwechsel.Firma.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Firma' on item 'Firmenwechsel.Firma'.", repo.Firmenwechsel.FirmaInfo, new RecordItemIndex(2));
            repo.Firmenwechsel.Firma.Element.SetAttributeValue("AccessibleValue", Firma);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Firma) on item 'Firmenwechsel.Firma'.", repo.Firmenwechsel.FirmaInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Firmenwechsel.FirmaInfo, "AccessibleValue", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Firmenwechsel.PbOk' at Center.", repo.Firmenwechsel.PbOkInfo, new RecordItemIndex(4));
            repo.Firmenwechsel.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (AccessibleValue~$Firma) on item 'TblRechList.TitleBar'.", repo.TblRechList.TitleBarInfo, new RecordItemIndex(5));
            Validate.AttributeRegex(repo.TblRechList.TitleBarInfo, "AccessibleValue", new Regex(Firma));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
