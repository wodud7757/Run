using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    private void Awake() {
        // SpriteRenderer의 bounds로 가로 길이 측정
        width = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update() {
        // 왼쪽으로 width 이상 이동했을 때 위치 리셋
        if (transform.position.x <= -width) {
            Reposition();
        }
    }

    // 위치를 리셋하는 메서드
    private void Reposition() {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}