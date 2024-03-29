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

namespace B_MNDR_002.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT_2 recording.
    /// </summary>
    [TestModule("6f63c9c1-4749-4026-be93-e67860ff7534", ModuleType.Recording, 1)]
    public partial class StartAUT_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_002.B_MNDR_002Repository repository.
        /// </summary>
        public static global::B_MNDR_002.B_MNDR_002Repository repo = global::B_MNDR_002.B_MNDR_002Repository.Instance;

        static StartAUT_2 instance = new StartAUT_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT_2()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Progamm_2 = "B_KLAB KL K";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("c0c4f8c5-9a6e-42bb-84e6-784a0f47983e")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Progamm_2;

        /// <summary>
        /// Gets or sets the value of variable Progamm_2.
        /// </summary>
        [TestVariable("4d9eccc5-b4fa-4f41-855b-ebd4dae8e79c")]
        public string Progamm_2
        {
            get { return _Progamm_2; }
            set { _Progamm_2 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Progamm_2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Progamm_2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKlAb.TitleBar100KundenKonto'", repo.FrmKlAb.TitleBar100KundenKontoInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmKlAb.TitleBar100KundenKontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kunden-Konto') on item 'FrmKlAb.TitleBar100KundenKonto'.", repo.FrmKlAb.TitleBar100KundenKontoInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmKlAb.TitleBar100KundenKontoInfo, "Text", "Kunden-Konto");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
