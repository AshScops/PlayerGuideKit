using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerGuideKit
{
    public class PanelManager : MonoBehaviour
    {
        public static PanelManager Instance;
        private List<PanelObj> m_panels;
        private Transform m_bg;
        private Transform m_common;
        private Transform m_pop;
        private Transform m_guide;
        private Transform m_const;
        private Transform m_toast;

        private void Awake()
        {
            Instance = this;
            m_panels = new List<PanelObj>();
            m_bg = transform.Find("Bg");
            m_common = transform.Find("Common");
            m_pop = transform.Find("Pop");
            m_guide = transform.Find("Guide");
            m_const = transform.Find("Const");
            m_toast = transform.Find("Toast");
        }

        private void OnDestroy()
        {
            foreach(var panel in m_panels)
            {
                Destroy(panel.gameObject);
            }
            m_panels.Clear();
        }

        public void OpenPanel(GameObject panelPrefab, PanelData panelData = null, UILevel panelLevel = UILevel.Common)
        {
            if (panelPrefab == null) return;

            Transform panelparent = null;
            switch (panelLevel)
            {
                case UILevel.Bg:
                    panelparent = m_bg;
                    break;
                case UILevel.Common:
                    panelparent = m_common;
                    break;
                case UILevel.Pop:
                    panelparent = m_pop;
                    break;
                case UILevel.Guide:
                    panelparent = m_guide;
                    break;
                case UILevel.Const:
                    panelparent = m_const;
                    break;
                case UILevel.Toast:
                    panelparent = m_toast;
                    break;
            }

            GameObject panelGO = GameObject.Instantiate(panelPrefab, panelparent);
            PanelObj panelObj = panelGO.GetComponent<PanelObj>();
            panelObj.Open(panelData);
        }

        public void ClosePanel(PanelObj panel)
        {
            panel.Close();
        }
    }
}
