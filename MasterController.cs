using UnityEngine;
using System.Collections;

public class MasterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject testRegion = GameObject.CreatePrimitive (PrimitiveType.Cube);
		testRegion.AddComponent<mapgen> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
