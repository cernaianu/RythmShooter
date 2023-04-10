using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectorInformatieSpectrala : MonoBehaviour
{

    [SerializeField] AudioSource sursaAudio;
    [SerializeField] int numarEsantioane = 512;
    [SerializeField] float[] esantioane = new float[512];
    [SerializeField] GameObject modelPatrat;
    private float amplificare = 100f;
    private List<GameObject> patrate = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        sursaAudio = GetComponent<AudioSource>();
        GenereazaPatrate();
    }

    // Update is called once per frame
    void Update()
    {
        ObtineInformatieSpectrala();
        ManipuleazaPatrateDupaEsantion();
    }

    public void ObtineInformatieSpectrala()
    {
        sursaAudio.GetSpectrumData(esantioane, 0, FFTWindow.Blackman);

    }

    public void GenereazaPatrate()
    {
        //-8, -4
        for(int i = 1; i <= 512; i++)
        {
            var patratNou = Instantiate(modelPatrat, new Vector3(-8f + i/32f, -4f, 0f), Quaternion.identity);
            patratNou.transform.localScale = new Vector3(1f / 32f, 1f, 1f);
            patrate.Add(patratNou);
        }
    }

    public void ManipuleazaPatrateDupaEsantion()
    {
        int i = 0;
        foreach (GameObject patrat in patrate)
        {
            patrat.transform.localScale = new Vector3(patrat.transform.localScale.x, esantioane[i++] * amplificare, patrat.transform.localScale.z);
        }

    }

}
