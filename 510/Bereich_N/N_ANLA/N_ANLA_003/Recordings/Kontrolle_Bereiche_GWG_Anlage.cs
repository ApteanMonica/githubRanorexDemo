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

namespace N_ANLA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Bereiche_GWG_Anlage recording.
    /// </summary>
    [TestModule("0fbc7708-cc70-4117-9ab3-57195069136c", ModuleType.Recording, 1)]
    public partial class Kontrolle_Bereiche_GWG_Anlage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_003.N_ANLA_003Repository repository.
        /// </summary>
        public static global::N_ANLA_003.N_ANLA_003Repository repo = global::N_ANLA_003.N_ANLA_003Repository.Instance;

        static Kontrolle_Bereiche_GWG_Anlage instance = new Kontrolle_Bereiche_GWG_Anlage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Bereiche_GWG_Anlage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Bereiche_GWG_Anlage Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100]  AVZ - Anlagen') on item 'FrmAnla.TitleBar100AVZAnlagen'.", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmAnla.TitleBar100AVZAnlagenInfo, "Text", "[100]  AVZ - Anlagen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbCommonNew' at Center.", repo.FrmAnla.PbCommonNewInfo, new RecordItemIndex(2));
            repo.FrmAnla.PbCommonNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '003_02{Tab}' with focus on 'FrmAnla.ClientArea.Anlagennr_Maske_N_ANLA'.", repo.FrmAnla.ClientArea.Anlagennr_Maske_N_ANLAInfo, new RecordItemIndex(3));
            repo.FrmAnla.ClientArea.Anlagennr_Maske_N_ANLA.PressKeys("003_02{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.ClientArea.Bereiche' at Center.", repo.FrmAnla.ClientArea.BereicheInfo, new RecordItemIndex(4));
            repo.FrmAnla.ClientArea.Bereiche.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmAnla.Registerkarte_Bereiche.ColAnbePosRow1'.", repo.FrmAnla.Registerkarte_Bereiche.ColAnbePosRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColAnbePosRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'FrmAnla.Registerkarte_Bereiche.ColBektNr1Row1'.", repo.FrmAnla.Registerkarte_Bereiche.ColBektNr1Row1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColBektNr1Row1Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1,00') on item 'FrmAnla.Registerkarte_Bereiche.ColAnbeMengeRow1'.", repo.FrmAnla.Registerkarte_Bereiche.ColAnbeMengeRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColAnbeMengeRow1Info, "Text", "1,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00000000') on item 'FrmAnla.Registerkarte_Bereiche.ColAnbeProzRow1'.", repo.FrmAnla.Registerkarte_Bereiche.ColAnbeProzRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColAnbeProzRow1Info, "Text", "100,00000000");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
