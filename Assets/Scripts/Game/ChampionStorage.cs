using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hydrochoerus.Game
{
    public class ChampionStorage:MonoBehaviour
    {
        public List<GameObject> ChampionsList;
        public GameObject InstantiateChampion(CharacterType type)
        {
            return Instantiate(ChampionsList[(int)type]);
        }
    }
}