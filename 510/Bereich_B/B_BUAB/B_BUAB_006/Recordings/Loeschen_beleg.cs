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

namespace B_BUAB_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Loeschen_beleg recording.
    /// </summary>
    [TestModule("af958a6b-c2e4-404f-b6a2-8c03c1dc324e", ModuleType.Recording, 1)]
    public partial class Loeschen_beleg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_006.B_BUAB_006Repository repository.
        /// </summary>
        public static global::B_BUAB_006.B_BUAB_006Repository repo = global::B_BUAB_006.B_BUAB_006Repository.Instance;

        static Loeschen_beleg instance = new Loeschen_beleg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_beleg()
        {
            beleg_loeschen = "BA_2030001_2020_1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_beleg Instance
        {
            get { return instance; }
        }

#region Variables

        string _beleg_loeschen;

        /// <summary>
        /// Gets or sets the value of variable beleg_loeschen.
        /// </summary>
        [TestVariable("99b59377-f025-4c5b-a944-fc83110a3356")]
        public string beleg_loeschen
        {
            get { return _beleg_loeschen; }
            set { _beleg_loeschen = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$beleg_loeschen' with focus on 'TblB.Beleg'.", repo.TblB.BelegInfo, new RecordItemIndex(0));
            repo.TblB.Beleg.PressKeys(beleg_loeschen);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbDataAccessLoad' at Center.", repo.TblB.PbDataAccessLoadInfo, new RecordItemIndex(1));
            repo.TblB.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbExtrasLoeschen' at Center.", repo.TblB.PbExtrasLoeschenInfo, new RecordItemIndex(2));
            repo.TblB.PbExtrasLoeschen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BBUAB.Loeschen' at Center.", repo.BBUAB.LoeschenInfo, new RecordItemIndex(3));
            repo.BBUAB.Loeschen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(5));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbDataAccessLoad' at Center.", repo.TblB.PbDataAccessLoadInfo, new RecordItemIndex(6));
            repo.TblB.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
