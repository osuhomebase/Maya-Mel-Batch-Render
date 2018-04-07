using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayaBatch;


namespace MayaBatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderBatch testBatch = new RenderBatch
            {
                binDirectory = "C:\\Program Files\\AutoDesk\\Maya2016\\bin",
                startFrame = 100,
                endFrame = 120,
                cameraName = "camera1",
                outputFileDirectory = "C:\\MayaOutput",
                outputFilePrefix = "testBatch",
                fileDirectory = "C:\\Users\\mrb14\\Downloads",
                fileName = "AA_test01.mb"

            };
            Console.WriteLine(testBatch.arguments);
            testBatch.Render();
            Console.ReadLine();
                
        }
    }
}
