using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hydrochoerus.Core
{
    /// <summary>
    /// 各シーンをstring型のテキストで提供します。
    /// </summary>
    public static class SceneNames
    {
        /// <summary>
        /// タイトルシーンのテキスト
        /// </summary>
        public static string TitleScene
        {
            get
            {
                return "Title";
            }
        }
        /// <summary>
        /// メニューシーンのテキスト
        /// </summary>
        public static string MenuScene
        {
            get
            {
                return "Menu";
            }
        }

        /// <summary>
        /// ゲームシーンのテキスト
        /// </summary>
        public static string GameScene
        {
            get
            {
                return "Game";
            }
        }
    }
}