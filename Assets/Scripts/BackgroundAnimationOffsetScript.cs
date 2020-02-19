﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimationOffsetScript : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        float randomStart = Random.Range(0, anim.GetCurrentAnimatorStateInfo(0).length);
        anim.Play("Take 001", 0, randomStart);
    }
}
