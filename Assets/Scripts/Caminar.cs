using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminar : MonoBehaviour
{
    public Animator anim;

    private void Update()
    {
        anim.SetFloat("Ver", Input.GetAxis("Vertical"));
        anim.SetFloat("Hor", Input.GetAxis("Horizontal"));
    }
}
