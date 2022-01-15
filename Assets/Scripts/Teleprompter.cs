using System;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

public class Teleprompter : MonoBehaviour
{
    public Text textContent;
    public float textSpeed;
    [SerializeField] private RectTransform textBox;
    [SerializeField] private float textOffSet;
    [NonSerialized]public bool playerLooked;
    private SegmentScriptableObject _segment;
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
        _segment = segment;
        textContent.text = segment.text;
        _height = textContent.preferredHeight;
        textBox.anchoredPosition = new Vector3(0, -(_height / 2 + textOffSet), -20);
        _active = true;
        
        if (segment.atStart)
        {
            segment.Raise();
        }
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

            if (!_segment.atStart)
            {
                _segment.Raise();
            }

            _height = 0;
            _segment = null;
            TeleprompterManager.instance.NextSegment();
        }
    }
}
