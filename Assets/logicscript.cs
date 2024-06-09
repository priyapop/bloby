using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
    public int Playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;
    
    public void addscore(int scoretoadd)
    {
        Playerscore = Playerscore + scoretoadd;
        scoretext.text = Playerscore.ToString();
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}
