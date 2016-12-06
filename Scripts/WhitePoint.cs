using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WhitePoint : MonoBehaviour {
    int count,state;
    Vector3 endPosition;
    public GameObject Xaxis, Yaxis, Zaxis, cube1, cube2, cube3;
    public Text txtRef1;
    public static bool holderStart;
    float timer = 0f;

    // Use this for initialization
    void Start () {
        txtRef1.text = "We can represent a scalar in a one dimentional space using a point on a scaled line";
        count = 1;
        state = 1;
        endPosition = new Vector3(.6f, 0, 1.5f);
        //endPosition = new Vector3(.4f, .6f, 1.7f);
        Xaxis = GameObject.Find("XAxis");
        Yaxis = GameObject.Find("YAxis");
        Zaxis = GameObject.Find("ZAxis");
        cube1 = GameObject.Find("cube1");
        cube2 = GameObject.Find("cube2");
        cube3 = GameObject.Find("cube3");

        Yaxis.SetActive(false);
        Zaxis.SetActive(false);
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        holderStart = false;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float speed = 1;
        if (Vector3.Distance(this.transform.position, endPosition) > .005f)
        {
            transform.position = Vector3.Lerp(this.transform.position, endPosition, speed * Time.deltaTime);
        }
        else
        {
            transform.position = endPosition;
            switch (state){
                case(1):
                    endPosition = GameObject.Find("XAxisNumber-4").transform.position;//new Vector3(-0.16f, 0, 1.5f);
                    state++;
                    break;
                case (2):
                    endPosition = GameObject.Find("XAxisNumber0").transform.position;//new Vector3(-0.16f, 0, 1.5f);
                    state++;
                    break;
                case (3):
                    txtRef1.text ="This number can refer to other directions of axes";
                    Yaxis.SetActive(true);
                    endPosition = GameObject.Find("YAxisNumber2").transform.position;//new Vector3(-0.16f, 0, 1.5f);
                    state++;
                    break;
                case (4):
                    txtRef1.text = "These components can represent a vector in a space, in this case a two dimensional space";
                    endPosition = new Vector3(0.6f, .4f, 1.5f);
                    state++;
                    break;
                case (5):
                    endPosition = new Vector3(0.6f, .4f, 1.5f);
                    state++;
                    break;
                case (6):
                    txtRef1.text = "If we use a third demnsion we can represent it like this";
                    Zaxis.SetActive(true);
                    endPosition = new Vector3(.6f, .4f, 1.9f);
                    state++;
                    break;
                case (7):
                    txtRef1.text = "and also represent it as a vector... we can represent the values of each dimen";
                    endPosition = new Vector3(.4f, .6f, 1.7f);
                    state++;
                    break;
                case (8):
                    txtRef1.text = "Now we can represent the values of each component of a vector as colors in cubes. ";
                    //Xaxis.SetActive(false);
                    //Yaxis.SetActive(false);
                    //Zaxis.SetActive(false);
                    cube1.SetActive(true);
                    cube2.SetActive(true);
                    cube3.SetActive(true);
                    if (timer>50)
                        state++;
                    break;
                case (9):
                    txtRef1.text = "and also represent it as a vector by concatenating cubes";
                    //endPosition = new Vector3(0, 0, 20f);
                    //cube1.SetActive(false);
                    //cube2.SetActive(false);
                    //cube3.SetActive(false);
                    if (timer > 60)
                    {
                        holderStart = true;
                        //Camera.current.transform.Translate(new Vector3(0, 0, -3.5f));
                        state++;
                    }
                    break;
                case (10):
                    txtRef1.text = "now if we concatenate these cube vectores we can represnt a matrix, accessing each component with two indices.";
                    //endPosition = new Vector3(0, 0, 0);
                    //Camera.current.transform.Translate(new Vector3(-.5f, 0, 1.8f));
                    //Camera.current.transform.Rotate(Vector3.up, -90);
                    state++;
                    break;
                case (11):
                    txtRef1.text = "if we go furthur and concatenate matrices we can find a rank 3 tensor represented liek this";
                    //Camera.current.transform.Translate(new Vector3(-1.0f, 0, 0));
                    //endPosition = new Vector3(0, 0, 20f);
                    state++;
                    break;
                case (12):
                    txtRef1.text = "Tensors can have higher or lower ranks. scalar is a rank 0 tensor, vector is a rank 1 tensor and matrix is rank 2 vector.";
                    //Camera.current.transform.Rotate(Vector3.up, 90);
                    //Camera.current.transform.Translate(new Vector3(0, 0, -2.3f));
                    
                    //endPosition = new Vector3(0, 0, 0);
                    state++;
                    break;
                default:
                    break;
            }
        }
    }
}
