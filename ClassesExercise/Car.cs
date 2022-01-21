using System;
namespace ClassesExercise
{
    public class Car
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private bool v6;

        public Car()
        {
            

        }

        public Car(int v1, string v2, string v3, string v4, string v5, bool v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }


        public void MakeEngineNoise(string engineNoise)

        {

            Console.WriteLine(engineNoise);


        }

        public void MakeHonkNoise(string honkNoise)
        {

            Console.WriteLine(honkNoise);

        }




    }
}
