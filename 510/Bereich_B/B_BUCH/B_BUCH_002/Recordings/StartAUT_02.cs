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

namespace B_BUCH_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT_02 recording.
    /// </summary>
    [TestModule("8f9b9b30-35ee-4e13-98b5-f04061286677", ModuleType.Recording, 1)]
    public partial class StartAUT_02 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_002.B_BUCH_001Repository repository.
        /// </summary>
        public static global::B_BUCH_002.B_BUCH_001Repository repo = global::B_BUCH_002.B_BUCH_001Repository.Instance;

        static StartAUT_02 instance = new StartAUT_02();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT_02()
        {
            Programm2 = "B_BUAB";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT_02 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm2;

        /// <summary>
        /// Gets or sets the value of variable Programm2.
        /// </summary>
        [TestVariable("d47aaff5-697f-49b6-9a00-bf43e0f051f1")]
        public string Programm2
        {
            get { return _Programm2; }
            set { _Programm2 = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("6b7fbe99-c263-4d21-b912-0dc3440a1679")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblB.TitleBar100BuchungenAnzeigen'", repo.TblB.TitleBar100BuchungenAnzeigenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblB.TitleBar100BuchungenAnzeigenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Buchungen') on item 'TblB.TitleBar100BuchungenAnzeigen'.", repo.TblB.TitleBar100BuchungenAnzeigenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblB.TitleBar100BuchungenAnzeigenInfo, "Text", "Buchungen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
