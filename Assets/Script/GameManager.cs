﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    static GameManager instance;
    [SerializeField]
    public static int[] chooseelf = new int[2];   //儲存選擇的水精靈
    [SerializeField]
    public static int playercurrenhealth;   //儲存主角血量
    [SerializeField]
    public static int cleanwatercount;   //儲存碎片數量
    [SerializeField]
    public static bool DestroyGameManager;
    void Awake()
    {
        if (instance == null)   //當第一個GameManager出現不要destroy
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != instance)  //當第二個GameManager出現刪除
        {
            DestroyGameManager = true;
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        playercurrenhealth = 20;
    }
}