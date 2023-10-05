using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerGuideKit
{
    public abstract class PanelObj : MonoBehaviour
    {
        public void Open(PanelData data = null)
        {
            gameObject.SetActive(true);

            if (data == null) return;
            OnOpenPanel(data);
        }

        public abstract void OnOpenPanel(PanelData data = null);

        public void Close()
        {
            gameObject.SetActive(false);
            OnClosePanel();
        }
        public abstract void OnClosePanel();
    }

}
