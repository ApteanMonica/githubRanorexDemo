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

namespace B_BUCH_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_Eingabe_Vorauszahlung recording.
    /// </summary>
    [TestModule("56cefa75-40c7-480c-a090-f8d40d25da4e", ModuleType.Recording, 1)]
    public partial class Validation_Eingabe_Vorauszahlung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_003.B_BUCH_003Repository repository.
        /// </summary>
        public static global::B_BUCH_003.B_BUCH_003Repository repo = global::B_BUCH_003.B_BUCH_003Repository.Instance;

        static Validation_Eingabe_Vorauszahlung instance = new Validation_Eingabe_Vorauszahlung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_Eingabe_Vorauszahlung()
        {
            Beleg2 = "B_BUCH_003_2";
            Kunde = "200006";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_Eingabe_Vorauszahlung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg2;

        /// <summary>
        /// Gets or sets the value of variable Beleg2.
        /// </summary>
        [TestVariable("59c94877-e6d2-474c-b0b8-0fb3b56e09b9")]
        public string Beleg2
        {
            get { return _Beleg2; }
            set { _Beleg2 = value; }
        }

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("7491f7da-eed9-4994-8c03-7049a6ead16e")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'MdiBuch.tblSB_Bereichsbuchungszeile.Row1'", repo.MdiBuch.tblSB_Bereichsbuchungszeile.Row1Info, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.MdiBuch.tblSB_Bereichsbuchungszeile.Row1Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'500,00\t\t\t\t\tVorauszahlung\t30') on item 'MdiBuch.tblSB_Bereichsbuchungszeile.Row1'.", repo.MdiBuch.tblSB_Bereichsbuchungszeile.Row1Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.MdiBuch.tblSB_Bereichsbuchungszeile.Row1Info, "Text", "500,00\t\t\t\t\tVorauszahlung\t30");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
