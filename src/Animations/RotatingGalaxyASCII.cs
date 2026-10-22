using System.Diagnostics;

namespace DesignPatterns.Animations
{
    public static class RotatingGalaxyASCII
    {
        // Added a duration parameter to control how long it runs
        public static void Play(int durationMilliseconds)
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int width = 80;
            int height = 40;
            int numArms = 3;
            int starsPerArm = 150;
            double maxRadius = Math.Min(width, height * 2) * 0.45;
            double twist = 1.5;
            double rotationSpeed = 0.05;
            double currentAngleOffset = 0;

            char[] asciiGradient = { '@', '#', '*', '+', '=', '-', ':', '.', ' ' };
            char[,] buffer = new char[width, height];

            // Start a stopwatch to track elapsed time
            Stopwatch stopwatch = Stopwatch.StartNew();

            // The loop now checks if the elapsed time is less than the requested duration
            while (stopwatch.ElapsedMilliseconds < durationMilliseconds)
            {
                for (int x = 0; x < width; x++)
                    for (int y = 0; y < height; y++)
                        buffer[x, y] = ' ';

                int centerX = width / 2;
                int centerY = height / 2;

                for (int arm = 0; arm < numArms; arm++)
                {
                    double armBaseAngle = arm * (2 * Math.PI / numArms);

                    for (int i = 0; i < starsPerArm; i++)
                    {
                        double distanceRatio = (double)i / starsPerArm;
                        double radius = distanceRatio * maxRadius;
                        double angle = armBaseAngle + (distanceRatio * twist) + currentAngleOffset;

                        int x = (int)(centerX + radius * Math.Cos(angle));
                        int y = (int)(centerY + radius * Math.Sin(angle) * 0.5);

                        if (x >= 0 && x < width && y >= 0 && y < height)
                        {
                            int gradientIndex = (int)(distanceRatio * (asciiGradient.Length - 1));
                            buffer[x, y] = asciiGradient[gradientIndex];
                        }
                    }
                }

                Console.SetCursorPosition(0, 0);
                System.Text.StringBuilder frameBuilder = new System.Text.StringBuilder();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        frameBuilder.Append(buffer[x, y]);
                    }
                    frameBuilder.AppendLine();
                }
                Console.Write(frameBuilder.ToString());

                currentAngleOffset += rotationSpeed;
                Thread.Sleep(33);
            }

            // Clean up and stop the stopwatch before exiting the method
            stopwatch.Stop();
            Console.CursorVisible = true; // Bring back the cursor for the main app
        }
    }

}