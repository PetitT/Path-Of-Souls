﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoulNumberDisplay : MonoBehaviour
{
    public TextMeshPro text;

    private void Start()
    {
        text.text = GetComponentInParent<EnemyTether>().soulValue.ToString();
    }
}