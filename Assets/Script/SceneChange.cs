using UnityEngine;
using UnityEngine.SceneManagement;  // ต้องใช้ namespace นี้สำหรับการจัดการฉาก

public class SceneChange : MonoBehaviour
{
    // ฟังก์ชันที่จะถูกเรียกเมื่อกดปุ่ม
    public void ChangeScene(string sceneName)
    {
        // โหลดฉากตามชื่อที่ระบุ
        SceneManager.LoadScene(sceneName);
    }
}
