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
    ///The loeschen_XML_JUVA recording.
    /// </summary>
    [TestModule("a314ecd6-ca9b-439b-bc1a-131607d6f973", ModuleType.Recording, 1)]
    public partial class Loeschen_XML_JUVA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_003.B_ELSTER_003Repository repository.
        /// </summary>
        public static global::B_ELSTER_003.B_ELSTER_003Repository repo = global::B_ELSTER_003.B_ELSTER_003Repository.Instance;

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
        [TestVariable("13e091cb-8da3-407b-9219-4bff2018a1d0")]
        public string XML_JUVA_Datei
        {
            get { return _XML_JUVA_Datei; }
            set { _XML_JUVA_Datei = value; }
        }

        string _Pfad;

        /// <summary>
        /// Gets or sets the value of variable Pfad.
        /// </summary>
        [TestVariable("2177e852-0302-4b17-a5fa-5a41be48f4c2")]
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
