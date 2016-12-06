using UnityEngine;
using System.Collections;

public class VectorStuff1 : MonoBehaviour {
    private GameObject[] lines = new GameObject[40];
    private LineRenderer[] newLine = new LineRenderer[40];
    private Object[] pointArr = new Object[41];
    public GameObject point;
    public GameObject MovingPoint;
    public Material mat1, mat2, mat3, mat4, mat5;
    private float lineDrawSpeed = 6;
    private float dist;
    private float counter;
    private bool draw;
    private int index;
    private Vector3 startp, endp;


    private Vector3 newPoint1 = new Vector3(.5f, .1f, 1.5f);
    private Vector3 newPoint2 = new Vector3(.2f, .7f, 2.5f);
    private Vector3 newPoint3 = new Vector3(.8f, .8f, 2f);
    private Vector3 p4, p5, p6;
    

    // Use this for initialization
    void Start () {
        //txtRef = GetComponent<Text>();
        int size = 16;
        for (int i = 0; i < size; i++)//lines.Length
        {
            lines[i] = new GameObject();
        }
        for (int i = 0; i < size; i++)//lines.Length
        {
            newLine[i] = lines[i].AddComponent<LineRenderer>();
            newLine[i].SetWidth(0.005f, 0.005f);
            newLine[i].SetPosition(0, GameObject.Find("XAxisNumber0").transform.position);//new Vector3(.3f, 0, .7f));
            newLine[i].SetPosition(1, GameObject.Find("XAxisNumber0").transform.position);// new Vector3(.3f, 0, .7f));
            newLine[i].material = mat1;
        }

        newLine[0].material = mat5;
        newLine[2].material = mat2;
        newLine[3].material = mat3;
        newLine[4].material = mat2;
        newLine[6].material = mat3;
        newLine[8].material = mat2;
        newLine[9].material = mat3;

        newLine[0].SetPosition(1, MovingPoint.transform.position);
        //pointArr[0] = Instantiate(point, MovingPoint.transform.position, Quaternion.identity);
        //newLine[1].SetPosition(1, newPoint2);
        //pointArr[1] = Instantiate(point, newPoint2, Quaternion.identity);
        //newLine[2].material = mat3;
        //newLine[2].SetPosition(1, newPoint3);
        //pointArr[2] = Instantiate(point, newPoint3, Quaternion.identity);
        
        //newLine[3].material = mat2;
        //newLine[3].SetPosition(0, newPoint1);
        //newLine[3].SetPosition(1, newPoint3);

        //newLine[4].material = mat2;
        //newLine[4].SetPosition(0, newPoint2);
        //newLine[4].SetPosition(1, newPoint3);
        
        counter = 0;
        draw = true;
        index = 3;
        startp = newPoint1;
        endp = newPoint3;
        dist = Vector3.Distance(endp, startp);

        // point = GameObject.Find("/Point");
        //GameObject element = Instantiate(line, transform.localPosition, Quaternion.identity) as GameObject;
        //element.transform.parent = this.transform;
        //DrawArrow(element, new Vector3(0f, 0f, 1.5f), new Vector3(1f, 1f, 2.5f));
    }
	
	// Update is called once per frame
	void Update () {
        newPoint1 = MovingPoint.transform.position;
        newPoint2 = MovingPoint.transform.position;
        newPoint3 = MovingPoint.transform.position;
        newPoint1.x = .3f;
        newPoint2.y = 0;
        newPoint3.z = 1f;
        p4 = newPoint1;
        p4.y = 0;
        p5 = newPoint1;
        p5.z = 1f;
        p6 = newPoint2;
        p6.z = 1f;
        //newLine[0].SetPosition(0, MovingPoint.transform.position);
        newLine[0].SetPosition(1, MovingPoint.transform.position);
        newLine[1].SetPosition(0, MovingPoint.transform.position);
        newLine[1].SetPosition(1, newPoint1);
        newLine[2].SetPosition(0, MovingPoint.transform.position);
        newLine[2].SetPosition(1, newPoint2);
        newLine[3].SetPosition(0, MovingPoint.transform.position);
        newLine[3].SetPosition(1, newPoint3);
        newLine[4].SetPosition(0, p4);
        newLine[4].SetPosition(1, newPoint1);
        newLine[5].SetPosition(0, p4);
        newLine[5].SetPosition(1, newPoint2);
        newLine[6].SetPosition(0, p5);
        newLine[6].SetPosition(1, newPoint1);
        newLine[7].SetPosition(0, p5);
        newLine[7].SetPosition(1, newPoint3);
        newLine[8].SetPosition(0, p6);
        newLine[8].SetPosition(1, newPoint3);
        newLine[9].SetPosition(0, p6);
        newLine[9].SetPosition(1, newPoint2);


        //pointArr[0] = Instantiate(point, MovingPoint.transform.position, Quaternion.identity);
        //if (draw)
        //{
        //    counter += 0.1f / lineDrawSpeed;
        //    float x = Mathf.Lerp(0, dist, counter);
        //    Vector3 pointAlongLine = x * Vector3.Normalize(endp - startp) + startp;
        //    newLine[index].SetPosition(0, startp);
        //    newLine[index].SetPosition(1, pointAlongLine);
        //    if (Vector3.Distance(pointAlongLine, endp) < 0.01f)
        //    {
        //        if (index == 3)
        //        {
        //            counter = 0;
        //            draw = true;
        //            index = 4;
        //            newLine[index].material = mat2;
        //            startp = newPoint2;
        //            endp = newPoint3;
        //            dist = Vector3.Distance(endp, startp);
        //        }
        //        else if (index == 4)
        //        {
        //            counter = 0;
        //            draw = true;
        //            index = 2;
        //            startp = new Vector3(0,0,1.5f);
        //            endp = newPoint3;
        //            dist = Vector3.Distance(endp, startp);
        //            newLine[2].material = mat3;
        //        }
        //        else
        //        {
        //            pointArr[2] = Instantiate(point, newPoint3, Quaternion.identity);
        //            draw = false;
        //        }

        //    }
        //}
    }

    public void DrawArrow(GameObject v, Vector3 startPoint, Vector3 endPoint)
    {
        Vector3 baseZero = endPoint - startPoint;
        Vector3 myAxis = Vector3.up + baseZero.normalized;
        transform.RotateAround(v.transform.position, myAxis, 180);
        //Vector3 baseZero = startPoint - endPoint;
        print(baseZero);
        v.transform.localScale = new Vector3(.01f, Vector3.Distance(startPoint, endPoint) / 2, 0.01f);
        float xAngle = Vector3.Angle(Vector3.up, new Vector3(0, baseZero.y, baseZero.z));
        float yAngle = Vector3.Angle(Vector3.up, baseZero);
        float zAngle = Vector3.Angle(Vector3.up, new Vector3(baseZero.x, baseZero.y, 0));
        //v.transform.Rotate(yAngle, 0, yAngle);
        //v.transform.Rotate(xAngle, 0, zAngle);
        //v.transform.position = new Vector3((startPoint.x + endPoint.x) / 2, (startPoint.y + endPoint.y) / 2, (startPoint.z + endPoint.z) / 2); //Vector3.xa(startPoint, endPoint, 0.5f); 
        //v.transform.rotation = Quaternion.LookRotation(baseZero);
        //GameObject end = Instantiate(point, endPoint, Quaternion.identity) as GameObject;
        //end.transform.parent = this.transform.parent;
    }
}
