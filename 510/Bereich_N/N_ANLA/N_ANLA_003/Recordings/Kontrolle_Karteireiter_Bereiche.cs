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
    ///The Kontrolle_Karteireiter_Bereiche recording.
    /// </summary>
    [TestModule("86fa9bb9-60eb-430f-98f3-e12810e6a2b1", ModuleType.Recording, 1)]
    public partial class Kontrolle_Karteireiter_Bereiche : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_003.N_ANLA_003Repository repository.
        /// </summary>
        public static global::N_ANLA_003.N_ANLA_003Repository repo = global::N_ANLA_003.N_ANLA_003Repository.Instance;

        static Kontrolle_Karteireiter_Bereiche instance = new Kontrolle_Karteireiter_Bereiche();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Karteireiter_Bereiche()
        {
            Positon_Anlage_003_01 = "1";
            Konstenstelle_Anlage_003_01 = "10";
            Menge_Anlage_003_01 = "1,00";
            Aufteilung_Prozent_Anlage_003_01 = "100,00000000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Karteireiter_Bereiche Instance
        {
            get { return instance; }
        }

#region Variables

        string _Positon_Anlage_003_01;

        /// <summary>
        /// Gets or sets the value of variable Positon_Anlage_003_01.
        /// </summary>
        [TestVariable("1f47d2d2-8320-439b-9c58-754c95cb48f5")]
        public string Positon_Anlage_003_01
        {
            get { return _Positon_Anlage_003_01; }
            set { _Positon_Anlage_003_01 = value; }
        }

        string _Konstenstelle_Anlage_003_01;

        /// <summary>
        /// Gets or sets the value of variable Konstenstelle_Anlage_003_01.
        /// </summary>
        [TestVariable("eddaba8c-3e39-467a-91c0-52d029b7a0bc")]
        public string Konstenstelle_Anlage_003_01
        {
            get { return _Konstenstelle_Anlage_003_01; }
            set { _Konstenstelle_Anlage_003_01 = value; }
        }

        string _Menge_Anlage_003_01;

        /// <summary>
        /// Gets or sets the value of variable Menge_Anlage_003_01.
        /// </summary>
        [TestVariable("ddbb4042-8223-4666-a251-3e5361773446")]
        public string Menge_Anlage_003_01
        {
            get { return _Menge_Anlage_003_01; }
            set { _Menge_Anlage_003_01 = value; }
        }

        string _Aufteilung_Prozent_Anlage_003_01;

        /// <summary>
        /// Gets or sets the value of variable Aufteilung_Prozent_Anlage_003_01.
        /// </summary>
        [TestVariable("eb05e480-8593-43e8-8e11-70ebddda68f5")]
        public string Aufteilung_Prozent_Anlage_003_01
        {
            get { return _Aufteilung_Prozent_Anlage_003_01; }
            set { _Aufteilung_Prozent_Anlage_003_01 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100]  AVZ - Anlagen') on item 'FrmAnla.TitleBar100AVZAnlagen'.", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmAnla.TitleBar100AVZAnlagenInfo, "Text", "[100]  AVZ - Anlagen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbCommonNew' at Center.", repo.FrmAnla.PbCommonNewInfo, new RecordItemIndex(2));
            repo.FrmAnla.PbCommonNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '003_01{Tab}' with focus on 'FrmAnla.ClientArea.Anlagennr_Maske_N_ANLA'.", repo.FrmAnla.ClientArea.Anlagennr_Maske_N_ANLAInfo, new RecordItemIndex(3));
            repo.FrmAnla.ClientArea.Anlagennr_Maske_N_ANLA.PressKeys("003_01{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.ClientArea.Bereiche' at Center.", repo.FrmAnla.ClientArea.BereicheInfo, new RecordItemIndex(4));
            repo.FrmAnla.ClientArea.Bereiche.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Positon_Anlage_003_01) on item 'FrmAnla.Registerkarte_Bereiche.ColAnbePosRow1'.", repo.FrmAnla.Registerkarte_Bereiche.ColAnbePosRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColAnbePosRow1Info, "Text", Positon_Anlage_003_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Konstenstelle_Anlage_003_01) on item 'FrmAnla.Registerkarte_Bereiche.ColBektNr1Row1'.", repo.FrmAnla.Registerkarte_Bereiche.ColBektNr1Row1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColBektNr1Row1Info, "Text", Konstenstelle_Anlage_003_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Menge_Anlage_003_01) on item 'FrmAnla.Registerkarte_Bereiche.ColAnbeMengeRow1'.", repo.FrmAnla.Registerkarte_Bereiche.ColAnbeMengeRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColAnbeMengeRow1Info, "Text", Menge_Anlage_003_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Aufteilung_Prozent_Anlage_003_01) on item 'FrmAnla.Registerkarte_Bereiche.ColAnbeProzRow1'.", repo.FrmAnla.Registerkarte_Bereiche.ColAnbeProzRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmAnla.Registerkarte_Bereiche.ColAnbeProzRow1Info, "Text", Aufteilung_Prozent_Anlage_003_01);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
