
using System.Collections;
 
//ArrayList list = new ArrayList(1);
////Console.WriteLine("1 st"+list.Capacity);
//list.Add(10);
//list.Add(20);
//list.Add(30);
////Console.WriteLine("2 nd " + list.Capacity);
//list.Add("hello"); //collection Object

//list.Add("Byy");
////Console.WriteLine("3 rd " + list.Capacity);
//list.Add(true);
//list.Add(false);
//list.Add(9.8m);
//list.Add(new {Name="arnav",marks=67 });
//Console.WriteLine(list.Capacity);

//Console.WriteLine(list[8]);

//list.Insert(1, "charan");
//Console.WriteLine(list[0]);
//Console.WriteLine(list[1]);
//Console.WriteLine(list[2]);

//Console.WriteLine(list.Contains(30));
//Console.WriteLine(list.Contains("hello"));
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//create annother Collection using ArraqyList

//ArrayList list1 = new ArrayList();
//list1.AddRange(list);
//list1.Add(100);
//var itr=list1.GetEnumerator();
//while (itr.MoveNext())
//{
//    Console.WriteLine(itr.Current);
//}

//list.Sort();
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//list.RemoveAt(0);
//list.RemoveRange()

//Hashtable ht = new Hashtable();
//ht.Add(0, "Raju");
//ht.Add(1,false);
//ht.Add('c',true);
////ht.Add(0,false);
//ht.Add("Pratham", "Teacher");

//ht.Remove(1);


//iterator

//var keys=ht.Keys;
//foreach (var item in keys)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("+++++++++++++++++++++++++");
//var values= ht.Values;
//foreach (var item in values)
//{
//    Console.WriteLine(item);
//}



class Employee
{
    public string Name {  get; set; }
    public string  Position {  get; set; }
    public int EmployeeID { get; set; }

    public Employee(string name,string position ,int empolyeeID)
    {
        Name=name;
        Position=position;
        EmployeeID = empolyeeID;
    }
    public override string ToString()
    {
        return $"Name :{Name} ,ID: {EmployeeID} ,Position :{Position}";
    }

}

