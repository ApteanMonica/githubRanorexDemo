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

namespace V_BOST_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the V_BOST_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1f3bc586-d129-46eb-b258-42960b6a78fd")]
    public partial class V_BOST_SchnelltestRepository : RepoGenBaseFolder
    {
        static V_BOST_SchnelltestRepository instance = new V_BOST_SchnelltestRepository();
        V_BOST_SchnelltestRepositoryFolders.TblBodkAppFolder _tblbodk;

        /// <summary>
        /// Gets the singleton class instance representing the V_BOST_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("1f3bc586-d129-46eb-b258-42960b6a78fd")]
        public static V_BOST_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public V_BOST_SchnelltestRepository() 
            : base("V_BOST_SchnelltestRepository", "/", null, 0, false, "1f3bc586-d129-46eb-b258-42960b6a78fd", ".\\RepositoryImages\\V_BOST_SchnelltestRepository1f3bc586.rximgres")
        {
            _tblbodk = new V_BOST_SchnelltestRepositoryFolders.TblBodkAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1f3bc586-d129-46eb-b258-42960b6a78fd")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TblBodk folder.
        /// </summary>
        [RepositoryFolder("7d6b40d2-42ad-42d6-98fd-b75655f2c9bf")]
        public virtual V_BOST_SchnelltestRepositoryFolders.TblBodkAppFolder TblBodk
        {
            get { return _tblbodk; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class V_BOST_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The TblBodkAppFolder folder.
        /// </summary>
        [RepositoryFolder("7d6b40d2-42ad-42d6-98fd-b75655f2c9bf")]
        public partial class TblBodkAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100bonusdefinitionskopfInfo;

            /// <summary>
            /// Creates a new TblBodk  folder.
            /// </summary>
            public TblBodkAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblBodk", "/form[@controlname='tblBodk']", parentFolder, 30000, null, true, "7d6b40d2-42ad-42d6-98fd-b75655f2c9bf", "")
            {
                _titlebar100bonusdefinitionskopfInfo = new RepoItemInfo(this, "TitleBar100BonusDefinitionskopf", "titlebar[@accessiblerole='TitleBar']", "titlebar[@accessiblerole='TitleBar']", 30000, null, "0887ac5c-5893-4d82-999a-416048209314");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7d6b40d2-42ad-42d6-98fd-b75655f2c9bf")]
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
            [RepositoryItemInfo("7d6b40d2-42ad-42d6-98fd-b75655f2c9bf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100BonusDefinitionskopf item.
            /// </summary>
            [RepositoryItem("0887ac5c-5893-4d82-999a-416048209314")]
            public virtual Ranorex.TitleBar TitleBar100BonusDefinitionskopf
            {
                get
                {
                    return _titlebar100bonusdefinitionskopfInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100BonusDefinitionskopf item info.
            /// </summary>
            [RepositoryItemInfo("0887ac5c-5893-4d82-999a-416048209314")]
            public virtual RepoItemInfo TitleBar100BonusDefinitionskopfInfo
            {
                get
                {
                    return _titlebar100bonusdefinitionskopfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}