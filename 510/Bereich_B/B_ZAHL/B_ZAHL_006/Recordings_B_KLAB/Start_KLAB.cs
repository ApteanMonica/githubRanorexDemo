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

namespace B_ZAHL_006.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_KLAB recording.
    /// </summary>
    [TestModule("32e9b0b4-35dc-4e43-b6bd-b20316a188d8", ModuleType.Recording, 1)]
    public partial class Start_KLAB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_006.B_ZAHL_006Repository repository.
        /// </summary>
        public static global::B_ZAHL_006.B_ZAHL_006Repository repo = global::B_ZAHL_006.B_ZAHL_006Repository.Instance;

        static Start_KLAB instance = new Start_KLAB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_KLAB()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm2 = "B_KLAB KL L";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_KLAB Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("c6e48d2c-9bbd-403a-bd13-79eb619064da")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm2;

        /// <summary>
        /// Gets or sets the value of variable Programm2.
        /// </summary>
        [TestVariable("99c06bde-d0f5-4b78-acfb-43144fcdb980")]
        public string Programm2
        {
            get { return _Programm2; }
            set { _Programm2 = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'FrmKlAb.TitleBar100LieferantenKonto'", repo.FrmKlAb.TitleBar100LieferantenKontoInfo, new ActionTimeout(180000), new RecordItemIndex(1));
            repo.FrmKlAb.TitleBar100LieferantenKontoInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten-Konto') on item 'FrmKlAb.TitleBar100LieferantenKonto'.", repo.FrmKlAb.TitleBar100LieferantenKontoInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmKlAb.TitleBar100LieferantenKontoInfo, "Text", "Lieferanten-Konto");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
