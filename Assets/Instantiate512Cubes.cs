using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour {
    public GameObject sampleCubePrefab;
    GameObject[] sampleCube = new GameObject[512];
    public float maxScale;

    Audiot adt;
	// Use this for initialization
	void Start (){
        //organize all the cubes into a circle
        adt = GameObject.FindGameObjectWithTag("vz_1").GetComponent<Audiot>();
        for(int i = 0; i < 512; i++)
        {
            GameObject instanceSampleCube = Instantiate(sampleCubePrefab);
            instanceSampleCube.transform.position = this.transform.position;    //why are we doing this? new object = object owning script?
            instanceSampleCube.transform.parent = this.transform;
            instanceSampleCube.name = "SampleCube" + i;

            this.transform.eulerAngles = new Vector3(0, -1 * (360f / 512f) * i, 0);
            instanceSampleCube.transform.position = Vector3.forward * 100;  //v3.forward = Vector3(0,0,1)
            sampleCube[i] = instanceSampleCube;
        }
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(adt.samples[1]);
        //Debug.Log(sampleCube[1].transform.position);
        //sampleCube[1].transform.localScale = new Vector3(10, (adt.samples[1] * maxScale) + 2, 10);
        for(int i = 0; i < 512; i++)
        {
            sampleCube[i].transform.localScale = new Vector3(1 , (adt.samples[i] * maxScale) + 2, 1);
        }
		
	}
}
