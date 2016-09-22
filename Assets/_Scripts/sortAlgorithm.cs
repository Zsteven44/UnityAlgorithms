using UnityEngine;
using System.Collections;

public class sortAlgorithm : MonoBehaviour {
	private GameObject[] s;
	private ArrayList myNodes;
	private int items;
	private int index;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 5; i++) {
			
			s[i] = new GameObject();
			s[i] = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			s[i].transform.position = new Vector3(i*2, i*2, 0);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
