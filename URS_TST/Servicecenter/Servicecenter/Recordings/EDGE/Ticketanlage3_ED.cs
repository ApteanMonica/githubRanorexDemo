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

namespace Servicecenter.Recordings.EDGE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ticketanlage3_ED recording.
    /// </summary>
    [TestModule("a6790bd6-d32c-495d-aceb-91e3f08a3b09", ModuleType.Recording, 1)]
    public partial class Ticketanlage3_ED : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Servicecenter.ServicecenterRepository repository.
        /// </summary>
        public static global::Servicecenter.ServicecenterRepository repo = global::Servicecenter.ServicecenterRepository.Instance;

        static Ticketanlage3_ED instance = new Ticketanlage3_ED();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ticketanlage3_ED()
        {
            Dateipfad = "C:\\Testdaten\\URS_TST\\Servicecenter";
            Datei = "Werbung.png";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ticketanlage3_ED Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dateipfad;

        /// <summary>
        /// Gets or sets the value of variable Dateipfad.
        /// </summary>
        [TestVariable("ce176a1d-ce89-481b-b19e-bd2fd4c8794d")]
        public string Dateipfad
        {
            get { return _Dateipfad; }
            set { _Dateipfad = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Datei.
        /// </summary>
        [TestVariable("0f0b517b-03ca-4fae-b87d-6d3289be3fef")]
        public string Datei
        {
            get { return repo.Datei; }
            set { repo.Datei = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.Fehler_Edge.FileUploadTicket1' at 4305;225.", repo.Windows.Fehler_Edge.FileUploadTicket1Info, new RecordItemIndex(0));
            repo.Windows.Fehler_Edge.FileUploadTicket1.Click("4305;225");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.ToolBar1001' at CenterRight.", repo.Windows.ToolBar1001Info, new RecordItemIndex(1));
            repo.Windows.ToolBar1001.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dateipfad'.", new RecordItemIndex(2));
            Keyboard.Press(Dateipfad);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Windows.SystemItemNameDisplay' at Center.", repo.Windows.SystemItemNameDisplayInfo, new RecordItemIndex(5));
            repo.Windows.SystemItemNameDisplay.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Name=$Datei) on item 'Windows.Fehler_Edge.WerbungPng1'.", repo.Windows.Fehler_Edge.WerbungPng1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.Windows.Fehler_Edge.WerbungPng1Info, "Name", Datei);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.Speichern' at Center.", repo.Windows.SpeichernInfo, new RecordItemIndex(7));
            repo.Windows.Speichern.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
