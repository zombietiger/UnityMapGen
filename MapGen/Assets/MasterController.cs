using UnityEngine;
using System.Collections;

public class MasterController : MonoBehaviour {
	GameObject sphere;
	// Use this for initialization
	void Start () {
		GameObject testRegion = GameObject.CreatePrimitive (PrimitiveType.Cube);
		testRegion.AddComponent<mapgen> ();
		/*sphere = GameObject.Find("Sphere");
		for (int i = 0; i < sphere.GetComponent<MeshFilter>().mesh.normals.Length; i++) {
			Debug.Log ( sphere.GetComponent<MeshFilter>().mesh.normals[i] );
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
