using UnityEngine;

public class BubbleOnOff : MonoBehaviour
{
    public GameObject objectToDeactivate;
    private float cnt = 1;

    // 버튼 클릭시 호출될 함수
    public void OnButtonClick()
    {
        if (cnt % 2 == 0)
        {
            objectToDeactivate.SetActive(false);
            cnt++;
        }
        else
        {
            objectToDeactivate.SetActive(true);
            cnt++;
        }
    }
}
