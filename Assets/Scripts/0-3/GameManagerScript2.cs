using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript2 : MonoBehaviour
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
            
            // 生成されたブロックの中から一つランダムに選ぶ
             GameObject BlockHole = ChordBlockPeaces[Random.Range(0,ChordBlockPeaces.Count)];
            //消されたブロックの番号を取得
             int index = ChordBlockPeaces.IndexOf(BlockHole);
             //配列を用意
             string[] ChordName = {"E","F","G♭","G","A","B♭","B","C","D","E♭","E","F","G","A♭","A","B♭","B","C","D♭","D","E","F","G♭","G"};
             //ChordNameの中から消されたブロックの音名を取得
                name = ChordName[index];
                Debug.Log(name);
            //該当の音名をテキストに表示
             ConectChord.GetText(name);
             //音名に該当する弦にラインを表示する
             ConectLine.GetLine(index);
             Debug.Log(index);
             //ランダムに選ばれたブロックを消す
             Destroy(BlockHole);
            //５秒ごとに生成
             yield return new WaitForSeconds(5.0f); 
            //ブロックが入ったリストを空にする
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