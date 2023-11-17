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

namespace B_BUDA_001.Recordings_B_BUCH
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_B_BUCH recording.
    /// </summary>
    [TestModule("860758e5-b32c-4726-9297-0fc9b679de08", ModuleType.Recording, 1)]
    public partial class Start_B_BUCH : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_001.B_BUDA_001Repository repository.
        /// </summary>
        public static global::B_BUDA_001.B_BUDA_001Repository repo = global::B_BUDA_001.B_BUDA_001Repository.Instance;

        static Start_B_BUCH instance = new Start_B_BUCH();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_B_BUCH()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_B_BUCH = "B_BUCH PAR3 BUC";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_B_BUCH Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("558262d9-048a-448c-9c9b-436034fe9890")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_B_BUCH;

        /// <summary>
        /// Gets or sets the value of variable Programm_B_BUCH.
        /// </summary>
        [TestVariable("6c9fa107-17f1-4b73-ae3a-669e2788b0df")]
        public string Programm_B_BUCH
        {
            get { return _Programm_B_BUCH; }
            set { _Programm_B_BUCH = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_B_BUCH in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_B_BUCH, "", false);
            
            // Maske Periodeneingabe
            Report.Log(ReportLevel.Info, "Wait", "Maske Periodeneingabe\r\nWaiting 7m to exist. Associated repository item: 'DlgFirmaPeriode.TitleBar100Dialogbuchung'", repo.DlgFirmaPeriode.TitleBar100DialogbuchungInfo, new ActionTimeout(420000), new RecordItemIndex(1));
            repo.DlgFirmaPeriode.TitleBar100DialogbuchungInfo.WaitForExists(420000);
            
            // Maske Periodeneingabe
            Report.Log(ReportLevel.Info, "Validation", "Maske Periodeneingabe\r\nValidating AttributeContains (Text>'Dialogbuchung') on item 'DlgFirmaPeriode.TitleBar100Dialogbuchung'.", repo.DlgFirmaPeriode.TitleBar100DialogbuchungInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgFirmaPeriode.TitleBar100DialogbuchungInfo, "Text", "Dialogbuchung");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
