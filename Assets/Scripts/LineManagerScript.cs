using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManagerScript : MonoBehaviour
{
    public GameObject line;
    // public GameObject Line = line.Getcomponent<GameObject> ();
    // Start is called before the first frame update
    void Start()
    {
        //   for(float dz = 0.07f; dz <=1.7f; dz = dz+ 0.325f)
        //     {
                // Line Line = line.Getcomponent<Line> ();
                // Line.Transform.position  = new Vector3(-0.43f,0.36f,dz);
            // }
            // GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,0.07f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void GetLine(int number)
    {
            // for(int i = 4; i <= 24; i = i + 4)
            // {
                if(number <= 3)
                {
                     GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,0.07f),Quaternion.AngleAxis(90,Vector3.up));
                     Destroy(Line,5.0f);
                }
                    
                else if(number <= 7)
                {
                     GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,0.4f),Quaternion.AngleAxis(90,Vector3.up));
                     Destroy(Line,5.0f);
                }
                else if(number <= 11)
                {
                     GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,0.7f),Quaternion.AngleAxis(90,Vector3.up));
                     Destroy(Line,5.0f);
                }
                else if(number <= 15)
                {
                     GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,1.03f),Quaternion.AngleAxis(90,Vector3.up));
                     Destroy(Line,5.0f);
                }
                else if(number <= 19)
                {
                     GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,1.35f),Quaternion.AngleAxis(90,Vector3.up));
                     Destroy(Line,5.0f);
                }
                else if(number <= 23)
                {
                     GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,1.68f),Quaternion.AngleAxis(90,Vector3.up));
                     Destroy(Line,5.0f);
                }
        // for(float dz = 0.07f; dz <=1.7f; dz = dz + 0.325f)
        // {
                        // GameObject Line = Instantiate(line,new Vector3(-0.43f,0.36f,dz),Quaternion.AngleAxis(90,Vector3.up));
        // }
            //     }
            // }
    }
}
