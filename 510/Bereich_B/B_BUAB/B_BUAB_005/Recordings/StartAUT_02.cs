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

namespace B_BUAB_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT_02 recording.
    /// </summary>
    [TestModule("d82df25d-138c-4672-a239-e10a05a11e0f", ModuleType.Recording, 1)]
    public partial class StartAUT_02 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_005.B_BUAB_005Repository repository.
        /// </summary>
        public static global::B_BUAB_005.B_BUAB_005Repository repo = global::B_BUAB_005.B_BUAB_005Repository.Instance;

        static StartAUT_02 instance = new StartAUT_02();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT_02()
        {
            Programm2 = "B_KLAB";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Tagesdatum = "";
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
        [TestVariable("afe2f0b1-c5e6-474e-8ba6-3ddf0c2f50f0")]
        public string Programm2
        {
            get { return _Programm2; }
            set { _Programm2 = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("0216fd4d-8b9e-49ca-8427-630d9d9b7b7f")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("013da815-616e-4e45-8124-8d4de2cce544")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKlAb.TitleBar100KundenKonto'", repo.FrmKlAb.TitleBar100KundenKontoInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmKlAb.TitleBar100KundenKontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Konto') on item 'FrmKlAb.TitleBar100KundenKonto'.", repo.FrmKlAb.TitleBar100KundenKontoInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmKlAb.TitleBar100KundenKontoInfo, "Text", "Konto");
            
            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
