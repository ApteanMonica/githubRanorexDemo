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

namespace B_EXOPV_005.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_B_BUAB recording.
    /// </summary>
    [TestModule("23307373-546d-47a8-b04d-8ea957263cd0", ModuleType.Recording, 1)]
    public partial class Start_B_BUAB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Start_B_BUAB instance = new Start_B_BUAB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_B_BUAB()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_3 = "B_BUAB";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_B_BUAB Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("f4d059c4-6c64-4ed4-8b05-48ddb68a667e")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_3;

        /// <summary>
        /// Gets or sets the value of variable Programm_3.
        /// </summary>
        [TestVariable("334effdd-578f-400c-85ee-8a062d4b05f0")]
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblB.TitleBar100BuchungenAnzeigen'", repo.TblB.TitleBar100BuchungenAnzeigenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblB.TitleBar100BuchungenAnzeigenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Buchungen anzeigen') on item 'TblB.TitleBar100BuchungenAnzeigen'.", repo.TblB.TitleBar100BuchungenAnzeigenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblB.TitleBar100BuchungenAnzeigenInfo, "Text", "Buchungen anzeigen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}