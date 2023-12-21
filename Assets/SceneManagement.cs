using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 플레이어가 깃발에 도착했을 때의 처리
            GameOver();
        }
    }

    void GameOver()
    {
        // 게임 종료 또는 승리 화면 표시
        // 예: SceneManager.LoadScene("WinScene");
        UnityEngine.Debug.Log("Game Over");
    }
}
