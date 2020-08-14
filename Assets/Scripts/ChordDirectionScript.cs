using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Effects;

public class ChordDirectionScript : MonoBehaviour
{
    // public string ChordName;
    public GameObject Chord;
    

    // public Text ChordText;
    // Start is called before the first frame update
    void Start()
    {
    //    string[] ChordName = {"A♭","A","B♭","B","D♭","D","E♭","E","G♭","G","A♭","A","B","C","D♭","D","E♭","E","F","G♭","A♭","A","B♭","B"};
    //     string name = "A♭";
    //         int num = ChordName.IndexOf(name);
    //         Debug.Log(num);
    //        string[] ChordName = {"A♭","A","B♭","B","D♭","D","E♭","E","G♭","G","A♭","A","B","C","D♭","D","E♭","E","F","G♭","A♭","A","B♭","B"};
    //    foreach(string val in ChordName)
    //    {
    //         int num = ChordName.IndexOf(val);
    //         Debug.Log(num);
    //    }
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void GetText(string x)
    {
        Text ChordText = Chord.GetComponent<Text> ();
        ChordText.text = x;
    } 



    
    // public int GetChordName(int number)
    // {
    // // string[] ChordName = {"A♭","A","B♭","B","D♭","D","E♭","E","G♭","G","A♭","A","B","C","D♭","D","E♭","E","F","G♭","A♭","A","B♭","B"};
    // // var ChordNameList = new List<string>();
    // // ChordNameList.AddRange(ChordName);
    // //      foreach (string name in ChordNameList)
    // //     {
    // //         // name = ChordName[2];
    // //         GetText(name);
    // //         int num = ChordNameList.IndexOf(name);
    // //         Debug.Log(num);
    // //     }
    // //    string[] ChordName = {"A♭","A","B♭","B","D♭","D","E♭","E","G♭","G","A♭","A","B","C","D♭","D","E♭","E","F","G♭","A♭","A","B♭","B"};
    // //    foreach(string val in ChordName)
    // //    {
    // //         int num = ChordName.IndexOf(val);
    // //         Debug.Log(num);
    // //    }
    //     }
    }


