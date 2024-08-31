using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Canvas canva;
 
    void Start()
    {
        Debug.Log(" ���� �ϴ°� Ȯ��");
        CreateStartPage();
    }


    private void CreateStartPage()
    {
        // �̷����� �ִ��� �ҷ��ͺ���.
        GameObject uiPage = Resources.Load<GameObject>("Prefab/UIStartPage");

        Debug.Log(uiPage); // Null

        GameObject ui = Instantiate(uiPage);

        ui.transform.SetParent(canva.transform);

        (ui.transform as RectTransform).offsetMin = Vector3.zero;
        (ui.transform as RectTransform).offsetMax = Vector3.zero;

        UIStartPage comp = ui.GetComponent<UIStartPage>();
        comp.SetCanvas(canva);
    }

    
}
