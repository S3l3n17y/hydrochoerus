using Hydrochoerus.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Hydrochoerus.Title
{
    public class TitleStartButton : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnClick()
        {
            SceneManager.LoadScene(SceneNames.TrainingScene);
        }
    }
}