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

namespace K_VERR_001.Recordings_K_IBUFE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_k_ibufe recording.
    /// </summary>
    [TestModule("49673ee5-b345-4046-8a67-9298b258e5d5", ModuleType.Recording, 1)]
    public partial class Start_k_ibufe : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERR_001.K_VERR_001Repository repository.
        /// </summary>
        public static global::K_VERR_001.K_VERR_001Repository repo = global::K_VERR_001.K_VERR_001Repository.Instance;

        static Start_k_ibufe instance = new Start_k_ibufe();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_k_ibufe()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm2 = "K_IBUFE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_k_ibufe Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("7074a84b-56a9-4834-b1e4-57b0882fce1a")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm2;

        /// <summary>
        /// Gets or sets the value of variable Programm2.
        /// </summary>
        [TestVariable("1144b365-ff06-498e-af5c-cebe9f4235cd")]
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblIbufe.TitleBar100KOREBuchungenAnzeigen'", repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'KORE-Buchungen anzeigen') on item 'TblIbufe.TitleBar100KOREBuchungenAnzeigen'.", repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblIbufe.TitleBar100KOREBuchungenAnzeigenInfo, "Text", "KORE-Buchungen anzeigen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
