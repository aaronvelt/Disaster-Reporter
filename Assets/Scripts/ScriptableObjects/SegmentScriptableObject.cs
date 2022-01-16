using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Segment", menuName = "ScriptableObjects/SegmentScriptableObject", order = 1)]
    public class SegmentScriptableObject : ScriptableObject
    {
        public string segmentName;
        public bool atStart;
    
        [TextArea(5, 5)] 
        public string text;
        
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Raise()
        {
            for(int i = listeners.Count -1; i >= 0; i--)
                listeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener)
        { listeners.Add(listener); }

        public void UnregisterListener(GameEventListener listener)
        { listeners.Remove(listener); }
    }
}