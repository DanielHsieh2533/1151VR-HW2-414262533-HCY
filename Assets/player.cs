using UnityEngine;

public class player : MonoBehaviour
{
    const float v = 5;
    int currentIndex = 0;
    Vector2[]  targetPoints = {new Vector2(0.0f, 1.84f), new Vector2(5.0f, 1.84f), new Vector2(6.0f, 3.84f), new Vector2(7.0f, 4.84f), new Vector2(8.0f, 5.34f), new Vector2(9.0f, 5.84f), new Vector2(10.0f, 5.34f), new Vector2(11.0f, 4.84f), new Vector2(12.0f, 3.84f), new Vector2(13.0f, 1.84f), new Vector2(18.0f, 1.84f)};

    public void Start()
    {
        Vector2 startPos = new Vector2(0.0f, 1.84f);  
        transform.position = startPos; 
        Application.targetFrameRate = 60;
        
    }

    public void Update()
    {
        if(currentIndex >= targetPoints.Length)
        {
            return;
        }
        double dis = Vector2.Distance(transform.position, targetPoints[currentIndex]);

        if(dis <= 0.1f)
        {
            currentIndex++;
        }
        if(currentIndex >= targetPoints.Length)
        {
            return;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPoints[currentIndex], v * Time.deltaTime);
    }
}
