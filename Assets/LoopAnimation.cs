using UnityEngine;
using System.Collections;

public class LoopAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
					gameObject.GetComponent<Animation>().wrapMode = WrapMode.Loop;

			//PlayAnimation();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
