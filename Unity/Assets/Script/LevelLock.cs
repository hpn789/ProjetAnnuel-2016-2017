﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLock : MonoBehaviour
{
    [SerializeField]
    Button[] _levelsBtn;

    [SerializeField]
    GameObject[] _locks;

    //[SerializeField]
    //GameManager _gameManager;

    private int _unlockLvl;

    void OnEnable ()
    {
        _unlockLvl = PlayerPrefs.GetInt("max_level", 1);
        for(int i = _unlockLvl; i < 5; ++i)
        {
            _levelsBtn[i].interactable = false;
            _locks[i].SetActive(true);
        }

	}
}