using UnityEngine;
using System.Collections;

public class vector_def : MonoBehaviour {
    public GameObject Xaxis, Yaxis, Zaxis;
    Vector3 startp, endp;
    float timer = 0f;

    // Use this for initialization
    void Start () {
        Xaxis = GameObject.Find("XAxis");
        Yaxis = GameObject.Find("YAxis");
        Zaxis = GameObject.Find("ZAxis");

        Xaxis.SetActive(false);
        Yaxis.SetActive(false);
        Zaxis.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float speed = 1;
        if (timer >= 10 && timer < 15)
        {

        }
        if (timer >= 15 && timer < 20)
        {

        }
    }
}
