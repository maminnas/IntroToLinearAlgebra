using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WhitePoint1 : MonoBehaviour {
    int count,state;
    Vector3 endPosition;
    public GameObject Xaxis, Yaxis, Zaxis, v2, v3, v4;
    //public Text txtRef1, txtRef2;
    public static bool holderStart;
    float timer = 0f;
    float x0 = .3f;
    float z0 = 1f;
    float speed = 1.5f;


    // Use this for initialization
    void Start () {
        count = 1;
        state = 1;
        endPosition = new Vector3(.3f, 0, 1f);
        //endPosition = new Vector3(.4f, .6f, 1.7f);
        /*Xaxis = GameObject.Find("XAxis");
        Yaxis = GameObject.Find("YAxis");
        Zaxis = GameObject.Find("ZAxis");*/
        v2.SetActive(false);
        v3.SetActive(false);
        v4.SetActive(false);
        Yaxis.SetActive(false);
        Zaxis.SetActive(false);
        holderStart = false;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (Vector3.Distance(this.transform.position, endPosition) > .0005f)
        {
            transform.position = Vector3.Lerp(this.transform.position, endPosition, Time.deltaTime);
        }
        else
        {
            transform.position = endPosition;
            if (timer >= 0 && timer <5 * speed)
            {
                endPosition = GameObject.Find("XAxisNumber4").transform.position;
            }
            if (timer >= 5 * speed && timer < 10 * speed)
            {
                endPosition = GameObject.Find("XAxisNumber-3").transform.position;
            }
            if (timer >= 10 * speed && timer < 15 * speed)
            {
                endPosition = GameObject.Find("XAxisNumber0").transform.position;
            }
            if (timer >= 15 * speed && timer < 20 * speed)
            {
                Yaxis.SetActive(true);
                endPosition = GameObject.Find("YAxisNumber2").transform.position;
            }
            if (timer >= 20 * speed && timer < 25 * speed)
            {
                endPosition = new Vector3(0.12f+x0, .08f, z0);
            }
            if (timer >= 25 * speed && timer < 30 * speed)
            {
                endPosition = new Vector3(0.12f+x0, .14f, z0);
            }
            if (timer >= 30 * speed && timer < 35 * speed)
            {
                Zaxis.SetActive(true);
                endPosition = new Vector3(.12f+x0, .08f, .08f+z0);
            }
            if (timer >= 35 * speed && timer < 40 * speed)
            {
                endPosition = new Vector3(.08f+x0, .12f, .04f+z0);
            }
            if (timer >= 60 * speed && timer < 65 * speed)
            {
                v3.SetActive(true);
            }
            if (timer >= 85 * speed && timer < 90 * speed)
            {
                v2.SetActive(true);
                v4.SetActive(true);
            }
            if (timer >= 95 * speed && timer < 100 * speed)
            {
                v2.SetActive(false);
                v4.SetActive(false);
            }
            if (timer >= 100 * speed && timer < 105 * speed)
            {
                MeshRenderer gameObjectRenderer = v3.transform.Find("x1").GetComponent<MeshRenderer>();
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = new Color(1, 0, 0, 1);
                gameObjectRenderer.material = newMaterial;
            }
            if (timer >= 105 * speed && timer < 110 * speed)
            {
                MeshRenderer gameObjectRenderer = v3.transform.Find("y1").GetComponent<MeshRenderer>();
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = new Color(0, 1, 0, 1);
                gameObjectRenderer.material = newMaterial;
            }
            if (timer >= 110 * speed && timer < 115 * speed)
            {
                MeshRenderer gameObjectRenderer = v3.transform.Find("z1").GetComponent<MeshRenderer>();
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = new Color(0, 0, 1, 1);
                gameObjectRenderer.material = newMaterial;
            }
            if (timer >= 115 * speed && timer < 120 * speed)
            {
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = new Color(1, 1, 1, 1);
                MeshRenderer gameObjectRenderer1 = v3.transform.Find("x1").GetComponent<MeshRenderer>();
                MeshRenderer gameObjectRenderer2 = v3.transform.Find("y1").GetComponent<MeshRenderer>();
                MeshRenderer gameObjectRenderer3 = v3.transform.Find("z1").GetComponent<MeshRenderer>();
                gameObjectRenderer1.material = newMaterial;
                gameObjectRenderer2.material = newMaterial;
                gameObjectRenderer3.material = newMaterial;
            }
            //switch (state){
            //    case(1):
            //        endPosition = GameObject.Find("XAxisNumber4").transform.position;//new Vector3(-0.16f, 0, 1.5f);
            //        state++;
            //        break;
            //    case (2):
            //        endPosition = GameObject.Find("XAxisNumber0").transform.position;//new Vector3(-0.16f, 0, 1.5f);
            //        state++;
            //        break;
            //    case (3):
            //        //txtRef1.text ="This number can refer to other directions of axes";
            //        Yaxis.SetActive(true);
            //        endPosition = GameObject.Find("YAxisNumber2").transform.position;//new Vector3(-0.16f, 0, 1.5f);
            //        state++;
            //        break;
            //    case (4):
            //        //txtRef1.text = "These components can represent a vector in a space, in this case a two dimensional space";
            //        endPosition = new Vector3(0.6f, .4f, .5f);
            //        state++;
            //        break;
            //    case (5):
            //        endPosition = new Vector3(0.6f, .4f, .5f);
            //        state++;
            //        break;
            //    case (6):
            //        //txtRef1.text = "If we use a third demension we can represent it like this";
            //        Zaxis.SetActive(true);
            //        endPosition = new Vector3(.6f, .4f, .9f);
            //        state++;
            //        break;
            //    case (7):
            //        //txtRef1.text = "and also represent it as a vector... we can represent the values of each dimen";
            //        endPosition = new Vector3(.4f, .6f, .7f);
            //        state++;
            //        break;
            //    case (8):
            //        //txtRef1.text = "Now we can represent the values of each component of a vector as colors in cubes. ";
            //        Xaxis.SetActive(false);
            //        Yaxis.SetActive(false);
            //        Zaxis.SetActive(false);
            //        state++;
            //        break;
            //    case (9):
            //        //txtRef1.text = "and also represent it as a vector by concatenating cubes";
            //        endPosition = new Vector3(0, 0, 20f);
            //        holderStart = true;
            //        //Camera.current.transform.Translate(new Vector3(0, 0, -3.5f));
            //        state++;
            //        break;
            //    case (10):
            //       // txtRef1.text = "now if we concatenate these cube vectores we can represnt a matrix, accessing each component with two indices.";
            //        //txtRef2.text = "";
            //        endPosition = new Vector3(0, 0, 0);
            //        //Camera.current.transform.Translate(new Vector3(-.5f, 0, 1.8f));
            //        //Camera.current.transform.Rotate(Vector3.up, -90);
            //        state++;
            //        break;
            //    case (11):
            //        //txtRef1.text = "if we go furthur and concatenate matrices we can find a rank 3 tensor represented liek this";
            //        //Camera.current.transform.Translate(new Vector3(-1.0f, 0, 0));
            //        endPosition = new Vector3(0, 0, 20f);
            //        state++;
            //        break;
            //    case (12):
            //       // txtRef1.text = "Tensors can have higher or lower ranks. scalar is a rank 0 tensor, vector is a rank 1 tensor and matrix is rank 2 vector.";
            //        //Camera.current.transform.Rotate(Vector3.up, 90);
            //        //Camera.current.transform.Translate(new Vector3(0, 0, -2.3f));

            //        endPosition = new Vector3(0, 0, 0);
            //        state++;
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
