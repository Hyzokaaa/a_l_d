using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator anim;
    private float speedX = 0;
    private float speedY = 0;
    private float smoothness = 10f;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
    }
    private void RunMotion()
    {
        anim.SetFloat("speedX", speedX);
        anim.SetFloat("speedY", speedY);
    }

    public void Idle()
    {
        speedX = Mathf.Lerp(speedX, 0, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void Walk()
    {
        speedX = Mathf.Lerp(speedX, 0, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0.7f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkSlow()
    {
        speedX = Mathf.Lerp(speedX, 0, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0.3f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void Run()
    {
        speedX = Mathf.Lerp(speedX, 0, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 1f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkBack()
    {
        speedX = Mathf.Lerp(speedX, 0, Time.deltaTime * smoothness); 
        speedY = Mathf.Lerp(speedY, -1f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkRight()
    {
        speedX = Mathf.Lerp(speedX, 1f, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkLeft()
    {
        speedX = Mathf.Lerp(speedX, -1f, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkBackRight()
    {
        speedX = Mathf.Lerp(speedX, 0.36f, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, -0.95f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkBackLeft()
    {
        speedX = Mathf.Lerp(speedX, -0.36f, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, -0.95f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkFrontRight()
    {
        speedX = Mathf.Lerp(speedX, 0.7f, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0.3f, Time.deltaTime * smoothness);
        RunMotion();
    }
    public void WalkFrontLeft()
    {
        speedX = Mathf.Lerp(speedX, -0.7f, Time.deltaTime * smoothness);
        speedY = Mathf.Lerp(speedY, 0.3f, Time.deltaTime * smoothness);
        RunMotion();
    }
}
