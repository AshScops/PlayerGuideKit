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
            data.Content = "一枚棋子四周有多少个空缺，就称这枚棋子有多少\"气\"";

            PanelManager.Instance.OpenPanel(PanelPrefab, data);
        }
    }
}