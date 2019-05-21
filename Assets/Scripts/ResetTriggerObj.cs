using UnityEngine;
using System.Collections;

public class ResetTriggerObj : MonoBehaviour
{

	[SerializeField]
	GameObject TriggerObj;

	[SerializeField]
	GameObject TargetObj;
	
	[SerializeField]
	float ActiveTime = 0.1f;
	
	//public KeyCode _switchKey;

	private void OtherObjActive ()
	{
		//ターゲットオブジェクトの表示処理
		TriggerObj.SetActive (true);
		TargetObj.SetActive (false);
	}

    void Update(){

        if (GvrControllerInput.ClickButtonDown)
		//if (Input.GetKeyDown(_switchKey))	

			//指定秒数後に、トリガーを表示しオブジェクトを非表示にする
			Invoke ("OtherObjActive", ActiveTime);

	}
}
