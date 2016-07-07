//-----------------------------------------------------------------------
//    MIT License
//
//    Copyright (c) 2016 Betabyte Software
//
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using BBS.Libraries.Extensions;
using NUnit.Framework;

namespace BBS.Libraries.UnitTests.General
{
    [TestFixture]
    public class Extensions
    {
        [Test]
        public void Enumerable_Batch_Creates_Correctly_Sized_Batches()
        {
            // ARRANGE
            var numberList = new[] {1, 3, 2, 3, 4, 1, 10, 9, 8, 28, 7, 3}; // 12 total numbers

            // ACT
            var batchedResults = numberList.Batch(5).ToList();

            // ASSERT
            Assert.That(batchedResults.Count(), Is.EqualTo(3));
            Assert.That(batchedResults[0].Count(), Is.EqualTo(5));
            Assert.That(batchedResults[1].Count(), Is.EqualTo(5));
            Assert.That(batchedResults[2].Count(), Is.EqualTo(2));
        }

        [Test]
        public void Enumerable_RunInBatches_Correctly_Runs_Items()
        {
            // ARRANGE
            var numberList = new[] { 1, 3, 2, 3, 4, 1, 10, 9, 8, 28, 7, 3 }; // 12 total numbers
            var count = 0;
            // ACT
            numberList.RunInBatches(5, batched =>
            {
                foreach (var item in batched)
                {
                    if (item == 3)
                    {
                        count ++;
                    }
                }
            });

            // ASSERT
            Assert.That(count, Is.EqualTo(3));
        }

        [Test]
        public void Int_ToBoolean_Converts_Integers_Correctly()
        {
            // Arrange
            var trueValue = 1;
            var falseValue = 0;
            var unknownThereforFalseValue = 32;

            // ACT
            var isTrue = trueValue.ToBoolean();
            var isFalse = falseValue.ToBoolean();
            var unknown = unknownThereforFalseValue.ToBoolean();
            
            // Assert
            Assert.That(isTrue, Is.True);
            Assert.That(isFalse, Is.False);
            Assert.That(unknown, Is.False);
        }
        [Test]
        public void Int_ToBoolean_TrueValues_NoDefaultUpdate_Sent_And_Correctly_Parsed()
        {
            // Arrange
            var trueValues = new[] {0, 4, 98};

            // ACT
            var firstTrue = 4.ToBoolean(trueValues);
            var secondTrue = 0.ToBoolean(trueValues);
            var thirdTrue = 98.ToBoolean(trueValues);

            var firstFalse = 1.ToBoolean(trueValues);
            var secondFalse = 99.ToBoolean(trueValues);

            // Assert

            Assert.That(firstTrue, Is.True);
            Assert.That(secondTrue, Is.True);
            Assert.That(thirdTrue, Is.True);

            Assert.That(firstFalse, Is.False);
            Assert.That(secondFalse, Is.False);
        }

        [Test]
        public void Int_ToBoolean_TrueValues_DefaultAsTrue_Sent_And_Correctly_Parsed()
        {
            // Arrange
            var trueValues = new[] { 0, 4, 98 };

            // ACT
            var firstTrue = 4.ToBoolean(trueValues, @default:true);
            var secondTrue = 0.ToBoolean(trueValues, @default: true);
            var thirdTrue = 98.ToBoolean(trueValues, @default: true);

            var firstFalse = 1.ToBoolean(trueValues, @default: true);
            var secondFalse = 99.ToBoolean(trueValues, @default: true);

            // Assert

            Assert.That(firstTrue, Is.True);
            Assert.That(secondTrue, Is.True);
            Assert.That(thirdTrue, Is.True);

            Assert.That(firstFalse, Is.True);
            Assert.That(secondFalse, Is.True);
        }

