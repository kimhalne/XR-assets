using UnityEngine;

public class MoveController: MonoBehaviour
{
	
	public float MoveSpeed = 2f;
	public float RotationSpeed = 60f;

	void Update()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.forward * MoveSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.up, -RotationSpeed*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up, +RotationSpeed*Time.deltaTime);
		}
	}
}