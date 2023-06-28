using System;
using Xunit;
using lab03;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string arr = "1 9 4 5";
            int res = Program.MultiplyFirst3(arr);
            Assert.Equal(res, 36);

    }
        [Fact]
        public void Test1a()
        {
            string arr = "1 5";
            int res = Program.MultiplyFirst3(arr);
            Assert.Equal(res, 0);
         }
        [Fact]
        public void Test1b()
        {
            string arr = "1 5 c";
            int res = Program.MultiplyFirst3(arr);
            Assert.Equal(res, 5);
        }
        [Fact]


        public void Test2()
        {
            int size = 3;
            int []arr = { 10,20,30} ;
            int res = Program.Average(3,arr);
            Assert.Equal(res, 20);

        }
        [Fact]
        public void Test2a()
        {
            int size = 3;
            int[] arr = { 0, 0, 0 };
            int res = Program.Average(3, arr);
            Assert.Equal(res, 0);

        }

        [Fact]
        public void Test3()
        {
         
            int[] arr = { 1, 1, 3,5,3,6,3,4,3 };
            int res = Program.DuplicateArr(arr);
            Assert.Equal(res, 3);

        }
        [Fact]
        public void Test3a()
        {

            int[] arr = { 1, 1, 2,2 };
            int res = Program.DuplicateArr(arr);
            Assert.Equal(res, 1);

        }
        [Fact]
        public void Test3b()
        {

            int[] arr = { 1, 2, 3,42 };
            int res = Program.DuplicateArr(arr);
            Assert.Equal(res, 1);

        }
        [Fact]
        public void Test3c()
        {

            int[] arr = {27, 27, 27, 27 };
            int res = Program.DuplicateArr(arr);
            Assert.Equal(res, 27);

        }



        [Fact]
        public void Test4()
        {

            int[] arr = { 27, 27, 27, 27 };
            int res = Program.MaxElement(arr);
            Assert.Equal(res, 27);

        }
        [Fact]
        public void Test4a()
        {

            int[] arr = { -27, -52, -2527, -2 };
            int res = Program.MaxElement(arr);
            Assert.Equal(res, -2);

        }


        [Fact]
        public void Test5()
        {

            string text = "Bashar Nidal";
            string[] arr = Program.NumbersOfWord(text);
            string [] output = {"Bashar: 6","Nidal: 5"};
            Assert.Equal(arr,output);

        }
        [Fact]
        public void Test5a()
        {

            string text = "Bas_* Nidal 27*";
            string[] arr = Program.NumbersOfWord(text);
            string[] output = { "Bas_*: 5", "Nidal: 5","27*: 3" };
            Assert.Equal(arr, output);

        }
    }
}
