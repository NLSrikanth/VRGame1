using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object4Controller : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    private bool isCubeActive = false;
    private bool isSphereActive = true;
    // Start is called before the first frame update
    void Start()
    {
        sphere.SetActive(false);
        cube.SetActive(true);
    }

    public void Object4FocusOnListener()
    {
        isSphereActive = true;
        isCubeActive = false;
        sphere.SetActive(true);
        cube.SetActive(false);
    }

    public void OnPointerExit()
    {
        isSphereActive = false;
        isCubeActive = true;
        cube.SetActive(true);
        sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSphereActive){
            //cube.transform.position = sphere.transform.position;
            //sphere.transform.position = cube.transform.position;
            sphere.SetActive(true);
            cube.SetActive(false);
        }else if(isCubeActive){
            //cube.transform.position = sphere.transform.position;
            //sphere.transform.position = cube.transform.position;
            cube.SetActive(true);
            sphere.SetActive(false);
        }
    }
}
