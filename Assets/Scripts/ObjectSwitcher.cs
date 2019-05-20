using System.Collections.Generic;
using UnityEngine;

namespace Assets.UnitySchool
{
    public class ObjectSwitcher : MonoBehaviour
    {
        /*フィールド*/

        [SerializeField]
        [Header("有効化するキー")]
        private KeyCode _switchKey;
        [Header("対象のゲームオブジェクト")]
        [SerializeField]
        private List<GameObject> _targetGameObjects;

        /*メソッド*/

        /// <summary>
        /// 毎フレーム実行される
        /// </summary>
        void Update () {
            
            //指定したキーが押下されていたなら
            if (Input.GetKeyDown(_switchKey))
            {
                //対象となるゲームオブジェクトを繰り返し処理で取り出して処理させる
                foreach (var g in _targetGameObjects)
                {
                    //ゲームオブジェクトの有効無効の状態を反転させる
                    g.SetActive(!g.activeSelf);
                }
            }
        }
    }
}
