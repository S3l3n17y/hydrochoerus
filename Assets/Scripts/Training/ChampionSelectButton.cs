using Hydrochoerus.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hydrochoerus.Training
{
    public class ChampionSelectButton : MonoBehaviour
    {
        public GameObject TrainingManager;
        public CharacterType Type;

        private TrainingManager manager;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// クリック時イベント
        /// </summary>
        public void OnClick()
        {
            if (manager == null)
            {
                manager = TrainingManager.GetComponent<TrainingManager>();
            }
                manager.SelectChampion(Type);
        }
    }
}