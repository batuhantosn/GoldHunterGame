using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public bool gameActive = false;
    public int goldCount = 0;
    public UnityEngine.UI.Text goldCountText;
    public UnityEngine.UI.Button startButton;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addGold()
    {
        goldCount += 1;
        goldCountText.text = "3 / " + goldCount;
    }
    public void gameStart()
    {
        gameActive = true;
        startButton.gameObject.SetActive(false);
    }
}
