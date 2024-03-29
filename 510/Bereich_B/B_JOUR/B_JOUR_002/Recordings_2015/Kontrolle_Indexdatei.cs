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

namespace B_JOUR_002.Recordings_2015
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Indexdatei recording.
    /// </summary>
    [TestModule("3ad85349-5fa0-41b3-b8e7-71d6ee8b9c01", ModuleType.Recording, 1)]
    public partial class Kontrolle_Indexdatei : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JOUR_002.B_JOUR_002Repository repository.
        /// </summary>
        public static global::B_JOUR_002.B_JOUR_002Repository repo = global::B_JOUR_002.B_JOUR_002Repository.Instance;

        static Kontrolle_Indexdatei instance = new Kontrolle_Indexdatei();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Indexdatei()
        {
            Index_xml_Werte = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Indexdatei Instance
        {
            get { return instance; }
        }

#region Variables

        string _Index_xml_Werte;

        /// <summary>
        /// Gets or sets the value of variable Index_xml_Werte.
        /// </summary>
        [TestVariable("413a417e-c0d1-4166-9b69-521100b375e6")]
        public string Index_xml_Werte
        {
            get { return _Index_xml_Werte; }
            set { _Index_xml_Werte = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'IndexXmlEditor.IndexXmlEditor'.", repo.IndexXmlEditor.IndexXmlEditorInfo, new RecordItemIndex(0));
            Validate.Exists(repo.IndexXmlEditor.IndexXmlEditorInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Index_xml_Werte) on item 'IndexXmlEditor.Text15'.", repo.IndexXmlEditor.Text15Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.IndexXmlEditor.Text15Info, "Text", Index_xml_Werte);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
