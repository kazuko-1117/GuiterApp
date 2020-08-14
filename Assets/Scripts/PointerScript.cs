using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointerScript : MonoBehaviour
{
    public GameObject[] playerIcons;
    public int PlayerHP = 3;
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 2f;
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * 2f;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x + dx,-0.48f,4.2f),
            0.58f,
            Mathf.Clamp(transform.position.z+ dz,-0.035f,1.765f)
        );
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerHP -= 1;
        audioSource.PlayOneShot(sound1);
        Debug.Log("P=" + PlayerHP);

        UpdatePlayerIcons();
    }

    private void UpdatePlayerIcons()
    {
            if(PlayerHP == 0)
            {
                playerIcons[0].SetActive(false);
                playerIcons[1].SetActive(false);
                playerIcons[2].SetActive(false);
                Invoke("ChangeScene",1.5f);
            }
            if(PlayerHP == 1)
            {
                playerIcons[0].SetActive(true);
                playerIcons[1].SetActive(false);
                playerIcons[2].SetActive(false);
                
            }
            if(PlayerHP == 2)
            {
                playerIcons[0].SetActive(true);
                playerIcons[1].SetActive(true);
                playerIcons[2].SetActive(false);
            }
            if(PlayerHP == 3)
            {
                playerIcons[0].SetActive(true);
                playerIcons[1].SetActive(true);
                playerIcons[2].SetActive(true);
            }

    }

    private void ChangeScene()
    {
         SceneManager.LoadScene("GameOverScene");
    }
}
