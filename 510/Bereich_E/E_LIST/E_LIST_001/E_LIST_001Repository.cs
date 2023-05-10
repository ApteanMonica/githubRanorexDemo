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

namespace E_LIST_001
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the E_LIST_001Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3696a477-4253-4cc1-a658-0e6ea826fa06")]
    public partial class E_LIST_001Repository : RepoGenBaseFolder
    {
        static E_LIST_001Repository instance = new E_LIST_001Repository();
        E_LIST_001RepositoryFolders.E_LISTAppFolder _e_list;
        E_LIST_001RepositoryFolders.FirmenwechselAppFolder _firmenwechsel;

        /// <summary>
        /// Gets the singleton class instance representing the E_LIST_001Repository element repository.
        /// </summary>
        [RepositoryFolder("3696a477-4253-4cc1-a658-0e6ea826fa06")]
        public static E_LIST_001Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public E_LIST_001Repository() 
            : base("E_LIST_001Repository", "/", null, 0, false, "3696a477-4253-4cc1-a658-0e6ea826fa06", ".\\RepositoryImages\\E_LIST_001Repository3696a477.rximgres")
        {
            _e_list = new E_LIST_001RepositoryFolders.E_LISTAppFolder(this);
            _firmenwechsel = new E_LIST_001RepositoryFolders.FirmenwechselAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3696a477-4253-4cc1-a658-0e6ea826fa06")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The E_LIST folder.
        /// </summary>
        [RepositoryFolder("40896b7d-a8cb-4d1a-9bff-af337a1e7b79")]
        public virtual E_LIST_001RepositoryFolders.E_LISTAppFolder E_LIST
        {
            get { return _e_list; }
        }

        /// <summary>
        /// The Firmenwechsel folder.
        /// </summary>
        [RepositoryFolder("d4e3b91e-65b6-409d-9326-c8136b2240e1")]
        public virtual E_LIST_001RepositoryFolders.FirmenwechselAppFolder Firmenwechsel
        {
            get { return _firmenwechsel; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class E_LIST_001RepositoryFolders
    {
        /// <summary>
        /// The E_LISTAppFolder folder.
        /// </summary>
        [RepositoryFolder("40896b7d-a8cb-4d1a-9bff-af337a1e7b79")]
        public partial class E_LISTAppFolder : RepoGenBaseFolder
        {
            E_LIST_001RepositoryFolders.BereichFolder _bereich;
            E_LIST_001RepositoryFolders.TabelleFolder _tabelle;
            RepoItemInfo _titel_e_listInfo;
            RepoItemInfo _ladenInfo;
            RepoItemInfo _firmenwechselInfo;
            RepoItemInfo _datum_vonInfo;
            RepoItemInfo _datum_bisInfo;

            /// <summary>
            /// Creates a new E_LIST  folder.
            /// </summary>
            public E_LISTAppFolder(RepoGenBaseFolder parentFolder) :
                    base("E_LIST", "/form[@controlname='tblLeer']", parentFolder, 30000, null, true, "40896b7d-a8cb-4d1a-9bff-af337a1e7b79", "")
            {
                _bereich = new E_LIST_001RepositoryFolders.BereichFolder(this);
                _tabelle = new E_LIST_001RepositoryFolders.TabelleFolder(this);
                _titel_e_listInfo = new RepoItemInfo(this, "Titel_E_LIST", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "d27959d0-e108-4670-9c3e-99b550052029");
                _ladenInfo = new RepoItemInfo(this, "Laden", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Load']", "", 30000, null, "0085059c-c598-478a-8d24-618ed847c794");
                _firmenwechselInfo = new RepoItemInfo(this, "Firmenwechsel", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbCommon_Firmenwechsel']", "", 30000, null, "2a45a329-f284-4d36-a346-344164200034");
                _datum_vonInfo = new RepoItemInfo(this, "Datum_von", "container[@controlname='ToolBar']/?/?/text[@accessiblerole='Text']", "", 30000, null, "651809c1-774c-4d40-affa-d5a0d1004f53");
                _datum_bisInfo = new RepoItemInfo(this, "Datum_bis", "container[@controlname='ToolBar']/text[@controlname='dfBsk_datum_bis']/text[@accessiblerole='Text']", "", 30000, null, "d8ceba30-7119-476b-9185-4df0cbb0d8a3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("40896b7d-a8cb-4d1a-9bff-af337a1e7b79")]
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
            [RepositoryItemInfo("40896b7d-a8cb-4d1a-9bff-af337a1e7b79")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Titel_E_LIST item.
            /// </summary>
            [RepositoryItem("d27959d0-e108-4670-9c3e-99b550052029")]
            public virtual Ranorex.TitleBar Titel_E_LIST
            {
                get
                {
                    return _titel_e_listInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The Titel_E_LIST item info.
            /// </summary>
            [RepositoryItemInfo("d27959d0-e108-4670-9c3e-99b550052029")]
            public virtual RepoItemInfo Titel_E_LISTInfo
            {
                get
                {
                    return _titel_e_listInfo;
                }
            }

            /// <summary>
            /// The Laden item.
            /// </summary>
            [RepositoryItem("0085059c-c598-478a-8d24-618ed847c794")]
            public virtual Ranorex.Button Laden
            {
                get
                {
                    return _ladenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Laden item info.
            /// </summary>
            [RepositoryItemInfo("0085059c-c598-478a-8d24-618ed847c794")]
            public virtual RepoItemInfo LadenInfo
            {
                get
                {
                    return _ladenInfo;
                }
            }

            /// <summary>
            /// The Firmenwechsel item.
            /// </summary>
            [RepositoryItem("2a45a329-f284-4d36-a346-344164200034")]
            public virtual Ranorex.Button Firmenwechsel
            {
                get
                {
                    return _firmenwechselInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Firmenwechsel item info.
            /// </summary>
            [RepositoryItemInfo("2a45a329-f284-4d36-a346-344164200034")]
            public virtual RepoItemInfo FirmenwechselInfo
            {
                get
                {
                    return _firmenwechselInfo;
                }
            }

            /// <summary>
            /// The Datum_von item.
            /// </summary>
            [RepositoryItem("651809c1-774c-4d40-affa-d5a0d1004f53")]
            public virtual Ranorex.Text Datum_von
            {
                get
                {
                    return _datum_vonInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Datum_von item info.
            /// </summary>
            [RepositoryItemInfo("651809c1-774c-4d40-affa-d5a0d1004f53")]
            public virtual RepoItemInfo Datum_vonInfo
            {
                get
                {
                    return _datum_vonInfo;
                }
            }

            /// <summary>
            /// The Datum_bis item.
            /// </summary>
            [RepositoryItem("d8ceba30-7119-476b-9185-4df0cbb0d8a3")]
            public virtual Ranorex.Text Datum_bis
            {
                get
                {
                    return _datum_bisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Datum_bis item info.
            /// </summary>
            [RepositoryItemInfo("d8ceba30-7119-476b-9185-4df0cbb0d8a3")]
            public virtual RepoItemInfo Datum_bisInfo
            {
                get
                {
                    return _datum_bisInfo;
                }
            }

            /// <summary>
            /// The Bereich folder.
            /// </summary>
            [RepositoryFolder("6284d9e8-56ab-427f-a1ec-3db7503876f2")]
            public virtual E_LIST_001RepositoryFolders.BereichFolder Bereich
            {
                get { return _bereich; }
            }

            /// <summary>
            /// The Tabelle folder.
            /// </summary>
            [RepositoryFolder("b64fddf4-b56f-406c-a458-79a9084471a6")]
            public virtual E_LIST_001RepositoryFolders.TabelleFolder Tabelle
            {
                get { return _tabelle; }
            }
        }

        /// <summary>
        /// The BereichFolder folder.
        /// </summary>
        [RepositoryFolder("6284d9e8-56ab-427f-a1ec-3db7503876f2")]
        public partial class BereichFolder : RepoGenBaseFolder
        {
            RepoItemInfo _rbbskInfo;
            RepoItemInfo _rblskInfo;
            RepoItemInfo _rbrechInfo;

            /// <summary>
            /// Creates a new Bereich  folder.
            /// </summary>
            public BereichFolder(RepoGenBaseFolder parentFolder) :
                    base("Bereich", "?/?/container[@controlname='groupBox1']", parentFolder, 30000, null, false, "6284d9e8-56ab-427f-a1ec-3db7503876f2", "")
            {
                _rbbskInfo = new RepoItemInfo(this, "RbBsk", "radiobutton[@controlname='rbBsk']", "", 30000, null, "5c8a6782-1c81-4908-9b28-0223b2459bf1");
                _rblskInfo = new RepoItemInfo(this, "RbLsk", "radiobutton[@controlname='rbLsk']", "", 30000, null, "4b100c8e-fd9d-4bed-9c92-990c9eae6860");
                _rbrechInfo = new RepoItemInfo(this, "RbRech", "radiobutton[@controlname='rbRech']", "", 30000, null, "97f169a8-66b2-4b72-be76-ee3232da795a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6284d9e8-56ab-427f-a1ec-3db7503876f2")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6284d9e8-56ab-427f-a1ec-3db7503876f2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RbBsk item.
            /// </summary>
            [RepositoryItem("5c8a6782-1c81-4908-9b28-0223b2459bf1")]
            public virtual Ranorex.RadioButton RbBsk
            {
                get
                {
                    return _rbbskInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RbBsk item info.
            /// </summary>
            [RepositoryItemInfo("5c8a6782-1c81-4908-9b28-0223b2459bf1")]
            public virtual RepoItemInfo RbBskInfo
            {
                get
                {
                    return _rbbskInfo;
                }
            }

            /// <summary>
            /// The RbLsk item.
            /// </summary>
            [RepositoryItem("4b100c8e-fd9d-4bed-9c92-990c9eae6860")]
            public virtual Ranorex.RadioButton RbLsk
            {
                get
                {
                    return _rblskInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RbLsk item info.
            /// </summary>
            [RepositoryItemInfo("4b100c8e-fd9d-4bed-9c92-990c9eae6860")]
            public virtual RepoItemInfo RbLskInfo
            {
                get
                {
                    return _rblskInfo;
                }
            }

            /// <summary>
            /// The RbRech item.
            /// </summary>
            [RepositoryItem("97f169a8-66b2-4b72-be76-ee3232da795a")]
            public virtual Ranorex.RadioButton RbRech
            {
                get
                {
                    return _rbrechInfo.CreateAdapter<Ranorex.RadioButton>(true);
                }
            }

            /// <summary>
            /// The RbRech item info.
            /// </summary>
            [RepositoryItemInfo("97f169a8-66b2-4b72-be76-ee3232da795a")]
            public virtual RepoItemInfo RbRechInfo
            {
                get
                {
                    return _rbrechInfo;
                }
            }
        }

        /// <summary>
        /// The TabelleFolder folder.
        /// </summary>
        [RepositoryFolder("b64fddf4-b56f-406c-a458-79a9084471a6")]
        public partial class TabelleFolder : RepoGenBaseFolder
        {
            RepoItemInfo _lieferantInfo;
            RepoItemInfo _datumInfo;
            RepoItemInfo _belegnummerInfo;

            /// <summary>
            /// Creates a new Tabelle  folder.
            /// </summary>
            public TabelleFolder(RepoGenBaseFolder parentFolder) :
                    base("Tabelle", "container[@controlname='ChildTableWindow']/?/?/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "b64fddf4-b56f-406c-a458-79a9084471a6", "")
            {
                _lieferantInfo = new RepoItemInfo(this, "Lieferant", "?/?/cell[@accessiblename='colLeer_adr_nr Row 1']", "", 30000, null, "7ff65e93-2e1a-446a-b0e7-efce84a72390");
                _datumInfo = new RepoItemInfo(this, "Datum", "?/?/cell[@accessiblename='colLeer_datum Row 1']", "", 30000, null, "fa221e84-0045-490c-a0f7-d3a2a2ba2896");
                _belegnummerInfo = new RepoItemInfo(this, "Belegnummer", "?/?/cell[@accessiblename='colLeer_nr Row 1']", "", 30000, null, "916ef792-e189-4bd6-98a6-9684ae4816a6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b64fddf4-b56f-406c-a458-79a9084471a6")]
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
            [RepositoryItemInfo("b64fddf4-b56f-406c-a458-79a9084471a6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Lieferant item.
            /// </summary>
            [RepositoryItem("7ff65e93-2e1a-446a-b0e7-efce84a72390")]
            public virtual Ranorex.Cell Lieferant
            {
                get
                {
                    return _lieferantInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Lieferant item info.
            /// </summary>
            [RepositoryItemInfo("7ff65e93-2e1a-446a-b0e7-efce84a72390")]
            public virtual RepoItemInfo LieferantInfo
            {
                get
                {
                    return _lieferantInfo;
                }
            }

            /// <summary>
            /// The Datum item.
            /// </summary>
            [RepositoryItem("fa221e84-0045-490c-a0f7-d3a2a2ba2896")]
            public virtual Ranorex.Cell Datum
            {
                get
                {
                    return _datumInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Datum item info.
            /// </summary>
            [RepositoryItemInfo("fa221e84-0045-490c-a0f7-d3a2a2ba2896")]
            public virtual RepoItemInfo DatumInfo
            {
                get
                {
                    return _datumInfo;
                }
            }

            /// <summary>
            /// The Belegnummer item.
            /// </summary>
            [RepositoryItem("916ef792-e189-4bd6-98a6-9684ae4816a6")]
            public virtual Ranorex.Cell Belegnummer
            {
                get
                {
                    return _belegnummerInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Belegnummer item info.
            /// </summary>
            [RepositoryItemInfo("916ef792-e189-4bd6-98a6-9684ae4816a6")]
            public virtual RepoItemInfo BelegnummerInfo
            {
                get
                {
                    return _belegnummerInfo;
                }
            }
        }

        /// <summary>
        /// The FirmenwechselAppFolder folder.
        /// </summary>
        [RepositoryFolder("d4e3b91e-65b6-409d-9326-c8136b2240e1")]
        public partial class FirmenwechselAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firmaInfo;
            RepoItemInfo _pbokInfo;

            /// <summary>
            /// Creates a new Firmenwechsel  folder.
            /// </summary>
            public FirmenwechselAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Firmenwechsel", "/form[@controlname='dlgFirmenwechsel']", parentFolder, 30000, null, true, "d4e3b91e-65b6-409d-9326-c8136b2240e1", "")
            {
                _firmaInfo = new RepoItemInfo(this, "Firma", "container[@controlname='frame1']/?/?/text[@accessiblename='Firma']", "", 30000, null, "7d20fee1-1895-4cad-a9c0-72458be781ac");
                _pbokInfo = new RepoItemInfo(this, "PbOk", "button[@controlname='pbOk']", "", 30000, null, "722893b4-ea19-4017-b167-b3cae2696470");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d4e3b91e-65b6-409d-9326-c8136b2240e1")]
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
            [RepositoryItemInfo("d4e3b91e-65b6-409d-9326-c8136b2240e1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Firma item.
            /// </summary>
            [RepositoryItem("7d20fee1-1895-4cad-a9c0-72458be781ac")]
            public virtual Ranorex.Text Firma
            {
                get
                {
                    return _firmaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Firma item info.
            /// </summary>
            [RepositoryItemInfo("7d20fee1-1895-4cad-a9c0-72458be781ac")]
            public virtual RepoItemInfo FirmaInfo
            {
                get
                {
                    return _firmaInfo;
                }
            }

            /// <summary>
            /// The PbOk item.
            /// </summary>
            [RepositoryItem("722893b4-ea19-4017-b167-b3cae2696470")]
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
            [RepositoryItemInfo("722893b4-ea19-4017-b167-b3cae2696470")]
            public virtual RepoItemInfo PbOkInfo
            {
                get
                {
                    return _pbokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
