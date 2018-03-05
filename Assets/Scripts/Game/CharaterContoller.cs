using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hydrochoerus.Game
{
    public class CharaterContoller : MonoBehaviour
    {
        public Transform verObject; //垂直方向の変更反映先
        public Transform horObject; //水平方向の変更反映先
        // Use this for initialization
        void Start()
        {
            verObject = transform;
            horObject= transform.parent;
        }

        // Update is called once per frame
        void Update()
        {
            SetCharacterLookAt();
            MoveCharacter();
        }

        /// <summary>
        /// キャラクターをマウスの移動量分回転する
        /// </summary>
        void SetCharacterLookAt()
        {
            float horizontal;
            float vertical;

            horizontal = Input.GetAxis("Mouse X");
            vertical = Input.GetAxis("Mouse Y");
            //水平方向の回転
            horObject.Rotate(0.0f, -horizontal, 0.0f);
            //垂直方向の回転
            Vector3 rot;
            rot.x = ClampRotX(verObject.localEulerAngles.x - vertical, 85.0f, 275.0f);
            rot.y = 0.0f;
            rot.z = 0.0f;
            verObject.localEulerAngles = rot;
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        void MoveCharacter()
        {
            float Dx;
            float Dz;

            SetCharacterLookAt();
            Dx = Input.GetAxis("Horizontal") * Time.deltaTime;
            Dz = Input.GetAxis("Vertical") * Time.deltaTime;
            horObject.Translate(Dx,0.0f,Dz);
        }

        float ClampRotX(float value, float min, float max)
        {
            value = Mathf.Repeat(value,360.0f);
            min = Mathf.Repeat(min, 360.0f);
            max = Mathf.Repeat(max, 360.0f);
            if (value > 180.0f)
            {
                return Mathf.Max(value, max);
            }
            else if (value < 0.0f)
            {
                return Mathf.Max(value + 360.0f, max);
            }
            return Mathf.Min(value, min);
        }
    }
}