using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject gameRuleObject = GameObject.Find("game_rule_scene");
        if (gameRuleObject != null)
        {
            gameRuleObject.SetActive(false);
        }
        else
        {
            Debug.LogError("game_rule 오브젝트를 찾을 수 없습니다.");
        }
    }
}
