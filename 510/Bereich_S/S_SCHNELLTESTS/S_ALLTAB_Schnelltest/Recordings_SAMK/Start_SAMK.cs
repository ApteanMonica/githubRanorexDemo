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

namespace S_ALLTAB_Schnelltest.Recordings_SAMK
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_SAMK recording.
    /// </summary>
    [TestModule("58e333df-d2d5-4640-a1da-4adb992cc2c1", ModuleType.Recording, 1)]
    public partial class Start_SAMK : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ALLTAB_Schnelltest.S_ALLTAB_SchnelltestRepository repository.
        /// </summary>
        public static global::S_ALLTAB_Schnelltest.S_ALLTAB_SchnelltestRepository repo = global::S_ALLTAB_Schnelltest.S_ALLTAB_SchnelltestRepository.Instance;

        static Start_SAMK instance = new Start_SAMK();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_SAMK()
        {
            Programm_SAMK = "S_ALLTAB Aufrufart SAMK";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_SAMK Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm_SAMK;

        /// <summary>
        /// Gets or sets the value of variable Programm_SAMK.
        /// </summary>
        [TestVariable("94c3d809-eb01-4df6-9cfd-4201027663d3")]
        public string Programm_SAMK
        {
            get { return _Programm_SAMK; }
            set { _Programm_SAMK = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("5c18c78b-4859-4e87-ad05-6f7459cbf4c6")]
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_SAMK in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_SAMK, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblSamk.TitleBar100VerwaltenSammelkonten'", repo.TblSamk.TitleBar100VerwaltenSammelkontenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblSamk.TitleBar100VerwaltenSammelkontenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Verwalten Sammelkonten') on item 'TblSamk.TitleBar100VerwaltenSammelkonten'.", repo.TblSamk.TitleBar100VerwaltenSammelkontenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblSamk.TitleBar100VerwaltenSammelkontenInfo, "Text", "Verwalten Sammelkonten");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
