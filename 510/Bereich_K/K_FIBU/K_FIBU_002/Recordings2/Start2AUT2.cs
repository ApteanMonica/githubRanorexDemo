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

namespace K_FIBU_002.Recordings2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start2AUT2 recording.
    /// </summary>
    [TestModule("7b36dbea-e305-42ab-b479-07f84e4e02b7", ModuleType.Recording, 1)]
    public partial class Start2AUT2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_002.K_FIBU_002Repository repository.
        /// </summary>
        public static global::K_FIBU_002.K_FIBU_002Repository repo = global::K_FIBU_002.K_FIBU_002Repository.Instance;

        static Start2AUT2 instance = new Start2AUT2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start2AUT2()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm2 = "K_IBUFE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start2AUT2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("eece2f3e-a2d8-4864-842a-7924a044bcec")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm2;

        /// <summary>
        /// Gets or sets the value of variable Programm2.
        /// </summary>
        [TestVariable("8165783a-0d50-4722-a076-173bc366dcf4")]
        public string Programm2
        {
            get { return _Programm2; }
            set { _Programm2 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblIbufe.TitleBar100KOREBuchungenAnzeigen'", repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>' KORE-Buchungen anzeigen') on item 'TblIbufe.TitleBar100KOREBuchungenAnzeigen'.", repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo, "Text", " KORE-Buchungen anzeigen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
