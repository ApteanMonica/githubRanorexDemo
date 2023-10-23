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

namespace B_UVA_2024_U30_2023_U1.Recordings_Formular_Werte_2017_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_2017_2_U30_ausgeben recording.
    /// </summary>
    [TestModule("530d6a6b-3b74-46f7-b3ff-494a7724d206", ModuleType.Recording, 1)]
    public partial class UVA_2017_2_U30_ausgeben : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository.Instance;

        static UVA_2017_2_U30_ausgeben instance = new UVA_2017_2_U30_ausgeben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_2017_2_U30_ausgeben()
        {
            UVA_Jahr_2017 = "2017";
            UVA_Monat_2 = "2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_2017_2_U30_ausgeben Instance
        {
            get { return instance; }
        }

#region Variables

        string _UVA_Jahr_2017;

        /// <summary>
        /// Gets or sets the value of variable UVA_Jahr_2017.
        /// </summary>
        [TestVariable("18109532-f0f7-4ad2-b120-250661cc7f81")]
        public string UVA_Jahr_2017
        {
            get { return _UVA_Jahr_2017; }
            set { _UVA_Jahr_2017 = value; }
        }

        string _UVA_Monat_2;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_2.
        /// </summary>
        [TestVariable("155d055e-8273-4e57-9c1c-5b05f0878d02")]
        public string UVA_Monat_2
        {
            get { return _UVA_Monat_2; }
            set { _UVA_Monat_2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVADruck.TitleBar200DruckUVAWerte'.", repo.DlgUVADruck.TitleBar200DruckUVAWerteInfo, new RecordItemIndex(0));
            Validate.Exists(repo.DlgUVADruck.TitleBar200DruckUVAWerteInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UVA_Jahr_2017' with focus on 'DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVon'.", repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVonInfo, new RecordItemIndex(1));
            repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVon.PressKeys(UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVon'.", repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVonInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVon);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UVA_Monat_2' with focus on 'DlgUVADruck.TpFormular.Text'.", repo.DlgUVADruck.TpFormular.TextInfo, new RecordItemIndex(3));
            repo.DlgUVADruck.TpFormular.Text.PressKeys(UVA_Monat_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Jahr_2017) on item 'DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVon'.", repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.FormulardruckFuerJahrMonatVonInfo, "Text", UVA_Jahr_2017);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_2) on item 'DlgUVADruck.TpFormular.Text'.", repo.DlgUVADruck.TpFormular.TextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.TextInfo, "Text", UVA_Monat_2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUVADruck.PbDruck' at Center.", repo.DlgUVADruck.PbDruckInfo, new RecordItemIndex(6));
            repo.DlgUVADruck.PbDruck.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
