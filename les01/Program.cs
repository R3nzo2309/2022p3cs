using System;

namespace les01
{
    class Program
    {
        private string greeting;
        private string greetWho;


        static void Main(string[] args)
        {
            program program = new program();

            program.setWhoToGreet("iedereen");
            program.prepareGreeting();

            string greeting = program.getGreeting();
            console.writeLine(greeting);
        }

        private void setWhoToGreet(string who){
            greetWho = who;
        }

        private void prepareGreeting(){
            greeting = "goedemorgen" + greetWho + "!";
        }

        private string getGreeting(){
            return greeting;
        }

    }
}
