using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

public class Teleprompter : MonoBehaviour
{
    [SerializeField] private RectTransform textBox;
    [SerializeField] private Text textContent;
    [SerializeField] private float textSpeed;
    [SerializeField] private float textOffSet;
    [SerializeField] private float textIncreasedSpeed;
    [SerializeField] private int textIncreasedSize;
    public bool playerLooked;
    private float _height;
    private bool _active;

    void Update()
    {
        if (_active)
        {
            ScrollSegment();
        }
    }

    public void StartSegment(SegmentScriptableObject segment)
    {
        textContent.text = segment.text;
        _height = textContent.preferredHeight;
        textBox.anchoredPosition = new Vector3(0, -(_height / 2 + textOffSet), -20);
        _active = true;
    }
    
    private void ScrollSegment()
    {
        Vector3 position = textBox.anchoredPosition;
        position = new Vector3(0, position.y + Time.deltaTime * textSpeed, position.z);
        textBox.anchoredPosition = position;

        if (textBox.anchoredPosition.y >= (_height / 2 + textOffSet))
        {
            _active = false;
            textContent.text = " ";
            textBox.anchoredPosition = new Vector3(0, -10, -20);
            TeleprompterManager.instance.NextSegment();
        }
    }

    private void ChangeTextSpeed()
    {
        textSpeed = textIncreasedSpeed;
    }

    private void ChangeFontSize()
    {
        textContent.fontSize = textIncreasedSize;
    }
}