        [Test]
        public void Int_ToBoolean_FalseValues_Sent_NoDefaultUpdate_And_Correctly_Parsed()
        {
            // Arrange
            var falseValues = new[] { 0, 4, 98 };

            // ACT
            var firstTrue = 4.ToBoolean( falseValues: falseValues);
            var secondTrue = 0.ToBoolean(falseValues: falseValues);
            var thirdTrue = 98.ToBoolean(falseValues: falseValues);

            var firstFalse = 1.ToBoolean(falseValues: falseValues);
            var secondFalse = 99.ToBoolean(falseValues: falseValues);

            // Assert

            Assert.That(firstTrue, Is.False);
            Assert.That(secondTrue, Is.False);
            Assert.That(thirdTrue, Is.False);

            Assert.That(firstFalse, Is.False);
            Assert.That(secondFalse, Is.False);
        }

        [Test]
        public void Int_ToBoolean_FalseValues_Sent_DefaultAsTrue_And_Correctly_Parsed()
        {
            // Arrange
            var falseValues = new[] { 0, 4, 98 };

            // ACT
            var firstTrue = 4.ToBoolean(falseValues: falseValues, @default: true);
            var secondTrue = 0.ToBoolean(falseValues: falseValues, @default: true);
            var thirdTrue = 98.ToBoolean(falseValues: falseValues, @default: true);

            var firstFalse = 1.ToBoolean(falseValues: falseValues, @default: true);
            var secondFalse = 99.ToBoolean(falseValues: falseValues, @default: true);

            // Assert

            Assert.That(firstTrue, Is.False);
            Assert.That(secondTrue, Is.False);
            Assert.That(thirdTrue, Is.False);

            Assert.That(firstFalse, Is.True);
            Assert.That(secondFalse, Is.True);
        }

        [Test]
        public void Int_ToBoolean_NoValues_Sent_DefaultAsTrue_And_Correctly_Parsed()
        {
            // Arrange

            // ACT
            var firstTrue = 4.ToBoolean(@default: true);
            var secondTrue = 0.ToBoolean(@default: true);
            var thirdTrue = 98.ToBoolean(@default: true);

            var firstFalse = 1.ToBoolean(@default: false);
            var secondFalse = 99.ToBoolean(@default: false);

            // Assert

            Assert.That(firstTrue, Is.True);
            Assert.That(secondTrue, Is.True);
            Assert.That(thirdTrue, Is.True);

            Assert.That(firstFalse, Is.False);
            Assert.That(secondFalse, Is.False);
        }

        [Test]
        public void Int_ToDouble_Correctly_Parses_To_Double()
        {
            // Arrange
            int intOneHundredOne = 101;
            double dblOneHundredOne = 101.00d;

            // ACT
            var castedInteger = intOneHundredOne.ToDouble();

            // Assert
            Assert.That(castedInteger, Is.EqualTo(dblOneHundredOne));
        }
        [Test]
        public void Object_ToJsonString_Converts_Correctly()
        {
            // Arrange
            var objectToConvert = new ObjectToConvert()
            {
                Name = "Brenton Lamar",
                Age = 29
            };

            // Act
            var objectAsString = objectToConvert.ToJsonString<ObjectToConvert>();
            
            // Assert  
            Assert.That(objectAsString, Contains.Substring("{\"Name\":\"Brenton Lamar\",\"Age\":29}"));
        }

        [Test]
        public void Object_FromJsonString_Converts_Correctly()
        {
            // Arrange
            var objectAsString = "{\"Name\":\"Brenton Lamar\",\"Age\":29}";
            
            // Act
            var convertedObject = objectAsString.FromJsonString<ObjectToConvert>();

            // Assert  
            Assert.That(convertedObject, Is.Not.Null);
            Assert.That(convertedObject.Name, Is.EqualTo("Brenton Lamar"));
            Assert.That(convertedObject.Age, Is.EqualTo(29));
        }

