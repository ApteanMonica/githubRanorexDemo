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

namespace S_ADG_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the S_ADG_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("42e92c67-d8b8-456d-a369-d2a2330c5a40")]
    public partial class S_ADG_SchnelltestRepository : RepoGenBaseFolder
    {
        static S_ADG_SchnelltestRepository instance = new S_ADG_SchnelltestRepository();
        S_ADG_SchnelltestRepositoryFolders.TblAdaAppFolder _tblada;
        S_ADG_SchnelltestRepositoryFolders.SADGAppFolder _sadg;

        /// <summary>
        /// Gets the singleton class instance representing the S_ADG_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("42e92c67-d8b8-456d-a369-d2a2330c5a40")]
        public static S_ADG_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public S_ADG_SchnelltestRepository() 
            : base("S_ADG_SchnelltestRepository", "/", null, 0, false, "42e92c67-d8b8-456d-a369-d2a2330c5a40", ".\\RepositoryImages\\S_ADG_SchnelltestRepository42e92c67.rximgres")
        {
            _tblada = new S_ADG_SchnelltestRepositoryFolders.TblAdaAppFolder(this);
            _sadg = new S_ADG_SchnelltestRepositoryFolders.SADGAppFolder(this);
        }

#region Variables

        string _ADRSSART_NEU = "51";

        /// <summary>
        /// Gets or sets the value of variable ADRSSART_NEU.
        /// </summary>
        [TestVariable("37368c07-b567-4cbf-8a6c-ef4c8c594015")]
        public string ADRSSART_NEU
        {
            get { return _ADRSSART_NEU; }
            set { _ADRSSART_NEU = value; }
        }

        string _ADRSSART_ALT = "";

        /// <summary>
        /// Gets or sets the value of variable ADRSSART_ALT.
        /// </summary>
        [TestVariable("dc3ed25d-07e1-4b67-a595-7d944452a749")]
        public string ADRSSART_ALT
        {
            get { return _ADRSSART_ALT; }
            set { _ADRSSART_ALT = value; }
        }

        string _ADRESSART_ALT = "Betriebsstätten";

        /// <summary>
        /// Gets or sets the value of variable ADRESSART_ALT.
        /// </summary>
        [TestVariable("50dc624a-cb2e-49b1-be9f-8738b54be115")]
        public string ADRESSART_ALT
        {
            get { return _ADRESSART_ALT; }
            set { _ADRESSART_ALT = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("42e92c67-d8b8-456d-a369-d2a2330c5a40")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TblAda folder.
        /// </summary>
        [RepositoryFolder("5d1482a4-99fb-4959-a474-98b4ad5fb50e")]
        public virtual S_ADG_SchnelltestRepositoryFolders.TblAdaAppFolder TblAda
        {
            get { return _tblada; }
        }

        /// <summary>
        /// The SADG folder.
        /// </summary>
        [RepositoryFolder("4ad3d3a9-e3f7-4dfd-b080-52ee5c7e8ff4")]
        public virtual S_ADG_SchnelltestRepositoryFolders.SADGAppFolder SADG
        {
            get { return _sadg; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class S_ADG_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The TblAdaAppFolder folder.
        /// </summary>
        [RepositoryFolder("5d1482a4-99fb-4959-a474-98b4ad5fb50e")]
        public partial class TblAdaAppFolder : RepoGenBaseFolder
        {
            S_ADG_SchnelltestRepositoryFolders.RibbonBarFolder _ribbonbar;
            S_ADG_SchnelltestRepositoryFolders.FlexGridFolder _flexgrid;
            RepoItemInfo _titlebar100adressartenInfo;
            RepoItemInfo _maximierenInfo;
            RepoItemInfo _maximieren1Info;

            /// <summary>
            /// Creates a new TblAda  folder.
            /// </summary>
            public TblAdaAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblAda", "/form[@controlname='tblAda']", parentFolder, 30000, null, true, "5d1482a4-99fb-4959-a474-98b4ad5fb50e", "")
            {
                _ribbonbar = new S_ADG_SchnelltestRepositoryFolders.RibbonBarFolder(this);
                _flexgrid = new S_ADG_SchnelltestRepositoryFolders.FlexGridFolder(this);
                _titlebar100adressartenInfo = new RepoItemInfo(this, "TitleBar100Adressarten", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "5a1ceea9-00ff-43e4-9717-0ad9c9676fba");
                _maximierenInfo = new RepoItemInfo(this, "Maximieren", "container[@controlname='RibbonBar']/titlebar[@accessiblerole='TitleBar']/button[@accessiblename='Maximieren']", "", 30000, null, "57ed01cd-c2ca-46bb-ae26-dcfb4ae60be0");
                _maximieren1Info = new RepoItemInfo(this, "Maximieren1", "titlebar[@accessiblerole='TitleBar']/button[@accessiblename='Maximieren']", "", 30000, null, "dacbeba7-c06b-4cfd-a6d6-644f6d36df38");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5d1482a4-99fb-4959-a474-98b4ad5fb50e")]
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
            [RepositoryItemInfo("5d1482a4-99fb-4959-a474-98b4ad5fb50e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100Adressarten item.
            /// </summary>
            [RepositoryItem("5a1ceea9-00ff-43e4-9717-0ad9c9676fba")]
            public virtual Ranorex.TitleBar TitleBar100Adressarten
            {
                get
                {
                    return _titlebar100adressartenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100Adressarten item info.
            /// </summary>
            [RepositoryItemInfo("5a1ceea9-00ff-43e4-9717-0ad9c9676fba")]
            public virtual RepoItemInfo TitleBar100AdressartenInfo
            {
                get
                {
                    return _titlebar100adressartenInfo;
                }
            }

            /// <summary>
            /// The Maximieren item.
            /// </summary>
            [RepositoryItem("57ed01cd-c2ca-46bb-ae26-dcfb4ae60be0")]
            public virtual Ranorex.Button Maximieren
            {
                get
                {
                    return _maximierenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Maximieren item info.
            /// </summary>
            [RepositoryItemInfo("57ed01cd-c2ca-46bb-ae26-dcfb4ae60be0")]
            public virtual RepoItemInfo MaximierenInfo
            {
                get
                {
                    return _maximierenInfo;
                }
            }

            /// <summary>
            /// The Maximieren1 item.
            /// </summary>
            [RepositoryItem("dacbeba7-c06b-4cfd-a6d6-644f6d36df38")]
            public virtual Ranorex.Button Maximieren1
            {
                get
                {
                    return _maximieren1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Maximieren1 item info.
            /// </summary>
            [RepositoryItemInfo("dacbeba7-c06b-4cfd-a6d6-644f6d36df38")]
            public virtual RepoItemInfo Maximieren1Info
            {
                get
                {
                    return _maximieren1Info;
                }
            }

            /// <summary>
            /// The RibbonBar folder.
            /// </summary>
            [RepositoryFolder("5a15e993-fc29-41e8-b7ac-bc7f3ea8ebec")]
            public virtual S_ADG_SchnelltestRepositoryFolders.RibbonBarFolder RibbonBar
            {
                get { return _ribbonbar; }
            }

            /// <summary>
            /// The FlexGrid folder.
            /// </summary>
            [RepositoryFolder("d7ff7ef3-140d-483b-b058-2148cc91120a")]
            public virtual S_ADG_SchnelltestRepositoryFolders.FlexGridFolder FlexGrid
            {
                get { return _flexgrid; }
            }
        }

        /// <summary>
        /// The RibbonBarFolder folder.
        /// </summary>
        [RepositoryFolder("5a15e993-fc29-41e8-b7ac-bc7f3ea8ebec")]
        public partial class RibbonBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _pbdataaccessnewInfo;
            RepoItemInfo _pbdataaccessloadInfo;
            RepoItemInfo _pbdataaccesssaveInfo;

            /// <summary>
            /// Creates a new RibbonBar  folder.
            /// </summary>
            public RibbonBarFolder(RepoGenBaseFolder parentFolder) :
                    base("RibbonBar", "container[@controlname='RibbonBar']", parentFolder, 30000, null, false, "5a15e993-fc29-41e8-b7ac-bc7f3ea8ebec", "")
            {
                _pbdataaccessnewInfo = new RepoItemInfo(this, "PbDataAccessNew", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_New']", "", 30000, null, "538a644d-6b6e-455d-9b12-64b2c2d53bee");
                _pbdataaccessloadInfo = new RepoItemInfo(this, "PbDataAccessLoad", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Load']", "", 30000, null, "2eb34564-69ae-4478-a6f4-9005c6f24171");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Save']", "", 30000, null, "283fa880-3c68-4b36-a973-1f5ce85b3164");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5a15e993-fc29-41e8-b7ac-bc7f3ea8ebec")]
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
            [RepositoryItemInfo("5a15e993-fc29-41e8-b7ac-bc7f3ea8ebec")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessNew item.
            /// </summary>
            [RepositoryItem("538a644d-6b6e-455d-9b12-64b2c2d53bee")]
            public virtual Ranorex.Button PbDataAccessNew
            {
                get
                {
                    return _pbdataaccessnewInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessNew item info.
            /// </summary>
            [RepositoryItemInfo("538a644d-6b6e-455d-9b12-64b2c2d53bee")]
            public virtual RepoItemInfo PbDataAccessNewInfo
            {
                get
                {
                    return _pbdataaccessnewInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessLoad item.
            /// </summary>
            [RepositoryItem("2eb34564-69ae-4478-a6f4-9005c6f24171")]
            public virtual Ranorex.Button PbDataAccessLoad
            {
                get
                {
                    return _pbdataaccessloadInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessLoad item info.
            /// </summary>
            [RepositoryItemInfo("2eb34564-69ae-4478-a6f4-9005c6f24171")]
            public virtual RepoItemInfo PbDataAccessLoadInfo
            {
                get
                {
                    return _pbdataaccessloadInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("283fa880-3c68-4b36-a973-1f5ce85b3164")]
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
            [RepositoryItemInfo("283fa880-3c68-4b36-a973-1f5ce85b3164")]
            public virtual RepoItemInfo PbDataAccessSaveInfo
            {
                get
                {
                    return _pbdataaccesssaveInfo;
                }
            }
        }

        /// <summary>
        /// The FlexGridFolder folder.
        /// </summary>
        [RepositoryFolder("d7ff7ef3-140d-483b-b058-2148cc91120a")]
        public partial class FlexGridFolder : RepoGenBaseFolder
        {
            S_ADG_SchnelltestRepositoryFolders.Row_mit_Variable_Adressart_NEUFolder _row_mit_variable_adressart_neu;
            S_ADG_SchnelltestRepositoryFolders.Row_mit_Variable_Adressart_ALTFolder _row_mit_variable_adressart_alt;
            RepoItemInfo _row0column0Info;
            RepoItemInfo _row1column0Info;
            RepoItemInfo _row9column0Info;
            RepoItemInfo _row8column0Info;

            /// <summary>
            /// Creates a new FlexGrid  folder.
            /// </summary>
            public FlexGridFolder(RepoGenBaseFolder parentFolder) :
                    base("FlexGrid", "container[@controlname='ChildTableWindow']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "d7ff7ef3-140d-483b-b058-2148cc91120a", "")
            {
                _row_mit_variable_adressart_neu = new S_ADG_SchnelltestRepositoryFolders.Row_mit_Variable_Adressart_NEUFolder(this);
                _row_mit_variable_adressart_alt = new S_ADG_SchnelltestRepositoryFolders.Row_mit_Variable_Adressart_ALTFolder(this);
                _row0column0Info = new RepoItemInfo(this, "Row0Column0", "row[@accessiblename='Row 0']/cell[@accessiblename='Row 0 Column 0']", "", 30000, null, "b4c65f2e-7f02-440f-9199-2c675ed007da");
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "row[@accessiblename='Row 1']/cell[@accessiblename='Row 1 Column 0']", "", 30000, null, "c3a5a175-e362-4c51-ba13-04b681de2d3c");
                _row9column0Info = new RepoItemInfo(this, "Row9Column0", "row[@accessiblename='Row 9']/cell[@accessiblename='Row 9 Column 0']", "", 30000, null, "f7ef44ea-0a5a-46f7-8a1d-d9b9e1946d92");
                _row8column0Info = new RepoItemInfo(this, "Row8Column0", "row[@accessiblename='Row 8']/cell[@accessiblename='Row 8 Column 0']", "", 30000, null, "aa7a37ca-c3f5-4456-bec0-690d0be87fe4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d7ff7ef3-140d-483b-b058-2148cc91120a")]
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
            [RepositoryItemInfo("d7ff7ef3-140d-483b-b058-2148cc91120a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Row0Column0 item.
            /// </summary>
            [RepositoryItem("b4c65f2e-7f02-440f-9199-2c675ed007da")]
            public virtual Ranorex.Cell Row0Column0
            {
                get
                {
                    return _row0column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row0Column0 item info.
            /// </summary>
            [RepositoryItemInfo("b4c65f2e-7f02-440f-9199-2c675ed007da")]
            public virtual RepoItemInfo Row0Column0Info
            {
                get
                {
                    return _row0column0Info;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("c3a5a175-e362-4c51-ba13-04b681de2d3c")]
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
            [RepositoryItemInfo("c3a5a175-e362-4c51-ba13-04b681de2d3c")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }

            /// <summary>
            /// The Row9Column0 item.
            /// </summary>
            [RepositoryItem("f7ef44ea-0a5a-46f7-8a1d-d9b9e1946d92")]
            public virtual Ranorex.Cell Row9Column0
            {
                get
                {
                    return _row9column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row9Column0 item info.
            /// </summary>
            [RepositoryItemInfo("f7ef44ea-0a5a-46f7-8a1d-d9b9e1946d92")]
            public virtual RepoItemInfo Row9Column0Info
            {
                get
                {
                    return _row9column0Info;
                }
            }

            /// <summary>
            /// The Row8Column0 item.
            /// </summary>
            [RepositoryItem("aa7a37ca-c3f5-4456-bec0-690d0be87fe4")]
            public virtual Ranorex.Cell Row8Column0
            {
                get
                {
                    return _row8column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row8Column0 item info.
            /// </summary>
            [RepositoryItemInfo("aa7a37ca-c3f5-4456-bec0-690d0be87fe4")]
            public virtual RepoItemInfo Row8Column0Info
            {
                get
                {
                    return _row8column0Info;
                }
            }

            /// <summary>
            /// The Row_mit_Variable_Adressart_NEU folder.
            /// </summary>
            [RepositoryFolder("222430a7-4741-4afe-8e09-7e9c91d9d1e5")]
            public virtual S_ADG_SchnelltestRepositoryFolders.Row_mit_Variable_Adressart_NEUFolder Row_mit_Variable_Adressart_NEU
            {
                get { return _row_mit_variable_adressart_neu; }
            }

            /// <summary>
            /// The Row_mit_Variable_Adressart_ALT folder.
            /// </summary>
            [RepositoryFolder("01bb60b4-666b-4fdd-b10e-ccce597fa9f6")]
            public virtual S_ADG_SchnelltestRepositoryFolders.Row_mit_Variable_Adressart_ALTFolder Row_mit_Variable_Adressart_ALT
            {
                get { return _row_mit_variable_adressart_alt; }
            }
        }

        /// <summary>
        /// The Row_mit_Variable_Adressart_NEUFolder folder.
        /// </summary>
        [RepositoryFolder("222430a7-4741-4afe-8e09-7e9c91d9d1e5")]
        public partial class Row_mit_Variable_Adressart_NEUFolder : RepoGenBaseFolder
        {
            RepoItemInfo _coladacdInfo;
            RepoItemInfo _coladabezInfo;
            RepoItemInfo _coladakzmehrfachInfo;
            RepoItemInfo _coladakzanzeigeInfo;
            RepoItemInfo _coladrklInfo;

            /// <summary>
            /// Creates a new Row_mit_Variable_Adressart_NEU  folder.
            /// </summary>
            public Row_mit_Variable_Adressart_NEUFolder(RepoGenBaseFolder parentFolder) :
                    base("Row_mit_Variable_Adressart_NEU", "row[@accessiblerole='Row' and @accessiblevalue~$ADRSSART_NEU]", parentFolder, 30000, null, false, "222430a7-4741-4afe-8e09-7e9c91d9d1e5", "")
            {
                _coladacdInfo = new RepoItemInfo(this, "ColAdaCd", "cell[@accessiblename~'colAda_cd']", "", 30000, null, "e822a5d7-9b7d-4c43-bb5d-d1fa0ca832eb");
                _coladabezInfo = new RepoItemInfo(this, "ColAdaBez", "cell[@accessiblename~'colAda_bez']", "", 30000, null, "2cdcf3a3-1ca6-4bfc-a39c-acc147047285");
                _coladakzmehrfachInfo = new RepoItemInfo(this, "ColAdaKzmehrfach", "cell[@accessiblename~'colAda_kzmehrfach']", "", 30000, null, "a577abc5-9c45-4615-a64e-252959586650");
                _coladakzanzeigeInfo = new RepoItemInfo(this, "ColAdaKzanzeige", "cell[@accessiblename~'colAda_kzanzeige']", "", 30000, null, "eb951db3-3c18-4c4e-bb39-0016e00e964f");
                _coladrklInfo = new RepoItemInfo(this, "ColAdrKl", "cell[@accessiblename~'colAdr_kl']", "", 30000, null, "d564b3c5-a8b6-4409-802b-86fc39f23f58");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("222430a7-4741-4afe-8e09-7e9c91d9d1e5")]
            public virtual Ranorex.Row Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("222430a7-4741-4afe-8e09-7e9c91d9d1e5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ColAdaCd item.
            /// </summary>
            [RepositoryItem("e822a5d7-9b7d-4c43-bb5d-d1fa0ca832eb")]
            public virtual Ranorex.Cell ColAdaCd
            {
                get
                {
                    return _coladacdInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColAdaCd item info.
            /// </summary>
            [RepositoryItemInfo("e822a5d7-9b7d-4c43-bb5d-d1fa0ca832eb")]
            public virtual RepoItemInfo ColAdaCdInfo
            {
                get
                {
                    return _coladacdInfo;
                }
            }

            /// <summary>
            /// The ColAdaBez item.
            /// </summary>
            [RepositoryItem("2cdcf3a3-1ca6-4bfc-a39c-acc147047285")]
            public virtual Ranorex.Cell ColAdaBez
            {
                get
                {
                    return _coladabezInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColAdaBez item info.
            /// </summary>
            [RepositoryItemInfo("2cdcf3a3-1ca6-4bfc-a39c-acc147047285")]
            public virtual RepoItemInfo ColAdaBezInfo
            {
                get
                {
                    return _coladabezInfo;
                }
            }

            /// <summary>
            /// The ColAdaKzmehrfach item.
            /// </summary>
            [RepositoryItem("a577abc5-9c45-4615-a64e-252959586650")]
            public virtual Ranorex.Cell ColAdaKzmehrfach
            {
                get
                {
                    return _coladakzmehrfachInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColAdaKzmehrfach item info.
            /// </summary>
            [RepositoryItemInfo("a577abc5-9c45-4615-a64e-252959586650")]
            public virtual RepoItemInfo ColAdaKzmehrfachInfo
            {
                get
                {
                    return _coladakzmehrfachInfo;
                }
            }

            /// <summary>
            /// The ColAdaKzanzeige item.
            /// </summary>
            [RepositoryItem("eb951db3-3c18-4c4e-bb39-0016e00e964f")]
            public virtual Ranorex.Cell ColAdaKzanzeige
            {
                get
                {
                    return _coladakzanzeigeInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColAdaKzanzeige item info.
            /// </summary>
            [RepositoryItemInfo("eb951db3-3c18-4c4e-bb39-0016e00e964f")]
            public virtual RepoItemInfo ColAdaKzanzeigeInfo
            {
                get
                {
                    return _coladakzanzeigeInfo;
                }
            }

            /// <summary>
            /// The ColAdrKl item.
            /// </summary>
            [RepositoryItem("d564b3c5-a8b6-4409-802b-86fc39f23f58")]
            public virtual Ranorex.Cell ColAdrKl
            {
                get
                {
                    return _coladrklInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColAdrKl item info.
            /// </summary>
            [RepositoryItemInfo("d564b3c5-a8b6-4409-802b-86fc39f23f58")]
            public virtual RepoItemInfo ColAdrKlInfo
            {
                get
                {
                    return _coladrklInfo;
                }
            }
        }

        /// <summary>
        /// The Row_mit_Variable_Adressart_ALTFolder folder.
        /// </summary>
        [RepositoryFolder("01bb60b4-666b-4fdd-b10e-ccce597fa9f6")]
        public partial class Row_mit_Variable_Adressart_ALTFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Row_mit_Variable_Adressart_ALT  folder.
            /// </summary>
            public Row_mit_Variable_Adressart_ALTFolder(RepoGenBaseFolder parentFolder) :
                    base("Row_mit_Variable_Adressart_ALT", "row[@accessiblerole~'Row' and @accessiblevalue~$ADRESSART_ALT]/?", parentFolder, 30000, null, false, "01bb60b4-666b-4fdd-b10e-ccce597fa9f6", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("01bb60b4-666b-4fdd-b10e-ccce597fa9f6")]
            public virtual Ranorex.Unknown Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("01bb60b4-666b-4fdd-b10e-ccce597fa9f6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The SADGAppFolder folder.
        /// </summary>
        [RepositoryFolder("4ad3d3a9-e3f7-4dfd-b080-52ee5c7e8ff4")]
        public partial class SADGAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _zeileeinfuegenInfo;
            RepoItemInfo _loeschenInfo;

            /// <summary>
            /// Creates a new SADG  folder.
            /// </summary>
            public SADGAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SADG", "/contextmenu[@processname='S_ADG']", parentFolder, 30000, null, true, "4ad3d3a9-e3f7-4dfd-b080-52ee5c7e8ff4", "")
            {
                _zeileeinfuegenInfo = new RepoItemInfo(this, "ZeileEinfuegen", "menuitem[@name='Zeile einfügen']", "", 30000, null, "088e3715-ff52-45ff-a4fb-ec5a36b13d8a");
                _loeschenInfo = new RepoItemInfo(this, "Loeschen", "menuitem[@name='Löschen']", "", 30000, null, "0b62638f-fdb8-477c-8277-bdf9857e27d4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4ad3d3a9-e3f7-4dfd-b080-52ee5c7e8ff4")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4ad3d3a9-e3f7-4dfd-b080-52ee5c7e8ff4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ZeileEinfuegen item.
            /// </summary>
            [RepositoryItem("088e3715-ff52-45ff-a4fb-ec5a36b13d8a")]
            public virtual Ranorex.MenuItem ZeileEinfuegen
            {
                get
                {
                    return _zeileeinfuegenInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The ZeileEinfuegen item info.
            /// </summary>
            [RepositoryItemInfo("088e3715-ff52-45ff-a4fb-ec5a36b13d8a")]
            public virtual RepoItemInfo ZeileEinfuegenInfo
            {
                get
                {
                    return _zeileeinfuegenInfo;
                }
            }

            /// <summary>
            /// The Loeschen item.
            /// </summary>
            [RepositoryItem("0b62638f-fdb8-477c-8277-bdf9857e27d4")]
            public virtual Ranorex.MenuItem Loeschen
            {
                get
                {
                    return _loeschenInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Loeschen item info.
            /// </summary>
            [RepositoryItemInfo("0b62638f-fdb8-477c-8277-bdf9857e27d4")]
            public virtual RepoItemInfo LoeschenInfo
            {
                get
                {
                    return _loeschenInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
