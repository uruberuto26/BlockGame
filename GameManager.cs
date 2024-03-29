using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject GameOverUI;
    public GameObject GameClearUI;

    private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameClear != true)
        {
            if (DestroyAllBlock())
            {
                //ゲームクリア
                Debug.Log("ゲームクリア");
                GameClearUI.SetActive(true);
                isGameClear = true;
            }
       
        }
        
    }

    private bool DestroyAllBlock()
    {
        foreach( Block b in blocks)
        {
            if ( b != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameOver()
    {
        Debug.Log("ゲームオーバー");
        GameOverUI.SetActive(true);

    }

    public void GameRetry ()
    {
        SceneManager.LoadScene("game");
    }
}
