 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float move_speed = 2f;
    public float bound_y = 32f;
    public bool moving_platform_left, is_spike,moving_platform_right,is_breakable, is_platform;

    private Animator anim;
     void Awake()
    {
        if (is_breakable)
            anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector2 temp = transform.position;
        temp.y += move_speed * Time.deltaTime;
        transform.position = temp;
        if(temp.y>=bound_y)
        {
            gameObject.SetActive(false);
        }
    }
    void BreakableDeactivate()
    {
        Invoke("DeactivateGameobject",1.6f);   //call after playing of animation
    }
    void DeactivateGameobject()
    {
        //sound manager instance ice break sound
        gameObject.SetActive(false);
        SoundManager.instance.Icebreaksound();
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Player")
        {
            if(is_spike)
            {
                target.transform.position = new Vector2(1000f, 1000f);
                SoundManager.instance.Gameoversound();
                GameManager.instance.RestartGame();
                //sound manager instance game oversound;
                //gamemanager instance restart game;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag=="Player")
        {
            if(is_breakable)
            {
                SoundManager.instance.LandSound();
                anim.Play("breakanimation");
            }
            if(is_platform)
            {
                SoundManager.instance.LandSound();
            }
        }
        
    }

    private void OnCollisionStay2D(Collision2D target)
    {
        
        if(target.gameObject.tag=="Player")
        {
            if(moving_platform_left)
            {
                target.gameObject.GetComponent<Playerscript>().PlatformMove(-6f); //passing -1 in Playerscript function

            }
            if (moving_platform_right)
            {
                target.gameObject.GetComponent<Playerscript>().PlatformMove(6f); //passing -1 in Playerscript function

            }
        }
    }


}
