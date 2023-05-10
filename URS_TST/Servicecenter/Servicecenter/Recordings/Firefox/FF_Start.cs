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

namespace Servicecenter.Recordings.Firefox
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FF_Start recording.
    /// </summary>
    [TestModule("d1f91980-9b84-44da-b0bd-4e5d6cb19790", ModuleType.Recording, 1)]
    public partial class FF_Start : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Servicecenter.ServicecenterRepository repository.
        /// </summary>
        public static global::Servicecenter.ServicecenterRepository repo = global::Servicecenter.ServicecenterRepository.Instance;

        static FF_Start instance = new FF_Start();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FF_Start()
        {
            Link = "https://sbg-webservtst.rs-soft.com/#login";
            Datum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FF_Start Instance
        {
            get { return instance; }
        }

#region Variables

        string _Link;

        /// <summary>
        /// Gets or sets the value of variable Link.
        /// </summary>
        [TestVariable("c7b6c12a-fdde-44a2-9526-abfd8c17e1df")]
        public string Link
        {
            get { return _Link; }
            set { _Link = value; }
        }

        string _Datum;

        /// <summary>
        /// Gets or sets the value of variable Datum.
        /// </summary>
        [TestVariable("5f3f77dd-151b-456b-95c8-77ac846a89ef")]
        public string Datum
        {
            get { return _Datum; }
            set { _Datum = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $Link with browser 'Firefox' in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(Link, "Firefox", "", false, true, false, false, false, false, false, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Link) on item 'FF.Adresse'.", repo.FF.AdresseInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FF.AdresseInfo, "Text", Link);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(2));
            Delay.Duration(15000, false);
            
            Datum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("yyyy-MM-dd");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
