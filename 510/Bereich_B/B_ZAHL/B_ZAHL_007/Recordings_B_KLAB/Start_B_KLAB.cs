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

namespace B_ZAHL_007.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_B_KLAB recording.
    /// </summary>
    [TestModule("2d708e4b-91f4-40f3-9a13-bfd8061ba662", ModuleType.Recording, 1)]
    public partial class Start_B_KLAB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_007.B_ZAHL_007Repository repository.
        /// </summary>
        public static global::B_ZAHL_007.B_ZAHL_007Repository repo = global::B_ZAHL_007.B_ZAHL_007Repository.Instance;

        static Start_B_KLAB instance = new Start_B_KLAB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_B_KLAB()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_2 = "B_KLAB KL L";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_B_KLAB Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("036643ea-bbd6-4e8c-8039-052c4d138f0f")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_2;

        /// <summary>
        /// Gets or sets the value of variable Programm_2.
        /// </summary>
        [TestVariable("0486593a-8029-4db2-9665-8e5c9c34287a")]
        public string Programm_2
        {
            get { return _Programm_2; }
            set { _Programm_2 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKlAb.TitleBar100LieferantenKonto'", repo.FrmKlAb.TitleBar100LieferantenKontoInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmKlAb.TitleBar100LieferantenKontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten-Konto') on item 'FrmKlAb.TitleBar100LieferantenKonto'.", repo.FrmKlAb.TitleBar100LieferantenKontoInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmKlAb.TitleBar100LieferantenKontoInfo, "Text", "Lieferanten-Konto");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
