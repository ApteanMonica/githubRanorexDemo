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
    ///The Stornobeleg_Eingaben_Korrekt recording.
    /// </summary>
    [TestModule("a02eff5d-364d-417e-b1df-ac31b259c2d5", ModuleType.Recording, 1)]
    public partial class Stornobeleg_Eingaben_Korrekt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_002.B_BUAB_002Repository repository.
        /// </summary>
        public static global::B_BUAB_002.B_BUAB_002Repository repo = global::B_BUAB_002.B_BUAB_002Repository.Instance;

        static Stornobeleg_Eingaben_Korrekt instance = new Stornobeleg_Eingaben_Korrekt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stornobeleg_Eingaben_Korrekt()
        {
            Buchungs_Jahr_Korrekt = "2019";
            Buchungs_Monat_Korrekt = "12";
            UVA_Jahr_Korrekt = "2020";
            UVA_Monat_Korrekt = "01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stornobeleg_Eingaben_Korrekt Instance
        {
            get { return instance; }
        }

#region Variables

        string _Buchungs_Jahr_Korrekt;

        /// <summary>
        /// Gets or sets the value of variable Buchungs_Jahr_Korrekt.
        /// </summary>
        [TestVariable("689b4feb-ae6a-415e-9a3d-a70c15e8902f")]
        public string Buchungs_Jahr_Korrekt
        {
            get { return _Buchungs_Jahr_Korrekt; }
            set { _Buchungs_Jahr_Korrekt = value; }
        }

        string _Buchungs_Monat_Korrekt;

        /// <summary>
        /// Gets or sets the value of variable Buchungs_Monat_Korrekt.
        /// </summary>
        [TestVariable("2a930b2c-19bd-41fe-876b-a2c4d2ab8ea2")]
        public string Buchungs_Monat_Korrekt
        {
            get { return _Buchungs_Monat_Korrekt; }
            set { _Buchungs_Monat_Korrekt = value; }
        }

        string _UVA_Jahr_Korrekt;

        /// <summary>
        /// Gets or sets the value of variable UVA_Jahr_Korrekt.
        /// </summary>
        [TestVariable("eb7e9fd6-b2ca-4e2b-a02d-eaaed212d4c8")]
        public string UVA_Jahr_Korrekt
        {
            get { return _UVA_Jahr_Korrekt; }
            set { _UVA_Jahr_Korrekt = value; }
        }

        string _UVA_Monat_Korrekt;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_Korrekt.
        /// </summary>
        [TestVariable("b7a599c2-c438-4208-92fe-39453f89f20f")]
        public string UVA_Monat_Korrekt
        {
            get { return _UVA_Monat_Korrekt; }
            set { _UVA_Monat_Korrekt = value; }
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Buchungs_Jahr_Korrekt' on item 'Fenster_Stornobeleg.Jahr'.", repo.Fenster_Stornobeleg.JahrInfo, new RecordItemIndex(1));
            repo.Fenster_Stornobeleg.Jahr.Element.SetAttributeValue("Text", Buchungs_Jahr_Korrekt);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Buchungs_Monat_Korrekt' on item 'Fenster_Stornobeleg.Monat'.", repo.Fenster_Stornobeleg.MonatInfo, new RecordItemIndex(2));
            repo.Fenster_Stornobeleg.Monat.Element.SetAttributeValue("Text", Buchungs_Monat_Korrekt);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$UVA_Jahr_Korrekt' on item 'Fenster_Stornobeleg.UVA_Jahr'.", repo.Fenster_Stornobeleg.UVA_JahrInfo, new RecordItemIndex(3));
            repo.Fenster_Stornobeleg.UVA_Jahr.Element.SetAttributeValue("Text", UVA_Jahr_Korrekt);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$UVA_Monat_Korrekt' on item 'Fenster_Stornobeleg.UVA_Monat'.", repo.Fenster_Stornobeleg.UVA_MonatInfo, new RecordItemIndex(4));
            repo.Fenster_Stornobeleg.UVA_Monat.Element.SetAttributeValue("Text", UVA_Monat_Korrekt);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Fenster_Stornobeleg.PbOK' at Center.", repo.Fenster_Stornobeleg.PbOKInfo, new RecordItemIndex(5));
            repo.Fenster_Stornobeleg.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Stornobuchung durchgeführt!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Stornobuchung durchgeführt!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
