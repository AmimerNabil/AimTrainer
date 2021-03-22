
using UnityEngine;

public class AnimationCode : MonoBehaviour
{
    //animationController
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        stayIdle();
    }

    // Update is called once per frame
    void Update()
    {

        //let the player reload while running
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.R)) anim.SetBool("Reload", true);
            walk();
        }
        //do nothing if not button are pressed
        else stayIdle();

        //reload while idle
        if (Input.GetKey(KeyCode.R))
        {
            reload();
        }
    }

    private void walk()
    {
        anim.SetBool("Reload", false);
        anim.SetBool("idle", false);
        anim.SetBool("walk", true);
    }

    private void reload()
    {
        anim.SetBool("walk", false);
        anim.SetBool("idle", false);
        anim.SetBool("Reload", true);
    }

    private void stayIdle()
    {
        anim.SetBool("Reload", false);
        anim.SetBool("walk", false);
        anim.SetBool("idle", true);
    }
}
