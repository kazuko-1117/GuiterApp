using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(8.94622f,90.9777f,0.3120459f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(this.transform.position.x <= 9.0f)
            {
                SceneManager.LoadScene("Start0-3");
            }
            else if(this.transform.position.x <= 14.0f)
            {
                SceneManager.LoadScene("Start4-7");
            }
            else
            {
                SceneManager.LoadScene("Start8-11");
            }
        }
        
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x += -4.35f;
            myTransform.position = new Vector3(Mathf.Clamp(pos.x,8.94622f,17.63f),pos.y,pos.z);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x += 4.35f;
            myTransform.position = new Vector3(Mathf.Clamp(pos.x,8.94622f,17.63f),pos.y,pos.z);
        }

    }
}
