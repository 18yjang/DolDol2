﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterClear : MonoBehaviour
{
    public GameObject[] chapter = new GameObject[PageSlide.chapterNum];
    public static int[] totalStarCount; // 각 챕터별 별 개수 총 합


    void Start()
    {
        GameObject.Find("Scrollbar Horizontal").GetComponent<Scrollbar>().value = 0;
        GetComponent<Text>().text = totalStarCount[0].ToString();

        chapter[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Chapter/Button_Chapter1_1");
        for (int i = 1; i < PageSlide.chapterNum; i++)
        {
            totalStarCount[i] = 0;
            chapter[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Chapter/Button_Chapter1_0");
        }
    }
    void Awake()
    {
        for(int i = 0; i<PageSlide.chapterNum; i++)
        {
            for(int j = 0; j<20; j++)
            {
                totalStarCount[i] += StageSelect.clear[i].stageStar[j];         // NullReference on Object("Chapter")
            }


            if(totalStarCount[i] == 60)
            {
                chapter[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Chapter/Button_Chapter1_3");
                                //GameObject.Find("star").transform.Find("Clear").gameObject.SetActive(true);       <- 실행시 윗라인 실행X
            }   // 스테이지 완성 및 별 모두 수집 시
            else if(StageSelect.clear[i].stageClear[19] == true)
            {
                chapter[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Chapter/Button_Chapter1_2");
            }       // 스테이지 완성만 했을 시

            // 다음 챕터 해방하기** (이미지 변경 + 버튼 true)

        }
    }

    
}
