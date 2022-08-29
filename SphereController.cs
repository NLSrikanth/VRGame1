using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private Vector3 _startingPosition;
    private bool gazedAt = false;
    private bool isTravelling = false;

    // Start is called before the first frame update
    void Start()
    {
        _startingPosition = transform.position;
    }

    public void SphereFocusOnListener()
    {
        gazedAt = true;
        isTravelling = true;
    }

    public void OnPointerExit()
    {
        gazedAt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gazedAt || isTravelling){
            transform.Translate(Vector3.down * Time.deltaTime*5);
        }
        else transform.position = _startingPosition;
    }

    void OnCollisionEnter(Collision collision){
        transform.position = _startingPosition;
        isTravelling = false;
    }
}
