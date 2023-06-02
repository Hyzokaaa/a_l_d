using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animation anim;
    [SerializeField]
    private float walkSpeed;
    [SerializeField]
    private float diagnalSpeed;
    [SerializeField]
    private float backSpeed;


    void Start()
    {
        // Asegúrate de asignar el componente Animation en el Inspector
        anim = GetComponent<Animation>();

        // Establecer todas las animaciones para que se reproduzcan en bucle
        foreach (AnimationState state in anim)
        {
            state.wrapMode = WrapMode.Loop;
            Debug.Log(anim.GetClipCount());
        }
        anim["Walk"].speed = walkSpeed;
        anim["Left"].speed = diagnalSpeed;
        anim["Right"].speed = diagnalSpeed;
        anim["BackLeft"].speed = diagnalSpeed;
        anim["BackRight"].speed = diagnalSpeed;
        anim["WalkB"].speed = backSpeed;

    }

    public void PlayAnimation(string animationName)
    {
        if (anim[animationName] != null)
        {
            anim.CrossFade(animationName);
        }
        else
        {
            Debug.LogError("La animación " + animationName + " no existe");
        }
    }
}