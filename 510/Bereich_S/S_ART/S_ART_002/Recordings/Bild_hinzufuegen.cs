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

namespace S_ART_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bild_hinzufuegen recording.
    /// </summary>
    [TestModule("50436785-076e-4682-b2c1-62ba9688f7b8", ModuleType.Recording, 1)]
    public partial class Bild_hinzufuegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ART_002.S_ART_002Repository repository.
        /// </summary>
        public static global::S_ART_002.S_ART_002Repository repo = global::S_ART_002.S_ART_002Repository.Instance;

        static Bild_hinzufuegen instance = new Bild_hinzufuegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bild_hinzufuegen()
        {
            Pfad_Bild = "C:\\Testdaten\\Sonstige Daten\\VRI\\R_S.png";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bild_hinzufuegen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Pfad_Bild;

        /// <summary>
        /// Gets or sets the value of variable Pfad_Bild.
        /// </summary>
        [TestVariable("07d86da1-b53a-4d94-8c72-c0780c89199f")]
        public string Pfad_Bild
        {
            get { return _Pfad_Bild; }
            set { _Pfad_Bild = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.TpAllgemein.Tabelle_Bilder' at Center.", repo.FrmArt.TpAllgemein.Tabelle_BilderInfo, new RecordItemIndex(0));
            repo.FrmArt.TpAllgemein.Tabelle_Bilder.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'FrmArt.TpAllgemein.Tabelle_Bilder'.", repo.FrmArt.TpAllgemein.Tabelle_BilderInfo, new RecordItemIndex(1));
            repo.FrmArt.TpAllgemein.Tabelle_Bilder.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmArt.TpAllgemein.Tabelle_Bilder'.", repo.FrmArt.TpAllgemein.Tabelle_BilderInfo, new RecordItemIndex(2));
            repo.FrmArt.TpAllgemein.Tabelle_Bilder.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.TpAllgemein.Zeile_Tabelle_Bilder' at Center.", repo.FrmArt.TpAllgemein.Zeile_Tabelle_BilderInfo, new RecordItemIndex(3));
            repo.FrmArt.TpAllgemein.Zeile_Tabelle_Bilder.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Pfad_Bild' with focus on 'FrmArt.TpAllgemein.Zeile_Tabelle_Bilder'.", repo.FrmArt.TpAllgemein.Zeile_Tabelle_BilderInfo, new RecordItemIndex(4));
            repo.FrmArt.TpAllgemein.Zeile_Tabelle_Bilder.PressKeys(Pfad_Bild);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Button_Speichern' at Center.", repo.FrmArt.Button_SpeichernInfo, new RecordItemIndex(5));
            repo.FrmArt.Button_Speichern.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=103,Height=89}) on item 'FrmArt.TpAllgemein.PicArtBild'.", repo.FrmArt.TpAllgemein.PicArtBildInfo, new RecordItemIndex(6));
            //Validate.ContainsImage(repo.FrmArt.TpAllgemein.PicArtBildInfo, PicArtBild_Screenshot1, PicArtBild_Screenshot1_Options);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage PicArtBild_Screenshot1
        { get { return repo.FrmArt.TpAllgemein.PicArtBildInfo.GetScreenshot1(new Rectangle(0, 0, 103, 89)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions PicArtBild_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
