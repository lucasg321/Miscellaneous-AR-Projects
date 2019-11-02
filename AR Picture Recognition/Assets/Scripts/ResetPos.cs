using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    Vector3 originalpos;
    // Start is called before the first frame update
    void Start()
    {
        originalpos = transform.localPosition; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Wall"))
        {
            transform.localPosition = originalpos; 
        }
    }

}
