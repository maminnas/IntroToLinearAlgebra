using UnityEngine;
using System.Collections;

public class MultAnimate : MonoBehaviour {
    public GameObject m2, m3, a11, a12, a21, a22, r1, r2, r3, r4;
    public bool fire,fire2;
    int x1, x2,x3,x4, y2, y3;
    Vector3 startp, endp;
    float timer = 0f;
    // Use this for initialization
    void Start () {
        r1.SetActive(false);
        r2.SetActive(false);
        r3.SetActive(false);
        r4.SetActive(false);
        fire2 = true;
        fire = false;
        x1 = x3 = 70;
        x2 = x4 = 50;
        y2 = y3 = 20;
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (timer >= 10 && timer < 15)
        {
            if (x1 > 0)
            {
                a11.transform.Translate(Vector3.right * 0.005f * 0.7f);
                a11.GetComponent<Renderer>().material.color = Color.red;
                m2.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;
                //a11.transform.Translate(Vector3.right * 0.005f);
                //a11.GetComponent<Renderer>().material.color = Color.red;
                x1--;
            }
            if (x2 > 0)
            {
                a12.transform.Translate(Vector3.right * 0.005f * 0.7f);
                a12.GetComponent<Renderer>().material.color = Color.red;
                m2.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.red;
                x2--;
            }
            if (y2 > 0)
            {
                a12.transform.Translate(Vector3.down * 0.005f * 0.8f);
                y2--;
            }
        }
        if (timer >= 15 && timer < 20)
        {
            m3.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.green;
            m3.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = Color.green;
        }
        if (timer >= 20 && timer < 25)
        {
            r1.SetActive(true);
        }
        if (timer >= 25 && timer < 27)
        {
            m3.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.white;
            m3.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = Color.white;
        }
        if (timer>= 27 && timer < 30)
        { 
            m3.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.green;
            m3.gameObject.transform.GetChild(3).GetComponent<Renderer>().material.color = Color.green;
        }
        if (timer >= 30 && timer < 35)
        {
            r2.SetActive(true);
        }
        if (timer >= 35 && timer < 40)
        {
            m3.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.green;
            m3.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = Color.green;
            m3.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.white;
            m3.gameObject.transform.GetChild(3).GetComponent<Renderer>().material.color = Color.white;
            a11.SetActive(false);
            a12.SetActive(false);
            if (x3 > 0)
            {
                a21.transform.Translate(Vector3.right * 0.005f* 0.7f);
                a21.GetComponent<Renderer>().material.color = Color.red;
                m2.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = Color.red;
                x3--;
            }
            if (x4 > 0)
            {
                a22.transform.Translate(Vector3.right * 0.005f * 0.7f);
                a22.GetComponent<Renderer>().material.color = Color.red;
                m2.gameObject.transform.GetChild(3).GetComponent<Renderer>().material.color = Color.red;
                x4--;
            }
            if (y3 > 0)
            {
                a21.transform.Translate(Vector3.up * 0.005f * 0.8f);
                y3--;
            }
        }
        if (timer >= 40 && timer < 45)
        {
            r3.SetActive(true);
            m3.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.white;
            m3.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = Color.white;
            m3.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.green;
            m3.gameObject.transform.GetChild(3).GetComponent<Renderer>().material.color = Color.green;
        }
        if (timer >= 45 && timer < 50)
        {
            r4.SetActive(true);
           
        }
        if (timer >= 50)
        {
            a21.SetActive(false);
            a22.SetActive(false);
            m3.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.white;
            m3.gameObject.transform.GetChild(3).GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
