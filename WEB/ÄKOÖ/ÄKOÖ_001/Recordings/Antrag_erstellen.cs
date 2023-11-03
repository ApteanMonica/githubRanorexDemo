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

namespace AEKOOE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Antrag_erstellen recording.
    /// </summary>
    [TestModule("c1fc7f03-4be8-4d0a-96ba-9449c089f93c", ModuleType.Recording, 1)]
    public partial class Antrag_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_001.AEKOOE_001Repository repository.
        /// </summary>
        public static global::AEKOOE_001.AEKOOE_001Repository repo = global::AEKOOE_001.AEKOOE_001Repository.Instance;

        static Antrag_erstellen instance = new Antrag_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Antrag_erstellen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Antrag_erstellen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.Card1_Button_Antraege_' at Center.", repo.Login.Card1_Button_Antraege_Info, new RecordItemIndex(0));
            repo.Login.Card1_Button_Antraege_.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'Login.Antrag'", repo.Login.AntragInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.Login.AntragInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Antrag') on item 'Login.Antrag'.", repo.Login.AntragInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Login.AntragInfo, "InnerText", "Antrag");
            
            // wurde eingebaut, weil die WEboberfläche Button "Neu" anzeigt bevor er richtig geladen wird, weshalb sich beim Klick drauf nichts tut.
            Report.Log(ReportLevel.Info, "Wait", "wurde eingebaut, weil die WEboberfläche Button \"Neu\" anzeigt bevor er richtig geladen wird, weshalb sich beim Klick drauf nichts tut.\r\nWaiting 2m to exist. Associated repository item: 'Login.BtnBtnSecondary'", repo.Login.BtnBtnSecondaryInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.Login.BtnBtnSecondaryInfo.WaitForExists(120000);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            //Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Login.ButtonTagBtn'.", repo.Login.ButtonTagBtnInfo, new RecordItemIndex(5));
            Validate.Exists(repo.Login.ButtonTagBtnInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.ButtonTagBtn' at Center.", repo.Login.ButtonTagBtnInfo, new RecordItemIndex(6));
            repo.Login.ButtonTagBtn.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.Antragskategorie1' at Center.", repo.Login.Antragskategorie1Info, new RecordItemIndex(7));
            repo.Login.Antragskategorie1.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
