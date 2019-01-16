using Abp;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DgCorER.DgEntity
{
    public class PersonTest
    {
        public PersonTest()
        {

            var person = new Person("John");

            person.SetData("RandomValue", RandomHelper.GetRandom(1, 1000));
            person.SetData("CustomData", new MyCustomObject { Value1 = 42, Value2 = "forty-two" });

            var randomValue = person.GetData<int>("RandomValue");
            var customData = person.GetData<MyCustomObject>("CustomData");


        }

        private class MyCustomObject
        {
            public int Value1 { get; set; }
            public string Value2 { get; set; }
        }
    }
}
