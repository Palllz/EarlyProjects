using System.Text;

 static bool IsValidIp(string ipAddres)
{
    //creating a list of numbers from IP
    List<string> myList = new List<string>();
    StringBuilder sb = new StringBuilder();
    foreach (char i in ipAddres)
    {
        if (i == ' ') //clutch
            return false;
        if (i != '.')
        {
            sb.Append(i);
        }
        else
        {
            myList.Add(sb.ToString());
            sb.Clear();
        }

    }
    myList.Add(sb.ToString());
    //checking the conditions
    string[] myArray = myList.ToArray();
    try
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            if (int.Parse(myArray[i]) > 255 || int.Parse(myArray[i]) < 0 || myArray.Length != 4 || (myArray[i][0] == '0') && (myArray[i].Length != 1))
                return false;
        }
    }
    catch (FormatException)
    {
        return false;
    }
    return true;
}
Console.WriteLine(IsValidIp("0.0.0.0")); 
Console.WriteLine(IsValidIp("12.255.56.1")); 
Console.WriteLine(IsValidIp("137.255.156.100")); 
Console.WriteLine(IsValidIp("")); 
