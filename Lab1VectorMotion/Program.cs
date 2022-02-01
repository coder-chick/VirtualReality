using System;

namespace Lab1VectorMotion
{
    class Program
    {
        const float NUMBER_OF_ITERATIONS = 10;
        public struct vector{
            public int x;
            public int y;
            public int z;
            public vector(int x, int y, int z){

                this.x = x;
                this.y = y;
                this.z = z;
            }


        }
        void inputVector(vector vectorStart, vector vectorFinal, int time){
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter start vector: \n");
            vector vStart = new vector(Convert.ToInt16(args[0]),Convert.ToInt16(args[1]),Convert.ToInt16(args[2]));
            vector vFinal = new vector(Convert.ToInt16(args[3]),Convert.ToInt16(args[4]),Convert.ToInt16(args[5]));
            int time = Convert.ToInt16(args[6]);

            Console.WriteLine("start position: " + vStart.x + " " + vStart.y + " " + vStart.z);
            Console.WriteLine("final position: " + vFinal.x + " " + vFinal.y + " " + vFinal.z);
            Console.WriteLine("time: " + time);

            float velocity = calcVelocity(calcDistance(vStart,vFinal),time);
            Console.WriteLine("velocity: " + velocity);

            iterationPosition(calcDistance(vStart,vFinal),time,velocity,vStart,vFinal);
        }
        static float calcDistance(vector vectorStart, vector vectorFinal){
            float dist = 0;

            dist = MathF.Sqrt(MathF.Pow((vectorFinal.x - vectorStart.x ),2)  + MathF.Pow((vectorFinal.y - vectorStart.y ),2) + MathF.Pow((vectorFinal.z - vectorStart.z ),2));


            return dist;

        }
        static float calcVelocity(float distance, int time){
            float velocity = 0;

            velocity = distance / time;

            return velocity;


        }

        static void iterationPosition(float totalDistance, int time,float velocity,vector vI, vector vF){

            vector currentVector = vI;

            float changeInX = (vF.x - vI.x) / NUMBER_OF_ITERATIONS;
            float changeInY = (vF.y - vI.y) / NUMBER_OF_ITERATIONS;
            float changeInZ = (vF.z - vI.z) / NUMBER_OF_ITERATIONS;

            float currentX = vI.x;
            float currentY = vI.y;
            float currentZ = vI.z;


            float deltaTime = time / NUMBER_OF_ITERATIONS;
            float currentDistance = 0;
            float moveTime = 0;
            for(int i = 0; i < NUMBER_OF_ITERATIONS; i++){

                currentDistance = velocity * moveTime;

                currentX += changeInX;
                currentY += changeInY;
                currentZ += changeInZ;


                Console.WriteLine(
                    "\niteration : " + (i+1) +
                    "\ndistance traveled : " + currentDistance +
                    "\ncurrent position : [" + currentX + ", " + currentY + ", " + currentZ + "]" 
                    + "\ntime: " + time
                    
                    );
                
                moveTime += deltaTime;
            }


        }
    }
}
