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

namespace B_JOUR_001.Recordings2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Prueferdatei_AT recording.
    /// </summary>
    [TestModule("4d8cee57-f096-4c14-bbfc-ecf31f9b2a83", ModuleType.Recording, 1)]
    public partial class Kontrolle_Prueferdatei_AT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JOUR_001.B_JOUR_001Repository repository.
        /// </summary>
        public static global::B_JOUR_001.B_JOUR_001Repository repo = global::B_JOUR_001.B_JOUR_001Repository.Instance;

        static Kontrolle_Prueferdatei_AT instance = new Kontrolle_Prueferdatei_AT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Prueferdatei_AT()
        {
            Prueferdatei_AT_Werte_2017 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Prueferdatei_AT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Prueferdatei_AT_Werte_2017;

        /// <summary>
        /// Gets or sets the value of variable Prueferdatei_AT_Werte_2017.
        /// </summary>
        [TestVariable("df8394ba-97f4-496c-b737-6858b0ab3117")]
        public string Prueferdatei_AT_Werte_2017
        {
            get { return _Prueferdatei_AT_Werte_2017; }
            set { _Prueferdatei_AT_Werte_2017 = value; }
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

            // Kontrolle Buchungs/Journalzeilen mit Spaltenüberschriften
            Report.Log(ReportLevel.Info, "Validation", "Kontrolle Buchungs/Journalzeilen mit Spaltenüberschriften\r\nValidating AttributeContains (Text>$Prueferdatei_AT_Werte_2017) on item 'Journal_mit_Kopfzeile_und_Buchungszeilen'.", repo.Journal_mit_Kopfzeile_und_BuchungszeilenInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.Journal_mit_Kopfzeile_und_BuchungszeilenInfo, "Text", Prueferdatei_AT_Werte_2017);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
