using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerGuideKit.ContentWithArrow
{
    public class ContentWithArrowPanel : PanelObj
    {
        [HideInInspector] public Text ContentText;

        public override void OnOpenPanel(PanelData panelData = null)
        {
            ContentText = transform.Find("ContentText").GetComponent<Text>();


            if (panelData is ContentWithArrowData data)
            {
                //ÏÔÊ¾ÎÄ×Ö
                ContentText.text = data.Content;

                //äÖÈ¾¼ýÍ·


            }
        }

        public override void OnClosePanel()
        {


        }
    }

}