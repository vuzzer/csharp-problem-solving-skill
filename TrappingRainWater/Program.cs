static int Trap(int[] heights)
{
    int left = 0, right = heights.Length - 1;
    int maxRight = heights[right], maxLeft = heights[left];
    int result = 0;
    while(right > left)
    {
       if(maxLeft < maxRight)
        {
            left += 1;
            maxLeft = int.Max(maxLeft, heights[left]);
            result += maxLeft - heights[left];
        }
        else
        {
            right -= 1;
            maxRight = int.Max(maxRight, heights[right]);
            result += maxRight - heights[left];
        }
    }
    return result;
}


int[] entree = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

Trap(entree);
