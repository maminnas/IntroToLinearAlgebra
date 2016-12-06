using UnityEngine;
using System.Collections;

public class mathAdd : MonoBehaviour {
	public GameObject v1,v2,v3,plus1,plus2,plus3,eq,m1,m2,m3,t1,t2,t3,p1,p2,eq1,eq2,h1,h2,h3;
	float timer = 0f;
	float interval = 9f;
	float ratio;
	public Material mat1,mat2,mat3;

	IEnumerator waitTenSeconds(){
		yield return new WaitForSeconds (3);
		print ("waited 3 sec!");
	}
	// Use this for initialization
	void Start () {
        //v1.SetActive (false);
        h2.SetActive(false);
        h3.SetActive(false);
        v2.SetActive (false);
		v3.SetActive (false);
		plus1.SetActive (false);
		plus2.SetActive (false);
		plus3.SetActive (false);
		eq.SetActive (false);
		eq1.SetActive (false);
		eq2.SetActive (false);
		m1.SetActive (false);
		m2.SetActive (false);
		m3.SetActive (false);
		t1.SetActive (false);
		t2.SetActive (false);
		t3.SetActive (false);
		p1.SetActive (false);
		p2.SetActive (false);

		//StartCoroutine ("waitTenSeconds");
		//v1.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		ratio = timer / interval;
		if (ratio >= 1 && ratio<2) {
            v2.SetActive (true);
		} else if (ratio >= 2 && ratio<3) {
			plus1.SetActive (true);
		} else if (ratio >= 3 && ratio<4) {
			plus2.SetActive (true);
			plus3.SetActive (true);
		} else if (ratio >= 4 && ratio<5) {
			eq.SetActive (true);
		} else if (ratio >= 5 && ratio<6) {
			v3.SetActive (true);
		} else if (ratio >= 6 && ratio<7) {
			plus2.SetActive (false);
			plus3.SetActive (false);
		} else if (ratio >= 7 && ratio<8) {
			v3.SetActive (true);
		}
        else if (ratio >= 8 && ratio < 9)
        {
            h1.SetActive(false);
            h2.SetActive(true);
            m1.SetActive(true);
        }
        else if (ratio >= 9 && ratio < 10)
        {
            p1.SetActive(true);
            m2.SetActive(true);
        }
        else if (ratio >= 10 && ratio < 11)
        {
            eq1.SetActive(true);
            m3.SetActive(true);
        }
        else if (ratio >= 11 && ratio < 12)
        {
            h2.SetActive(false);
            h3.SetActive(true);
            t1.SetActive(true);
        }
        else if (ratio >= 12 && ratio < 13)
        {
            p2.SetActive(true);
            t2.SetActive(true);
        }
        else if (ratio >= 13 && ratio < 14)
        {
            eq2.SetActive(true);
            t3.SetActive(true);
        }
        else if (ratio >= 14 && ratio < 15)
        {
            h3.SetActive(true);
        }
    }
}
