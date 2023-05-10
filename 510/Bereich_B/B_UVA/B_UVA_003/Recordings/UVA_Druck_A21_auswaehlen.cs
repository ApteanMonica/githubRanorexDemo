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

namespace B_UVA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_Druck_A21_auswaehlen recording.
    /// </summary>
    [TestModule("7314fea2-bd46-4999-864e-5c7a40cc3af5", ModuleType.Recording, 1)]
    public partial class UVA_Druck_A21_auswaehlen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_003.B_UVA_003Repository repository.
        /// </summary>
        public static global::B_UVA_003.B_UVA_003Repository repo = global::B_UVA_003.B_UVA_003Repository.Instance;

        static UVA_Druck_A21_auswaehlen instance = new UVA_Druck_A21_auswaehlen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_Druck_A21_auswaehlen()
        {
            UVA_A21_Form_Name = "UVA-Österreich 2021";
            UVA_A20_2_Form_Name = "UVA-Österreich 2020 mit Steuersenkung";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_Druck_A21_auswaehlen Instance
        {
            get { return instance; }
        }

#region Variables

        string _UVA_A21_Form_Name;

        /// <summary>
        /// Gets or sets the value of variable UVA_A21_Form_Name.
        /// </summary>
        [TestVariable("82db5d5d-96f4-45af-8219-b6be2235d203")]
        public string UVA_A21_Form_Name
        {
            get { return _UVA_A21_Form_Name; }
            set { _UVA_A21_Form_Name = value; }
        }

        string _UVA_A20_2_Form_Name;

        /// <summary>
        /// Gets or sets the value of variable UVA_A20_2_Form_Name.
        /// </summary>
        [TestVariable("7bbc5896-0f6e-4263-af84-85bd32cd585d")]
        public string UVA_A20_2_Form_Name
        {
            get { return _UVA_A20_2_Form_Name; }
            set { _UVA_A20_2_Form_Name = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Druck UVA-Werte') on item 'DlgUVADruck.TitleBar200DruckUVAWerte'.", repo.DlgUVADruck.TitleBar200DruckUVAWerteInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.DlgUVADruck.TitleBar200DruckUVAWerteInfo, "Text", "Druck UVA-Werte");
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute ControlText to '$UVA_A21_Form_Name' on item 'DlgUVADruck.TpFormular.CmbUvaFBez'.", repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, new RecordItemIndex(1));
            //repo.DlgUVADruck.TpFormular.CmbUvaFBez.Element.SetAttributeValue("ControlText", UVA_A21_Form_Name);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Up' Press with focus on 'DlgUVADruck.TpFormular.CmbUvaFBez'.", repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, new RecordItemIndex(2));
            //Keyboard.PrepareFocus(repo.DlgUVADruck.TpFormular.CmbUvaFBez);
            //Keyboard.Press(System.Windows.Forms.Keys.Up, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Down' Press with focus on 'DlgUVADruck.TpFormular.CmbUvaFBez'.", repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, new RecordItemIndex(3));
            //Keyboard.PrepareFocus(repo.DlgUVADruck.TpFormular.CmbUvaFBez);
            //Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUVADruck.TpFormular.CmbUvaFBez' at Center.", repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, new RecordItemIndex(4));
            repo.DlgUVADruck.TpFormular.CmbUvaFBez.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.UVAOEsterreich2021' at Center.", repo.List1000.UVAOEsterreich2021Info, new RecordItemIndex(5));
            repo.List1000.UVAOEsterreich2021.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AT') on item 'DlgUVADruck.TpFormular.Land'.", repo.DlgUVADruck.TpFormular.LandInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.LandInfo, "Text", "AT");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_A21_Form_Name) on item 'DlgUVADruck.TpFormular.CmbUvaFBez'.", repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgUVADruck.TpFormular.CmbUvaFBezInfo, "Text", UVA_A21_Form_Name);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
