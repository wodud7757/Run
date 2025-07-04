using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    private bool stepped = false;

    private void OnEnable()
    {
        stepped = false;
        for (int i = 0; i < obstacles.Length; i++)
        {
            // 장애물 오브젝트를 비활성화
            if (Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }
    // 플랫폼 이동 속도

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어가 플랫폼에 닿았을 때
        if (collision.gameObject.CompareTag("Player") && !stepped)
        {
            stepped = true;
            // 게임 매니저의 점수 증가 메서드 호출
            GameManager.instance.AddScore(1);
        }
    }

    
}