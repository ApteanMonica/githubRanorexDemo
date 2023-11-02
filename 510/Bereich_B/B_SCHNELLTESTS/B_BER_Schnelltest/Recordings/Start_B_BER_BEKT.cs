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

namespace B_BER_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_B_BER_BEKT recording.
    /// </summary>
    [TestModule("4d784fe1-d508-4a9c-aa1e-6d73b2cca66e", ModuleType.Recording, 1)]
    public partial class Start_B_BER_BEKT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BER_Schnelltest.B_BER_SchnelltestRepository repository.
        /// </summary>
        public static global::B_BER_Schnelltest.B_BER_SchnelltestRepository repo = global::B_BER_Schnelltest.B_BER_SchnelltestRepository.Instance;

        static Start_B_BER_BEKT instance = new Start_B_BER_BEKT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_B_BER_BEKT()
        {
            Programm_BEKT = "B_BER Aufrufart BEKT";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_B_BER_BEKT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm_BEKT;

        /// <summary>
        /// Gets or sets the value of variable Programm_BEKT.
        /// </summary>
        [TestVariable("6895b48b-0492-4671-9136-610bbe1a600d")]
        public string Programm_BEKT
        {
            get { return _Programm_BEKT; }
            set { _Programm_BEKT = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("b6866913-a9be-4f3f-91d3-7a5bb492786c")]
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_BEKT in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_BEKT, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblBekt.TitleBar100VerwaltenBereichskonten'", repo.TblBekt.TitleBar100VerwaltenBereichskontenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblBekt.TitleBar100VerwaltenBereichskontenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Verwalten Bereichskonten') on item 'TblBekt.TitleBar100VerwaltenBereichskonten'.", repo.TblBekt.TitleBar100VerwaltenBereichskontenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblBekt.TitleBar100VerwaltenBereichskontenInfo, "Text", "Verwalten Bereichskonten");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
