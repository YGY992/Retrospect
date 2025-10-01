using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextUpdater : MonoBehaviour
{
 

        public Text clueTextUI;

 
        private const string CLUE_TEXT_ID = "1"; 

        public void DisplayPrompt()
        {
            if (clueTextUI == null || JsonData.Instance == null)
            {
                Debug.LogError("�ؽ�Ʈ UI �Ǵ� JsonData�� ����/�غ���� �ʾҽ��ϴ�.");
                return;
            }

     
            string prompt = JsonData.Instance.GetTextById(CLUE_TEXT_ID);

            clueTextUI.text = prompt;
            clueTextUI.gameObject.SetActive(true);
            Debug.Log($"�ڸ� ǥ�� ����: {prompt}");
        }
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
