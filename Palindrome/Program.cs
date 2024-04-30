using System.Text.RegularExpressions;

static bool Solution(String s)
{
    s = s.ToLower();
    string messageSanitize = Regex.Replace(s, "[^a-zA-Z0-9]", "");
    int halfSize = messageSanitize.Length / 2;
    if(halfSize > 0)
    {
        for (int right = 0, left = messageSanitize.Length - 1; right <= halfSize; right++, left--)
        {
            if (messageSanitize[right] != messageSanitize[left])
            {
                return false;
            }
        }
    }
    return true;
}

string message = "A man, a plan, a canal: Panama";

// Display message sanitize
Console.WriteLine(Solution(message));



