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

namespace B_ERBU_002.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT_B_EXOPV recording.
    /// </summary>
    [TestModule("9d1bd3c6-a179-4e71-9a06-f511828c1778", ModuleType.Recording, 1)]
    public partial class StartAUT_B_EXOPV : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static StartAUT_B_EXOPV instance = new StartAUT_B_EXOPV();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT_B_EXOPV()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_3 = "B_EXOPV";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT_B_EXOPV Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("cdca62f4-1bf4-4d68-9a2e-8b0c03f8a015")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_3;

        /// <summary>
        /// Gets or sets the value of variable Programm_3.
        /// </summary>
        [TestVariable("1a936585-0bde-4489-8ecb-4f2f70fb6ddd")]
        public string Programm_3
        {
            get { return _Programm_3; }
            set { _Programm_3 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_3 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_3, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmMain_Schnittstelle_verbuchen.TitleBar100ExterneBuchungenVerbuche'", repo.FrmMain_Schnittstelle_verbuchen.TitleBar100ExterneBuchungenVerbucheInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmMain_Schnittstelle_verbuchen.TitleBar100ExterneBuchungenVerbucheInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Externe Buchungen verbuchen') on item 'FrmMain_Schnittstelle_verbuchen.TitleBar100ExterneBuchungenVerbuche'.", repo.FrmMain_Schnittstelle_verbuchen.TitleBar100ExterneBuchungenVerbucheInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmMain_Schnittstelle_verbuchen.TitleBar100ExterneBuchungenVerbucheInfo, "Text", "Externe Buchungen verbuchen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
