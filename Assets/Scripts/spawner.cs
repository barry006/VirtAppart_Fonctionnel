using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60 / 130)*2;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (timer > beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, cubes.Length)], points[Random.Range(0, points.Length)]);
            cube.transform.localPosition = Vector3.zero;
           // cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }
        timer += Time.deltaTime;
    }













    /*
   public int qSamples = 2048; // QWindow
   public int channels = 2;
   public int bassMinHz = 30; //Min bass Frequency in Hz
   public int bassMaxHz = 120; // Max bass Frequency in Hz
   private int bassMinSamples; //Min bass in samples
   private int bassMaxSamples; // Max bass in samples
   public float[] spectrumSamples;
   Transform objectToMove; // Add you object here
   public float moveMultiplier = 10; // Adjust this to move more or less
    public AudioListener audioListener; // Assign one audioListener here
   // bool audioisPlaying = false;

   public GameObject[] cubes;
   public Transform[] points;
   public float beat = (60 / 130) * 2;    
   float timer;*/
    /*
    void Start()
    {
        spectrumSamples = new float[qSamples];
        bassMinSamples = (bassMinHz * qSamples) / (AudioSettings.outputSampleRate / channels);
        bassMaxSamples = (bassMaxHz * qSamples) / (AudioSettings.outputSampleRate / channels);

    }

    void Update()
    {       
        if (audioListener != null )
        AnalizeSpectrum();
    }
    void AnalizeSpectrum()
    {      
        AudioListener.GetSpectrumData(spectrumSamples, 0, FFTWindow.Rectangular);    
            
        if (spectrumSamples[1] > beat)
        {

             StartCoroutine(DoCheck());

           
        }
        timer += Time.deltaTime;
    }

    
    IEnumerator DoCheck()
    {
        yield return new WaitForSeconds(.1f);
        GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);

            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        
    }





    */






























}
