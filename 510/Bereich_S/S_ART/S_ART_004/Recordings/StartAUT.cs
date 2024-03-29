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

namespace S_ART_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("9b0b060c-ae32-452b-af1b-5470e0a19856", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ART_004.S_ART_004Repository repository.
        /// </summary>
        public static global::S_ART_004.S_ART_004Repository repo = global::S_ART_004.S_ART_004Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Programm = "S_ART";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("5a45091f-c630-4504-8d5f-d2b34899a2c1")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("452dc8b5-8608-4c2e-8b30-c4c5629f4b9c")]
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmArt.TitleBar100ArtikelstammVerwalten'", repo.FrmArt.TitleBar100ArtikelstammVerwaltenInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.FrmArt.TitleBar100ArtikelstammVerwaltenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'Artikelstamm verwalten') on item 'FrmArt.TitleBar100ArtikelstammVerwalten'.", repo.FrmArt.TitleBar100ArtikelstammVerwaltenInfo, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.FrmArt.TitleBar100ArtikelstammVerwaltenInfo, "Text", new Regex("Artikelstamm verwalten"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
