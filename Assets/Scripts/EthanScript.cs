using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.LeftArrow)) {
        //     transform.Translate(-0.15f,0,0);
        // }
        // if(Input.GetKey(KeyCode.RightArrow)) {
        //     transform.Translate(0.15f,0,0);
        // }


        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 2f;
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * 2f;
        // float dz = Input.GetAxis("Vertical") * Time.deltaTime * 8f;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x + dx,-0.48f,4.2f),
            0.2f,
            Mathf.Clamp(transform.position.z+ dz,-0.035f,1.765f)
        );
    }
}

