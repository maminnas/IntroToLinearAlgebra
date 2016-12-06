using UnityEngine;
using System.Collections;

public class MultTemp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void MultiplyVectors(GameObject v1, GameObject v2, GameObject v3, GameObject v4, int i1, int i2)
    {
        v1.transform.Rotate(Vector3.back, 90);
        foreach(Transform child in transform)
            child.transform.Rotate(Vector3.back, 90);
        v1.transform.Translate(1 + i1 * .2f, 0, - .1f);
        v3.transform.Translate(0 , 0, -.1f);
        transform.Translate(1 + i1 * .2f, 0, 0);
        v4.SetActive(true);
        //v4.collapse...
    }
}
