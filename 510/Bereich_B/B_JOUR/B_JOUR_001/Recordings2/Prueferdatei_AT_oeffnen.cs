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

namespace B_JOUR_001.Recordings2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Prueferdatei_AT_oeffnen recording.
    /// </summary>
    [TestModule("8843b689-3f40-4e72-beaf-77fc87b0bba5", ModuleType.Recording, 1)]
    public partial class Prueferdatei_AT_oeffnen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JOUR_001.B_JOUR_001Repository repository.
        /// </summary>
        public static global::B_JOUR_001.B_JOUR_001Repository repo = global::B_JOUR_001.B_JOUR_001Repository.Instance;

        static Prueferdatei_AT_oeffnen instance = new Prueferdatei_AT_oeffnen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Prueferdatei_AT_oeffnen()
        {
            Pfad_File1 = "c:\\temp\\b_JOUR_001_journal_AT_endgueltig_2017.txt";
            File1 = "b_JOUR_001_journal_AT_endgueltig_2017.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Prueferdatei_AT_oeffnen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Pfad_File1;

        /// <summary>
        /// Gets or sets the value of variable Pfad_File1.
        /// </summary>
        [TestVariable("80c3a1b5-5e86-43bf-a59d-f42ada893253")]
        public string Pfad_File1
        {
            get { return _Pfad_File1; }
            set { _Pfad_File1 = value; }
        }

        string _File1;

        /// <summary>
        /// Gets or sets the value of variable File1.
        /// </summary>
        [TestVariable("9d124195-f73d-4bb4-845d-c8efa9ee388b")]
        public string File1
        {
            get { return _File1; }
            set { _File1 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Pfad_File1 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Pfad_File1, "", "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'BJOUR001JournalATEndgueltig2017Tx.BJOUR001JournalATEndgueltig2017Tx'", repo.BJOUR001JournalATEndgueltig2017Tx.BJOUR001JournalATEndgueltig2017TxInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.BJOUR001JournalATEndgueltig2017Tx.BJOUR001JournalATEndgueltig2017TxInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$File1) on item 'BJOUR001JournalATEndgueltig2017Tx.BJOUR001JournalATEndgueltig2017Tx'.", repo.BJOUR001JournalATEndgueltig2017Tx.BJOUR001JournalATEndgueltig2017TxInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.BJOUR001JournalATEndgueltig2017Tx.BJOUR001JournalATEndgueltig2017TxInfo, "Text", File1);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
