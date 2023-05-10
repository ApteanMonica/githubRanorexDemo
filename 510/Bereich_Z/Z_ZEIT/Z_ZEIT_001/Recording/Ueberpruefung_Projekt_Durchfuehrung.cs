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

namespace Z_ZEIT_001.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberpruefung_Projekt_Durchfuehrung recording.
    /// </summary>
    [TestModule("575b6088-5a6d-4787-b4b4-f2a3e8bbe602", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_Projekt_Durchfuehrung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_ZEIT_001.Z_ZEIT_001Repository repository.
        /// </summary>
        public static global::Z_ZEIT_001.Z_ZEIT_001Repository repo = global::Z_ZEIT_001.Z_ZEIT_001Repository.Instance;

        static Ueberpruefung_Projekt_Durchfuehrung instance = new Ueberpruefung_Projekt_Durchfuehrung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_Projekt_Durchfuehrung()
        {
            Projekt_1 = "ZEIT_001";
            Phase_Dokumentation = "202";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_Projekt_Durchfuehrung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Projekt_1;

        /// <summary>
        /// Gets or sets the value of variable Projekt_1.
        /// </summary>
        [TestVariable("b6656160-1857-4f36-bf5a-3e1147cbeadc")]
        public string Projekt_1
        {
            get { return _Projekt_1; }
            set { _Projekt_1 = value; }
        }

        string _Phase_Dokumentation;

        /// <summary>
        /// Gets or sets the value of variable Phase_Dokumentation.
        /// </summary>
        [TestVariable("a7b65b21-5c45-4fae-b09e-7eaf5a3560fe")]
        public string Phase_Dokumentation
        {
            get { return _Phase_Dokumentation; }
            set { _Phase_Dokumentation = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Projekt_1) on item 'MdiZeit.Tabelle.Zeile_4.ColProjNrRow4'.", repo.MdiZeit.Tabelle.Zeile_4.ColProjNrRow4Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MdiZeit.Tabelle.Zeile_4.ColProjNrRow4Info, "Text", Projekt_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Phase_Dokumentation) on item 'MdiZeit.Tabelle.Zeile_4.ColPhasCdRow4'.", repo.MdiZeit.Tabelle.Zeile_4.ColPhasCdRow4Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiZeit.Tabelle.Zeile_4.ColPhasCdRow4Info, "Text", Phase_Dokumentation);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='02:00') on item 'MdiZeit.Tabelle.Zeile_4.ColZeitIstZRow4'.", repo.MdiZeit.Tabelle.Zeile_4.ColZeitIstZRow4Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiZeit.Tabelle.Zeile_4.ColZeitIstZRow4Info, "Text", "02:00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
