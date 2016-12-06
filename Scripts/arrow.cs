using UnityEngine;
using System.Collections;

public class arrow : MonoBehaviour {
    float size=1f;
    public GameObject startPoint;
    float z_offset = 1;
    float x, y, a = 0;
	// Use this for initialization
	void Start () {
        x = 3;
        y = 4;
        a = -Mathf.Rad2Deg * Mathf.Atan2(x, y);
        size = Vector3.Distance(startPoint.transform.position, new Vector3(x,y,0+z_offset));
        this.transform.localScale = new Vector3(1,size,1);
        this.transform.Rotate(0, 0, a);
        Debug.Log(a);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
