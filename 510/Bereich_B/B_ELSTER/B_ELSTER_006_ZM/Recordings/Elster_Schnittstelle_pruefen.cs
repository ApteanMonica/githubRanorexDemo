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

namespace B_ELSTER_006_ZM.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Elster_Schnittstelle_pruefen recording.
    /// </summary>
    [TestModule("a570b97e-0dda-46bd-9edb-55cc1fa0ca76", ModuleType.Recording, 1)]
    public partial class Elster_Schnittstelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_006_ZM.B_ELSTER_006_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_006_ZM.B_ELSTER_006_ZMRepository repo = global::B_ELSTER_006_ZM.B_ELSTER_006_ZMRepository.Instance;

        static Elster_Schnittstelle_pruefen instance = new Elster_Schnittstelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Elster_Schnittstelle_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Elster_Schnittstelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'FrmMain_B_ELSTER.TitleBar300ELSTERSchnittstelleUVA'", repo.FrmMain_B_ELSTER.TitleBar300ELSTERSchnittstelleUVAInfo, new ActionTimeout(300000), new RecordItemIndex(0));
            repo.FrmMain_B_ELSTER.TitleBar300ELSTERSchnittstelleUVAInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to not exist. Associated repository item: 'Hinweis'", repo.Hinweis.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.Hinweis.SelfInfo.WaitForNotExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ELSTER-Schnittstelle') on item 'FrmMain_B_ELSTER.TitleBar300ELSTERSchnittstelleUVA'.", repo.FrmMain_B_ELSTER.TitleBar300ELSTERSchnittstelleUVAInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmMain_B_ELSTER.TitleBar300ELSTERSchnittstelleUVAInfo, "Text", "ELSTER-Schnittstelle");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain_B_ELSTER.ClientArea.CbTest'.", repo.FrmMain_B_ELSTER.ClientArea.CbTestInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain_B_ELSTER.ClientArea.CbTestInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9181081508155') on item 'FrmMain_B_ELSTER.ClientArea.DfSteuernr'.", repo.FrmMain_B_ELSTER.ClientArea.DfSteuernrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain_B_ELSTER.ClientArea.DfSteuernrInfo, "Text", "9181081508155");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'9181') on item 'FrmMain_B_ELSTER.ClientArea.Finanzamt_510'.", repo.FrmMain_B_ELSTER.ClientArea.Finanzamt_510Info, new RecordItemIndex(5));
            //Validate.AttributeContains(repo.FrmMain_B_ELSTER.ClientArea.Finanzamt_510Info, "Text", "9181");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
