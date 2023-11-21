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

namespace B_KLLIQ_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_KLLIQ_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("b350ee26-6ea7-400a-8be0-1c226aeb4f18")]
    public partial class B_KLLIQ_SchnelltestRepository : RepoGenBaseFolder
    {
        static B_KLLIQ_SchnelltestRepository instance = new B_KLLIQ_SchnelltestRepository();
        B_KLLIQ_SchnelltestRepositoryFolders.FrmMainAppFolder _frmmain;

        /// <summary>
        /// Gets the singleton class instance representing the B_KLLIQ_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("b350ee26-6ea7-400a-8be0-1c226aeb4f18")]
        public static B_KLLIQ_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_KLLIQ_SchnelltestRepository() 
            : base("B_KLLIQ_SchnelltestRepository", "/", null, 0, false, "b350ee26-6ea7-400a-8be0-1c226aeb4f18", ".\\RepositoryImages\\B_KLLIQ_SchnelltestRepositoryb350ee26.rximgres")
        {
            _frmmain = new B_KLLIQ_SchnelltestRepositoryFolders.FrmMainAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b350ee26-6ea7-400a-8be0-1c226aeb4f18")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmMain folder.
        /// </summary>
        [RepositoryFolder("7cb98dcc-0f1d-4587-b5bf-98de69ce442d")]
        public virtual B_KLLIQ_SchnelltestRepositoryFolders.FrmMainAppFolder FrmMain
        {
            get { return _frmmain; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_KLLIQ_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The FrmMainAppFolder folder.
        /// </summary>
        [RepositoryFolder("7cb98dcc-0f1d-4587-b5bf-98de69ce442d")]
        public partial class FrmMainAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100kundenliquiditaetsueberInfo;

            /// <summary>
            /// Creates a new FrmMain  folder.
            /// </summary>
            public FrmMainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmMain", "/form[@controlname='frmMain']", parentFolder, 30000, null, true, "7cb98dcc-0f1d-4587-b5bf-98de69ce442d", "")
            {
                _titlebar100kundenliquiditaetsueberInfo = new RepoItemInfo(this, "TitleBar100KundenLiquiditaetsUEber", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "3e042b04-21c1-4452-83d0-2e36a95c0830");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7cb98dcc-0f1d-4587-b5bf-98de69ce442d")]
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
            [RepositoryItemInfo("7cb98dcc-0f1d-4587-b5bf-98de69ce442d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100KundenLiquiditaetsUEber item.
            /// </summary>
            [RepositoryItem("3e042b04-21c1-4452-83d0-2e36a95c0830")]
            public virtual Ranorex.TitleBar TitleBar100KundenLiquiditaetsUEber
            {
                get
                {
                    return _titlebar100kundenliquiditaetsueberInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100KundenLiquiditaetsUEber item info.
            /// </summary>
            [RepositoryItemInfo("3e042b04-21c1-4452-83d0-2e36a95c0830")]
            public virtual RepoItemInfo TitleBar100KundenLiquiditaetsUEberInfo
            {
                get
                {
                    return _titlebar100kundenliquiditaetsueberInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}