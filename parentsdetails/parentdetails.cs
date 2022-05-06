System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parents
{
    internal class FamilyTree
    {
       
            static void Main()
            {
                FamilyTree tree = new FamilyTree();
                tree.PrintFamilydetails("Dineshkumar");
                Console.WriteLine("===================================================");
                tree.PrintFamilydetails("Adinarayana");
                Console.ReadLine();
            }
            public void PrintFamilydetails(string name)
            {
                Child objchaild = new Child();
                objchaild.ChildName1 = name;
                Familydetails(objchaild);

            }

            public void Familydetails(Child obj)
            {
                string result = $"Surename :{obj.Surname} \n GrandFater :{obj.GrandParentName1} ,GrandMother :{obj.GrandParentName2} \n"
                    + $" Father :{obj.ParentName1} ,Mother :{obj.ParentName2} \n Chaild :{obj.ChildName1} \n"
                    + $"Location :{obj.Location} , City :{obj.City}";
                Console.WriteLine(result);

            }
        }



        public class GrandParent
        {

            public string GrandParentName1 { get; set; } = "chinnappareddy";
            public string GrandParentName2 { get; set; } = "syamalamma";
            public string Location { get; set; } = "0.42,gvpalli,Dinesh,AP";

            public string Surname { get; set; } = "g";
            public string City { get; set; } = "Chittoor";

            //public GrandParent(string name1,string name2)
            //{
            //    this.GrandParentName1 = name1;
            //    this.GrandParentName2 = name2;
            //}

        }

        public class Parent : GrandParent
        {
            public string ParentName1 { get; set; } = "Adinarayanareddy";
            public string ParentName2 { get; set; } = "prabhavathi";
        }

        public class Child : Parent
        {
            public string ChildName1 { get; set; }

        }
    }