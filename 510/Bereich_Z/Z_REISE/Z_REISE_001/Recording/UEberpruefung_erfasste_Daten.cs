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

namespace Z_REISE_001.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UEberpruefung_erfasste_Daten recording.
    /// </summary>
    [TestModule("3fbee3ac-5a6a-42b8-a0ef-a2dfc8ab4245", ModuleType.Recording, 1)]
    public partial class UEberpruefung_erfasste_Daten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_REISE_001.Z_REISE_001Repository repository.
        /// </summary>
        public static global::Z_REISE_001.Z_REISE_001Repository repo = global::Z_REISE_001.Z_REISE_001Repository.Instance;

        static UEberpruefung_erfasste_Daten instance = new UEberpruefung_erfasste_Daten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UEberpruefung_erfasste_Daten()
        {
            Datum_von = "01.01.1900";
            Datum_bis = "31.12.2999";
            Bezeichnung = "Kundenbereich";
            Code = "KB";
            Reisevariante = "I";
            Info_Text = "QS-Test";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UEberpruefung_erfasste_Daten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_von;

        /// <summary>
        /// Gets or sets the value of variable Datum_von.
        /// </summary>
        [TestVariable("d78e6fe3-c456-4975-9605-7269e332315d")]
        public string Datum_von
        {
            get { return _Datum_von; }
            set { _Datum_von = value; }
        }

        string _Datum_bis;

        /// <summary>
        /// Gets or sets the value of variable Datum_bis.
        /// </summary>
        [TestVariable("6a318ab6-5c14-4bb1-b96a-a35027c3ae8f")]
        public string Datum_bis
        {
            get { return _Datum_bis; }
            set { _Datum_bis = value; }
        }

        string _Bezeichnung;

        /// <summary>
        /// Gets or sets the value of variable Bezeichnung.
        /// </summary>
        [TestVariable("98e03ea1-01c9-4448-b836-cc3a16c999bf")]
        public string Bezeichnung
        {
            get { return _Bezeichnung; }
            set { _Bezeichnung = value; }
        }

        string _Code;

        /// <summary>
        /// Gets or sets the value of variable Code.
        /// </summary>
        [TestVariable("e8507319-78ef-431c-b741-c0aa17a3629a")]
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        string _Reisevariante;

        /// <summary>
        /// Gets or sets the value of variable Reisevariante.
        /// </summary>
        [TestVariable("e5dc674e-6e54-4b46-9887-93d541f4e587")]
        public string Reisevariante
        {
            get { return _Reisevariante; }
            set { _Reisevariante = value; }
        }

        string _Info_Text;

        /// <summary>
        /// Gets or sets the value of variable Info_Text.
        /// </summary>
        [TestVariable("9bf9971a-d796-481a-b50b-04384fd85380")]
        public string Info_Text
        {
            get { return _Info_Text; }
            set { _Info_Text = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_von) on item 'FormRart.ColDtvonRow1'.", repo.FormRart.ColDtvonRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FormRart.ColDtvonRow1Info, "Text", Datum_von);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_bis) on item 'FormRart.ColDtbisRow1'.", repo.FormRart.ColDtbisRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FormRart.ColDtbisRow1Info, "Text", Datum_bis);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Code) on item 'FormRart.DfRartCd'.", repo.FormRart.DfRartCdInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FormRart.DfRartCdInfo, "Text", Code);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bezeichnung) on item 'FormRart.DfRartBez'.", repo.FormRart.DfRartBezInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FormRart.DfRartBezInfo, "Text", Bezeichnung);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Reisevariante) on item 'FormRart.DfRkVar'.", repo.FormRart.DfRkVarInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FormRart.DfRkVarInfo, "Text", Reisevariante);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Info_Text) on item 'FormRart.Info_511_521'.", repo.FormRart.Info_511_521Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FormRart.Info_511_521Info, "Text", Info_Text);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
