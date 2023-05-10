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

namespace B_KTO_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Konto_reorganisieren_loeschen recording.
    /// </summary>
    [TestModule("7173f87d-9757-4a8a-b53c-c47188591f62", ModuleType.Recording, 1)]
    public partial class Konto_reorganisieren_loeschen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTO_004.B_KTO_004Repository repository.
        /// </summary>
        public static global::B_KTO_004.B_KTO_004Repository repo = global::B_KTO_004.B_KTO_004Repository.Instance;

        static Konto_reorganisieren_loeschen instance = new Konto_reorganisieren_loeschen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Konto_reorganisieren_loeschen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Konto_reorganisieren_loeschen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.Button_Reogarnisieren' at Center.", repo.FrmKto.Button_ReogarnisierenInfo, new RecordItemIndex(0));
            repo.FrmKto.Button_Reogarnisieren.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ACHTUNG! \r\n \r\nDie Reorganisierung löscht alle Konten mit dem Status <gelöscht> \r\nund kann nicht mehr rückgängig gemacht werden. \r\n \r\nWollen Sie wirklich reorganisieren ? \r\n') on item 'DlgMessageBox.Meldung_Reogarnisieren'.", repo.DlgMessageBox.Meldung_ReogarnisierenInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.Meldung_ReogarnisierenInfo, "Text", "ACHTUNG! \r\n \r\nDie Reorganisierung löscht alle Konten mit dem Status <gelöscht> \r\nund kann nicht mehr rückgängig gemacht werden. \r\n \r\nWollen Sie wirklich reorganisieren ? \r\n");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
