using UnityEngine;
using UnityEngine.UI;

namespace Better.Components.Runtime
{
    [RequireComponent(typeof(RectTransform))]
    public class UIMonoBehaviour : MonoBehaviour
    {
        private RectTransform _rectTransform;
        
        public RectTransform RectTransform
        {
            get
            {
                if (_rectTransform == null)
                {
                    _rectTransform = GetComponent<RectTransform>();
                }

                return _rectTransform;
            }
        }

        protected virtual void RebuildLayout()
        {
            LayoutRebuilder.ForceRebuildLayoutImmediate(RectTransform);
        }
    }
}
