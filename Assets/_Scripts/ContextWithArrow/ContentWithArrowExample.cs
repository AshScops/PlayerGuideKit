using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerGuideKit.ContentWithArrow
{
    public class ContentWithArrowExample : MonoBehaviour
    {
        public GameObject PanelPrefab;
        
        void Start()
        {
            var data = new ContentWithArrowData();
            data.Content = "һö���������ж��ٸ���ȱ���ͳ���ö�����ж���\"��\"";

            PanelManager.Instance.OpenPanel(PanelPrefab, data);
        }
    }
}