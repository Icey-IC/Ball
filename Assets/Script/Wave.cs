using UnityEngine;

public class Wave : MonoBehaviour
{
    public Transform[] childObjects; // 5个子物体（手动拖拽）
    public float waveAmplitude = 1f; // 振幅（上下移动的高度）
    public float waveFrequency = 15f; // 频率（摆动快慢）
    public float phaseOffset = 2f; // 每个物体的相位偏移（错开运动形成波浪）

    private Vector3[] startLocalPositions; // 记录子物体初始局部位置

    void Start()
    {

        // 记录所有子物体的初始位置
        startLocalPositions = new Vector3[childObjects.Length];
        for (int i = 0; i < childObjects.Length; i++)
        {
            startLocalPositions[i] = childObjects[i].localPosition;
        }
    }

    void Update()
    {
        for (int i = 0; i < childObjects.Length; i++)
        {
            float waveOffset = i * phaseOffset; // 每个子物体错开时间
            float yOffset = Mathf.Sin(Time.time * waveFrequency + waveOffset) * waveAmplitude;

            // 让子物体相对父物体上下运动
            childObjects[i].localPosition = new Vector3(startLocalPositions[i].x, startLocalPositions[i].y + yOffset, startLocalPositions[i].z);
        }
    }
}
