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

namespace B_BUCH_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_Jahr_Periode_Busy recording.
    /// </summary>
    [TestModule("9e945422-9b9f-4cec-af56-abc3b907024d", ModuleType.Recording, 1)]
    public partial class Validation_Jahr_Periode_Busy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_002.B_BUCH_002Repository repository.
        /// </summary>
        public static global::B_BUCH_002.B_BUCH_002Repository repo = global::B_BUCH_002.B_BUCH_002Repository.Instance;

        static Validation_Jahr_Periode_Busy instance = new Validation_Jahr_Periode_Busy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_Jahr_Periode_Busy()
        {
            Busy = "AR";
            Jahr = "2020";
            Monat = "01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_Jahr_Periode_Busy Instance
        {
            get { return instance; }
        }

#region Variables

        string _Busy;

        /// <summary>
        /// Gets or sets the value of variable Busy.
        /// </summary>
        [TestVariable("6c310bcf-88e9-40c7-95eb-611510951272")]
        public string Busy
        {
            get { return _Busy; }
            set { _Busy = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("1734b967-3310-44b9-adea-1392315ce631")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Monat;

        /// <summary>
        /// Gets or sets the value of variable Monat.
        /// </summary>
        [TestVariable("9d068b37-4c0e-445c-be09-0acdbc7d5e12")]
        public string Monat
        {
            get { return _Monat; }
            set { _Monat = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Dialogbuchung') on item 'MdiBuch.TitleBar100Dialogbuchung'.", repo.MdiBuch.TitleBar100DialogbuchungInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.MdiBuch.TitleBar100DialogbuchungInfo, "Text", "Dialogbuchung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'MdiBuch.Toolbar_Kopfbereich.DfFirma'.", repo.MdiBuch.Toolbar_Kopfbereich.DfFirmaInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfFirmaInfo, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Busy) on item 'MdiBuch.Toolbar_Kopfbereich.DfBusyCd'.", repo.MdiBuch.Toolbar_Kopfbereich.DfBusyCdInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfBusyCdInfo, "Text", Busy);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'MdiBuch.Toolbar_Kopfbereich.DfJahrbezJ'.", repo.MdiBuch.Toolbar_Kopfbereich.DfJahrbezJInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfJahrbezJInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Monat) on item 'MdiBuch.Toolbar_Kopfbereich.DfPeriodeJ'.", repo.MdiBuch.Toolbar_Kopfbereich.DfPeriodeJInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfPeriodeJInfo, "Text", Monat);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfSoll'.", repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfSollInfo, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'MdiBuch.Toolbar_Kopfbereich.DfHaben'.", repo.MdiBuch.Toolbar_Kopfbereich.DfHabenInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiBuch.Toolbar_Kopfbereich.DfHabenInfo, "Text", "0,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
