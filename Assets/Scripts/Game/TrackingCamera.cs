using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hydrochoerus.Core
{
    /// <summary>
    /// 指定オブジェクトをトラッキングします。
    /// </summary>
    public class TrackingCamera : MonoBehaviour {

        public GameObject Target = null;        //トラッキング対象のオブジェクト
        public float Distance = 1.0f;           //カメラ距離
        public Vector3 Angle = Vector3.back;    //カメラ角度
        public Vector3 Offset = Vector3.zero;   //カメラオフセット
        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {
            if (Target == null) return;//ターゲットが存在しない
            Vector3 rotation = Target.transform.rotation * Angle;   //ターゲットの向きから角度分ずらす
            Vector3 position = Offset + Target.transform.position;
            position += rotation * Distance;
            gameObject.transform.position = position;
            gameObject.transform.rotation = Quaternion.LookRotation(Target.transform.rotation * -Angle);
        }
    }

}