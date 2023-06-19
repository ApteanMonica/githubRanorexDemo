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

namespace B_BUCH_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Eingabe recording.
    /// </summary>
    [TestModule("33ddf31e-027a-483b-bf55-2f1b8988ab2e", ModuleType.Recording, 1)]
    public partial class Eingabe : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_006.B_BUCH_006Repository repository.
        /// </summary>
        public static global::B_BUCH_006.B_BUCH_006Repository repo = global::B_BUCH_006.B_BUCH_006Repository.Instance;

        static Eingabe instance = new Eingabe();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Eingabe()
        {
            lieferant = "303112";
            ER_Nr = "2300007";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Eingabe Instance
        {
            get { return instance; }
        }

#region Variables

        string _lieferant;

        /// <summary>
        /// Gets or sets the value of variable lieferant.
        /// </summary>
        [TestVariable("42569c32-9290-4c73-bbd5-4a02ea07e18d")]
        public string lieferant
        {
            get { return _lieferant; }
            set { _lieferant = value; }
        }

        string _ER_Nr;

        /// <summary>
        /// Gets or sets the value of variable ER_Nr.
        /// </summary>
        [TestVariable("6743f457-3009-4575-a198-aaa2a4695a2a")]
        public string ER_Nr
        {
            get { return _ER_Nr; }
            set { _ER_Nr = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F4}' with focus on 'MdiBuch.Beleg'.", repo.MdiBuch.BelegInfo, new RecordItemIndex(0));
            repo.MdiBuch.Beleg.PressKeys("{F4}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$lieferant' with focus on 'TblErbu.Lieferant'.", repo.TblErbu.LieferantInfo, new RecordItemIndex(1));
            repo.TblErbu.Lieferant.PressKeys(lieferant);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ER_Nr' with focus on 'TblErbu.ERNr'.", repo.TblErbu.ERNrInfo, new RecordItemIndex(2));
            repo.TblErbu.ERNr.PressKeys(ER_Nr);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.PbDataAccessLaden' at Center.", repo.TblErbu.PbDataAccessLadenInfo, new RecordItemIndex(3));
            repo.TblErbu.PbDataAccessLaden.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblErbu.PbStandard1' at Center.", repo.TblErbu.PbStandard1Info, new RecordItemIndex(4));
            repo.TblErbu.PbStandard1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12}'.", new RecordItemIndex(5));
            Keyboard.Press("{F12}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
