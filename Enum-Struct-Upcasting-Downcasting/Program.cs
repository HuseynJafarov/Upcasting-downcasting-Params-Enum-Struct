
using Enum_Struct_Upcasting_Downcasting.Models;
using System;

namespace Enum_Struct_Upcasting_Downcasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //GetElements(5, 9, 7, 12, 15);
            #endregion

            #region Enum
            //CheckRole(1);
            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.word);
            //string name = null;
            //int? age = null;

            //var result = age == null ? 55 : 60;
            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test test = null;
            //Console.WriteLine(test.word.ToString());
            #endregion

            #region Struct

            //Test1 test1 = new Test1("Orxan");

            //Console.WriteLine(test1.Num);
            #endregion

            #region Upcasting
            //Eagle eagle1 = new Eagle();

            //Eagle eagle3 = new Eagle();

            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();

            //Animal eagle2 = eagle1;

            ////Bird eagle2 = eagle1;

            //Animal[] animals = { shark2,eagle1, eagle2, eagle3,shark1 };

            //foreach (var item in animals)
            //{
            //    item.Test();
            //}
            #endregion

            #region Downcasting
            ////int m = 5;
            ////byte n = (byte)m;
            ////Console.WriteLine(n);

            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();
            //Shark shark3 = (Shark)shark2 ;

            //object[] objects = { 2, 5, "Salam", shark2 };

            //foreach (var item in objects)
            //{
            //    Shark shark = item as Shark;
            //    //if (item is Shark t)
            //    ////    t.Weight = 500;
            //    ////Console.WriteLine(t.Weight);

            //    //((Shark)item).Weight = 500;
            //    //Console.WriteLine(((Shark)item).Weight);
            //}
            #endregion



        }

        #region Params
        //public static void GetElements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion

        #region Enum
        //static void CheckRole(int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Roles.SuperAdmin:
        //            Console.WriteLine("Super Admin");
        //            break;
        //        case (int)Roles.Admin:
        //            Console.WriteLine("Admin");
        //            break;
        //        case (int)Roles.Menbers:
        //            Console.WriteLine("Menbers");
        //            break;

        //        default:
        //            Console.WriteLine("Not fount role id");
        //            break;
        //    }
        //}
        #endregion

    }

    #region Struct
    //struct Test1
    //{

    //    public int Num { get; set; }

    //    public Test1(string name)
    //    {
    //        Num = 66;
    //        Console.WriteLine(Num);
    //    }
    //}
    #endregion

    #region Nullable
    //class Test
    //{
    //    public int number { get; set; }
    //    public string word { get; set; }
    //}
    #endregion

    #region Enum
    //public enum Roles
    //{
    //    Admin,
    //    Menbers,
    //    SuperAdmin


    //}
    #endregion


}
