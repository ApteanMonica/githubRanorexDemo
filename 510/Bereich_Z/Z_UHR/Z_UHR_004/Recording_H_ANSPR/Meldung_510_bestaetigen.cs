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

namespace Z_UHR_004.Recording_H_ANSPR
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_510_bestaetigen recording.
    /// </summary>
    [TestModule("6b561320-56ee-4587-b95b-0b09594c8fab", ModuleType.Recording, 1)]
    public partial class Meldung_510_bestaetigen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_004.Z_UHR_004Repository repository.
        /// </summary>
        public static global::Z_UHR_004.Z_UHR_004Repository repo = global::Z_UHR_004.Z_UHR_004Repository.Instance;

        static Meldung_510_bestaetigen instance = new Meldung_510_bestaetigen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_510_bestaetigen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_510_bestaetigen Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.Anspruchsdefinition_510'", repo.DlgMessageBox.Anspruchsdefinition_510Info, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgMessageBox.Anspruchsdefinition_510Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Erfolgreich berechnet!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Erfolgreich berechnet!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFehlzeitergebnisse.PbDataAccessReload_510' at Center.", repo.TblFehlzeitergebnisse.PbDataAccessReload_510Info, new RecordItemIndex(3));
            repo.TblFehlzeitergebnisse.PbDataAccessReload_510.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
