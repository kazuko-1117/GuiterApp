using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript3 : MonoBehaviour
{
    public GameObject ChordBlock;
    // public GameObject ChordBlockPeaces;
    public GameObject ChordBlockPeace;
    private ChordDirectionScript ConectChord;
    private LineManagerScript ConectLine;
    public GameObject Guide;
    public GameObject ChangeGuideOn;
    public GameObject ChangeGuideOff;
    // public WaitForSeconds(float seconds);

    IEnumerator SpawnChordBlock()
    {
        while(true)
        {
          // ブロックを並べる
            for(float iz = 0.0f; iz <= 1.8f; iz = iz + 0.345f)
            {
                for(float ix = 0.0f; ix <= 4.0f; ix = ix + 1.25f)
                {
                        
                    GameObject ChordBlockPeace = Instantiate(ChordBlock, 
                                                             new Vector3(ix,10.0f,iz),
                                                             Quaternion.identity
                     );
                     Destroy(ChordBlockPeace,6.0f);
                            // 生成されたブロックをリストに追加
                            ChordBlockPeaces.Add(ChordBlockPeace);  
                                  
                }
            }
            
            // 生成されたブロックの中から一つランダムに選び、消す
             GameObject BlockHole = ChordBlockPeaces[Random.Range(0,ChordBlockPeaces.Count)];
             int index = ChordBlockPeaces.IndexOf(BlockHole);
             string[] ChordName = {"C","D♭","D","E♭","F","G♭","G","A♭","B♭","B","C","D♭","E♭","E","F","G♭","G","A♭","A","B♭","C","D♭","D","E♭"};
                name = ChordName[index];
                Debug.Log(name);
             ConectChord.GetText(name);
             ConectLine.GetLine(index);
             Debug.Log(index);
             Destroy(BlockHole);

             yield return new WaitForSeconds(5.0f); 

             ChordBlockPeaces.Clear();
        }
    }
   
    private List<GameObject> ChordBlockPeaces = new List<GameObject>();   // リストを作る
    
    // Start is called before the first frame update
    void Start()
    {   
        Guide.SetActive(false);
        ChangeGuideOff.SetActive(true);
        ChangeGuideOn.SetActive(false);
        ConectChord = GameObject
                    .FindWithTag("GameController")
                    .GetComponent<ChordDirectionScript>();

        ConectLine = GameObject
                    .FindWithTag("Line")
                    .GetComponent<LineManagerScript>();
        
        StartCoroutine("SpawnChordBlock");
    }


     void Update()
    {
         if(Input.GetKeyDown(KeyCode.G))
        {
            Guide.SetActive(true);
            ChangeGuideOn.SetActive(true);
            ChangeGuideOff.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            ChangeGuideOn.SetActive(false);
            ChangeGuideOff.SetActive(true);
            Guide.SetActive(false);
        }
    }

}