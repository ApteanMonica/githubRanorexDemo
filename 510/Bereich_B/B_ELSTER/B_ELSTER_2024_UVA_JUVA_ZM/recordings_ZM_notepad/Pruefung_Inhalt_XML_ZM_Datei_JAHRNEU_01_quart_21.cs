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

namespace B_ELSTER_2024_UVA_JUVA_ZM.recordings_ZM_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Inhalt_XML_ZM_Datei_JAHRNEU_01_quart_21 recording.
    /// </summary>
    [TestModule("650ee93e-62bd-4141-b7b0-3cf6f424c2f9", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_ZM_Datei_JAHRNEU_01_quart_21 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Pruefung_Inhalt_XML_ZM_Datei_JAHRNEU_01_quart_21 instance = new Pruefung_Inhalt_XML_ZM_Datei_JAHRNEU_01_quart_21();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_ZM_Datei_JAHRNEU_01_quart_21()
        {
            XML_ZM_Version_JAHRNEU = "";
            XML_ZM_JAHRNEU_01_Teil_1 = "";
            XML_ZM_JAHRNEU_01_Teil_2 = "";
            XML_ZM_JAHRNEU_01_Teil_3 = "";
            XML_ZM_JAHRNEU_01_Teil_4_quart21 = "";
            JAHRNEU = "";
            XML_ZM_JAHRNEU_01_Teil_5 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_ZM_Datei_JAHRNEU_01_quart_21 Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_ZM_Version_JAHRNEU;

        /// <summary>
        /// Gets or sets the value of variable XML_ZM_Version_JAHRNEU.
        /// </summary>
        [TestVariable("b6eb57f6-8115-4979-a651-8152bbcc5a68")]
        public string XML_ZM_Version_JAHRNEU
        {
            get { return _XML_ZM_Version_JAHRNEU; }
            set { _XML_ZM_Version_JAHRNEU = value; }
        }

        string _XML_ZM_JAHRNEU_01_Teil_1;

        /// <summary>
        /// Gets or sets the value of variable XML_ZM_JAHRNEU_01_Teil_1.
        /// </summary>
        [TestVariable("3a18b84c-0056-4767-9473-821624859d52")]
        public string XML_ZM_JAHRNEU_01_Teil_1
        {
            get { return _XML_ZM_JAHRNEU_01_Teil_1; }
            set { _XML_ZM_JAHRNEU_01_Teil_1 = value; }
        }

        string _XML_ZM_JAHRNEU_01_Teil_2;

        /// <summary>
        /// Gets or sets the value of variable XML_ZM_JAHRNEU_01_Teil_2.
        /// </summary>
        [TestVariable("9cabe337-fcfa-4443-b7c6-e12eae1a6685")]
        public string XML_ZM_JAHRNEU_01_Teil_2
        {
            get { return _XML_ZM_JAHRNEU_01_Teil_2; }
            set { _XML_ZM_JAHRNEU_01_Teil_2 = value; }
        }

        string _XML_ZM_JAHRNEU_01_Teil_3;

        /// <summary>
        /// Gets or sets the value of variable XML_ZM_JAHRNEU_01_Teil_3.
        /// </summary>
        [TestVariable("af7324a5-2aac-401c-8c10-d59bf416fcc5")]
        public string XML_ZM_JAHRNEU_01_Teil_3
        {
            get { return _XML_ZM_JAHRNEU_01_Teil_3; }
            set { _XML_ZM_JAHRNEU_01_Teil_3 = value; }
        }

        string _XML_ZM_JAHRNEU_01_Teil_4_quart21;

        /// <summary>
        /// Gets or sets the value of variable XML_ZM_JAHRNEU_01_Teil_4_quart21.
        /// </summary>
        [TestVariable("0bb677cd-d7fb-4442-8742-4e03471816f2")]
        public string XML_ZM_JAHRNEU_01_Teil_4_quart21
        {
            get { return _XML_ZM_JAHRNEU_01_Teil_4_quart21; }
            set { _XML_ZM_JAHRNEU_01_Teil_4_quart21 = value; }
        }

        string _JAHRNEU;

        /// <summary>
        /// Gets or sets the value of variable JAHRNEU.
        /// </summary>
        [TestVariable("ef2de08d-9c0c-45ba-98cb-df480ea76dd9")]
        public string JAHRNEU
        {
            get { return _JAHRNEU; }
            set { _JAHRNEU = value; }
        }

        string _XML_ZM_JAHRNEU_01_Teil_5;

        /// <summary>
        /// Gets or sets the value of variable XML_ZM_JAHRNEU_01_Teil_5.
        /// </summary>
        [TestVariable("4a5fb84b-b042-45d8-9806-3392a508a849")]
        public string XML_ZM_JAHRNEU_01_Teil_5
        {
            get { return _XML_ZM_JAHRNEU_01_Teil_5; }
            set { _XML_ZM_JAHRNEU_01_Teil_5 = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_ZM_JAHRNEU_01_Teil_1) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_ZM_JAHRNEU_01_Teil_1, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_ZM_JAHRNEU_01_Teil_2) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(1));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_ZM_JAHRNEU_01_Teil_2, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_ZM_JAHRNEU_01_Teil_3) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(2));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_ZM_JAHRNEU_01_Teil_3, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_ZM_Version_JAHRNEU) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(3));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_ZM_Version_JAHRNEU, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_ZM_JAHRNEU_01_Teil_4_quart21) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(4));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_ZM_JAHRNEU_01_Teil_4_quart21, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$JAHRNEU) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(5));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", JAHRNEU, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_ZM_JAHRNEU_01_Teil_5) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(6));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_ZM_JAHRNEU_01_Teil_5, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
