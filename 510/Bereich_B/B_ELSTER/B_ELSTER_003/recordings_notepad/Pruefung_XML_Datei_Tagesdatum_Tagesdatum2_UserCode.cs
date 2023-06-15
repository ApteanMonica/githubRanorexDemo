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

namespace B_ELSTER_003.recordings_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_XML_Datei_Tagesdatum_Tagesdatum2_UserCode recording.
    /// </summary>
    [TestModule("968f40ec-5fdc-4279-ac26-1649aabedf27", ModuleType.Recording, 1)]
    public partial class Pruefung_XML_Datei_Tagesdatum_Tagesdatum2_UserCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_003.B_ELSTER_003Repository repository.
        /// </summary>
        public static global::B_ELSTER_003.B_ELSTER_003Repository repo = global::B_ELSTER_003.B_ELSTER_003Repository.Instance;

        static Pruefung_XML_Datei_Tagesdatum_Tagesdatum2_UserCode instance = new Pruefung_XML_Datei_Tagesdatum_Tagesdatum2_UserCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_XML_Datei_Tagesdatum_Tagesdatum2_UserCode()
        {
            XML_Inhalt_aktuell = "";
            Tagesdatum_yyyyMMdd = "";
            Tagesdatum2_yyyyMMdd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_XML_Datei_Tagesdatum_Tagesdatum2_UserCode Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_Inhalt_aktuell;

        /// <summary>
        /// Gets or sets the value of variable XML_Inhalt_aktuell.
        /// </summary>
        [TestVariable("4e27003d-1e92-4757-9f4b-2d2dc6621e4e")]
        public string XML_Inhalt_aktuell
        {
            get { return _XML_Inhalt_aktuell; }
            set { _XML_Inhalt_aktuell = value; }
        }

        string _Tagesdatum_yyyyMMdd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_yyyyMMdd.
        /// </summary>
        [TestVariable("55bbd373-4c7c-4082-b387-a5ceca8dc517")]
        public string Tagesdatum_yyyyMMdd
        {
            get { return _Tagesdatum_yyyyMMdd; }
            set { _Tagesdatum_yyyyMMdd = value; }
        }

        string _Tagesdatum2_yyyyMMdd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum2_yyyyMMdd.
        /// </summary>
        [TestVariable("3be57a67-cc4c-4e9e-b70e-9245edd391df")]
        public string Tagesdatum2_yyyyMMdd
        {
            get { return _Tagesdatum2_yyyyMMdd; }
            set { _Tagesdatum2_yyyyMMdd = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(XML_Inhalt_aktuell, Tagesdatum_yyyyMMdd, Tagesdatum2_yyyyMMdd);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
