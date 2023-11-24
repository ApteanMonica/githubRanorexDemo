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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace B_JAHR_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_JAHR_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("245624a7-da67-4257-81b6-9426e362986f")]
    public partial class B_JAHR_SchnelltestRepository : RepoGenBaseFolder
    {
        static B_JAHR_SchnelltestRepository instance = new B_JAHR_SchnelltestRepository();
        B_JAHR_SchnelltestRepositoryFolders.Main_530_tblMain_510_frmMainAppFolder _main_530_tblmain_510_frmmain;
        B_JAHR_SchnelltestRepositoryFolders.DlgJahrAppFolder _dlgjahr;
        B_JAHR_SchnelltestRepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;

        /// <summary>
        /// Gets the singleton class instance representing the B_JAHR_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("245624a7-da67-4257-81b6-9426e362986f")]
        public static B_JAHR_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_JAHR_SchnelltestRepository() 
            : base("B_JAHR_SchnelltestRepository", "/", null, 0, false, "245624a7-da67-4257-81b6-9426e362986f", ".\\RepositoryImages\\B_JAHR_SchnelltestRepository245624a7.rximgres")
        {
            _main_530_tblmain_510_frmmain = new B_JAHR_SchnelltestRepositoryFolders.Main_530_tblMain_510_frmMainAppFolder(this);
            _dlgjahr = new B_JAHR_SchnelltestRepositoryFolders.DlgJahrAppFolder(this);
            _dlgmessagebox = new B_JAHR_SchnelltestRepositoryFolders.DlgMessageBoxAppFolder(this);
        }

#region Variables

        string _Jahr_ALT = "2017";

        /// <summary>
        /// Gets or sets the value of variable Jahr_ALT.
        /// </summary>
        [TestVariable("8fd51e5f-8991-4ab4-a748-3076d5b24910")]
        public string Jahr_ALT
        {
            get { return _Jahr_ALT; }
            set { _Jahr_ALT = value; }
        }

        string _Jahr_NEU = "2099";

        /// <summary>
        /// Gets or sets the value of variable Jahr_NEU.
        /// </summary>
        [TestVariable("6bf11a9f-c841-4ec2-986d-1ffeb454e2ca")]
        public string Jahr_NEU
        {
            get { return _Jahr_NEU; }
            set { _Jahr_NEU = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("245624a7-da67-4257-81b6-9426e362986f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Main_530_tblMain_510_frmMain folder.
        /// </summary>
        [RepositoryFolder("39769a1d-b3e3-4d46-894f-d2ddf518e3fd")]
        public virtual B_JAHR_SchnelltestRepositoryFolders.Main_530_tblMain_510_frmMainAppFolder Main_530_tblMain_510_frmMain
        {
            get { return _main_530_tblmain_510_frmmain; }
        }

        /// <summary>
        /// The DlgJahr folder.
        /// </summary>
        [RepositoryFolder("285c5274-36d4-445f-a166-2426404ac2fd")]
        public virtual B_JAHR_SchnelltestRepositoryFolders.DlgJahrAppFolder DlgJahr
        {
            get { return _dlgjahr; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("1e0205cf-3143-44b3-bce9-2547f18820dc")]
        public virtual B_JAHR_SchnelltestRepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_JAHR_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The Main_530_tblMain_510_frmMainAppFolder folder.
        /// </summary>
        [RepositoryFolder("39769a1d-b3e3-4d46-894f-d2ddf518e3fd")]
        public partial class Main_530_tblMain_510_frmMainAppFolder : RepoGenBaseFolder
        {
            B_JAHR_SchnelltestRepositoryFolders.Tabelle_510_530Folder _tabelle_510_530;
            RepoItemInfo _titlebar100verwaltengeschaeftsjahrInfo;
            RepoItemInfo _pbcommonneuesInfo;
            RepoItemInfo _pbstandard1Info;
            RepoItemInfo _schliessenInfo;
            RepoItemInfo _pbcommonjournalzeilenInfo;
            RepoItemInfo _tabelle_530Info;
            RepoItemInfo _tabelle_510Info;

            /// <summary>
            /// Creates a new Main_530_tblMain_510_frmMain  folder.
            /// </summary>
            public Main_530_tblMain_510_frmMainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Main_530_tblMain_510_frmMain", "/form[@controlname~'Main']", parentFolder, 30000, null, true, "39769a1d-b3e3-4d46-894f-d2ddf518e3fd", "")
            {
                _tabelle_510_530 = new B_JAHR_SchnelltestRepositoryFolders.Tabelle_510_530Folder(this);
                _titlebar100verwaltengeschaeftsjahrInfo = new RepoItemInfo(this, "TitleBar100VerwaltenGeschaeftsjahr", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "74855842-374e-4eef-b9a1-8a565578d604");
                _pbcommonneuesInfo = new RepoItemInfo(this, "PbCommonNeues", "container[@controlname='RibbonBar']/container[@controlname='CommonGroup']/button[@controlname='pbCommon_Neues']", "", 30000, null, "db648043-58f5-49d2-8d2c-eeac0f3106e4");
                _pbstandard1Info = new RepoItemInfo(this, "PbStandard1", "container[@controlname='RibbonBar']/container[@controlname='CommonGroup']/button[@controlname='pbStandard1']", "", 30000, null, "4eb5fcfe-2711-4261-af07-8c533763d16e");
                _schliessenInfo = new RepoItemInfo(this, "Schliessen", "titlebar[@accessiblerole='TitleBar']/button[@accessiblename='Schließen']", "", 30000, null, "fe792f41-c4e6-41ad-8930-37b952f58bdd");
                _pbcommonjournalzeilenInfo = new RepoItemInfo(this, "PbCommonJournalzeilen", "container[@controlname='RibbonBar']/container[@controlname='cRibbonGroup1']/button[@controlname='pbCommon_Journalzeilen']", "", 30000, null, "6e93e769-a862-4d17-80b7-a9ac5169b131");
                _tabelle_530Info = new RepoItemInfo(this, "Tabelle_530", "container[@controlname='ChildTableWindow']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", "", 30000, null, "7ea00e1a-c3d3-4795-b19c-88d3fb5a81ec");
                _tabelle_510Info = new RepoItemInfo(this, "Tabelle_510", "container[@controlname='ClientArea']/container[@controlname='tblGjhr']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", "", 30000, null, "e062f9f4-68b5-4f63-b06a-ee35b54aa4b0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("39769a1d-b3e3-4d46-894f-d2ddf518e3fd")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("39769a1d-b3e3-4d46-894f-d2ddf518e3fd")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltenGeschaeftsjahr item.
            /// </summary>
            [RepositoryItem("74855842-374e-4eef-b9a1-8a565578d604")]
            public virtual Ranorex.TitleBar TitleBar100VerwaltenGeschaeftsjahr
            {
                get
                {
                    return _titlebar100verwaltengeschaeftsjahrInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltenGeschaeftsjahr item info.
            /// </summary>
            [RepositoryItemInfo("74855842-374e-4eef-b9a1-8a565578d604")]
            public virtual RepoItemInfo TitleBar100VerwaltenGeschaeftsjahrInfo
            {
                get
                {
                    return _titlebar100verwaltengeschaeftsjahrInfo;
                }
            }

            /// <summary>
            /// The PbCommonNeues item.
            /// </summary>
            [RepositoryItem("db648043-58f5-49d2-8d2c-eeac0f3106e4")]
            public virtual Ranorex.Button PbCommonNeues
            {
                get
                {
                    return _pbcommonneuesInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonNeues item info.
            /// </summary>
            [RepositoryItemInfo("db648043-58f5-49d2-8d2c-eeac0f3106e4")]
            public virtual RepoItemInfo PbCommonNeuesInfo
            {
                get
                {
                    return _pbcommonneuesInfo;
                }
            }

            /// <summary>
            /// The PbStandard1 item.
            /// </summary>
            [RepositoryItem("4eb5fcfe-2711-4261-af07-8c533763d16e")]
            public virtual Ranorex.Button PbStandard1
            {
                get
                {
                    return _pbstandard1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbStandard1 item info.
            /// </summary>
            [RepositoryItemInfo("4eb5fcfe-2711-4261-af07-8c533763d16e")]
            public virtual RepoItemInfo PbStandard1Info
            {
                get
                {
                    return _pbstandard1Info;
                }
            }

            /// <summary>
            /// The Schliessen item.
            /// </summary>
            [RepositoryItem("fe792f41-c4e6-41ad-8930-37b952f58bdd")]
            public virtual Ranorex.Button Schliessen
            {
                get
                {
                    return _schliessenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Schliessen item info.
            /// </summary>
            [RepositoryItemInfo("fe792f41-c4e6-41ad-8930-37b952f58bdd")]
            public virtual RepoItemInfo SchliessenInfo
            {
                get
                {
                    return _schliessenInfo;
                }
            }

            /// <summary>
            /// The PbCommonJournalzeilen item.
            /// </summary>
            [RepositoryItem("6e93e769-a862-4d17-80b7-a9ac5169b131")]
            public virtual Ranorex.Button PbCommonJournalzeilen
            {
                get
                {
                    return _pbcommonjournalzeilenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonJournalzeilen item info.
            /// </summary>
            [RepositoryItemInfo("6e93e769-a862-4d17-80b7-a9ac5169b131")]
            public virtual RepoItemInfo PbCommonJournalzeilenInfo
            {
                get
                {
                    return _pbcommonjournalzeilenInfo;
                }
            }

            /// <summary>
            /// The Tabelle_530 item.
            /// </summary>
            [RepositoryItem("7ea00e1a-c3d3-4795-b19c-88d3fb5a81ec")]
            public virtual Ranorex.Table Tabelle_530
            {
                get
                {
                    return _tabelle_530Info.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Tabelle_530 item info.
            /// </summary>
            [RepositoryItemInfo("7ea00e1a-c3d3-4795-b19c-88d3fb5a81ec")]
            public virtual RepoItemInfo Tabelle_530Info
            {
                get
                {
                    return _tabelle_530Info;
                }
            }

            /// <summary>
            /// The Tabelle_510 item.
            /// </summary>
            [RepositoryItem("e062f9f4-68b5-4f63-b06a-ee35b54aa4b0")]
            public virtual Ranorex.Table Tabelle_510
            {
                get
                {
                    return _tabelle_510Info.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Tabelle_510 item info.
            /// </summary>
            [RepositoryItemInfo("e062f9f4-68b5-4f63-b06a-ee35b54aa4b0")]
            public virtual RepoItemInfo Tabelle_510Info
            {
                get
                {
                    return _tabelle_510Info;
                }
            }

            /// <summary>
            /// The Tabelle_510_530 folder.
            /// </summary>
            [RepositoryFolder("2e68ec69-f51b-401f-a55e-05fa07c8df8a")]
            public virtual B_JAHR_SchnelltestRepositoryFolders.Tabelle_510_530Folder Tabelle_510_530
            {
                get { return _tabelle_510_530; }
            }
        }

        /// <summary>
        /// The Tabelle_510_530Folder folder.
        /// </summary>
        [RepositoryFolder("2e68ec69-f51b-401f-a55e-05fa07c8df8a")]
        public partial class Tabelle_510_530Folder : RepoGenBaseFolder
        {
            RepoItemInfo _zeile_mit_jahr_neuInfo;
            RepoItemInfo _column0_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrbez_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrperivon_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrperibis_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrperivonkore_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrperibiskore_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrdtvon_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _colgjhrdtbis_in_zeile_mit_jahr_neuInfo;
            RepoItemInfo _zeile_mit_jahr_altInfo;
            RepoItemInfo _column0_in_zeile_mit_jahr_altInfo;

            /// <summary>
            /// Creates a new Tabelle_510_530  folder.
            /// </summary>
            public Tabelle_510_530Folder(RepoGenBaseFolder parentFolder) :
                    base("Tabelle_510_530", "container/?/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "2e68ec69-f51b-401f-a55e-05fa07c8df8a", "")
            {
                _zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]", "", 5000, null, "9f3d7e7c-54fb-4889-b604-9de4855bd3ac");
                _column0_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "Column0_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'Column 0']", "", 30000, null, "f97fe9e1-8c8d-4c25-a5e0-1b9d8bdfad64");
                _colgjhrbez_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrBez_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_bez']", "", 30000, null, "40e5a5cb-0812-4e82-a817-be7097013c95");
                _colgjhrperivon_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrPerivon_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_perivon']", "", 30000, null, "99ee8fc8-0960-4bc3-8b1d-4efc56df687e");
                _colgjhrperibis_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrPeribis_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_peribis']", "", 30000, null, "48697640-b058-47c7-943f-e89269e9819f");
                _colgjhrperivonkore_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_perivon_kore']", "", 30000, null, "f87b87c2-c0c0-4b39-91c8-0308c90919ba");
                _colgjhrperibiskore_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_peribis_kore']", "", 30000, null, "7e89bbe0-6b0b-4aa7-b995-5a1ecfec2d38");
                _colgjhrdtvon_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrDtvon_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_dtvon']", "", 30000, null, "b24fa285-7726-4d8e-81e0-ff2ebedeadbc");
                _colgjhrdtbis_in_zeile_mit_jahr_neuInfo = new RepoItemInfo(this, "ColGjhrDtbis_in_Zeile_mit_Jahr_NEU", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_NEU]/cell[@accessiblename~'colGjhr_dtbis']", "", 30000, null, "600aac77-2d07-4bf5-97da-972e9afefb89");
                _zeile_mit_jahr_altInfo = new RepoItemInfo(this, "Zeile_mit_Jahr_ALT", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_ALT]", "", 30000, null, "18601465-9521-4f8f-9ef1-e999067c6ddf");
                _column0_in_zeile_mit_jahr_altInfo = new RepoItemInfo(this, "Column0_in_Zeile_mit_Jahr_ALT", "row[@accessiblerole~'Row' and @accessiblevalue~$Jahr_ALT]/cell[@accessiblename~'Column 0']", "", 30000, null, "e7cdea55-dc36-403d-a315-9253ca18fd2b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2e68ec69-f51b-401f-a55e-05fa07c8df8a")]
            public virtual Ranorex.Table Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2e68ec69-f51b-401f-a55e-05fa07c8df8a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("9f3d7e7c-54fb-4889-b604-9de4855bd3ac")]
            public virtual Ranorex.Row Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("9f3d7e7c-54fb-4889-b604-9de4855bd3ac")]
            public virtual RepoItemInfo Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The Column0_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("f97fe9e1-8c8d-4c25-a5e0-1b9d8bdfad64")]
            public virtual Ranorex.Cell Column0_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _column0_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Column0_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("f97fe9e1-8c8d-4c25-a5e0-1b9d8bdfad64")]
            public virtual RepoItemInfo Column0_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _column0_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrBez_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("40e5a5cb-0812-4e82-a817-be7097013c95")]
            public virtual Ranorex.Cell ColGjhrBez_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrbez_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrBez_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("40e5a5cb-0812-4e82-a817-be7097013c95")]
            public virtual RepoItemInfo ColGjhrBez_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrbez_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPerivon_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("99ee8fc8-0960-4bc3-8b1d-4efc56df687e")]
            public virtual Ranorex.Cell ColGjhrPerivon_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrperivon_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPerivon_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("99ee8fc8-0960-4bc3-8b1d-4efc56df687e")]
            public virtual RepoItemInfo ColGjhrPerivon_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrperivon_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPeribis_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("48697640-b058-47c7-943f-e89269e9819f")]
            public virtual Ranorex.Cell ColGjhrPeribis_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrperibis_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPeribis_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("48697640-b058-47c7-943f-e89269e9819f")]
            public virtual RepoItemInfo ColGjhrPeribis_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrperibis_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("f87b87c2-c0c0-4b39-91c8-0308c90919ba")]
            public virtual Ranorex.Cell ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrperivonkore_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("f87b87c2-c0c0-4b39-91c8-0308c90919ba")]
            public virtual RepoItemInfo ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrperivonkore_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("7e89bbe0-6b0b-4aa7-b995-5a1ecfec2d38")]
            public virtual Ranorex.Cell ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrperibiskore_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("7e89bbe0-6b0b-4aa7-b995-5a1ecfec2d38")]
            public virtual RepoItemInfo ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrperibiskore_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrDtvon_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("b24fa285-7726-4d8e-81e0-ff2ebedeadbc")]
            public virtual Ranorex.Cell ColGjhrDtvon_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrdtvon_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrDtvon_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("b24fa285-7726-4d8e-81e0-ff2ebedeadbc")]
            public virtual RepoItemInfo ColGjhrDtvon_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrdtvon_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The ColGjhrDtbis_in_Zeile_mit_Jahr_NEU item.
            /// </summary>
            [RepositoryItem("600aac77-2d07-4bf5-97da-972e9afefb89")]
            public virtual Ranorex.Cell ColGjhrDtbis_in_Zeile_mit_Jahr_NEU
            {
                get
                {
                    return _colgjhrdtbis_in_zeile_mit_jahr_neuInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrDtbis_in_Zeile_mit_Jahr_NEU item info.
            /// </summary>
            [RepositoryItemInfo("600aac77-2d07-4bf5-97da-972e9afefb89")]
            public virtual RepoItemInfo ColGjhrDtbis_in_Zeile_mit_Jahr_NEUInfo
            {
                get
                {
                    return _colgjhrdtbis_in_zeile_mit_jahr_neuInfo;
                }
            }

            /// <summary>
            /// The Zeile_mit_Jahr_ALT item.
            /// </summary>
            [RepositoryItem("18601465-9521-4f8f-9ef1-e999067c6ddf")]
            public virtual Ranorex.Row Zeile_mit_Jahr_ALT
            {
                get
                {
                    return _zeile_mit_jahr_altInfo.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Zeile_mit_Jahr_ALT item info.
            /// </summary>
            [RepositoryItemInfo("18601465-9521-4f8f-9ef1-e999067c6ddf")]
            public virtual RepoItemInfo Zeile_mit_Jahr_ALTInfo
            {
                get
                {
                    return _zeile_mit_jahr_altInfo;
                }
            }

            /// <summary>
            /// The Column0_in_Zeile_mit_Jahr_ALT item.
            /// </summary>
            [RepositoryItem("e7cdea55-dc36-403d-a315-9253ca18fd2b")]
            public virtual Ranorex.Cell Column0_in_Zeile_mit_Jahr_ALT
            {
                get
                {
                    return _column0_in_zeile_mit_jahr_altInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Column0_in_Zeile_mit_Jahr_ALT item info.
            /// </summary>
            [RepositoryItemInfo("e7cdea55-dc36-403d-a315-9253ca18fd2b")]
            public virtual RepoItemInfo Column0_in_Zeile_mit_Jahr_ALTInfo
            {
                get
                {
                    return _column0_in_zeile_mit_jahr_altInfo;
                }
            }
        }

        /// <summary>
        /// The DlgJahrAppFolder folder.
        /// </summary>
        [RepositoryFolder("285c5274-36d4-445f-a166-2426404ac2fd")]
        public partial class DlgJahrAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100neuesjahrInfo;
            RepoItemInfo _pbokInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _datumendeInfo;
            RepoItemInfo _datumende1Info;

            /// <summary>
            /// Creates a new DlgJahr  folder.
            /// </summary>
            public DlgJahrAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgJahr", "/form[@controlname='dlgJahr']", parentFolder, 30000, null, true, "285c5274-36d4-445f-a166-2426404ac2fd", "")
            {
                _titlebar100neuesjahrInfo = new RepoItemInfo(this, "TitleBar100NeuesJahr", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "e84bb9c0-7bb6-4e5a-b438-be1c3e8833a9");
                _pbokInfo = new RepoItemInfo(this, "PbOk", "button[@controlname='pbOk']", "", 30000, null, "abd43d5b-6fd8-47a8-b4f6-520bf5cf89bf");
                _textInfo = new RepoItemInfo(this, "Text", "text[@controlname='dfJahr']/text[@accessiblerole='Text']", "", 30000, null, "853925d7-f817-4802-9c36-9433a85f9426");
                _datumendeInfo = new RepoItemInfo(this, "DatumEnde", "text[@controlname='dfDatumV']/text[@accessiblename='Datum Ende']", "", 30000, null, "497cdee5-23cc-4d9b-b2b6-8beb174ed2b1");
                _datumende1Info = new RepoItemInfo(this, "DatumEnde1", "text[@controlname='dfDatumB']/text[@accessiblename='Datum Ende']", "", 30000, null, "a2a7dbd3-98b9-4dfa-a367-e8d4936743b9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("285c5274-36d4-445f-a166-2426404ac2fd")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("285c5274-36d4-445f-a166-2426404ac2fd")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100NeuesJahr item.
            /// </summary>
            [RepositoryItem("e84bb9c0-7bb6-4e5a-b438-be1c3e8833a9")]
            public virtual Ranorex.TitleBar TitleBar100NeuesJahr
            {
                get
                {
                    return _titlebar100neuesjahrInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100NeuesJahr item info.
            /// </summary>
            [RepositoryItemInfo("e84bb9c0-7bb6-4e5a-b438-be1c3e8833a9")]
            public virtual RepoItemInfo TitleBar100NeuesJahrInfo
            {
                get
                {
                    return _titlebar100neuesjahrInfo;
                }
            }

            /// <summary>
            /// The PbOk item.
            /// </summary>
            [RepositoryItem("abd43d5b-6fd8-47a8-b4f6-520bf5cf89bf")]
            public virtual Ranorex.Button PbOk
            {
                get
                {
                    return _pbokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbOk item info.
            /// </summary>
            [RepositoryItemInfo("abd43d5b-6fd8-47a8-b4f6-520bf5cf89bf")]
            public virtual RepoItemInfo PbOkInfo
            {
                get
                {
                    return _pbokInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("853925d7-f817-4802-9c36-9433a85f9426")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("853925d7-f817-4802-9c36-9433a85f9426")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The DatumEnde item.
            /// </summary>
            [RepositoryItem("497cdee5-23cc-4d9b-b2b6-8beb174ed2b1")]
            public virtual Ranorex.Text DatumEnde
            {
                get
                {
                    return _datumendeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DatumEnde item info.
            /// </summary>
            [RepositoryItemInfo("497cdee5-23cc-4d9b-b2b6-8beb174ed2b1")]
            public virtual RepoItemInfo DatumEndeInfo
            {
                get
                {
                    return _datumendeInfo;
                }
            }

            /// <summary>
            /// The DatumEnde1 item.
            /// </summary>
            [RepositoryItem("a2a7dbd3-98b9-4dfa-a367-e8d4936743b9")]
            public virtual Ranorex.Text DatumEnde1
            {
                get
                {
                    return _datumende1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DatumEnde1 item info.
            /// </summary>
            [RepositoryItemInfo("a2a7dbd3-98b9-4dfa-a367-e8d4936743b9")]
            public virtual RepoItemInfo DatumEnde1Info
            {
                get
                {
                    return _datumende1Info;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("1e0205cf-3143-44b3-bce9-2547f18820dc")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "1e0205cf-3143-44b3-bce9-2547f18820dc", "")
            {
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "e547daf5-809f-44b2-b9dd-1c19c3692b84");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "f76d2794-6c83-4991-a26e-6725c530c99e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1e0205cf-3143-44b3-bce9-2547f18820dc")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1e0205cf-3143-44b3-bce9-2547f18820dc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LabelMeldungstext item.
            /// </summary>
            [RepositoryItem("e547daf5-809f-44b2-b9dd-1c19c3692b84")]
            public virtual Ranorex.Text LabelMeldungstext
            {
                get
                {
                    return _labelmeldungstextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelMeldungstext item info.
            /// </summary>
            [RepositoryItemInfo("e547daf5-809f-44b2-b9dd-1c19c3692b84")]
            public virtual RepoItemInfo LabelMeldungstextInfo
            {
                get
                {
                    return _labelmeldungstextInfo;
                }
            }

            /// <summary>
            /// The Button0 item.
            /// </summary>
            [RepositoryItem("f76d2794-6c83-4991-a26e-6725c530c99e")]
            public virtual Ranorex.Button Button0
            {
                get
                {
                    return _button0Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button0 item info.
            /// </summary>
            [RepositoryItemInfo("f76d2794-6c83-4991-a26e-6725c530c99e")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
