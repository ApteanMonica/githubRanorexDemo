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

namespace B_EXOPV_003.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_B_BUAB recording.
    /// </summary>
    [TestModule("a7c1c7d7-89f1-4790-9f87-d0cc893cdad1", ModuleType.Recording, 1)]
    public partial class Start_B_BUAB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_003.B_EXOPV_003Repository repository.
        /// </summary>
        public static global::B_EXOPV_003.B_EXOPV_003Repository repo = global::B_EXOPV_003.B_EXOPV_003Repository.Instance;

        static Start_B_BUAB instance = new Start_B_BUAB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_B_BUAB()
        {
            Programm = "B_EXOPV";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_4 = "B_BUAB";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_B_BUAB Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("915a0148-4281-4b3e-85ab-1aed8cc2d26c")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("a26681b9-4448-439d-9b40-d2e8549e66e6")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_4;

        /// <summary>
        /// Gets or sets the value of variable Programm_4.
        /// </summary>
        [TestVariable("07f7a83c-893e-44de-89e7-ed92d727304b")]
        public string Programm_4
        {
            get { return _Programm_4; }
            set { _Programm_4 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_4 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_4, "", false);
            
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
