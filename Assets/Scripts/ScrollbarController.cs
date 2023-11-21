using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarController : MonoBehaviour {
    private Sprite imageSprite1;
    private Sprite imageSprite2;
    private Sprite imageSprite3;
    private Sprite imageSprite4;
    private Sprite imageSprite5;
    private Sprite imageSprite6;
    private Sprite imageSprite7;
    private Sprite imageSprite8;
    private Sprite imageSprite9;

    // public ScrollRect scrollRect;

    public Image image1;
    public Image image2; 
    public Image image3;

    public Scrollbar scrollbar;
    public RectTransform panel;

    private float scrollPos = 0.0f;
    private float pageSize = 3.0f;
    private float imageSize = 12.0f;
    private int totalPage = 0;

    private Vector2 touchStartPos;
    private float totalDistance;

    void Start() {
        scrollbar.value = scrollPos;
        totalPage = (int)Math.Ceiling(imageSize / pageSize);
    }

    void Update() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            touchStartPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDelta1 = Input.GetTouch(0).position - touchStartPos;
            float verticalSwipe = Mathf.Sign(touchDelta1.y) * touchDelta1.magnitude;
            float unityDistance = (verticalSwipe / Screen.dpi) * 0.15f;
            totalDistance -= unityDistance;

            if (totalDistance <= 0) {
                totalDistance = 0;
            } else if (totalDistance >= 1) {
                totalDistance = 1;
            }
            scrollbar.value = totalDistance;
        }

        float percentage = 1.0f / totalPage;
        scrollbar.size = percentage;
        scrollPos = scrollbar.value;
        
        int currentPage = 0;
        for (int i = 0 ; i < totalPage ; i++) {
            if (scrollPos >= (percentage * i) && scrollPos <= ((percentage * i) + percentage)) {
                break;
            }
            currentPage += 1;
        }

        int start = (int)(currentPage * pageSize);
        image1.sprite = Resources.Load<Sprite>("image" + start);
        image2.sprite = Resources.Load<Sprite>("image" + (start + 1));
        image3.sprite = Resources.Load<Sprite>("image" + (start + 2));

        //panel.anchoredPosition = new Vector2(0, Mathf.Lerp(0, panel.sizeDelta.y - panel.parent.GetComponent<RectTransform>().sizeDelta.y, scrollPos));
    }
}
