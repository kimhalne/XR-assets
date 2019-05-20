using UnityEngine;
using System.Collections;
public class RandomCloneObj : MonoBehaviour
{
	
public GameObject[] Train;

	void Start (){
		int number = Random.Range (0, Train.Length);

		Instantiate(Train [number],transform.position,transform.rotation);
	}
}