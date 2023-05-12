using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animation anim;

    void Start()
    {
        // Aseg�rate de asignar el componente Animation en el Inspector
        //anim = GetComponent<Animation>();

        // Establecer todas las animaciones para que se reproduzcan en bucle
        foreach (AnimationState state in anim)
        {
            state.wrapMode = WrapMode.Loop;
            Debug.Log(anim.GetClipCount());
        }
    }

    public void PlayAnimation(string animationName)
    {
        if (anim[animationName] != null)
        {
            anim.CrossFade(animationName);
        }
        else
        {
            Debug.LogError("La animaci�n " + animationName + " no existe");
        }
    }
}