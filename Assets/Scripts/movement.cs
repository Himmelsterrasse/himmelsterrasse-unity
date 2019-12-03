using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
                float scroll = Input.GetAxis ("Mouse ScrollWheel");

                transform.LookAt (target);
                transform.Translate(0, 0, scroll * speed, Space.World);


            }

        if (Input.GetAxis ("Mouse ScrollWheel") > 0) {

            float scroll = Input.GetAxis ("Mouse ScrollWheel");
            transform.LookAt (target);
            transform.Translate(0, 0, scroll * speed, Space.Self);
        }
    }
