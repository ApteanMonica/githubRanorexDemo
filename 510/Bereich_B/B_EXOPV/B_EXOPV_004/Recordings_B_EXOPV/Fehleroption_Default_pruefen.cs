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

namespace B_EXOPV_004.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Fehleroption_Default_pruefen recording.
    /// </summary>
    [TestModule("5cd9f441-a840-4ad2-8d33-490f0297a6fc", ModuleType.Recording, 1)]
    public partial class Fehleroption_Default_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Fehleroption_Default_pruefen instance = new Fehleroption_Default_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fehleroption_Default_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fehleroption_Default_pruefen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbOptionenOptionen' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbOptionenOptionenInfo, new RecordItemIndex(0));
            repo.Form100ExterneBuchungenVerbuchen.PbOptionenOptionen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgOptionenParameter.TitleBar100Optionen'", repo.DlgOptionenParameter.TitleBar100OptionenInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.DlgOptionenParameter.TitleBar100OptionenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'DlgOptionenParameter.TpName0.CbFehlerstatus'.", repo.DlgOptionenParameter.TpName0.CbFehlerstatusInfo, new RecordItemIndex(2));
            repo.DlgOptionenParameter.TpName0.CbFehlerstatus.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgOptionenParameter.TpName0.CbFehlerstatus'.", repo.DlgOptionenParameter.TpName0.CbFehlerstatusInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgOptionenParameter.TpName0.CbFehlerstatusInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgOptionenParameter.PbSpeichern' at Center.", repo.DlgOptionenParameter.PbSpeichernInfo, new RecordItemIndex(4));
            repo.DlgOptionenParameter.PbSpeichern.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
