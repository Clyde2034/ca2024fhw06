using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject videoPlayer;
	private Animator _animator;

    public void VideoStart()
    {
        videoPlayer.SetActive(true);
    }
	
	// Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this._animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        this._animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        //characterMotion(); //鍵盤控制
    }

    void characterMotion()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetTrigger("walkingTrigger");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetTrigger("runningTrigger");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetTrigger("idleTrigger");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            _animator.SetTrigger("motionTrigger");
        }
    }

}


