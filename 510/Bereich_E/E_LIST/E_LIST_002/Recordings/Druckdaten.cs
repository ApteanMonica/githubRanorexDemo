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

namespace E_LIST_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Druckdaten recording.
    /// </summary>
    [TestModule("b491d12c-eb59-435e-ab44-434a9a412886", ModuleType.Recording, 1)]
    public partial class Druckdaten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LIST_002.E_LIST_002Repository repository.
        /// </summary>
        public static global::E_LIST_002.E_LIST_002Repository repo = global::E_LIST_002.E_LIST_002Repository.Instance;

        static Druckdaten instance = new Druckdaten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Druckdaten()
        {
            Benutzer = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Druckdaten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Benutzer;

        /// <summary>
        /// Gets or sets the value of variable Benutzer.
        /// </summary>
        [TestVariable("62206a8c-f5f2-428a-9c0b-2eb686c9cfb0")]
        public string Benutzer
        {
            get { return _Benutzer; }
            set { _Benutzer = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='Lieferant') on item 'FrmBsko.Kriterien'.", repo.FrmBsko.KriterienInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBsko.KriterienInfo, "AccessibleValue", "Lieferant");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBsko.Kriterien' at Center.", repo.FrmBsko.KriterienInfo, new RecordItemIndex(1));
            repo.FrmBsko.Kriterien.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='Postleitzahl') on item 'FrmBsko.Kriterien'.", repo.FrmBsko.KriterienInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBsko.KriterienInfo, "AccessibleValue", "Postleitzahl");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBsko.Kriterien' at Center.", repo.FrmBsko.KriterienInfo, new RecordItemIndex(3));
            repo.FrmBsko.Kriterien.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='Bestelldatum') on item 'FrmBsko.Kriterien'.", repo.FrmBsko.KriterienInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBsko.KriterienInfo, "AccessibleValue", "Bestelldatum");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBsko.Kriterien' at Center.", repo.FrmBsko.KriterienInfo, new RecordItemIndex(5));
            repo.FrmBsko.Kriterien.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Benutzer' on item 'FrmBsko.FuerBenutzer'.", repo.FrmBsko.FuerBenutzerInfo, new RecordItemIndex(6));
            repo.FrmBsko.FuerBenutzer.Element.SetAttributeValue("AccessibleValue", Benutzer);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Benutzer) on item 'FrmBsko.FuerBenutzer'.", repo.FrmBsko.FuerBenutzerInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBsko.FuerBenutzerInfo, "AccessibleValue", Benutzer);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
