using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    Vector3 cachedScale;
 
	void Start() {
		cachedScale = transform.localScale;
	}

	public void OnMouseEnter() {
		transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
	}

	public void OnMouseExit() {
		transform.localScale = cachedScale;
	}
}
