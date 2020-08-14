using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpeningManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Invoke("ChangeScene",5.0f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ChangeScene()
    {
         SceneManager.LoadScene("Opening2");
    }
}
