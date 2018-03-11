using Hydrochoerus.Core;
using Hydrochoerus.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hydrochoerus.Training
{
    public class TrainingManager : MonoBehaviour
    {
        private CharacterType _charaType;
        private ChampionStorage _storage;
        private TrackingCamera _camera;
        private GameObject _champion;
        private GameObject _championSelecter;
        // Use this for initialization
        void Start()
        {
            _charaType = CharacterType.Drenc;
            _storage = GetComponent<ChampionStorage>();
            _camera = GameObject.Find("PlayerCamera").GetComponent<TrackingCamera>();
            _championSelecter = GameObject.Find("ChampionSelecter");
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SelectChampion(CharacterType type)
        {
            _charaType = type;
            if (_champion != null)
            {
                Destroy(_champion);
            }
            //チャンピオンオブジェクト取得
            _champion=_storage.InstantiateChampion(type);
            //子のトラッキング用オブジェクトを検索
            GameObject target = _champion.transform.Find("TrackPoint").gameObject;
            _camera.Target = target;
            Cursor.lockState = CursorLockMode.Locked;
            _championSelecter.SetActive(false);
        }
    }
}