        [Test]
        public void Object_ToBase64String_Converts_Correctly()
        {
            // Arrange
            var objectToConvert = new SerializableObjectToConvert()
            {
                Age = 29,
                Name = "Brenton Lamar"
            };

            // ACT
            var base64String = objectToConvert.ToBase64String();

            // Assert
            Assert.That(base64String, Is.EqualTo("AAEAAAD/////AQAAAAAAAAAMAgAAAFZCQlMuTGlicmFyaWVzLlVuaXRUZXN0cy5HZW5lcmFsLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbAUBAAAARkJCUy5MaWJyYXJpZXMuVW5pdFRlc3RzLkdlbmVyYWwuRXh0ZW5zaW9ucytTZXJpYWxpemFibGVPYmplY3RUb0NvbnZlcnQCAAAAFTxOYW1lPmtfX0JhY2tpbmdGaWVsZBQ8QWdlPmtfX0JhY2tpbmdGaWVsZAEACAIAAAAGAwAAAA1CcmVudG9uIExhbWFyHQAAAAs="));
        }

        [Test]
        public void Object_FromBase64String_Converts_Correctly()
        {
            // Arrange
            var base64String = "AAEAAAD/////AQAAAAAAAAAMAgAAAFZCQlMuTGlicmFyaWVzLlVuaXRUZXN0cy5HZW5lcmFsLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbAUBAAAARkJCUy5MaWJyYXJpZXMuVW5pdFRlc3RzLkdlbmVyYWwuRXh0ZW5zaW9ucytTZXJpYWxpemFibGVPYmplY3RUb0NvbnZlcnQCAAAAFTxOYW1lPmtfX0JhY2tpbmdGaWVsZBQ8QWdlPmtfX0JhY2tpbmdGaWVsZAEACAIAAAAGAwAAAA1CcmVudG9uIExhbWFyHQAAAAs=";

            // ACT
            var convertedObject = base64String.FromString() as SerializableObjectToConvert;

            // Assert
            Assert.That(convertedObject, Is.Not.Null);
            Assert.That(convertedObject.Age, Is.EqualTo(29));
            Assert.That(convertedObject.Name, Is.EqualTo("Brenton Lamar"));
        }

        [Test]
        public void String_ToBase64String_Converts_Correctly()
        {
            // Arrange
            var stringToConvert = "This is a test string";
            var expectedResult = "VGhpcyBpcyBhIHRlc3Qgc3RyaW5n";
            // Act
            var @string = stringToConvert.ToBase64String();

            // Assert
            Assert.That(@string, Is.EqualTo(expectedResult));
        }

        [Test]
        public void String_ToBoolean_Converts_Correctly()
        {
            // Arrange
            var trueString = "TruE";
            var falseString = "False";
            var trueChar = 'T'.ToString();
            var falseChar = 'F'.ToString();
            var oneString = 1.ToString();
            var zeroString = 0.ToString();
            var @default = "Something Else";

            // ACT
            var trueStringResult = trueString.ToBoolean();
            var trueCharReuslt = trueChar.ToBoolean();
            var oneStringResult = oneString.ToBoolean();

            var falseStringResult = falseString.ToBoolean();
            var falseCharResult = falseChar.ToBoolean();
            var zeroStringResult = zeroString.ToBoolean();

            var defaultResult = @default.ToBoolean();

            // Assert

            Assert.That(trueStringResult, Is.True);
            Assert.That(trueCharReuslt, Is.True);
            Assert.That(oneStringResult, Is.True);

            Assert.That(falseStringResult, Is.False);
            Assert.That(falseCharResult, Is.False);
            Assert.That(zeroStringResult, Is.False);

            Assert.That(defaultResult, Is.False);
        }

