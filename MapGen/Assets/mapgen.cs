using UnityEngine;
using System.Collections;

public class mapgen : MonoBehaviour {
	public Vector3[] newVertices;
	public Vector2[] newUV;
	public int[] newTriangles;
	public Vector3[] newNormals;
	private GameObject sample;
	void Start() {

		Mesh mesh = new Mesh ();
		GetComponent<MeshFilter>().mesh = mesh;

		Vector3 center = Vector3.zero;

		int points = 3;

		newVertices = new Vector3[] { center, new Vector3(0,1,0), new Vector3(1,0,0), new Vector3(0,-1,0), new Vector3(-1,0,0) };
		newUV = new Vector2[] { Vector2.zero,Vector2.zero,Vector2.zero,Vector2.zero,Vector2.zero };
		//newNormals = new Vector3[] { new Vector3(-0.2f,-1.0f,-0.1f), new Vector3(-0.1f,-1.0f,-0.1f), new Vector3(-0.1f,-1.0f,-0.1f), new Vector3(-0.0f,-1.0f,-0.2f), new Vector3(-0.0f,-1.0f,-0.2f) };
		newTriangles = new int[] { 0,1,2,0,2,3 };

		mesh.vertices = newVertices;
		mesh.uv = newUV;
		mesh.triangles = newTriangles;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
