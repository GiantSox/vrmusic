using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof(AudioSource))]
public class Audiot : MonoBehaviour {
    AudioSource asrc;
    public float[] samples = new float[512];
	// Use this for initialization
	void Start () {
        asrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
	}

    void GetSpectrumAudioSource()
    {
        asrc.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }


}