        [Test]
        public void String_ToBoolean_TrueValues_NoDefaultUpdate_Sent_And_Correctly_Parsed()
        {
            // Arrange
            var trueValues = new[] { "T", "LukeSkywalker", "God" };

            // ACT
            var firstTrue = "T".ToBoolean(trueValues);
            var secondTrue = "lukeSkYwalker".ToBoolean(trueValues);
            var thirdTrue = "God".ToBoolean(trueValues);

            var firstFalse = "Brenton".ToBoolean(trueValues);
            var secondFalse = "False".ToBoolean(trueValues);

            // Assert

            Assert.That(firstTrue, Is.True);
            Assert.That(secondTrue, Is.True);
            Assert.That(thirdTrue, Is.True);

            Assert.That(firstFalse, Is.False);
            Assert.That(secondFalse, Is.False);
        }

        [Test]
        public void String_ToBoolean_TrueValues_DefaultAsTrue_Sent_And_Correctly_Parsed()
        {
            // Arrange
            var trueValues = new[] { "T", "LukeSkywalker", "God" };

            // ACT
            var firstTrue = "T".ToBoolean(trueValues, @default: true);
            var secondTrue = "lukeSkYwalker".ToBoolean(trueValues, @default: true);
            var thirdTrue = "God".ToBoolean(trueValues, @default: true);

            var firstFalse = "Brenton".ToBoolean(trueValues, @default: true);
            var secondFalse = "False".ToBoolean(trueValues, @default: true);

            // Assert

            Assert.That(firstTrue, Is.True);
            Assert.That(secondTrue, Is.True);
            Assert.That(thirdTrue, Is.True);

            Assert.That(firstFalse, Is.True);
            Assert.That(secondFalse, Is.True);
        }

        [Test]
        public void String_ToBoolean_FalseValues_Sent_NoDefaultUpdate_And_Correctly_Parsed()
        {
            // Arrange
            var falseValues = new[] { "0", "BananaBread" };

            // ACT
            var firstTrue = "0".ToBoolean(falseValues: falseValues);
            var secondTrue = "BananaBREAD".ToBoolean(falseValues: falseValues);

            var firstFalse = "true".ToBoolean(falseValues: falseValues);
            var secondFalse = "TRUEDAMMIT".ToBoolean(falseValues: falseValues);

            // Assert

            Assert.That(firstTrue, Is.False);
            Assert.That(secondTrue, Is.False);

            Assert.That(firstFalse, Is.False);
            Assert.That(secondFalse, Is.False);
        }

        [Test]
        public void String_ToBoolean_FalseValues_Sent_DefaultAsTrue_And_Correctly_Parsed()
        {
            // Arrange
            var falseValues = new[] { "0", "BananaBread" };

            // ACT
            var firstTrue = "0".ToBoolean(falseValues: falseValues, @default: true);
            var secondTrue = "BananaBREAD".ToBoolean(falseValues: falseValues, @default: true);

            var firstFalse = "true".ToBoolean(falseValues: falseValues, @default: true);
            var secondFalse = "TRUEDAMMIT".ToBoolean(falseValues: falseValues, @default: true);

            // Assert

            Assert.That(firstTrue, Is.False);
            Assert.That(secondTrue, Is.False);

            Assert.That(firstFalse, Is.True);
            Assert.That(secondFalse, Is.True);
        }

        [Test]
        public void String_ToBoolean_NoValues_Sent_DefaultAsTrue_And_Correctly_Parsed()
        {
            // Arrange

            // ACT
            var firstTrue = "4".ToBoolean(@default: true);
            var secondTrue = "true".ToBoolean(@default: true);
            var thirdTrue = "false".ToBoolean(@default: true);

            var firstFalse = "one".ToBoolean(@default: false);
            var secondFalse = "truthy".ToBoolean(@default: false);

            // Assert

            Assert.That(firstTrue, Is.True);
            Assert.That(secondTrue, Is.True);
            Assert.That(thirdTrue, Is.True);

            Assert.That(firstFalse, Is.False);
            Assert.That(secondFalse, Is.False);
        }


        private class ObjectToConvert
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [Serializable]
        private class SerializableObjectToConvert
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
