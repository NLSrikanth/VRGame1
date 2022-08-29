using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkleController : MonoBehaviour
{
    private bool letPlay = true;
    public GameObject SparkleObject;

    // Start is called before the first frame update
    void Start()
    {
        //SparkleObject = GetComponent<ParticleSystem>();
        SparkleObject.SetActive(false);
    }

    public void SparkleFocusOnListener()
    {
        letPlay = true;
        SparkleObject.SetActive(true);
    }

    public void OnPointerExit()
    {
        letPlay = false;
        SparkleObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(letPlay)
            SparkleObject.SetActive(true);
        else
            SparkleObject.SetActive(false);
    }
}
