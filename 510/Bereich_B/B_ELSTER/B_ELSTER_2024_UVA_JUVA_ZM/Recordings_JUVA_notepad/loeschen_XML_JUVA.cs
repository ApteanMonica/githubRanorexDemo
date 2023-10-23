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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_JUVA_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The loeschen_XML_JUVA recording.
    /// </summary>
    [TestModule("e52a4974-bc58-423b-9db3-0d0694dc345f", ModuleType.Recording, 1)]
    public partial class Loeschen_XML_JUVA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository.Instance;

        static Loeschen_XML_JUVA instance = new Loeschen_XML_JUVA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_XML_JUVA()
        {
            XML_JUVA_Datei = "";
            Pfad = "c:\\temp";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_XML_JUVA Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_JUVA_Datei;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_Datei.
        /// </summary>
        [TestVariable("ec0b93a4-cae8-4452-bc4b-4ef75926cfc0")]
        public string XML_JUVA_Datei
        {
            get { return _XML_JUVA_Datei; }
            set { _XML_JUVA_Datei = value; }
        }

        string _Pfad;

        /// <summary>
        /// Gets or sets the value of variable Pfad.
        /// </summary>
        [TestVariable("31ef149b-cecf-4b57-856f-8a1c25f0cde3")]
        public string Pfad
        {
            get { return _Pfad; }
            set { _Pfad = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.FileLibrary.DeleteFiles(Pfad, XML_JUVA_Datei);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
