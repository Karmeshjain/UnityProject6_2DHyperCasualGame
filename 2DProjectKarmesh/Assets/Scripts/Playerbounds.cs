using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbounds : MonoBehaviour
{
    // Start is called before the first frame update
    public float min_x=-17.5f, max_x=16.5f,min_y=-35f; //16.5 plus and minus
    private bool outofbounds;
    // Update is called once per frame
    void Update()
    {
        CheckBounds();   
    }
void CheckBounds()
    {
        Vector2 temp = transform.position;
        if (temp.x > max_x)
            temp.x = max_x;
        if (temp.x < min_x)
            temp.x = min_x;
        transform.position = temp;
        if(temp.y<=min_y)
        {
            if (!outofbounds)
                outofbounds = true;
            SoundManager.instance.Deathsound();
            SoundManager.instance.Gameoversound();
            GameManager.instance.RestartGame();
            //death of player restart game and death sound;
        }

    } //check bounds

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Topspike")
        {
            transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.Deathsound();
            SoundManager.instance.Gameoversound();
            GameManager.instance.RestartGame();
        }
    
    }

}

