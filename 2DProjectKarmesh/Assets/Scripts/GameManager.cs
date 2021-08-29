using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    public void RestartGame()
    {
        SoundManager.instance.Gameoversound();
        Invoke("RestartAfterTime", 2f);
        SoundManager.instance.Gameoversound();
    }
    void RestartAfterTime()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gamescene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
