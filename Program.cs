// author : Arthur Leyva
Console.WriteLine("Coding Challenge - Your Name Is Mine\n");

Console.Write("Enter first name : ");
string? name1 = Convert.ToString(Console.ReadLine());
Console.Write("Enter seconde name : ");
string? name2 = Convert.ToString(Console.ReadLine());
    string lName = "";
    string sName = "";
    if(name1.Length < name2.Length) {
        lName = name2;
        sName = name1;
    }
    else {
        lName = name1;
        sName = name2;
    }

    if(name1.Length == name2.Length && name1 != name2) {
        Console.WriteLine("NO! " + name1 + " & " + name2 + " are not allowed to marry");
    }
    else {
        for(int i = 0; i < sName.Length; i++)
        {
            if(sName[i] != lName[i])
            {
                lName = lName.Substring(0,i) + lName.Substring(i + 1, lName.Length - i - 1);
            }
        }
        lName = lName.Substring(0, sName.Length);
        Console.WriteLine("YES! " + name1 + " & " + name2 + " are allowed to marry");
    }
    

