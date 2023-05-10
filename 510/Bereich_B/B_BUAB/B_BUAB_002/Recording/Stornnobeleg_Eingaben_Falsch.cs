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

namespace B_BUAB_002.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stornnobeleg_Eingaben_Falsch recording.
    /// </summary>
    [TestModule("9c0cd88f-52c7-4af2-bfb8-42b21b746132", ModuleType.Recording, 1)]
    public partial class Stornnobeleg_Eingaben_Falsch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_002.B_BUAB_002Repository repository.
        /// </summary>
        public static global::B_BUAB_002.B_BUAB_002Repository repo = global::B_BUAB_002.B_BUAB_002Repository.Instance;

        static Stornnobeleg_Eingaben_Falsch instance = new Stornnobeleg_Eingaben_Falsch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stornnobeleg_Eingaben_Falsch()
        {
            Buchungs_Jahr_Falsch = "2018";
            Buchungs_Monat_Falsch = "01";
            UVA_Jahr_Falsch = "2018";
            UVA_Monat_Falsch = "01";
            Stornobeleg = "BAÄ_04";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stornnobeleg_Eingaben_Falsch Instance
        {
            get { return instance; }
        }

#region Variables

        string _Buchungs_Jahr_Falsch;

        /// <summary>
        /// Gets or sets the value of variable Buchungs_Jahr_Falsch.
        /// </summary>
        [TestVariable("b8b420c0-dfd4-4f54-9e9f-ab6855c07d27")]
        public string Buchungs_Jahr_Falsch
        {
            get { return _Buchungs_Jahr_Falsch; }
            set { _Buchungs_Jahr_Falsch = value; }
        }

        string _Buchungs_Monat_Falsch;

        /// <summary>
        /// Gets or sets the value of variable Buchungs_Monat_Falsch.
        /// </summary>
        [TestVariable("8e1421f2-20d6-4d61-81cb-d4575f76191c")]
        public string Buchungs_Monat_Falsch
        {
            get { return _Buchungs_Monat_Falsch; }
            set { _Buchungs_Monat_Falsch = value; }
        }

        string _UVA_Jahr_Falsch;

        /// <summary>
        /// Gets or sets the value of variable UVA_Jahr_Falsch.
        /// </summary>
        [TestVariable("07452bb7-2305-4fde-a754-3a88863e4894")]
        public string UVA_Jahr_Falsch
        {
            get { return _UVA_Jahr_Falsch; }
            set { _UVA_Jahr_Falsch = value; }
        }

        string _UVA_Monat_Falsch;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_Falsch.
        /// </summary>
        [TestVariable("5482b54d-5dfe-48c2-88ee-a4e2fc8af05f")]
        public string UVA_Monat_Falsch
        {
            get { return _UVA_Monat_Falsch; }
            set { _UVA_Monat_Falsch = value; }
        }

        string _Stornobeleg;

        /// <summary>
        /// Gets or sets the value of variable Stornobeleg.
        /// </summary>
        [TestVariable("32060bef-3423-48b0-b407-43ddeddb6747")]
        public string Stornobeleg
        {
            get { return _Stornobeleg; }
            set { _Stornobeleg = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Storno') on item 'Fenster_Stornobeleg.Storno'.", repo.Fenster_Stornobeleg.StornoInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.Fenster_Stornobeleg.StornoInfo, "Text", "Storno");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Stornobeleg' with focus on 'Fenster_Stornobeleg.NeueBelegNr'.", repo.Fenster_Stornobeleg.NeueBelegNrInfo, new RecordItemIndex(1));
            repo.Fenster_Stornobeleg.NeueBelegNr.EnsureVisible();
            Keyboard.Press(Stornobeleg);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Stornobeleg) on item 'Fenster_Stornobeleg.NeueBelegNr'.", repo.Fenster_Stornobeleg.NeueBelegNrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Fenster_Stornobeleg.NeueBelegNrInfo, "Text", Stornobeleg);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Buchungs_Jahr_Falsch' on item 'Fenster_Stornobeleg.Jahr'.", repo.Fenster_Stornobeleg.JahrInfo, new RecordItemIndex(3));
            repo.Fenster_Stornobeleg.Jahr.Element.SetAttributeValue("Text", Buchungs_Jahr_Falsch);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Buchungs_Monat_Falsch' on item 'Fenster_Stornobeleg.Monat'.", repo.Fenster_Stornobeleg.MonatInfo, new RecordItemIndex(4));
            repo.Fenster_Stornobeleg.Monat.Element.SetAttributeValue("Text", Buchungs_Monat_Falsch);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Fenster_Stornobeleg.UVA_Jahr' at Center.", repo.Fenster_Stornobeleg.UVA_JahrInfo, new RecordItemIndex(5));
            repo.Fenster_Stornobeleg.UVA_Jahr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UVA_Jahr_Falsch' with focus on 'Fenster_Stornobeleg.UVA_Jahr'.", repo.Fenster_Stornobeleg.UVA_JahrInfo, new RecordItemIndex(6));
            repo.Fenster_Stornobeleg.UVA_Jahr.PressKeys(UVA_Jahr_Falsch);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'Fenster_Stornobeleg.UVA_Jahr'.", repo.Fenster_Stornobeleg.UVA_JahrInfo, new RecordItemIndex(7));
            repo.Fenster_Stornobeleg.UVA_Jahr.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA-Jahr 2018 Ok?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "UVA-Jahr 2018 Ok?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$UVA_Monat_Falsch' on item 'Fenster_Stornobeleg.UVA_Monat'.", repo.Fenster_Stornobeleg.UVA_MonatInfo, new RecordItemIndex(10));
            repo.Fenster_Stornobeleg.UVA_Monat.Element.SetAttributeValue("Text", UVA_Monat_Falsch);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Fenster_Stornobeleg.PbOK' at Center.", repo.Fenster_Stornobeleg.PbOKInfo, new RecordItemIndex(11));
            repo.Fenster_Stornobeleg.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bitte gültige Periode eingeben !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Bitte gültige Periode eingeben !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(13));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
