using UnityEngine;
using System.Collections;
using System.IO;

public class Tensor
{
    public int order;
    public int [] sizes;

    public Tensor() : base(){}

    //public Tensor Slice(Tensor t, int x, int y, int z) //int [] args
    //{
        //Tensor result = new Tensor(x, y, z);
        //return result;
    //}
}

public class TestScript : MonoBehaviour {
    public GameObject ObjectToSpawn;
    //public GameObject NewArrow;
    public int n;
    public float xStart, yStart, zStart;
	const int xSize = 3;
	const int ySize = 3;
	const int zSize = 3;
	const int xSliceSize =3;
	const int ySliceSize =3;
	const int zSliceSize =3;
	int count=1;


	public GameObject[,,] cubes = new GameObject[xSize, ySize, zSize];
	public double[,,] values = new double[xSize, ySize, zSize];

	public GameObject[,,] SlicedCubes = new GameObject[xSliceSize, ySliceSize, zSliceSize];
	public double[,,] SlicedValues = new double[xSliceSize, ySliceSize, zSliceSize];

	void slice(GameObject sliceHold, int x1,int y1,int z1,int x2,int y2,int z2)// ca make it two Vector3 s
	{
		for (int i = x1; i <= x2; i++) {
			for (int j = y1; j <= y2; j++) {
				for (int k = z1; k <= z2; k++) {
                    GameObject element = Instantiate(ObjectToSpawn, transform.localPosition + new Vector3(i * 0.15f, j * 0.15f, k * 0.15f), Quaternion.identity) as GameObject;
                    element.transform.parent = sliceHold.transform;
                    ChangeColor(element, (float)i / xSize, (float)j / ySize, (float)k / zSize);
                    //SlicedValues [i-x1, j-y1, k-z1] = values [i, j, k];
                    //SlicedCubes [i-x1, j-y1, k-z1] = cubes [i, j, k];
                }
			}
		}
	}

	// Use this for initialization
	void Start () {
        //readTextFile("test.txt");
        n = 3;
        xStart = -1;
        yStart = -0.7f;
        zStart = 1.5f;
        //Vector4 v = new Vector4(1,2,3,4);
        //Matrix4x4 m = Matrix4x4.identity;

        //Vector3 res = m.MultiplyVector(v);
        CreateCube(xSize, ySize, zSize) ;
        GameObject slice1 = GameObject.Find("SliceHolder1");
        GameObject slice2 = GameObject.Find("SliceHolder2");
        GameObject slice3 = GameObject.Find("SliceHolder3");
        slice(slice1, 1, 3, 3, 3, 3, 3);
        slice(slice2, 2, 1, 1, 2, 3, 3);
        slice(slice3, 1, 2, 1, 3, 3, 2);
    }

    public Vector4 matrix_mult(Matrix4x4 m, Vector4 v, int size) {
        //Vector3 n = m.MultiplyVector(v);
        Vector4 result = new Vector4();
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                result[i] += m[i,j] * v[j];
            }
        }
        return result;
    }
	
	// Update is called once per frame
	void Update () {
        if (WhitePoint.holderStart)
        {
            float speed = 0;
            if (count < 500)
            {
                //GameObject hello = (GameObject)cubes[i, j, k];
                speed = (count < 250) ? count : (500 - count);
                speed *= 0.01f;
                GameObject Sliced = GameObject.Find("SliceHolder1");
                Sliced.transform.Translate(speed * Time.deltaTime, 0 * speed * Time.deltaTime, 0);
                count += 12;
            }
            else if (count < 1000)
            {
                speed = (count < 750) ? count - 500 : (1000 - count);
                speed *= 0.01f;
                GameObject Sliced = GameObject.Find("SliceHolder2");
                Sliced.transform.Translate(speed * Time.deltaTime * 0, 0, speed * Time.deltaTime);
                count += 12;
            }
            else if (count < 1500)
            {
                speed = (count < 1250) ? count - 1000 : (1500 - count);
                speed *= 0.01f;
                GameObject Sliced = GameObject.Find("SliceHolder3");
                Sliced.transform.Translate(speed * Time.deltaTime * 0, speed * Time.deltaTime, 0);
                count += 12;
            }
        }
    }

    //void readTextFile(string file_path)
    //{
    //    StreamReader inp_stm = new StreamReader(file_path);

    //    while (!inp_stm.EndOfStream)
    //    {
    //        string inp_ln = inp_stm.ReadLine();
    //        print(inp_ln);
    //    }

    //    inp_stm.Close();
    //}

    void CreateCube(int x, int y, int z)
    {
        for(int i = 1; i <= x; i++)
        {
            for(int j = 1; j <= y; j++)
            {
                for(int k = 1; k <= z; k++)
                {
                    Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
                    //GameObject element = Instantiate(ObjectToSpawn, new Vector3(xStart + i*0.15f, yStart + j*0.15f, zStart + k*0.15f), Quaternion.identity) as GameObject;
                    GameObject element = Instantiate(ObjectToSpawn, transform.localPosition + new Vector3(i * 0.15f, j * 0.15f, k * 0.15f), Quaternion.identity) as GameObject;
                    element.transform.parent = this.transform;
                    ChangeColor(element,(float)i/x, (float)j /y, (float)k /z);
                    //float my_num = Random.Range(-1f, 1f);
                    //float red_num, blue_num;
                    //if (my_num > 0) {
                    //    red_num = my_num;
                    //   blue_num = 0;
                    //}
                    //else
                    //{
                    //    red_num = 0;
                    //    blue_num = -my_num;
                    //}

                    //ChangeColor(element, red_num, 0, blue_num);
                    //ChangeColor(element, Random.Range(-1f,1f), .8f, Random.Range(-1f, 1f));
                }
            }
        }
    }

    void ChangeColor(GameObject gameObj, float red, float green, float blue)
    {
        Color newColor = new Color(red, green, blue, 1);

        MeshRenderer gameObjectRenderer = gameObj.GetComponent<MeshRenderer>();

        Material newMaterial = new Material(Shader.Find("Standard"));

        newMaterial.color = newColor;
        gameObjectRenderer.material = newMaterial;
    }
}
