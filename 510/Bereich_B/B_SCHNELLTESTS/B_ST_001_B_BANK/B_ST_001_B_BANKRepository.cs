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

namespace B_ST_001_B_BANK
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_ST_001_B_BANKRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("9fdaf88a-f645-431e-9d4f-e8bf416e1439")]
    public partial class B_ST_001_B_BANKRepository : RepoGenBaseFolder
    {
        static B_ST_001_B_BANKRepository instance = new B_ST_001_B_BANKRepository();
        B_ST_001_B_BANKRepositoryFolders.FrmBankAppFolder _frmbank;
        B_ST_001_B_BANKRepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;

        /// <summary>
        /// Gets the singleton class instance representing the B_ST_001_B_BANKRepository element repository.
        /// </summary>
        [RepositoryFolder("9fdaf88a-f645-431e-9d4f-e8bf416e1439")]
        public static B_ST_001_B_BANKRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_ST_001_B_BANKRepository() 
            : base("B_ST_001_B_BANKRepository", "/", null, 0, false, "9fdaf88a-f645-431e-9d4f-e8bf416e1439", ".\\RepositoryImages\\B_ST_001_B_BANKRepository9fdaf88a.rximgres")
        {
            _frmbank = new B_ST_001_B_BANKRepositoryFolders.FrmBankAppFolder(this);
            _dlgmessagebox = new B_ST_001_B_BANKRepositoryFolders.DlgMessageBoxAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("9fdaf88a-f645-431e-9d4f-e8bf416e1439")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmBank folder.
        /// </summary>
        [RepositoryFolder("94fb2696-a65f-4084-83aa-e1df56ee93e1")]
        public virtual B_ST_001_B_BANKRepositoryFolders.FrmBankAppFolder FrmBank
        {
            get { return _frmbank; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("55c49c0d-d526-480c-b1f6-6c8686cb4e54")]
        public virtual B_ST_001_B_BANKRepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_ST_001_B_BANKRepositoryFolders
    {
        /// <summary>
        /// The FrmBankAppFolder folder.
        /// </summary>
        [RepositoryFolder("94fb2696-a65f-4084-83aa-e1df56ee93e1")]
        public partial class FrmBankAppFolder : RepoGenBaseFolder
        {
            B_ST_001_B_BANKRepositoryFolders.Suchergebis_TabelleFolder _suchergebis_tabelle;
            RepoItemInfo _titlebar100verwaltungbankverbindungInfo;
            RepoItemInfo _pbnavigationbackInfo;
            RepoItemInfo _pbnewInfo;
            RepoItemInfo _pbdataaccesssaveInfo;
            RepoItemInfo _pballgemeinloeschenInfo;
            RepoItemInfo _bankInfo;
            RepoItemInfo _nameInfo;
            RepoItemInfo _landInfo;
            RepoItemInfo _text_statusInfo;
            RepoItemInfo _sepa_versionInfo;
            RepoItemInfo _tabpagekontenInfo;
            RepoItemInfo _tabpageallgemeinInfo;
            RepoItemInfo _dfbankktobankInfo;
            RepoItemInfo _text_spesenInfo;

            /// <summary>
            /// Creates a new FrmBank  folder.
            /// </summary>
            public FrmBankAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmBank", "/form[@controlname='frmBank']", parentFolder, 30000, null, true, "94fb2696-a65f-4084-83aa-e1df56ee93e1", "")
            {
                _suchergebis_tabelle = new B_ST_001_B_BANKRepositoryFolders.Suchergebis_TabelleFolder(this);
                _titlebar100verwaltungbankverbindungInfo = new RepoItemInfo(this, "TitleBar100VerwaltungBankverbindung", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "fca82e71-6a58-4f21-a751-7d5f17b33541");
                _pbnavigationbackInfo = new RepoItemInfo(this, "PbNavigationBack", "container[@controlname='RibbonBar']/container[@controlname='NavigationGroup']/button[@controlname='pbNavigation_Back']", "", 30000, null, "5a4942aa-fb63-4854-8387-3a744d45f523");
                _pbnewInfo = new RepoItemInfo(this, "PbNew", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']/container[@controlname='RibbonBar']/container[@controlname='SearchGroup2']/button[@controlname='pbNew']", "", 30000, null, "842afed1-6e86-4e9c-b971-8a217cf4e060");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='RibbonBar']/container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Save']", "", 30000, null, "e77a85ca-da6f-40d9-bce7-7af7db1df954");
                _pballgemeinloeschenInfo = new RepoItemInfo(this, "PbAllgemeinLoeschen", "container[@controlname='RibbonBar']/container[@controlname='AllgemeinGroup']/button[@controlname='pbAllgemein_Löschen']", "", 30000, null, "b88da893-1824-4aef-8b7f-b8dd67a480a8");
                _bankInfo = new RepoItemInfo(this, "Bank", "container[@controlname='ClientArea']/text[@controlname='dfBank_nr']/text[@accessiblename='Bank']", "", 30000, null, "db902066-2fbc-4fbe-8cb2-8b49e8c2a567");
                _nameInfo = new RepoItemInfo(this, "Name", "container[@controlname='ClientArea']/text[@controlname='dfBank_name']/text[@accessiblename='Name']", "", 30000, null, "1cdf5620-bfca-4a63-a4a3-6b59eca56a9b");
                _landInfo = new RepoItemInfo(this, "Land", "container[@controlname='ClientArea']/text[@controlname='dfLand_cd']/text[@accessiblename='Land']", "", 30000, null, "6fb956e0-8c7c-43f8-a76b-a5be97faced5");
                _text_statusInfo = new RepoItemInfo(this, "Text_Status", "container[@controlname='ClientArea']/text[@controlname='dfBank_Status']/text[@accessiblerole='Text']", "", 30000, null, "3ce4efcd-9efd-49f4-948a-fc91f5c7976c");
                _sepa_versionInfo = new RepoItemInfo(this, "SEPA_Version", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpAllgeein']/container[@controlname='gBSepa']/text[@controlname='dfSepa_Vers']/text[@accessiblename='Version']", "", 30000, null, "ca8223db-fce6-4c78-a1b6-efa02473ecf1");
                _tabpagekontenInfo = new RepoItemInfo(this, "TabPageKonten", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@accessiblename='&Konten']", "", 30000, null, "0c2a2eb6-3d90-4ab8-a428-82beecac0ac1");
                _tabpageallgemeinInfo = new RepoItemInfo(this, "TabPageAllgemein", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@accessiblename='&Allgemein']", "", 30000, null, "ede41e8c-1ccf-428a-8c37-b775caa1b59b");
                _dfbankktobankInfo = new RepoItemInfo(this, "DfBankKtobank", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpKonten']/text[@controlname='dfBank_ktobank']", "", 30000, null, "656ececb-bd78-46f4-9fdb-190846dffb30");
                _text_spesenInfo = new RepoItemInfo(this, "Text_Spesen", "container[@controlname='ClientArea']/tabpagelist[@controlname='picTabs']/tabpage[@controlname='tpKonten']/text[@controlname='dfBank_ktospesen']/text[@accessiblerole='Text']", "", 30000, null, "86210241-8af0-4587-ab75-ee18b2aa8416");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("94fb2696-a65f-4084-83aa-e1df56ee93e1")]
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
            [RepositoryItemInfo("94fb2696-a65f-4084-83aa-e1df56ee93e1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltungBankverbindung item.
            /// </summary>
            [RepositoryItem("fca82e71-6a58-4f21-a751-7d5f17b33541")]
            public virtual Ranorex.TitleBar TitleBar100VerwaltungBankverbindung
            {
                get
                {
                    return _titlebar100verwaltungbankverbindungInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltungBankverbindung item info.
            /// </summary>
            [RepositoryItemInfo("fca82e71-6a58-4f21-a751-7d5f17b33541")]
            public virtual RepoItemInfo TitleBar100VerwaltungBankverbindungInfo
            {
                get
                {
                    return _titlebar100verwaltungbankverbindungInfo;
                }
            }

            /// <summary>
            /// The PbNavigationBack item.
            /// </summary>
            [RepositoryItem("5a4942aa-fb63-4854-8387-3a744d45f523")]
            public virtual Ranorex.Button PbNavigationBack
            {
                get
                {
                    return _pbnavigationbackInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbNavigationBack item info.
            /// </summary>
            [RepositoryItemInfo("5a4942aa-fb63-4854-8387-3a744d45f523")]
            public virtual RepoItemInfo PbNavigationBackInfo
            {
                get
                {
                    return _pbnavigationbackInfo;
                }
            }

            /// <summary>
            /// The PbNew item.
            /// </summary>
            [RepositoryItem("842afed1-6e86-4e9c-b971-8a217cf4e060")]
            public virtual Ranorex.Button PbNew
            {
                get
                {
                    return _pbnewInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbNew item info.
            /// </summary>
            [RepositoryItemInfo("842afed1-6e86-4e9c-b971-8a217cf4e060")]
            public virtual RepoItemInfo PbNewInfo
            {
                get
                {
                    return _pbnewInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("e77a85ca-da6f-40d9-bce7-7af7db1df954")]
            public virtual Ranorex.Button PbDataAccessSave
            {
                get
                {
                    return _pbdataaccesssaveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessSave item info.
            /// </summary>
            [RepositoryItemInfo("e77a85ca-da6f-40d9-bce7-7af7db1df954")]
            public virtual RepoItemInfo PbDataAccessSaveInfo
            {
                get
                {
                    return _pbdataaccesssaveInfo;
                }
            }

            /// <summary>
            /// The PbAllgemeinLoeschen item.
            /// </summary>
            [RepositoryItem("b88da893-1824-4aef-8b7f-b8dd67a480a8")]
            public virtual Ranorex.Button PbAllgemeinLoeschen
            {
                get
                {
                    return _pballgemeinloeschenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbAllgemeinLoeschen item info.
            /// </summary>
            [RepositoryItemInfo("b88da893-1824-4aef-8b7f-b8dd67a480a8")]
            public virtual RepoItemInfo PbAllgemeinLoeschenInfo
            {
                get
                {
                    return _pballgemeinloeschenInfo;
                }
            }

            /// <summary>
            /// The Bank item.
            /// </summary>
            [RepositoryItem("db902066-2fbc-4fbe-8cb2-8b49e8c2a567")]
            public virtual Ranorex.Text Bank
            {
                get
                {
                    return _bankInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Bank item info.
            /// </summary>
            [RepositoryItemInfo("db902066-2fbc-4fbe-8cb2-8b49e8c2a567")]
            public virtual RepoItemInfo BankInfo
            {
                get
                {
                    return _bankInfo;
                }
            }

            /// <summary>
            /// The Name item.
            /// </summary>
            [RepositoryItem("1cdf5620-bfca-4a63-a4a3-6b59eca56a9b")]
            public virtual Ranorex.Text Name
            {
                get
                {
                    return _nameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Name item info.
            /// </summary>
            [RepositoryItemInfo("1cdf5620-bfca-4a63-a4a3-6b59eca56a9b")]
            public virtual RepoItemInfo NameInfo
            {
                get
                {
                    return _nameInfo;
                }
            }

            /// <summary>
            /// The Land item.
            /// </summary>
            [RepositoryItem("6fb956e0-8c7c-43f8-a76b-a5be97faced5")]
            public virtual Ranorex.Text Land
            {
                get
                {
                    return _landInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Land item info.
            /// </summary>
            [RepositoryItemInfo("6fb956e0-8c7c-43f8-a76b-a5be97faced5")]
            public virtual RepoItemInfo LandInfo
            {
                get
                {
                    return _landInfo;
                }
            }

            /// <summary>
            /// The Text_Status item.
            /// </summary>
            [RepositoryItem("3ce4efcd-9efd-49f4-948a-fc91f5c7976c")]
            public virtual Ranorex.Text Text_Status
            {
                get
                {
                    return _text_statusInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text_Status item info.
            /// </summary>
            [RepositoryItemInfo("3ce4efcd-9efd-49f4-948a-fc91f5c7976c")]
            public virtual RepoItemInfo Text_StatusInfo
            {
                get
                {
                    return _text_statusInfo;
                }
            }

            /// <summary>
            /// The SEPA_Version item.
            /// </summary>
            [RepositoryItem("ca8223db-fce6-4c78-a1b6-efa02473ecf1")]
            public virtual Ranorex.Text SEPA_Version
            {
                get
                {
                    return _sepa_versionInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SEPA_Version item info.
            /// </summary>
            [RepositoryItemInfo("ca8223db-fce6-4c78-a1b6-efa02473ecf1")]
            public virtual RepoItemInfo SEPA_VersionInfo
            {
                get
                {
                    return _sepa_versionInfo;
                }
            }

            /// <summary>
            /// The TabPageKonten item.
            /// </summary>
            [RepositoryItem("0c2a2eb6-3d90-4ab8-a428-82beecac0ac1")]
            public virtual Ranorex.TabPage TabPageKonten
            {
                get
                {
                    return _tabpagekontenInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The TabPageKonten item info.
            /// </summary>
            [RepositoryItemInfo("0c2a2eb6-3d90-4ab8-a428-82beecac0ac1")]
            public virtual RepoItemInfo TabPageKontenInfo
            {
                get
                {
                    return _tabpagekontenInfo;
                }
            }

            /// <summary>
            /// The TabPageAllgemein item.
            /// </summary>
            [RepositoryItem("ede41e8c-1ccf-428a-8c37-b775caa1b59b")]
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
            [RepositoryItemInfo("ede41e8c-1ccf-428a-8c37-b775caa1b59b")]
            public virtual RepoItemInfo TabPageAllgemeinInfo
            {
                get
                {
                    return _tabpageallgemeinInfo;
                }
            }

            /// <summary>
            /// The DfBankKtobank item.
            /// </summary>
            [RepositoryItem("656ececb-bd78-46f4-9fdb-190846dffb30")]
            public virtual Ranorex.Text DfBankKtobank
            {
                get
                {
                    return _dfbankktobankInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfBankKtobank item info.
            /// </summary>
            [RepositoryItemInfo("656ececb-bd78-46f4-9fdb-190846dffb30")]
            public virtual RepoItemInfo DfBankKtobankInfo
            {
                get
                {
                    return _dfbankktobankInfo;
                }
            }

            /// <summary>
            /// The Text_Spesen item.
            /// </summary>
            [RepositoryItem("86210241-8af0-4587-ab75-ee18b2aa8416")]
            public virtual Ranorex.Text Text_Spesen
            {
                get
                {
                    return _text_spesenInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text_Spesen item info.
            /// </summary>
            [RepositoryItemInfo("86210241-8af0-4587-ab75-ee18b2aa8416")]
            public virtual RepoItemInfo Text_SpesenInfo
            {
                get
                {
                    return _text_spesenInfo;
                }
            }

            /// <summary>
            /// The Suchergebis_Tabelle folder.
            /// </summary>
            [RepositoryFolder("b597f144-438c-4fea-8aa7-972cf32aafe8")]
            public virtual B_ST_001_B_BANKRepositoryFolders.Suchergebis_TabelleFolder Suchergebis_Tabelle
            {
                get { return _suchergebis_tabelle; }
            }
        }

        /// <summary>
        /// The Suchergebis_TabelleFolder folder.
        /// </summary>
        [RepositoryFolder("b597f144-438c-4fea-8aa7-972cf32aafe8")]
        public partial class Suchergebis_TabelleFolder : RepoGenBaseFolder
        {
            RepoItemInfo _row1column0Info;
            RepoItemInfo _row1Info;
            RepoItemInfo _celltmpbanknrrow1Info;
            RepoItemInfo _row11Info;

            /// <summary>
            /// Creates a new Suchergebis_Tabelle  folder.
            /// </summary>
            public Suchergebis_TabelleFolder(RepoGenBaseFolder parentFolder) :
                    base("Suchergebis_Tabelle", "container[@controlname='searchContainer']/form[@controlname='frmSearchPage']/container[@controlname='ClientArea']/container[@controlname='searchResult']/container[@controlname='tblSearchResult']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "b597f144-438c-4fea-8aa7-972cf32aafe8", "")
            {
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "cell[@accessiblename='Row 1 Column 0']", "", 30000, null, "e96cef6b-b146-42be-be76-25c8cf4cd947");
                _row1Info = new RepoItemInfo(this, "Row1", "row[@accessiblename='Row 1']", "", 30000, null, "f15fef2d-13e1-4c43-8db4-d5837f77a33e");
                _celltmpbanknrrow1Info = new RepoItemInfo(this, "CellTmpBANKNRRow1", "cell[@accessiblename='__tmp__BANK_NR Row 1']", "", 30000, null, "da0b97ef-7c1c-4b5f-b52e-5abac6a6a95f");
                _row11Info = new RepoItemInfo(this, "Row11", "", "", 30000, null, "be4e405a-8fe9-41f9-9b53-845d4b394fa2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b597f144-438c-4fea-8aa7-972cf32aafe8")]
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
            [RepositoryItemInfo("b597f144-438c-4fea-8aa7-972cf32aafe8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("e96cef6b-b146-42be-be76-25c8cf4cd947")]
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
            [RepositoryItemInfo("e96cef6b-b146-42be-be76-25c8cf4cd947")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }

            /// <summary>
            /// The Row1 item.
            /// </summary>
            [RepositoryItem("f15fef2d-13e1-4c43-8db4-d5837f77a33e")]
            public virtual Ranorex.Row Row1
            {
                get
                {
                    return _row1Info.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Row1 item info.
            /// </summary>
            [RepositoryItemInfo("f15fef2d-13e1-4c43-8db4-d5837f77a33e")]
            public virtual RepoItemInfo Row1Info
            {
                get
                {
                    return _row1Info;
                }
            }

            /// <summary>
            /// The CellTmpBANKNRRow1 item.
            /// </summary>
            [RepositoryItem("da0b97ef-7c1c-4b5f-b52e-5abac6a6a95f")]
            public virtual Ranorex.Cell CellTmpBANKNRRow1
            {
                get
                {
                    return _celltmpbanknrrow1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellTmpBANKNRRow1 item info.
            /// </summary>
            [RepositoryItemInfo("da0b97ef-7c1c-4b5f-b52e-5abac6a6a95f")]
            public virtual RepoItemInfo CellTmpBANKNRRow1Info
            {
                get
                {
                    return _celltmpbanknrrow1Info;
                }
            }

            /// <summary>
            /// The Row11 item.
            /// </summary>
            [RepositoryItem("be4e405a-8fe9-41f9-9b53-845d4b394fa2")]
            public virtual Ranorex.Table Row11
            {
                get
                {
                    return _row11Info.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Row11 item info.
            /// </summary>
            [RepositoryItemInfo("be4e405a-8fe9-41f9-9b53-845d4b394fa2")]
            public virtual RepoItemInfo Row11Info
            {
                get
                {
                    return _row11Info;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("55c49c0d-d526-480c-b1f6-6c8686cb4e54")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _verwaltenbankverbindungenInfo;
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "55c49c0d-d526-480c-b1f6-6c8686cb4e54", "")
            {
                _verwaltenbankverbindungenInfo = new RepoItemInfo(this, "VerwaltenBankverbindungen", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "54cf19b5-142d-4408-89da-a11bbec6e43c");
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "268b0ce5-1d15-4a26-af48-9bb64dd95d87");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "143a439e-ab4b-4121-a969-5152a63643f1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("55c49c0d-d526-480c-b1f6-6c8686cb4e54")]
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
            [RepositoryItemInfo("55c49c0d-d526-480c-b1f6-6c8686cb4e54")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The VerwaltenBankverbindungen item.
            /// </summary>
            [RepositoryItem("54cf19b5-142d-4408-89da-a11bbec6e43c")]
            public virtual Ranorex.TitleBar VerwaltenBankverbindungen
            {
                get
                {
                    return _verwaltenbankverbindungenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The VerwaltenBankverbindungen item info.
            /// </summary>
            [RepositoryItemInfo("54cf19b5-142d-4408-89da-a11bbec6e43c")]
            public virtual RepoItemInfo VerwaltenBankverbindungenInfo
            {
                get
                {
                    return _verwaltenbankverbindungenInfo;
                }
            }

            /// <summary>
            /// The LabelMeldungstext item.
            /// </summary>
            [RepositoryItem("268b0ce5-1d15-4a26-af48-9bb64dd95d87")]
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
            [RepositoryItemInfo("268b0ce5-1d15-4a26-af48-9bb64dd95d87")]
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
            [RepositoryItem("143a439e-ab4b-4121-a969-5152a63643f1")]
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
            [RepositoryItemInfo("143a439e-ab4b-4121-a969-5152a63643f1")]
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
