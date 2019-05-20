using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinker : MonoBehaviour {

    public float DelayTime = 1.0f;
    public float interval = 0.1f;

    void Start () {
        StartCoroutine ("Blink");
    }

    IEnumerator Blink() {
		yield return new WaitForSeconds(DelayTime);
		
        while ( true ) {
            var renderComponent = GetComponent<Renderer>();
            renderComponent.enabled = !renderComponent.enabled;
            yield return new WaitForSeconds(interval);
        }
    }

}