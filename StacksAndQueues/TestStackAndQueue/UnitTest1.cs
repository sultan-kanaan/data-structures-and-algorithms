using System;
using Xunit;
using StacksAndQueues;

namespace TestStackAndQueue
{
    public class UnitTest1
    {
        // Can successfully push onto a stack
        [Fact]
        public void Testpush()
        {
            Stack stack = new Stack();
            stack.push(5);
            Assert.Equal("[5] -> NULL", stack.Print());
        }

        //Can successfully push multiple values onto a stack
        [Fact]
        public void TestpushMulti()
        {
            Stack stack = new Stack();
            stack.push(5);
            stack.push(15);
            stack.push(25);
            Assert.Equal("[25] -> [15] -> [5] -> NULL", stack.Print());
        }
        //Can successfully pop off the stack
        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack();
            stack.push(5);
            stack.push(15);
            stack.pop();
            Assert.Equal("[5] -> NULL", stack.Print());
        }
        //Can successfully empty a stack after multiple pops
        [Fact]
        public void TestPopmulti()
        {
            Stack stack = new Stack();
            stack.push(5);
            stack.push(15);
            stack.pop();
            stack.pop();
            Assert.Equal("Stack is Empty!", stack.Print());
        }

        //Can successfully peek the next item on the stack
        [Fact]
        public void Testpeek()
        {
            Stack stack = new Stack();
            stack.push(5);
            stack.push(15);
            Assert.Equal("peek is 15", stack.peek());
        }

        //Can successfully instantiate an empty stack
        [Fact]
        public void TestEmptyStack()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }
        //Calling pop or peek on empty stack raises exception
        [Fact]
        public void Testexception()
        {
            Stack stack = new Stack();
            stack.push(5);
            stack.push(15);
            stack.pop();
            stack.pop();
            Assert.Equal("Stack is Empty!", stack.Print());
        }
        //Can successfully enqueue into a queue
        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            Assert.Equal(20,queue.Rear.Value);

        }
        //Can successfully enqueue multiple values into a queue
        [Fact]
        public void TestEnqueueMulti()
        {
            Queue queue = new Queue(); 
            queue.Enqueue(20);
            queue.Enqueue(30);
            Assert.Equal(30,queue.Rear.Value);
        }
        //Can successfully dequeue out of a queue the expected value
        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            Assert.Equal(30, queue.Rear.Value);
        }
        //Can successfully peek into a queue, seeing the expected value
        [Fact]
        public void TestDequeuePeek()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Peek();
            Assert.Equal("peek is 20", queue.Peek());
        }
        //Can successfully empty a queue after multiple dequeues
        [Fact]
        public void TestEmptyQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Dequeue();
            Assert.True(queue.IsEmpty());
        }
        //Can successfully instantiate an empty queue
        [Fact]
        public void TestInstantiateEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }

        
        [Fact]
        public void TestPseudoEnqueue()
        {
            PseudoQueue pseudo = new PseudoQueue();
            pseudo.Enqueue(5);

            Assert.Equal("peek is 5", pseudo.peek());
        }

        [Fact]
        public void TestPseudoDequeue()
        {
            PseudoQueue pseudo = new PseudoQueue();
            pseudo.Enqueue(5);
            pseudo.Enqueue(10);
            pseudo.Dequeue();


            Assert.Equal("peek is 10", pseudo.peek());
        }
        [Fact]
        public void TestShelterEnqueue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Cat cat1 = new Cat();
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(cat1);

            Assert.Equal(cat1, animalShelter.Dequeue("cat"));

        }

        [Fact]
        public void TestShelterDequeue()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Cat cat1 = new Cat();
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(cat1);


            Assert.NotEqual(dog2, animalShelter.Dequeue("cat"));


        }

        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{}[](())")]
        public void TestTrueOutCome(string input)
        {
            Assert.True(Program.BracketValidation(input));
        }
        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        public void TestFalseOutCome(string input)
        {
            Assert.False(Program.BracketValidation(input));
        }


    }
}
