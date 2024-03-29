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

namespace B_KTO_003
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_KTO_003Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e30feed3-d347-45f4-99b4-e3b83693c594")]
    public partial class B_KTO_003Repository : RepoGenBaseFolder
    {
        static B_KTO_003Repository instance = new B_KTO_003Repository();
        B_KTO_003RepositoryFolders.FrmKtoAppFolder _frmkto;
        B_KTO_003RepositoryFolders.DlgCopyKtoAppFolder _dlgcopykto;
        B_KTO_003RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;

        /// <summary>
        /// Gets the singleton class instance representing the B_KTO_003Repository element repository.
        /// </summary>
        [RepositoryFolder("e30feed3-d347-45f4-99b4-e3b83693c594")]
        public static B_KTO_003Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_KTO_003Repository() 
            : base("B_KTO_003Repository", "/", null, 0, false, "e30feed3-d347-45f4-99b4-e3b83693c594", ".\\RepositoryImages\\B_KTO_003Repositorye30feed3.rximgres")
        {
            _frmkto = new B_KTO_003RepositoryFolders.FrmKtoAppFolder(this);
            _dlgcopykto = new B_KTO_003RepositoryFolders.DlgCopyKtoAppFolder(this);
            _dlgmessagebox = new B_KTO_003RepositoryFolders.DlgMessageBoxAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e30feed3-d347-45f4-99b4-e3b83693c594")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmKto folder.
        /// </summary>
        [RepositoryFolder("6f2cb1a4-5471-4340-a15b-ed53ffe45262")]
        public virtual B_KTO_003RepositoryFolders.FrmKtoAppFolder FrmKto
        {
            get { return _frmkto; }
        }

        /// <summary>
        /// The DlgCopyKto folder.
        /// </summary>
        [RepositoryFolder("be460b53-b8a0-4262-8679-817c18c7ff90")]
        public virtual B_KTO_003RepositoryFolders.DlgCopyKtoAppFolder DlgCopyKto
        {
            get { return _dlgcopykto; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("2c5d078d-8cbf-47a1-864b-3539362f81ad")]
        public virtual B_KTO_003RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_KTO_003RepositoryFolders
    {
        /// <summary>
        /// The FrmKtoAppFolder folder.
        /// </summary>
        [RepositoryFolder("6f2cb1a4-5471-4340-a15b-ed53ffe45262")]
        public partial class FrmKtoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textInfo;
            RepoItemInfo _row1column0Info;
            RepoItemInfo _titlebar100sachkontenverwaltenInfo;
            RepoItemInfo _pbtoolbaritemskopierenInfo;
            RepoItemInfo _rbaktivInfo;
            RepoItemInfo _kontoInfo;
            RepoItemInfo _bezeichnungInfo;
            RepoItemInfo _waehrungInfo;
            RepoItemInfo _tabpageallgemeinInfo;
            RepoItemInfo _verwendungInfo;
            RepoItemInfo _tabpagegruppenInfo;
            RepoItemInfo _colktgrcdrow1Info;
            RepoItemInfo _bereicheInfo;
            RepoItemInfo _bereiche_pflichtigkeitInfo;

            /// <summary>
            /// Creates a new FrmKto  folder.
            /// </summary>
            public FrmKtoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKto", "/form[@controlname='frmKto']", parentFolder, 30000, null, true, "6f2cb1a4-5471-4340-a15b-ed53ffe45262", "")
            {
                _textInfo = new RepoItemInfo(this, "Text", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']/container[@controlname='RibbonBar']/container[@controlname='SearchGroup1']/container[@controlname='simpleSearch']/text[@controlname='dfSearchExpression']/text[@accessiblerole='Text']", "", 30000, null, "8dc2bfac-3c66-4422-9434-837c0c0a0e58");
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']/container[@controlname='ClientArea']/container[@controlname='searchResult']/container[@controlname='tblSearchResult']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']/row[@accessiblename='Row 1']/cell[@accessiblename='Row 1 Column 0']", "", 30000, null, "3779bd40-52a2-4dea-92c8-2e89f7d45f67");
                _titlebar100sachkontenverwaltenInfo = new RepoItemInfo(this, "TitleBar100SachkontenVerwalten", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "8dfd4e03-e0d0-4992-a8bd-f15550770448");
                _pbtoolbaritemskopierenInfo = new RepoItemInfo(this, "PbToolBarItemsKopieren", "container[@controlname='RibbonBar']/container[@controlname='ShareGroup']/button[@controlname='pbToolBarItems_Kopieren']", "", 30000, null, "2cc5e535-f795-43bd-90a5-c61462eaccc8");
                _rbaktivInfo = new RepoItemInfo(this, "RbAktiv", "container[@controlname='ClientArea']/container[@controlname='groupBox1']/radiobutton[@controlname='rbAktiv']", "", 30000, null, "55611e06-64b3-4258-960f-e972b6f8bf61");
                _kontoInfo = new RepoItemInfo(this, "Konto", "container[@controlname='ClientArea']/text[@controlname='dfKto_nr']/text[@accessiblename='Konto']", "", 30000, null, "928b039c-314e-444a-b454-17926e640114");
                _bezeichnungInfo = new RepoItemInfo(this, "Bezeichnung", "container[@controlname='ClientArea']/text[@controlname='dfKto_bez1']/text[@accessiblename='Bezeichnung']", "", 30000, null, "fc606dab-b191-46e0-84d4-e5b973d05517");
                _waehrungInfo = new RepoItemInfo(this, "Waehrung", "container[@controlname='ClientArea']/text[@controlname='dfWrg_cd']/text[@accessiblename='Währung']", "", 30000, null, "077c9b0a-ba7e-4001-b751-91312d487e88");
                _tabpageallgemeinInfo = new RepoItemInfo(this, "TabPageAllgemein", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@accessiblename='&Allgemein']", "", 30000, null, "40513e80-5b96-44ad-8f93-b824d20a29bc");
                _verwendungInfo = new RepoItemInfo(this, "Verwendung", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpAllgemein']/?/?/text[@accessiblename='Verwendung']", "", 30000, null, "a23a756d-bc1e-45e0-bc04-feba9d5deaa9");
                _tabpagegruppenInfo = new RepoItemInfo(this, "TabPageGruppen", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@accessiblename='&Gruppen']", "", 30000, null, "6f36a84e-89a3-4121-b8bd-03f826b03804");
                _colktgrcdrow1Info = new RepoItemInfo(this, "ColKtgrCdRow1", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpGruppen']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKtgr_cd Row 1']", "", 30000, null, "4bcce6cf-3279-407f-964f-f75e623fd873");
                _bereicheInfo = new RepoItemInfo(this, "Bereiche", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@accessiblename='Be&reiche']", "", 30000, null, "77b03917-3de1-4ad8-b195-8284b01af748");
                _bereiche_pflichtigkeitInfo = new RepoItemInfo(this, "Bereiche_Pflichtigkeit", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpBereiche']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKtbz_kz Row 1']", "", 30000, null, "bc79dac4-36ae-44f4-aa80-578676f1aee6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6f2cb1a4-5471-4340-a15b-ed53ffe45262")]
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
            [RepositoryItemInfo("6f2cb1a4-5471-4340-a15b-ed53ffe45262")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("8dc2bfac-3c66-4422-9434-837c0c0a0e58")]
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
            [RepositoryItemInfo("8dc2bfac-3c66-4422-9434-837c0c0a0e58")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("3779bd40-52a2-4dea-92c8-2e89f7d45f67")]
            public virtual Ranorex.Cell Row1Column0
            {
                get
                {
                    return _row1column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row1Column0 item info.
            /// </summary>
            [RepositoryItemInfo("3779bd40-52a2-4dea-92c8-2e89f7d45f67")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }

            /// <summary>
            /// The TitleBar100SachkontenVerwalten item.
            /// </summary>
            [RepositoryItem("8dfd4e03-e0d0-4992-a8bd-f15550770448")]
            public virtual Ranorex.TitleBar TitleBar100SachkontenVerwalten
            {
                get
                {
                    return _titlebar100sachkontenverwaltenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100SachkontenVerwalten item info.
            /// </summary>
            [RepositoryItemInfo("8dfd4e03-e0d0-4992-a8bd-f15550770448")]
            public virtual RepoItemInfo TitleBar100SachkontenVerwaltenInfo
            {
                get
                {
                    return _titlebar100sachkontenverwaltenInfo;
                }
            }

            /// <summary>
            /// The PbToolBarItemsKopieren item.
            /// </summary>
            [RepositoryItem("2cc5e535-f795-43bd-90a5-c61462eaccc8")]
            public virtual Ranorex.Button PbToolBarItemsKopieren
            {
                get
                {
                    return _pbtoolbaritemskopierenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbToolBarItemsKopieren item info.
            /// </summary>
            [RepositoryItemInfo("2cc5e535-f795-43bd-90a5-c61462eaccc8")]
            public virtual RepoItemInfo PbToolBarItemsKopierenInfo
            {
                get
                {
                    return _pbtoolbaritemskopierenInfo;
                }
            }

            /// <summary>
            /// The RbAktiv item.
            /// </summary>
            [RepositoryItem("55611e06-64b3-4258-960f-e972b6f8bf61")]
            public virtual Ranorex.RadioButton RbAktiv
            {
                get
                {
                    return _rbaktivInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RbAktiv item info.
            /// </summary>
            [RepositoryItemInfo("55611e06-64b3-4258-960f-e972b6f8bf61")]
            public virtual RepoItemInfo RbAktivInfo
            {
                get
                {
                    return _rbaktivInfo;
                }
            }

            /// <summary>
            /// The Konto item.
            /// </summary>
            [RepositoryItem("928b039c-314e-444a-b454-17926e640114")]
            public virtual Ranorex.Text Konto
            {
                get
                {
                    return _kontoInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Konto item info.
            /// </summary>
            [RepositoryItemInfo("928b039c-314e-444a-b454-17926e640114")]
            public virtual RepoItemInfo KontoInfo
            {
                get
                {
                    return _kontoInfo;
                }
            }

            /// <summary>
            /// The Bezeichnung item.
            /// </summary>
            [RepositoryItem("fc606dab-b191-46e0-84d4-e5b973d05517")]
            public virtual Ranorex.Text Bezeichnung
            {
                get
                {
                    return _bezeichnungInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Bezeichnung item info.
            /// </summary>
            [RepositoryItemInfo("fc606dab-b191-46e0-84d4-e5b973d05517")]
            public virtual RepoItemInfo BezeichnungInfo
            {
                get
                {
                    return _bezeichnungInfo;
                }
            }

            /// <summary>
            /// The Waehrung item.
            /// </summary>
            [RepositoryItem("077c9b0a-ba7e-4001-b751-91312d487e88")]
            public virtual Ranorex.Text Waehrung
            {
                get
                {
                    return _waehrungInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Waehrung item info.
            /// </summary>
            [RepositoryItemInfo("077c9b0a-ba7e-4001-b751-91312d487e88")]
            public virtual RepoItemInfo WaehrungInfo
            {
                get
                {
                    return _waehrungInfo;
                }
            }

            /// <summary>
            /// The TabPageAllgemein item.
            /// </summary>
            [RepositoryItem("40513e80-5b96-44ad-8f93-b824d20a29bc")]
            public virtual Ranorex.TabPage TabPageAllgemein
            {
                get
                {
                    return _tabpageallgemeinInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TabPageAllgemein item info.
            /// </summary>
            [RepositoryItemInfo("40513e80-5b96-44ad-8f93-b824d20a29bc")]
            public virtual RepoItemInfo TabPageAllgemeinInfo
            {
                get
                {
                    return _tabpageallgemeinInfo;
                }
            }

            /// <summary>
            /// The Verwendung item.
            /// </summary>
            [RepositoryItem("a23a756d-bc1e-45e0-bc04-feba9d5deaa9")]
            public virtual Ranorex.Text Verwendung
            {
                get
                {
                    return _verwendungInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Verwendung item info.
            /// </summary>
            [RepositoryItemInfo("a23a756d-bc1e-45e0-bc04-feba9d5deaa9")]
            public virtual RepoItemInfo VerwendungInfo
            {
                get
                {
                    return _verwendungInfo;
                }
            }

            /// <summary>
            /// The TabPageGruppen item.
            /// </summary>
            [RepositoryItem("6f36a84e-89a3-4121-b8bd-03f826b03804")]
            public virtual Ranorex.TabPage TabPageGruppen
            {
                get
                {
                    return _tabpagegruppenInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TabPageGruppen item info.
            /// </summary>
            [RepositoryItemInfo("6f36a84e-89a3-4121-b8bd-03f826b03804")]
            public virtual RepoItemInfo TabPageGruppenInfo
            {
                get
                {
                    return _tabpagegruppenInfo;
                }
            }

            /// <summary>
            /// The ColKtgrCdRow1 item.
            /// </summary>
            [RepositoryItem("4bcce6cf-3279-407f-964f-f75e623fd873")]
            public virtual Ranorex.Cell ColKtgrCdRow1
            {
                get
                {
                    return _colktgrcdrow1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKtgrCdRow1 item info.
            /// </summary>
            [RepositoryItemInfo("4bcce6cf-3279-407f-964f-f75e623fd873")]
            public virtual RepoItemInfo ColKtgrCdRow1Info
            {
                get
                {
                    return _colktgrcdrow1Info;
                }
            }

            /// <summary>
            /// The Bereiche item.
            /// </summary>
            [RepositoryItem("77b03917-3de1-4ad8-b195-8284b01af748")]
            public virtual Ranorex.TabPage Bereiche
            {
                get
                {
                    return _bereicheInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Bereiche item info.
            /// </summary>
            [RepositoryItemInfo("77b03917-3de1-4ad8-b195-8284b01af748")]
            public virtual RepoItemInfo BereicheInfo
            {
                get
                {
                    return _bereicheInfo;
                }
            }

            /// <summary>
            /// The Bereiche_Pflichtigkeit item.
            /// </summary>
            [RepositoryItem("bc79dac4-36ae-44f4-aa80-578676f1aee6")]
            public virtual Ranorex.Cell Bereiche_Pflichtigkeit
            {
                get
                {
                    return _bereiche_pflichtigkeitInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Bereiche_Pflichtigkeit item info.
            /// </summary>
            [RepositoryItemInfo("bc79dac4-36ae-44f4-aa80-578676f1aee6")]
            public virtual RepoItemInfo Bereiche_PflichtigkeitInfo
            {
                get
                {
                    return _bereiche_pflichtigkeitInfo;
                }
            }
        }

        /// <summary>
        /// The DlgCopyKtoAppFolder folder.
        /// </summary>
        [RepositoryFolder("be460b53-b8a0-4262-8679-817c18c7ff90")]
        public partial class DlgCopyKtoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _neuekontonrInfo;
            RepoItemInfo _ok_button_bei_konto_kopierenInfo;
            RepoItemInfo _dfktobez1Info;

            /// <summary>
            /// Creates a new DlgCopyKto  folder.
            /// </summary>
            public DlgCopyKtoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgCopyKto", "/form[@controlname='dlgCopyKto']", parentFolder, 30000, null, true, "be460b53-b8a0-4262-8679-817c18c7ff90", "")
            {
                _neuekontonrInfo = new RepoItemInfo(this, "NeueKontoNr", "?/?/text[@accessiblename='Neue Konto-Nr.:']", "", 30000, null, "95ada3b6-adb2-476e-b47d-df1ef3a9a851");
                _ok_button_bei_konto_kopierenInfo = new RepoItemInfo(this, "Ok_Button_bei_Konto_kopieren", "button[@controlname='pbOk']", "", 30000, null, "72e39c87-1b69-42ea-8807-c21edf3a2f61");
                _dfktobez1Info = new RepoItemInfo(this, "DfKtoBez1", "text[@controlname='dfKto_bez1']", "", 30000, null, "c2820653-c1de-4fb7-b211-fb2ba9fdda73");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("be460b53-b8a0-4262-8679-817c18c7ff90")]
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
            [RepositoryItemInfo("be460b53-b8a0-4262-8679-817c18c7ff90")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The NeueKontoNr item.
            /// </summary>
            [RepositoryItem("95ada3b6-adb2-476e-b47d-df1ef3a9a851")]
            public virtual Ranorex.Text NeueKontoNr
            {
                get
                {
                    return _neuekontonrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The NeueKontoNr item info.
            /// </summary>
            [RepositoryItemInfo("95ada3b6-adb2-476e-b47d-df1ef3a9a851")]
            public virtual RepoItemInfo NeueKontoNrInfo
            {
                get
                {
                    return _neuekontonrInfo;
                }
            }

            /// <summary>
            /// The Ok_Button_bei_Konto_kopieren item.
            /// </summary>
            [RepositoryItem("72e39c87-1b69-42ea-8807-c21edf3a2f61")]
            public virtual Ranorex.Button Ok_Button_bei_Konto_kopieren
            {
                get
                {
                    return _ok_button_bei_konto_kopierenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Ok_Button_bei_Konto_kopieren item info.
            /// </summary>
            [RepositoryItemInfo("72e39c87-1b69-42ea-8807-c21edf3a2f61")]
            public virtual RepoItemInfo Ok_Button_bei_Konto_kopierenInfo
            {
                get
                {
                    return _ok_button_bei_konto_kopierenInfo;
                }
            }

            /// <summary>
            /// The DfKtoBez1 item.
            /// </summary>
            [RepositoryItem("c2820653-c1de-4fb7-b211-fb2ba9fdda73")]
            public virtual Ranorex.Text DfKtoBez1
            {
                get
                {
                    return _dfktobez1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfKtoBez1 item info.
            /// </summary>
            [RepositoryItemInfo("c2820653-c1de-4fb7-b211-fb2ba9fdda73")]
            public virtual RepoItemInfo DfKtoBez1Info
            {
                get
                {
                    return _dfktobez1Info;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("2c5d078d-8cbf-47a1-864b-3539362f81ad")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _meldung_konto_bereits_vorhandenInfo;
            RepoItemInfo _ok_button_bei_meldungInfo;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "2c5d078d-8cbf-47a1-864b-3539362f81ad", "")
            {
                _meldung_konto_bereits_vorhandenInfo = new RepoItemInfo(this, "Meldung_Konto_bereits_vorhanden", "text[@controlname='labelMeldungstext']", "", 30000, null, "89c0ae41-9e57-4550-9431-e32d94f367a0");
                _ok_button_bei_meldungInfo = new RepoItemInfo(this, "ok_Button_bei_Meldung", "button[@controlname='button0']", "", 30000, null, "1a7089cf-5d69-480f-a95d-1b9b8a4ef526");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2c5d078d-8cbf-47a1-864b-3539362f81ad")]
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
            [RepositoryItemInfo("2c5d078d-8cbf-47a1-864b-3539362f81ad")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Meldung_Konto_bereits_vorhanden item.
            /// </summary>
            [RepositoryItem("89c0ae41-9e57-4550-9431-e32d94f367a0")]
            public virtual Ranorex.Text Meldung_Konto_bereits_vorhanden
            {
                get
                {
                    return _meldung_konto_bereits_vorhandenInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Meldung_Konto_bereits_vorhanden item info.
            /// </summary>
            [RepositoryItemInfo("89c0ae41-9e57-4550-9431-e32d94f367a0")]
            public virtual RepoItemInfo Meldung_Konto_bereits_vorhandenInfo
            {
                get
                {
                    return _meldung_konto_bereits_vorhandenInfo;
                }
            }

            /// <summary>
            /// The ok_Button_bei_Meldung item.
            /// </summary>
            [RepositoryItem("1a7089cf-5d69-480f-a95d-1b9b8a4ef526")]
            public virtual Ranorex.Button ok_Button_bei_Meldung
            {
                get
                {
                    return _ok_button_bei_meldungInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ok_Button_bei_Meldung item info.
            /// </summary>
            [RepositoryItemInfo("1a7089cf-5d69-480f-a95d-1b9b8a4ef526")]
            public virtual RepoItemInfo ok_Button_bei_MeldungInfo
            {
                get
                {
                    return _ok_button_bei_meldungInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
