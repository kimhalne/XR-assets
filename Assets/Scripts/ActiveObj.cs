using UnityEngine;
using System.Collections;

public class ActiveObj : MonoBehaviour
{

	[SerializeField]
	GameObject TargetObj;
	
	[SerializeField]
	float ActiveTime = 0.1f;

	private void HideThisTrigger ()
	{
		//トリガーの非表示処理
		gameObject.SetActive (false);
	}

	private void OtherObjActive ()
	{
		//ターゲットオブジェクトの表示処理
		TargetObj.SetActive (true);
	}

	private void Start ()
	{
		GetComponent<Collider> ().isTrigger = true;
	}

	private void OnTriggerEnter (Collider other)
	{
		string layerName = LayerMask.LayerToName (other.gameObject.layer);

		if (layerName == "Player") {

			//指定秒数後に、オブジェクトを表示
			Invoke ("OtherObjActive", ActiveTime);
			//指定秒数後に、トリガーを非表示
			Invoke ("HideThisTrigger", 0.1f);
		}
	}
}