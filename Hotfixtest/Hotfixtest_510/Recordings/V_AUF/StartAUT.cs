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

namespace Hotfixtest_510.Recordings.V_AUF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("4be66d73-80e7-473d-bc4d-88db4182d718", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Hotfixtest_510.Hotfixtest_510Repository repository.
        /// </summary>
        public static global::Hotfixtest_510.Hotfixtest_510Repository repo = global::Hotfixtest_510.Hotfixtest_510Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            V_AUF = "V_AUF";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("ff20259d-e136-477d-889d-fa4d5f16bad7")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _V_AUF;

        /// <summary>
        /// Gets or sets the value of variable V_AUF.
        /// </summary>
        [TestVariable("323487d3-130e-4e32-b873-f65328ae1013")]
        public string V_AUF
        {
            get { return _V_AUF; }
            set { _V_AUF = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $V_AUF in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, V_AUF, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 4m to exist. Associated repository item: 'V_AUF.TitleBar100Auftragserfassung'", repo.V_AUF.TitleBar100AuftragserfassungInfo, new ActionTimeout(240000), new RecordItemIndex(1));
            repo.V_AUF.TitleBar100AuftragserfassungInfo.WaitForExists(240000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'Auftragserfassung') on item 'V_AUF.TitleBar100Auftragserfassung'.", repo.V_AUF.TitleBar100AuftragserfassungInfo, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.V_AUF.TitleBar100AuftragserfassungInfo, "Text", new Regex("Auftragserfassung"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
