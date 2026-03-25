
//using DemoRepositoryPattern.Entity;
//using DemoRepositoryPattern.Data.Defination;
//using DemoRepositoryPattern.Data.Impl;
//using DemoRepositoryPattern.Entity;





//IRepository<User> _userRepository = new Repository<User>();
//User u = new User
//{
//    Name = "Mahi",
//    Email="Mahioejfhjdhdfh",
//};

//_userRepository.Add(u);


//IRepository<Student> _studentRepository = new Repository<Student>();
//Student s = new Student
//{
//    Name = "Rahul",
//    Marks = 356

//};

//_studentRepository.Add(s);
//class Student : BaseEntity
//{
//    public string Name { get; set; }
//    public int Marks { get;  set; }
//}


//int[] arr = { 2, 3, 56, 8, 9, 2, 1, 5 };

//Console.WriteLine("Enter any index number");
//int index=Convert.ToInt32(Console.ReadLine());

//for (int i=0;i<arr.Length;i++)
//{
//    if (i == index)
//    {
//        break;
//    }
//    else
//    {
//        for (int j = 0; j < arr.Length; j++)
//        {
//            int first=arr[0]
//            int temp = arr[i];
//            arr[i] = arr[i + 1];
//            arr[arr.Length - 1] = temp;
//            arr[arr.Length]=first;
//        }

//    }




//}

//foreach(int i in arr)
//{
//    Console.Write(i+" ");
//}




int[] arr = {10,12,2,4,25,3 };
int small = arr[0];
int Sposition = 0;
int largest = arr[0];
int Lposition = 0;
for(int i=0;i<arr.Length;i++)
{
    if (small > arr[i])
    {
        small = arr[i];
        Sposition=i+1;
    }
    if (largest < arr[i])
    {
        largest = arr[i];
        Lposition = i + 1;
    }

}

Console.WriteLine($"Smallest number :{small} \nSmallest Number Position :{Sposition} \nLargest Number :{largest} \nLargest Number Position :{Lposition} ");
