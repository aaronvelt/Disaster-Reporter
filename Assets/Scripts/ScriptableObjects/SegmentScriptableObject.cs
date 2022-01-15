using UnityEngine;

namespace ScriptableObjects
{
    public enum SegmentType {Casual, Breaking, Crime, Weather}

    [CreateAssetMenu(fileName = "Segment", menuName = "ScriptableObjects/SegmentScriptableObject", order = 1)]
    public class SegmentScriptableObject : ScriptableObject
    {
        public string segmentName;
        public SegmentType segmentType;
        public string eventName;
        public bool atStart;
    
        [TextArea(5, 5)] 
        public string text;
    }
}