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

namespace B_UVA_2024_U30_2023_U1.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Druck_UVA_Werte_aufrufen recording.
    /// </summary>
    [TestModule("2fd77acf-95d2-462b-aab3-8256c7396334", ModuleType.Recording, 1)]
    public partial class Druck_UVA_Werte_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository.Instance;

        static Druck_UVA_Werte_aufrufen instance = new Druck_UVA_Werte_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Druck_UVA_Werte_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Druck_UVA_Werte_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Form_Name_VORJAHR.
        /// </summary>
        [TestVariable("32c85a1f-9bfe-4286-aee1-de432dec44a5")]
        public string Form_Name_VORJAHR
        {
            get { return repo.Form_Name_VORJAHR; }
            set { repo.Form_Name_VORJAHR = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TblUVAF.TitleBar200VerwaltenUVAFormulare'.", repo.TblUVAF.TitleBar200VerwaltenUVAFormulareInfo, new RecordItemIndex(0));
            Validate.Exists(repo.TblUVAF.TitleBar200VerwaltenUVAFormulareInfo);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_VORJAHR'", repo.TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_VORJAHRInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_VORJAHRInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUVAF.PbCommonDrucken' at Center.", repo.TblUVAF.PbCommonDruckenInfo, new RecordItemIndex(2));
            repo.TblUVAF.PbCommonDrucken.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgUVADruck.TitleBar100DruckUVAWerte'", repo.DlgUVADruck.TitleBar100DruckUVAWerteInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.DlgUVADruck.TitleBar100DruckUVAWerteInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVADruck.TitleBar100DruckUVAWerte'.", repo.DlgUVADruck.TitleBar100DruckUVAWerteInfo, new RecordItemIndex(4));
            Validate.Exists(repo.DlgUVADruck.TitleBar100DruckUVAWerteInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
