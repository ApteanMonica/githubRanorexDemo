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

namespace B_MNDR_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Eingabe_Faelligkeit recording.
    /// </summary>
    [TestModule("98d6cb16-4a64-4ba0-a4c8-76633d338581", ModuleType.Recording, 1)]
    public partial class Eingabe_Faelligkeit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_003.B_MNDR_003Repository repository.
        /// </summary>
        public static global::B_MNDR_003.B_MNDR_003Repository repo = global::B_MNDR_003.B_MNDR_003Repository.Instance;

        static Eingabe_Faelligkeit instance = new Eingabe_Faelligkeit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Eingabe_Faelligkeit()
        {
            Datum_der_Mahnung = "15.02.2021";
            Posten_faellig_bis = "14.02.2021";
            Posten_letzte_Mahnung_vor = "09.02.2021";
            Zahlung_beruecksichtigt_bis = "14.02.2021";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Eingabe_Faelligkeit Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_der_Mahnung;

        /// <summary>
        /// Gets or sets the value of variable Datum_der_Mahnung.
        /// </summary>
        [TestVariable("deedae78-5c9d-42ad-b21d-e6c9ca2b15f0")]
        public string Datum_der_Mahnung
        {
            get { return _Datum_der_Mahnung; }
            set { _Datum_der_Mahnung = value; }
        }

        string _Posten_faellig_bis;

        /// <summary>
        /// Gets or sets the value of variable Posten_faellig_bis.
        /// </summary>
        [TestVariable("dc124ea1-bd0c-4471-a5b4-e0482d15022a")]
        public string Posten_faellig_bis
        {
            get { return _Posten_faellig_bis; }
            set { _Posten_faellig_bis = value; }
        }

        string _Posten_letzte_Mahnung_vor;

        /// <summary>
        /// Gets or sets the value of variable Posten_letzte_Mahnung_vor.
        /// </summary>
        [TestVariable("f33b9b64-7a5c-4d33-928b-af2b1fdabbcb")]
        public string Posten_letzte_Mahnung_vor
        {
            get { return _Posten_letzte_Mahnung_vor; }
            set { _Posten_letzte_Mahnung_vor = value; }
        }

        string _Zahlung_beruecksichtigt_bis;

        /// <summary>
        /// Gets or sets the value of variable Zahlung_beruecksichtigt_bis.
        /// </summary>
        [TestVariable("e50cd75f-f54e-4d7e-83a9-239c3afd5758")]
        public string Zahlung_beruecksichtigt_bis
        {
            get { return _Zahlung_beruecksichtigt_bis; }
            set { _Zahlung_beruecksichtigt_bis = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnung' at Center.", repo.FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnungInfo, new RecordItemIndex(0));
            repo.FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnung.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnung'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnungInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnung);
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_der_Mahnung' with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnung'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnungInfo, new RecordItemIndex(2));
            repo.FrmVorschlagErstellen.Register_Faelligkeit.DatumDerMahnung.PressKeys(Datum_der_Mahnung);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis' at Center.", repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBisInfo, new RecordItemIndex(3));
            repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBisInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis);
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Posten_faellig_bis' with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBisInfo, new RecordItemIndex(5));
            repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis.PressKeys(Posten_faellig_bis);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBisInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenFaelligBis);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Posten_letzte_Mahnung_vor) on item 'FrmVorschlagErstellen.Register_Faelligkeit.PostenMitLetzterMahnungVor'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenMitLetzterMahnungVorInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmVorschlagErstellen.Register_Faelligkeit.PostenMitLetzterMahnungVorInfo, "Text", Posten_letzte_Mahnung_vor);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBis' at Center.", repo.FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBisInfo, new RecordItemIndex(8));
            repo.FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBis'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBisInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBis);
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Zahlung_beruecksichtigt_bis' with focus on 'FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBis'.", repo.FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBisInfo, new RecordItemIndex(10));
            repo.FrmVorschlagErstellen.Register_Faelligkeit.ZahlungenBeruecksichtigtBis.PressKeys(Zahlung_beruecksichtigt_bis);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
