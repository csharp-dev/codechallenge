
using System;
using NUnit.Framework;
using System.Reflection;
using Moq;
using Hackerearth;


namespace Test
{
    [TestFixture]
    class ReverseIntTest
    { 
        private ReverseIntArray objUnderTest;

        [OneTimeSetUp]
        public void init() {
            objUnderTest = new ReverseIntArray();
        }



        [TestCase( 4, ExpectedResult = new int[] { 1, 2, 3, 4 } )]
        public object returnsIntArrReadFromConsole(int number) {
            var mockedRCLI = new Mock<IConsole>();
            mockedRCLI.Setup(m => m.readLine()).Returns("0");
            mockedRCLI.SetupSequence(m => m.readLine())
                .Returns("1")
                .Returns("2")
                .Returns("3")
                .Returns("4")
                .Throws(new InvalidOperationException());

            //mockedRCLI.Setup(m => m.readLine()).Returns("2");
            //mockedRCLI.Setup(m => m.readLine()).Returns("3");
            //mockedRCLI.Setup(m => m.readLine()).Returns("4");


            // NOT CALLED IN THIS CONTEXT
            //var mockedCLI = new Mock<IReverse>();
            //mockedCLI.SetupSequence(f => f.readNumberFromConsole(mockedRCLI.Object))
            //    .Returns(1)
            //    .Returns(2)
            //    .Returns(3)
            //    .Returns(4)
            //    .Throws(new InvalidOperationException());


            //object[] parameters = { number, mockedRCLI };
            //MethodInfo methodInfo = typeof(ReverseIntArray).GetMethod("readInts", BindingFlags.NonPublic | BindingFlags.Instance);
            //var actual = methodInfo.Invoke(objUnderTest, parameters);

           return objUnderTest.readInts(number, mockedRCLI.Object);
        }
    
        [Test]
        public void reversesIntArr()
        {
            MethodInfo methodInfo = typeof(ReverseIntArray).GetMethod("reversedIntArr", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { new int[] { 1, 4, 3 } };
            int[] expected = { 3, 4, 1 };
            var actual = methodInfo.Invoke(objUnderTest, parameters);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(
            new int[] { 21, 12, 31, 41 },
            ExpectedResult = new int[] { 41, 31, 12, 21 })
            ]
        public object reversesIntArr_SecondCase(int[] numbers) {
            object[] parameters = { numbers };
            MethodInfo methodInfo = typeof(ReverseIntArray).GetMethod("reversedIntArr", BindingFlags.NonPublic | BindingFlags.Instance);
            return methodInfo.Invoke(objUnderTest, parameters);
        }


    }
}

#region CLI
public interface ICommandLineInterface
{
    string[] getCommandLineArgs();
}

public class CommandInterface : ICommandLineInterface
{
    public string[] getCommandLineArgs()
    {
        return Environment.GetCommandLineArgs();
    }
}

class CLIArgsExample {
    [Test]
    public void simulateCLIArgument()
    {
        //Arrange
        string[] expectedArgs = new[] { "1", "2", "3", "4" };
        var mockedCLI = new Mock<ICommandLineInterface>();
        mockedCLI.Setup(m => m.getCommandLineArgs()).Returns(expectedArgs);
        var target = mockedCLI.Object;

        //// Act
        var args = target.getCommandLineArgs();
        Assert.That(expectedArgs, Does.Contain("1"));


        // Assert
        //args.Should().NotBeNull();
        //args.Should().ContainInOrder(expectedArgs);

    }

}

#endregion CLI